using SimpleAreaCalculator.Abstract_Classes;
using SimpleAreaCalculator.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleAreaCalculator.Classes
{
    public class Circle : Figure, IPrint 
    {

        public double Radius { get; set; }
        public double PI = Math.PI;

        public Circle() { }
        public Circle(double radius, double pi)
        {
            this.Radius = radius;
            PI = pi;
        }
        public override double calculateArea()
        {
            
            return PI * Radius * Radius;
        }

        public override double calculatePerimeter()
        {
            return 2 * PI * Radius;
        }

        public void print()
        {
            Console.WriteLine("Value of radius: " + Radius);
            Console.WriteLine("Value of area: " + calculateArea());
            Console.WriteLine("Value of perimeter: " + calculatePerimeter());
            Console.WriteLine();
        }

        public void setValue()
        {
            Console.Write("Set a value of radius: ");
            try
            {
                string value = Console.ReadLine();
                double radius = double.Parse(value);
                if (radius == 0)
                    throw new Exception("Radius must be greater than zero");
                else
                Radius = radius;
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
