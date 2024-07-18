using assingment_OOP04.Intertfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment_OOP04
{
    internal class Circle : ICircle
    {
        public double Radius { get; set; }
        

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle with radius {Radius} has an area of {Area:F2}");
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area => Math.PI * Math.Pow(Radius, 2);

    }
}
