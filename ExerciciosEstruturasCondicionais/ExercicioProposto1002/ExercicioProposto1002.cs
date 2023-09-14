using System;
using System.Globalization;

namespace ExercicioProposto1002
{
    public class ExercicioProposto1002
    {
        static void Main(string[] args)
        {
            double raio, area;
            double n = 3.14159;
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            raio = Math.Pow(raio, 2.0);
            area = raio * n;
            Console.WriteLine("A=" + area.ToString("F4",CultureInfo.InvariantCulture));
        }
    }
}
// A fórmula para calcular a área de uma circunferência é: area = π . raio2. Considerando para este problema que π = 3.14159:

// - Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por π.