using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VidSlim_Compressor
{
    public class GUIOperations
    {

        public void browseDialogSetup(Videos videos, OpenFileDialog browseDialog)
        {
            browseDialog.Filter = HelperFunctions.GenerateFilterString(videos);
            browseDialog.Multiselect = true;
        }

        public void materialSkinSetup(CompressorGUI compressorGUI)
        {
            var materialManager = MaterialSkinManager.Instance;
            materialManager.AddFormToManage(compressorGUI);

            materialManager.Theme = MaterialSkinManager.Themes.DARK;
            materialManager.ColorScheme = new ColorScheme(
                Primary.Grey800, Primary.Grey800,
                Primary.Grey600, Accent.Teal200,
                TextShade.WHITE
             );
        }

        public void InitializeVideosAndControls(MaterialLabel videosConvertedLabel, MaterialListView videoList, Videos videos)
        {
            videosConvertedLabel.Visible = false;
            videoList.Columns.Add("Video name", -2, HorizontalAlignment.Left);

            videos = new Videos();
        }



    }
}
