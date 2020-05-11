using System;
using System.Collections.Generic;


namespace HWdelegates
{
    class Program
    {
        static void Main(string[] args)
        {           
            Func<int, int, string> squareDlgt = delegate(int sideA, int sideB){ return$"Area of square is {sideA * sideA}"; } ;
            Func<int, int, string> rectangleDlgt = delegate (int sideA, int sideB) { return $"Area of rectangle is {sideA * sideB}";};
            Func<int, int, string> triangleDlgt = delegate (int baseT, int hight) { return $"Area of triangle is {baseT * 0.5 * hight}"; };
            Func<int, int, string> circleDlgt = delegate (int radius, int zero1) { return $"Area of circle with radius {radius} is" +
                $" {Math.Round(Math.PI*Math.Pow(radius,2),2)}" +
                $" and length of circle is {Math.Round(2*Math.PI*radius,2)}";};
            //Dictionary<FiguresNames, Func<Figure, string>> myDictionary = new Dictionary<FiguresNames, Func<Figure, string>>();
            Dictionary<Figures, Func<int, int, string>> myDictionary = new Dictionary<Figures, Func<int, int, string>>();
            myDictionary.Add(Figures.Square, squareDlgt);
            myDictionary.Add(Figures.Reqtangle, rectangleDlgt);
            myDictionary.Add(Figures.Triangle, triangleDlgt);
            myDictionary.Add(Figures.Circle, circleDlgt);
           // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            bool IsWrongChoice =true;
            while (IsWrongChoice)
            {
                Console.WriteLine("Input Type of figure (1-circle, 2-square, 3- rectangle, 4-triangle) :");
                int zero = 0;

                if (int.TryParse(Console.ReadLine(), out int numberOfFigure))
                {
                    if (Enum.IsDefined(typeof(Figures), numberOfFigure))
                    {

                        switch (numberOfFigure)
                        {
                            case 1:
                                Console.WriteLine("Input radius (integer number):");
                                int.TryParse(Console.ReadLine(), out int radius1);

                                IsWrongChoice = false;
                                Console.WriteLine(myDictionary[Figures.Circle](radius1, zero));

                                break;

                            case 2:
                                Console.WriteLine("Input side (integer number):");
                                int.TryParse(Console.ReadLine(), out int side1);
                                IsWrongChoice = false;
                                Console.WriteLine(myDictionary[Figures.Square](side1, zero));
                                break;

                            case 3:
                                Console.WriteLine("Input side A (integer number):");
                                int.TryParse(Console.ReadLine(), out int sideA);

                                Console.WriteLine("Input side B (integer number):");
                                int.TryParse(Console.ReadLine(), out int sideB);
                                IsWrongChoice = false;
                                Console.WriteLine(myDictionary[Figures.Reqtangle](sideA, sideB));
                                break;

                            case 4:
                                Console.WriteLine("Input height (integer number):");
                                int.TryParse(Console.ReadLine(), out int height);
                                Console.WriteLine("Input base (integer number):");
                                int.TryParse(Console.ReadLine(), out int baseT);
                                IsWrongChoice = false;
                                Console.WriteLine(myDictionary[Figures.Reqtangle](height, baseT));
                                break;
                        }
                    }
                    else
                        Console.WriteLine("Your choice is wrong!");
                       
                }
            }
        }
    }
}
