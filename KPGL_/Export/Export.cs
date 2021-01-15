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
    public partial class Export : Form
    {
        Main_Form form;
        public Export(Main_Form form)
        {
            InitializeComponent();

            this.form = form;
        }

        private void Export_btn_Click(object sender, EventArgs e)
        {
            bool Image = image_export_checkbox.Checked;
            bool Csv = csv_export_checkbox.Checked;

            if(Image!=false || Csv!=false)
                form.Export(Image, Csv);
        }
    }
}
