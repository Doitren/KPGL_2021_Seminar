using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPGL_
{
    public class Setting_Destinations
    {
        String DEF_PATH = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"@\\Output";
        String Path;
        //Done
        public void SetDestination(){
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();  
            folderDlg.ShowNewFolderButton = true;  
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();  
            if (result == DialogResult.OK) {
                //Environment.SpecialFolder root = folderDlg.RootFolder;
                this.Path = folderDlg.SelectedPath;
            }else{
                this.Path = DEF_PATH;
            }
        }
        public string Return_Destinaton(){
            if (this.Path == null)
                SetDestination();
            return this.Path;
        }
        public void SetDefault()
        {
            this.Path = null;
        }
    }
}
