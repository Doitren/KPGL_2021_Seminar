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

        Pen p;

        public Visual(Config conf)
        {
            InitializeComponent();
            Default_Status(conf);
        }

        private void Default_Status(Config conf)
        {
            this.conf = conf;
            fractal = new Fractal_Lines(Draw_panel.Width, Draw_panel.Height);
            this.p = new Pen(Color.Black);
            Set_Timer(conf.Get_Timer_Status());
        }

        private void Export_btn_Click(object sender, EventArgs e)
        {
            Export_choices choices = new Export_choices(this);
            choices.Show();
        }
        //Check if graphics exists
        public void Export(bool Image, bool Csv)
        {
            MessageBox.Show("Vyberte místo pro uložení");
            String Path = conf.Get_Setting_Destinations().Return_Destinaton();
            if (Image)
            {

            }
            if (Csv)
            {

            }
            conf.Get_Setting_Destinations().SetDefault();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            bool Status_Of_Timer = conf.Get_Timer_Status();

            Set_Timer(Status_Of_Timer);

            if (Status_Of_Timer)
                Paint_On_Panel();
        }
        private void Set_Timer(bool Timer_Status)
        {
            int interval = conf.timer;
            Timer.Interval = interval;
            Timer.Enabled = Timer_Status;

            String Timer_def = Timer_status_lbl.Text.Split(':')[0] + ": ";
            Timer_interval_lbl.Text = Timer_interval_lbl.Text.Split(':')[0] + ": " + interval;

            if (Timer_Status)
            {
                Timer_status_lbl.Text = Timer_def + Timer_Status;
                start_btn.Text = "Stop Timer";
            }
            else
            {
                Timer_status_lbl.Text = Timer_def + Timer_Status;
                Timer.Enabled = Timer_Status;
                start_btn.Text = "Start Timer";
            }
        }
        //Set Graphic panel and then continue with iteration internaly, real magic happens here
        private void Paint_On_Panel()
        {
            Draw_panel.Refresh();
            Graphics g = Draw_panel.CreateGraphics();
            
            List<Line> fractal_lines = fractal.GetLines();
            foreach(Line s in fractal_lines)
            {
                int[] x_cor = s.Get_X();
                int[] y_cor = s.Get_Y();

                g.DrawLine(p, x_cor[0], y_cor[0], x_cor[1], y_cor[1]);
            }
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            bool Timer_status = conf.Get_Timer_Status();
            if (!Timer_status)
            {
                conf.Turn_Timer(true);
                Timer.Enabled = true;
            }
            else
            {
                conf.Turn_Timer(false);
                Timer.Enabled = false;
            }
            Set_Timer(!Timer_status);
        }

        private void next_iteration_btn_Click(object sender, EventArgs e)
        {
            fractal.NextIteration();
            Paint_On_Panel();
        }
    }
}