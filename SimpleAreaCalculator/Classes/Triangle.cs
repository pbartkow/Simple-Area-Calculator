using SimpleAreaCalculator.Abstract_Classes;
using SimpleAreaCalculator.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleAreaCalculator.Classes
{
    public class Triangle : Figure, IPrint
    {

        public double Base { get; set; }
        public double Height { get; set; }
        public double SideA { get; set; }
        public double SideB { get; set; }

        public Triangle() { }
        public Triangle(double Base, double Height, double SideA, double SideB)
        {
            this.Base = Base;
            this.Height = Height;
            this.SideA = SideA;
            this.SideB = SideB;
        }

     
        public void proofTriangle()
        {
            if(SideA < Base + SideB && Base < SideB + SideA && SideB < SideA + Base)
            {
                Console.WriteLine("Triangel is OK");
            }
            else
            {
                throw new Exception("The condition of the existance of a triangle was not met");
            }
        }

        public override double calculateArea()
        {
            return (Base * Height) / 2;
        }

        public override double calculatePerimeter()
        {
            return SideA + SideB + Base;
        }

        public void print()
        {
            Console.WriteLine("Value of base: " + Base);
            Console.WriteLine("Value of side A: " + SideA);
            Console.WriteLine("Value of side B: " + SideB);
            Console.WriteLine("Value of height: " + Height);
            Console.WriteLine("Value of area: " + calculateArea());
            Console.WriteLine("Value of perimeter: " + calculatePerimeter());
            Console.WriteLine();
        }

        public void setValue()
        {
            try
            {
                Console.Write("Set value of base: ");
                string valueOfBase = Console.ReadLine();
                Console.Write("Set value of height: ");
                string valueOfHeight = Console.ReadLine();
                Console.Write("Set value of side A: ");
                string valueOfSideA = Console.ReadLine();
                Console.Write("Set value of side B: ");
                string valueOfSideB = Console.ReadLine();

                double Base = double.Parse(valueOfBase);
                double height = double.Parse(valueOfHeight);
                double sideA = double.Parse(valueOfSideA);
                double sideB = double.Parse(valueOfSideB);
                if (Base == 0 || height == 0 || sideA == 0 || sideB == 0)
                    throw new Exception("Value of sizes must be greater than zero");
                else
                {
                    this.Base = Base;
                    Height = height;
                    SideA = sideA;
                    SideB = sideB;
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
