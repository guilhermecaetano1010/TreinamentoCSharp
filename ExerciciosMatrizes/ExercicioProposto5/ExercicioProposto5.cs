using System;


namespace ExercicioProposto5
{
    public class ExercicioProposto5
    {
            static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');
            int M = int.Parse(valores[0]);
            int N = int.Parse(valores[1]);

            int[,] A = new int[M, N];
            int[,] B = new int[M, N];
            int[,] C = new int[M, N];


            for (int i = 0; i < M; i++) {
                valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    A[i, j] = int.Parse(valores[j]);
                }
            }

   
            for (int i = 0; i < M; i++) {
                valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    B[i, j] = int.Parse(valores[j]);
                }
            }


            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }


            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
/*Fazer um programa para ler duas matrizes de números inteiros A e B, contendo de M linhas e N colunas cada. Depois,
gerar uma terceira matriz C onde cada elemento desta é a soma dos elementos correspondentes das matrizes originais.
Imprimir na tela a matriz gerada.*/