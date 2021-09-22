using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfACircle
{
    public class Circle
    {
        public static double Area(double radius)
        {
            return Math.PI* Math.Pow(radius, 2);
        }
        public static double Circumference(double radius)
        {
            return 2 * Math.PI * radius;
        }
        public static double Diameter(double radius)
        {
            return 2 * radius;
        }
        public static double GallonsUsed(double circum, double MPG)
        {
            return circum / MPG;
        }
    }
}
