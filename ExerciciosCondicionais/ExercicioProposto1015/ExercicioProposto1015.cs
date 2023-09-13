using System;
using System.Globalization;

namespace ExercicioProposto1015
{
    public class ExercicioProposto1015
    {
        static void Main(string[] args)
        {

            string[] vector;

            vector = Console.ReadLine().Split(' ');
            double x1 = double.Parse(vector[0], CultureInfo.InvariantCulture);
            double y1 = double.Parse(vector[1], CultureInfo.InvariantCulture);


            vector = Console.ReadLine().Split(' ');
            double x2 = double.Parse(vector[0], CultureInfo.InvariantCulture);
            double y2 = double.Parse(vector[1], CultureInfo.InvariantCulture);

            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));


            Console.WriteLine(distance.ToString("F4", CultureInfo.InvariantCulture));


        }

    }
}
