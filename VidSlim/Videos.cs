using System.Collections.Generic;

namespace VidSlim_Compressor
{
    public class Videos
    {

        private List<string> _videoFormats { get; set; }

        private List<string> _videoNames { get; set; }

        

        public Videos()
        {
            _videoFormats = new List<string>();
            _videoNames = new List<string>();  
        }

        public void addFormatToList(string videoFormat)
        {
            _videoFormats.Add(videoFormat);
        }

        public void addVideoToList(string videoName)
        {
            if (!_videoNames.Contains(videoName))
                _videoNames.Add(videoName);
        }

        public void emptyVideoList()
        {
            _videoNames.Clear();
        }

        public bool CheckVideoFormat(string videoName)
        {
            return _videoFormats.Contains(videoName);
        }

        public List<string> GetVideoNames()
        {
            return _videoNames;
        }

        public List<string> GetVideoFormats()
        {
            return _videoFormats;
        }

    }
}
