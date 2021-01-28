using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPGL_.Fractal
{
    public class Line
    {
        int x;
        int y;
        public Line(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int Get_X() { return x; }
        public int Get_Y() { return y; }
        public void Set_X(int x) { this.x = x; }
        public void Set_Y(int y) { this.y = y; }
    }
}
