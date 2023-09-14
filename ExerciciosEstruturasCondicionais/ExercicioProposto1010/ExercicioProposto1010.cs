using System;
using System.Globalization;

namespace ExercicioProposto1010
{
    public class ExercicioProposto1010
    {
        static void Main(string[] args) {

            int x,y,a,b;
            double z,c,amount1,amount2,totalValue;

            string[] vector1 = Console.ReadLine().Split(' ');
             x = int.Parse(vector1[0]);
             y = int.Parse(vector1[1]);
             z = double.Parse(vector1[2], CultureInfo.InvariantCulture);

            string[] vector2 = Console.ReadLine().Split(' ');
             a = int.Parse(vector2[0]);
             b = int.Parse(vector2[1]);
             c = double.Parse(vector2[2], CultureInfo.InvariantCulture);

             amount1 = y * z;
             amount2 = b * c;
             totalValue = amount1 + amount2;

             Console.WriteLine("VALOR A PAGAR: R$ "+ totalValue.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

//Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.