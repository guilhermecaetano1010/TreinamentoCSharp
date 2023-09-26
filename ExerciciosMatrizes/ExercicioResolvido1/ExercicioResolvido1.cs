using System;

namespace ExercicioResolvido1
{
    public class ExercicioResolvido1
    {
         static void Main(string[] args) {
            int N;
            int[,] A;


            N = int.Parse(Console.ReadLine());
            A = new int[N, N];

            for (int i = 0; i < N; i++) {

                string[] s = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++) {

                    A[i, j] = int.Parse(s[j]);

                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL: ");

            for (int i = 0; i < N; i++) {

                Console.Write(A[i, i] + " ");

            }

            Console.WriteLine();
            
            int contagem = 0;

            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                if (A[i, j] < 0) {
                contagem ++;
            }
                }
            }

            Console.WriteLine("QUANTIDADE DE NÚMEROS NEGATIVOS: "+ contagem);

        }
    }
}