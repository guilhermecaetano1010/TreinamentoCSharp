
using System;
using System.Globalization;

namespace ExercicioResolvido2
{
    public class ExercicioResolvido2
    {
        static void Main(string[]args){
        
        Console.WriteLine("Digite o valor da base do Retângulo:");
        double base1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor da altura do Retângulo:");
        double height1 = double.Parse(Console.ReadLine());

        double area = base1*height1;
        double perimeter = 2*(base1+height1);
        double diagonal = Math.Sqrt(Math.Pow(base1, 2.0)+Math.Pow(height1,2.0));

        Console.WriteLine("AREA = "+ area.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("PERIMETER = "+ perimeter.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("DIAGONAL = "+ diagonal.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}