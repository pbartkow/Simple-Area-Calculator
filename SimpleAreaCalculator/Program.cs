using SimpleAreaCalculator.Abstract_Classes;
using SimpleAreaCalculator.Classes;
using System;

namespace SimpleAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();
            Triangle triangle = new Triangle();
            bool open = true;

            while (open)
            {
                Console.WriteLine("--- CHOOSE A FIGURE ---");
                Console.WriteLine();
                Console.WriteLine("----   1 CIRCLE    ----");
                Console.WriteLine("----   2 RECTANGLE ----");
                Console.WriteLine("----   3 TRIANGLE  ----");
                Console.WriteLine("----   4 CLOSE     ----");
                Console.WriteLine();

                Console.Write("Set your choice: ");
                string number = Console.ReadLine();
                int choice = int.Parse(number);
                switch (choice)
                {
                    case 1:
                        circle.setValue();
                        circle.calculateArea();
                        circle.calculatePerimeter();
                        circle.print();
                        Console.ReadKey();
                        Console.Clear();
                        break; 
                    case 2:
                        rectangle.setValue();
                        rectangle.calculateArea();
                        rectangle.calculatePerimeter();
                        rectangle.print();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        triangle.setValue();
                        triangle.proofTriangle();
                        triangle.calculateArea();
                        triangle.calculatePerimeter();
                        triangle.print();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        open = false;
                        break;
                }
            }
            //Console.ReadKey();
        }
    }
}
