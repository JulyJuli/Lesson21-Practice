using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDelegateDictionary
{
    public enum FigureType
    {
        Circle, Square, Triangle, Rectangle
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<FigureType, Func<double, double, double, string>> dict = new Dictionary<FigureType, Func<double, double, double, string>>();

            dict[FigureType.Circle] = GetCircleProperties;
            dict[FigureType.Rectangle] = GetRectangleProperties;

            dict[FigureType.Square] = GetSquareProperties;
            dict[FigureType.Triangle] = GetTriangleProperties;

            Console.WriteLine(
                dict[FigureType.Circle](1, 0, 0));

            Console.ReadKey();
        }

        public static string GetCircleProperties(double radius, double b = 0, double c = 0)
        {
            double area = Math.PI * radius * radius;
            double perimeter = 2 * Math.PI * radius;
            return $"Circle, radius: {radius}, area: {area:f2}, perimeter: {perimeter:f2}.";
        }

        public static string GetSquareProperties(double sideA, double b = 0, double c = 0)
        {
            double area = sideA * sideA;
            double perimeter = 4 * sideA;
            return $"Square, side: {sideA}, area: {area:f2}, perimeter: {perimeter:f2}.";
        }

        public static string GetTriangleProperties(double sideA, double sideB, double sideC)
        {
            double perimeter = sideA + sideB + sideC;
            double area = Math.Sqrt(
                perimeter / 2 * (perimeter / 2 - sideA) * (perimeter / 2 - sideB) * (perimeter / 2 - sideC)
                );
            return $"Triangle, side A: {sideA}, side B: {sideB}, side C: {sideC}, area: {area:f2}, perimeter: {perimeter:f2}.";
        }

        public static string GetRectangleProperties(double sideA, double sideB, double c = 0)
        {
            double area = sideA * sideB;
            double perimeter = 2 * sideA;
            return $"Rectangle, side A: {sideA}, side B: {sideB}, area: {area:f2}, perimeter: {perimeter:f2}.";
        }
    }
}
