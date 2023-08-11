using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VidSlim_Compressor
{

    public partial class CompressorGUI : MaterialForm
    {
        private Videos videos;
        private OpenFileDialog browseDialog = new System.Windows.Forms.OpenFileDialog();
        private bool isCompressing = false; 
        private CancellationTokenSource cts = new CancellationTokenSource();

        public CompressorGUI()
        {
            InitializeComponent();

            videos = new Videos();

            GUIOperations guiOperations = new GUIOperations();
            guiOperations.materialSkinSetup(this);
            guiOperations.browseDialogSetup(videos, browseDialog);
            guiOperations.InitializeVideosAndControls(videosConvertedLabel, videoList, videos);

            VideoConvertSetup.AddCommonFormats(videos);
        }

        private async void compressButton_Click(object sender, EventArgs e)
        {
            string compressInput = compressedSizeBox.Text;
            int parsedCompressSize = 0;

            if (!HelperFunctions.checkSizeInput(compressInput,out string message, ref parsedCompressSize))
            {
                ShowMessage(message);
                return;
            }

            if (videoList.SelectedItems.Count == 0)
            {
                ShowMessage("You didn't select any videos.");
                return;
            }

            await SetupVideoConversion(parsedCompressSize);
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (browseDialog.ShowDialog() == DialogResult.OK)
                {
                    VideoConvertSetup.clearCurrentVideoList(videoList, videos);

                    foreach (string file in browseDialog.FileNames)
                    {
                        VideoConvertSetup.checkVideoFormat(file, ref videos);
                    }

                    if (videos.GetVideoNames().Any())
                    {
                        foreach (string video in videos.GetVideoNames())
                        {
                            videoList.Items.Add(video);
                        }
                    }
                    else
                    {
                        videoList.Items.Add("No videos found with the selected formats.");
                    }
                }
            }
            catch (Exception err)
            {
                ShowError(err);
            }
        }

        private async Task SetupVideoConversion(int parsedCompressSize)
        {
            if (!isCompressing)
            {
                try
                {
                    List<string> selectedVideos = VideoConvertSetup.getSelectedVideos(videoList);

                    updateTextsAndBools("", true, true, "Cancel");

                    await Compressor.convertVideos(videos, parsedCompressSize * 1000000, selectedVideos, videosConvertedLabel, cts.Token);

                }
                catch (Exception err)
                {
                    ShowError(err);
                }
                finally
                {
                    updateTextsAndBools("", false, false, "Compress");
                }
            }
            else
            {
                cancelVideoConversion();
            }
        }

        private void updateTextsAndBools(string videosConvertedText = null, bool? visibility = null, bool? isCompressingBool = null, string compressButtonText = null)
        {
            if (videosConvertedText != null)
                videosConvertedLabel.Text = videosConvertedText;

            if (visibility != null)
                videosConvertedLabel.Visible = visibility.Value;

            if (isCompressingBool != null)
                isCompressing = isCompressingBool.Value;

            if (compressButtonText != null)
                compressButton.Text = compressButtonText;
        }

        private void cancelVideoConversion()
        {
            updateTextsAndBools(null, false, false, "Compress");

            cts.Cancel();
            cts = new CancellationTokenSource();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void ShowError(Exception err)
        {
            ShowMessage($"Error: {err.Message}");
        }

        private void selectAllBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem item in videoList.Items)
                {
                    item.Selected = selectAllBox.Checked;
                }
            }
            catch (Exception err)
            {
                ShowError(err);
            }
        }

        private void discordSizeBox_CheckedChanged(object sender, EventArgs e)
        {
            if (discordSizeBox.Checked)
            {
                compressedSizeBox.Text = "25";
            }
            else
            {
                compressedSizeBox.Text = "";
            }
        }
    }
}
