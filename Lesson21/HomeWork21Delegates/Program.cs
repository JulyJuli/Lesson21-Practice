using System;
using System.Collections.Generic;

namespace HomeWork21Delegates
{
    public enum Figures
    {
        square = 1,
        circle,
        triangle,
        rectangle
    }
    public class Program
    {
        public delegate void Calculate(int height, int width, int side);
        public static void Main(string[] args)
        {
            double area = default;
            double perimetr = default;

            Calculate squareDelegate = (int height, int width, int side) => { area = height * width; };
            squareDelegate += (int height, int width, int side) => { perimetr = height * 2 + width * 2; };

            Calculate circleDelegate = (int radius, int width, int side) => { area = Math.PI * Math.Pow(radius, 2); };
            circleDelegate += (int radius, int width, int side) => { perimetr = 2 * Math.PI * radius; };

            Calculate triangleDelegate = (int height, int width, int side) => { area = height * side / 2; };
            triangleDelegate += (int height, int width, int side) => { perimetr = height + width + side; };

            Calculate rectangleDelegate = (int height, int width, int side) => { area = height * width; };
            rectangleDelegate += (int height, int width, int side) => { perimetr = height * 2 + width * 2; };


            Dictionary<Figures, Calculate> calculation = new Dictionary<Figures, Calculate>();
            calculation.Add(Figures.square, squareDelegate);
            calculation.Add(Figures.circle, circleDelegate);
            calculation.Add(Figures.triangle, triangleDelegate);
            calculation.Add(Figures.rectangle, rectangleDelegate);

            calculation[Figures.square](4, 2, 1);
            Console.WriteLine($"Area of {Figures.square} is {area}\t Perimetr is {perimetr}");

            calculation[Figures.circle](4, 4, 1);
            Console.WriteLine($"Area of {Figures.circle} is {Math.Round(area, 2)}\t Perimetr is {Math.Round(perimetr, 2)}");

            calculation[Figures.triangle](4, 4, 10);
            Console.WriteLine($"Area of {Figures.triangle} is {area}\t Perimetr is {perimetr}");

            calculation[Figures.rectangle](10, 4, 1);
            Console.WriteLine($"Area of {Figures.rectangle} is {area}\t Perimetr is {perimetr}");

            Console.ReadKey();
        }
    }
}
