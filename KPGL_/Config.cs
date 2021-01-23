using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPGL_
{
    public class Config
    {
        //Main Config for working with excensive and basic code
        Setting_Destinations destination;
        public int iteration;
        int def_iteration = 2;

        public int timer;
        int def_timer = 200;
        bool Timer_On = false;
        //Done ?? I hope I do not need to extend
        public Config()
        {
            Default_Config();
        }

        private void Default_Config()
        {
            this.destination = new Setting_Destinations();
            iteration = def_iteration;
            timer = def_timer;
        }

        public Setting_Destinations Get_Setting_Destinations() { return this.destination; }
        public void Set_Def_destination() { destination.SetDefault(); }
        public int get_Def_Iteration() { return def_iteration; }
        public int get_Def_Timer() { return def_timer; }
        public void Turn_Timer(bool Timer_On) { this.Timer_On = Timer_On; }
        public bool Get_Timer_Status() { return Timer_On; }
    }
}
