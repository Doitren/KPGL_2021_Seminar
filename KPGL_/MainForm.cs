using KPGL_.Fractal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPGL_
{
    public partial class Main_Form : Form
    {
        Fractal_Lines fractal;
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            Settings_grpbox.Visible = true;
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            Settings_grpbox.Visible = false;
        }

        private void Export_btn_Click(object sender, EventArgs e)
        {

        }

        public void Export(bool image, bool csv)
        {
            if (image)
            {

            }
            if (csv)
            {

            }
        }

        private void Paint_Of_Fractal_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
}
