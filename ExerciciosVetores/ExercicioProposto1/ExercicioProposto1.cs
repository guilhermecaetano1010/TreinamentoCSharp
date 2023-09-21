using System;
using System.Globalization;

namespace ExercicioProposto1
{
    public class ExercicioProposto1 {
        static void Main(string[] args) {
            
            int N;
            double[] vetor;

            N = int.Parse(Console.ReadLine());
            vetor = new double[N];

            string[] valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++) {
                vetor[i] = double.Parse(valores[i], CultureInfo.InvariantCulture);
            }

            double maior = vetor[0];
            int posicaoMaior = 0;

            for (int i = 1; i < N; i++) {
                if (vetor[i] > maior) {
                    maior = vetor[i];
                    posicaoMaior = i;
                }
            }
            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicaoMaior);
        }
    }
}
/*Faça um programa que leia N números reais e armazene-os em um vetor. Em seguida, mostrar na tela o maior número
do vetor (supor não haver empates). Mostrar também a posição do maior elemento.*/