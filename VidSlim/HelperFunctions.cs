using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VidSlim_Compressor
{
    public static class HelperFunctions
    {

        public static bool checkSizeInput(string sizeInput, out string message, ref int parsedCompressSize)
        {

            if (string.IsNullOrEmpty(sizeInput))
            {
                message = "Enter a file size.";
                return false;

            }
            else if (!int.TryParse(sizeInput, out parsedCompressSize))
            {
                message = "Please enter only numbers!";
                return false;

            }
            else
            {
                message = "";
                return true;
            }
        }

        public static string GenerateFilterString(Videos videos)
        {
            List<string> formats = videos.GetVideoFormats();
            string filterString = "Video Files|";

            foreach (var format in formats)
            {
                filterString += $"*{format};";
            }

            return filterString.TrimEnd(';');
        }

    }
}
