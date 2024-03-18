using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_MethodOverridingVsMethodHiding
{
    public class Circle //imagine this is defined in an external library that you use
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Circumference()
        {
            return 2 * Math.PI * Radius;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public virtual string Draw()
        {
            return @"O";
        }
    }

    public class SmartCircle : Circle
    {
        public SmartCircle(double radius) : base(radius)
        {
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public new string Draw()
        {
            return @"
                   *  *    
                *        * 
               *          *
               *          *
                *        * 
                   *  *    ";
        }
    }
}
