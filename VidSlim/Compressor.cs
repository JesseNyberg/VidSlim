using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;
using NReco.VideoConverter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VidSlim_Compressor
{
    internal static class Compressor
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CompressorGUI());
        }

        public static async Task convertVideos(Videos videos, int compressSize, List<string> selectedVideos, MaterialLabel videosConvertedLabel, CancellationToken cancelToken)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string compressedPath = Path.Combine(currentDirectory, "CompressedVideos");

            try
            {
                if (!Directory.Exists("CompressedVideos"))
                    Directory.CreateDirectory(compressedPath);
            }
            catch (Exception err)
            {
                MessageBox.Show($"Making a directory failed. Check permissions or run as adminstrator: {err.Message}");
            }

            ConvertSettings settings = new ConvertSettings();
            settings.VideoCodec = "libx264";

            var ffProbe = new NReco.VideoInfo.FFProbe();

            int audioBitRate = 128;

            int videosCompleted = 0;

            videosConvertedLabel.Text = $"{videosCompleted}/{selectedVideos.Count} videos converted";

            var tasks = selectedVideos.Select(video =>
            {
                FFMpegConverter converter = new NReco.VideoConverter.FFMpegConverter();

                converter.ConvertProgress += (sender, e) =>
                {
                    if (cancelToken.IsCancellationRequested)
                    {
                        ((FFMpegConverter)sender).Stop(); // stop current conversion process
                        cancelToken.ThrowIfCancellationRequested(); // propagate cancellation request further up the call stack
                    }
                };

                string inputFilePath = Path.Combine(currentDirectory, video);
                string outputFilePath = Path.Combine(compressedPath, Path.GetFileNameWithoutExtension(video) + "_" + (compressSize / 1000000).ToString() + "MB" + ".mp4");

                var videoInfo = ffProbe.GetMediaInfo(inputFilePath);
                double videoDuration = videoInfo.Duration.TotalSeconds;

                double calculatedBitRate = (double)(compressSize * 8) / 1000 / videoDuration;
                int bitrateInKbps = (int)Math.Round(calculatedBitRate) - audioBitRate;

                settings.CustomOutputArgs = $"-b:v {bitrateInKbps}k";

                return Task.Run(() =>
                {
                    converter.ConvertMedia(inputFilePath, null, outputFilePath, NReco.VideoConverter.Format.mp4, settings);
                }).ContinueWith((task) =>
                {
                        Interlocked.Increment(ref videosCompleted);
                        videosConvertedLabel.BeginInvoke((MethodInvoker)delegate
                        {
                            videosConvertedLabel.Text = $"{videosCompleted}/{selectedVideos.Count} videos converted";
                        });
                });
            });

            await Task.WhenAll(tasks);
        }
    }
}
