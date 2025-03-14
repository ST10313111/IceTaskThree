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

        public void CalculateArea()
        {
            double calculatedR = Width * Length;
           
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Width: {Width} \n Length: {Length} \n" +
                $"Calculated Area: {CalculateArea}");
        }

    }
}
