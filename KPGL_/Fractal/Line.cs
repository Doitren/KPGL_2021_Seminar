using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPGL_.Fractal
{
    public class Line
    {
        int x1, x2;
        int y1, y2;
        public Line(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public int[] Get_X() { return new int[2] { x1, x2 }; }
        public int[] Get_Y() { return new int[2] { y1, y2 }; }
    }
}
