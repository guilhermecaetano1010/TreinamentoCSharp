using System;
using System.Globalization;

namespace ExercicioProposto6
{
    public class ExercicioProposto6
    {
            static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            double[,] mat = new double[N, N];

         
            for (int i = 0; i < N; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    mat[i, j] = double.Parse(valores[j], CultureInfo.InvariantCulture);
                }
            }

            int linha = int.Parse(Console.ReadLine());
            int coluna = int.Parse(Console.ReadLine());

          
            double soma = 0.0;
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    if (mat[i, j] > 0.0) {
                        soma = soma + mat[i, j];
                    }
                }
            }
            Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1", CultureInfo.InvariantCulture));

      	
            Console.Write("LINHA ESCOLHIDA: ");
            for (int j = 0; j < N; j++) {
                Console.Write(mat[linha, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

       	
            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i = 0; i < N; i++) {
                Console.Write(mat[i, coluna].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

      
            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++) {
                Console.Write(mat[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    if (mat[i, j] < 0.0) {
                        mat[i, j] = mat[i, j] * mat[i, j];
                    }
                }
            }
            Console.WriteLine("MATRIZ ALTERADA:");
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    Console.Write(mat[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
/*Ler uma matriz quadrada de ordem N, contendo números reais. Em seguida, fazer as seguintes ações:
a) calcular e imprimir a soma de todos os elementos positivos da matriz.
b) fazer a leitura do índice de uma linha da matriz e, daí, imprimir todos os elementos desta linha.
c) fazer a leitura do índice de uma coluna da matriz e, daí, imprimir todos os elementos desta coluna.
d) imprimir os elementos da diagonal principal da matriz.
e) alterar a matriz elevando ao quadrado todos os números negativos da mesma. Em seguida imprimir a matriz alterada*/