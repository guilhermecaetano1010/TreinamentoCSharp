using System;
using System.Globalization;

namespace ExercicioProposto1014
{
    public class ExercicioProposto1014
    {
        static void Main(string[] args) {
            int X;
            double Y, total;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = X/Y;

            Console.WriteLine(total.ToString("F3", CultureInfo.InvariantCulture)+" km/l");
        }
    }
}
//Calcule o consumo médio de um automóvel sendo fornecidos a distância total percorrida (em Km) e o total de combustível gasto (em litros).