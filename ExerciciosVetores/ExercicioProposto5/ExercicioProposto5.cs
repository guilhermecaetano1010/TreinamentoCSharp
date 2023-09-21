using System;
using System.Globalization;

namespace ExercicioProposto5
{
    public class ExercicioProposto5
    {
       static void Main(string[] args) {
            
            int N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            string[] valores = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++) {
                vet[i] = double.Parse(valores[i]);
            }

            double somaDosPares = 0.0;
            int quantidadeDePares = 0;
            for (int i = 0; i < N; i++) {

                if (vet[i] % 2 == 0) {
                    somaDosPares = somaDosPares + vet[i];
                    quantidadeDePares++;
                }

            }

            if (quantidadeDePares == 0) {
                Console.WriteLine("Não havia nenhum número par.");
            }
            else {
                double media = somaDosPares / quantidadeDePares;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
       } 
    }
}
/*Fazer um programa para ler um vetor de N números inteiros. Em seguida, mostrar na tela a média aritmética somente
dos números pares lidos. */