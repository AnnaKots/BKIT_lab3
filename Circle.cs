using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_BKIT
{
    class Circle : Figure, IPrint, IComparable
    {
        private double radius;

        public Circle(double rad)
        {
            this.radius = rad;
            this.Type = "Круг";
        }

        public override double AreaCalc()
        {
            double Area = (Math.PI) * (this.radius) * (this.radius);
            return Area;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
