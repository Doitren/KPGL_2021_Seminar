using KPGL_.Export_folder;
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
    public partial class Visual : Form
    {
        Config conf;

        Fractal_Lines fractal;
        int iteration;

        public Visual(Config conf)
        {
            InitializeComponent();
            Default_Status(conf);
        }

        private void Default_Status(Config conf)
        {
            this.conf = conf;

            int timer_interval = conf.timer;
            Timer.Interval = timer_interval;
            Timer_interval_lbl.Text = Timer_interval_lbl.Text.Split(':')[0] + ": "+ timer_interval;
            bool timer_status = conf.Get_Timer_Status();
            Timer.Enabled = timer_status;
            Timer_status_lbl.Text = Timer_status_lbl.Text.Split(':')[0] + ": " + timer_status;

            iteration = conf.iteration;
        }

        private void Export_btn_Click(object sender, EventArgs e)
        {
            Export_choices choices = new Export_choices(this);
            choices.Show();
        }
        //Check if graphics exists
        public void Export(bool Image, bool Csv)
        {
            String Path = conf.Get_Setting_Destinations().Return_Destinaton();
            if (Image)
            {
                
            }
            if (Csv)
            {

            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int interval = conf.timer;
            Timer.Interval = interval;
            bool Status_Of_Timer = conf.Get_Timer_Status();

            String Timer_def = Timer_status_lbl.Text.Split(':')[0]+": ";
            Timer_interval_lbl.Text = Timer_interval_lbl.Text.Split(':')[0] + ": " + interval;

            if (Status_Of_Timer)
            {
                Timer_status_lbl.Text = Timer_def + Status_Of_Timer;

                //Paint_On_Panel();
            }
            else
            {
                Timer_status_lbl.Text = Timer_def + Status_Of_Timer;
                Timer.Enabled = Status_Of_Timer;
            }
        }
        //Set Graphic panel and then continue with iteration internaly, real magic happens here
        private void Paint_On_Panel()
        {
            throw new NotImplementedException();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            conf.Turn_Timer(true);
            Timer.Enabled = true;
        }
    }
}