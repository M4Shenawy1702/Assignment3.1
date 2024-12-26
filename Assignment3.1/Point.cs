using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._1
{
    internal struct Point
    {
        public double X;
        public double Y;
        public Point(double _x, double _y)
        {
            X = _x;
            Y = _y;
        }
        public static double Calc (double x1 , double y1 , double x2 ,double y2)
        {
            //var distance = Math.Sqrt((x2 - x1)*(x2 - x1) - (y2 - y1)*(y2 - y1));
            var distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return distance;
        }
    }
}
