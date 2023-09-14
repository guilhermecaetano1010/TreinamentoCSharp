using System;
using System.Globalization;

namespace ExercicioProposto1117
{
    public class ExercicioProposto1117
    {
        static void Main(string[] args)
        {
            double A1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (A1 < 0.0 || A1 > 10.0) {
                Console.WriteLine("nota invalida");
                A1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double A2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (A2 < 0.0 || A2 > 10.0) {
                Console.WriteLine("nota invalida");
                A2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double media = (A1 + A2) / 2.0;
            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
}

/*Faça um programa que leia as notas referentes às duas avaliações de um aluno. Calcule e imprima a média semestral. Faça com que o algoritmo só aceite notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). Cada nota deve ser validada separadamente.*/