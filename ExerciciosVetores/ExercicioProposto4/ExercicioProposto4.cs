using System;
using System.Globalization;

namespace ExercicioProposto4
{
    public class ExercicioProposto4
    {
        static void Main(string[] args) {
                        int N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            string[] valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++) {
                vet[i] = double.Parse(valores[i], CultureInfo.InvariantCulture);
            }

  
            double soma = 0.0;
            for (int i = 0; i < N; i++) {
                soma = soma + vet[i];
            }
            double media = soma / N;
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            for (int i = 0; i < N; i++) {
                if (vet[i] < media) {
                    Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
/*Fazer um programa para ler um vetor de N números reais. Em seguida, mostrar na tela a média aritmética de todos
elementos. Depois mostrar todos os elementos do vetor que estejam abaixo da média.*/