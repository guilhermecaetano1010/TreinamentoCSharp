using System;


namespace ExercicioResolvido2
{
    public class ExercicioResolvido2
    {
        static void Main(string[] args) {
            int M, N;
            int[,] A;

            string[] vetor = Console.ReadLine().Split(' ');
            M = int.Parse(vetor[0]);
            N = int.Parse(vetor[1]);
            A = new int[M,N];

            for (int i = 0; i < M; i++) {
                vetor = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++) {
                    A[i, j] = int.Parse(vetor[j]);
                }
            }

            int[] B = new int [M];
            
            for (int i = 0; i < M; i++) {
                int soma = 0;
                for (int j = 0; j < N; j++) {
                    soma = soma + A[i, j];
                }
                B[i] = soma;
            }

            for (int i = 0; i < M; i++) {
                Console.WriteLine(B[i]);
            }
        }
    }
}