using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPGL_
{
    public class Export_Types
    {
        FINAL STRING DEF_PATH = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"@\\Output";
        String Path;

        public void SetDestination(){

            FolderBrowserDialog folderDlg = newFolderBrowserDialog();  
            folderDlg.ShowNewFolderButton = true;  
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();  
            if (result == DialogResult.OK) {  
                //Environment.SpecialFolder root = folderDlg.RootFolder;
                Path = folderDlg.SelectedPath;
            }else{
                Path = null;
            }
        }
        public void Export_Image(){
            
        }

        public void Export_CSV(){
            
        }
    }
}
