using assingment_OOP04.Intertfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment_OOP04
{
    internal class Rectangle : IRectangle
    {
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double width {   get; private set ; }
        public double height {  get;  private set ; }

        public double Area => width * height;

        double IShape.Area { get    => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        double IRectangle.Width     => throw new NotImplementedException();

        double IRectangle.Height    => throw new NotImplementedException();

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle with width {width} and height {height} has an area of {Area:F2}");
        }

        
    }
}
