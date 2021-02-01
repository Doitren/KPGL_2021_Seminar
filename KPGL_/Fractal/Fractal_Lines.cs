using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPGL_.Fractal
{
    public class Fractal_Lines
    {
        List<object> Pattern;
        List<Line> Lines;
        public Fractal_Lines(int width, int height)
        {
            this.Lines = new List<Line>();

            Default_State(width, height);
        }

        private void Default_State(int x, int y)
        {
            //this.Lines = new List<Line>() { new Line(0, 0, x, 0), new Line(x, 0, x, y), new Line(x, y, 0, y), new Line(0, y, 0, 0) };
            this.Lines = new List<Line>() { new Line(0, y/4, x, y/4) };
            this.Pattern = new List<object>() { "Right", "Up", "Right","Down","Right" };
        }

        public void NextIteration()
        {
            List<Line> result = new List<Line>();
            for (int i = 0; i < Lines.Count; i++)
            {
                int[] x = Lines[i].Get_X();
                int[] y = Lines[i].Get_Y();

                int width = Math.Abs(x[1] - x[0]);
                int height = Math.Abs(y[1] - y[0]);

                int third_of_width = width / 3;
                int third_of_height = height / 3;

                foreach(String s in Pattern)
                {
                    if(s == "Right")
                    {
                        result.Add(new Line(x[0],y[0],x[0] + third_of_width, y[0]));
                        x[0] += third_of_width;
                    }
                    else if (s == "Up")
                    {
                        result.Add(new Line(x[0], y[0], x[0], y[0] + third_of_width));
                        y[0] += third_of_width;
                    }
                    else if (s == "Down")
                    {
                        result.Add(new Line(x[0], y[0], x[0], y[0] - third_of_width));
                        y[0] -= third_of_width;
                    }
                    else if (s == "Left")
                    {
                        result.Add(new Line(x[0], y[0], x[0], y[0] - third_of_width));
                        x[0] -= third_of_width;
                    }
                }
            }
            this.Lines = result;
        }
        public List<Line> GetLines() { return Lines; }
    }
}