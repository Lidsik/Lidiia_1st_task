using System;

namespace Lidiia_1st_task
{
    public class Figure
    {
        public double input;

        public Figure(double RadiusOrSide)
        {
            input = RadiusOrSide;
        }

        static double CircleArea(double r)
        {
            double result = Math.Round(Math.PI * Math.Pow(r, 2), 2);
            return result;
        }

        static double SquareArea(double a)
        {
            double result = Math.Round(Math.Pow(a, 2), 2);
            return result;
        }

        public static void Main(string[] args)
        {
            EnterFigure(Shape.Circle);
            EnterFigure(Shape.Square);
            Console.WriteLine("The 1st task is done \nPlease enter any key");
            Console.ReadKey();
        }

        enum Shape
        {
            Circle,
            Square
        }

        static void EnterFigure(Shape shape)
        {
            switch (shape)
            {
                case Shape.Circle:

                    Console.WriteLine("Please enter circle radius:");
                    double CircleAreaAnswer = CircleArea(ReturnRadiusOrSide());
                    Console.WriteLine("\n\rThe area of the circle is " + CircleAreaAnswer);
                    break;

                case Shape.Square:

                    Console.WriteLine("\nPlease enter square side:");
                    double SquareAreaAnswer = SquareArea(ReturnRadiusOrSide());
                    Console.WriteLine("\n\rThe area of the square is " + SquareAreaAnswer);
                    break;
            }
        }

        public static double ReturnRadiusOrSide()
        {
            int e = 0;
            while (e < 3)
            {
                string InputString = Console.ReadLine();
                if (InputString.ToString() != string.Empty)
                {
                    try
                    {
                        double RadiusOrSideTest = Convert.ToDouble(InputString);
                        var CircleOrArea = new Figure(RadiusOrSideTest) { };
                        Console.WriteLine("\nInput Value is " + CircleOrArea.input);
                        return CircleOrArea.input;
                    }

                    catch (SystemException invalid)
                    {
                     
                        string LastError = invalid.Message;
                        Console.WriteLine("\nInvalid data" + LastError + " \nPlease, enter the valid values");
                        e++;
                    }
                }
                else
                {
                    Console.WriteLine("\nParameters 'a' and 'r' must be set");
                }
            }

            if (e == 3)
            {

                double min = 0.5;
                double max = 5.0;
                //Random r = new Random();
                //double randomValue = rangeMin + (rangeMax - rangeMin) * r.nextDouble();
                double RadiusOrSide = new Random().NextDouble() * (max - min) + min;
                Figure OtherCircleOrArea = new Figure(RadiusOrSide) { };
                Console.WriteLine("\nRandom value is " + OtherCircleOrArea.input);
                return OtherCircleOrArea.input;
            }
            return 0;
        }

    }
}