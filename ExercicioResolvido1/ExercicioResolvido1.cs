using System;
using System.Globalization; 

namespace ExercicioResolvido1
{
    public class ExercicioResolvido1
    {
        static void Main(string[] args) {
            double largura, comprimento, valorMetro, area, preco;
            Console.WriteLine("Digite a largura do terreno:");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o comprimento do terreno:");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor por metro quadrado:");
            valorMetro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura*comprimento;
            preco = area * valorMetro;

            Console.WriteLine("AREA = "+area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO = "+preco.ToString("2", CultureInfo.InvariantCulture));
        }
    }
}