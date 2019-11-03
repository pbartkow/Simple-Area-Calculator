using SimpleAreaCalculator.Abstract_Classes;
using SimpleAreaCalculator.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleAreaCalculator.Classes
{
    public class Rectangle : Figure, IPrint
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle() { }
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public override double calculateArea()
        {
            return Height * Width;
        }

        public override double calculatePerimeter()
        {
            return (2 * Width) + (2 * Height);
        }

        public void print()
        {
            Console.WriteLine("Value of height: " + Height);
            Console.WriteLine("Value of width: " + Width);
            Console.WriteLine("Value of area: " + calculateArea());
            Console.WriteLine("Value of perimeter: " + calculatePerimeter());
            Console.WriteLine();
        }

        public void setValue()
        {
            try
            {
                Console.Write("Set value of height: ");
                string valueOfHeight = Console.ReadLine();
                Console.Write("Set value of width: ");
                string valueOfWidth = Console.ReadLine();
                double width = double.Parse(valueOfWidth);
                double height = double.Parse(valueOfHeight);
                if (width == 0 || height == 0)
                    throw new Exception("Value of width and height must be greater than zero");
                else
                {
                    Height = height;
                    Width = width;
                }
            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
            }
            catch (OverflowException oVx)
            {
                Console.WriteLine(oVx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
