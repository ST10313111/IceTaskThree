using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTaskThree
{
    class Rectangle : Shape, ICalculateArea
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public Rectangle(string name, double width, double length) : base(name)
        {
            Width = width;
            Length = length;
        }

        public double CalculateArea()
        {
            double calculatedR = Width * Length;
            return calculatedR;

        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Width: {Width}\nLength: {Length} \n" +
                $"Calculated Area: {CalculateArea()}");
        }

    }
}
