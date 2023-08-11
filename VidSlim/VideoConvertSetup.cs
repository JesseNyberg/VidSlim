using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VidSlim_Compressor
{
    public class VideoConvertSetup
    {
        public static void AddCommonFormats(Videos videos)
        {
            videos.addFormatToList(".webm");
            videos.addFormatToList(".mpg");
            videos.addFormatToList(".mp2");
            videos.addFormatToList(".mpeg");
            videos.addFormatToList(".mpe");
            videos.addFormatToList(".mpv");
            videos.addFormatToList(".ogg");
            videos.addFormatToList(".mp4");
            videos.addFormatToList(".m4p");
            videos.addFormatToList(".m4v");
            videos.addFormatToList(".avi");
            videos.addFormatToList(".wmv");
            videos.addFormatToList(".mov");
            videos.addFormatToList(".qt");
            videos.addFormatToList(".flv");
            videos.addFormatToList(".swf");
        }

        public static void checkVideoFormat(string file, ref Videos videos)
        {
            if (videos.CheckVideoFormat(Path.GetExtension(file).ToLower()))
            {
                videos.addVideoToList(file);
            }
        }
        public static void clearCurrentVideoList(MaterialListView videoList, Videos videos)
        {
            videoList.Items.Clear();
            videos.emptyVideoList();
        }

        public static List<string> getSelectedVideos(MaterialListView videoList)
        {
            List<string> selectedVideos = new List<string> { };

            foreach (int index in videoList.SelectedIndices)
            {
                selectedVideos.Add(videoList.Items[index].Text);
            }

            return selectedVideos;
        }

    }
}
