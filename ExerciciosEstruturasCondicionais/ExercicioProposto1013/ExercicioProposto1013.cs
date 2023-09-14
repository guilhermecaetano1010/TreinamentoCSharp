using System;
using System.Globalization;

namespace ExercicioProposto1013
{
    public class ExercicioProposto1013
    {
        static void Main(string[] args){
            string[] vector = Console.ReadLine().Split(' ');
            int A = int.Parse(vector[0], CultureInfo.InvariantCulture);
            int B = int.Parse(vector[1], CultureInfo.InvariantCulture);
            int C = int.Parse(vector[2], CultureInfo.InvariantCulture);

            double greaterAB = (A+B+Math.Abs(A-B))/2;

            double greater = (greaterAB+C+Math.Abs(greaterAB-C))/2;


            Console.WriteLine(greater+" eh o maior");

        }
    }
}
/*Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. Utilize a fórmula:
Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.*/
