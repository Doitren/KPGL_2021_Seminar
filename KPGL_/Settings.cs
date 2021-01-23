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
    public partial class Settings : Form
    {
        Config conf;
        public Settings(Config conf)
        {
            InitializeComponent();
            Default_Status(conf);
        }

        private void Default_Status(Config conf)
        {
            this.conf = conf;
            Iteration_txtbox.Text = conf.iteration.ToString();
            timer_tick_txtbox.Text = conf.timer.ToString();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            conf.iteration = int.Parse(Iteration_txtbox.Text);
            conf.timer = int.Parse(timer_tick_txtbox.Text);
        }

        private void Iteration_txtbox_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if(!int.TryParse(txt.Text,out int value))
            {
                if (txt.Name == Iteration_txtbox.Name)
                    Iteration_txtbox.Text = conf.get_Def_Iteration().ToString();
                else
                    timer_tick_txtbox.Text = conf.get_Def_Timer().ToString();
            }
        }
        //TODO import
        private void Import_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
