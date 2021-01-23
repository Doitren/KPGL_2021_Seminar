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
        Config conf;
        //Done
        public Main_Form()
        {
            InitializeComponent();

            this.conf = new Config();
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            conf.Turn_Timer(false);
            conf.iteration = conf.get_Def_Iteration();
            conf.timer = conf.get_Def_Timer();
            MainPanel.Controls.Clear();
        }

        private void visual_btn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            Visual vis = new Visual(conf);
            vis.TopLevel = false;
            vis.AutoScroll = true;
            vis.FormBorderStyle = FormBorderStyle.None;
            MainPanel.Controls.Add(vis);
            vis.Show();
        }

        private void Settings_btn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            Settings exp = new Settings(conf);
            exp.TopLevel = false;
            exp.AutoScroll = true;
            exp.FormBorderStyle = FormBorderStyle.None;
            MainPanel.Controls.Add(exp);
            exp.Show();
        }
    }
}