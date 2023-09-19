using System;
using System.Globalization;

namespace ExercicioResolvido02
{
    public class ExercicioResolvido02 {
        static void Main(string[] args) {
            int N;
            double[] vet; 
            double media = 1;
            double soma = 0;

            N = int.Parse(Console.ReadLine());
            vet = new double[N];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++) {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < N; i++) {
            Console.Write(vet[i].ToString("F1", CultureInfo.InvariantCulture)+" ");
            }

            Console.WriteLine();
            
            for (int i = 0; i < N; i++) {
                     soma += vet[i];
            }
             media = soma / N;

                Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}