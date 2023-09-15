using System;
using System.Globalization;

namespace ExemploFacaEnquanto
{
    public class ExemploFacaEnquanto
    {
        static void Main(string[] args) {
            
            double C, F;
            char repetir;

            do{
                Console.WriteLine("Digite a temperatura em Celsius: ");
                C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                F = 9.0 * C / 5.0 + 32.00;
                Console.WriteLine("Equivalente em Fahrenheit: "+ F);
                Console.WriteLine("Digite repetir (s/n)? ");
                repetir = char.Parse(Console.ReadLine());
            } while(repetir == 's');
        }
    }
}