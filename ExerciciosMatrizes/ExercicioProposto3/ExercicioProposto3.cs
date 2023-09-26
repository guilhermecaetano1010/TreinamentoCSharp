using System;


namespace ExercicioProposto3
{
    public class ExercicioProposto3
    {
            static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N, N];

            for (int i = 0; i < N; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            for (int i = 0; i < N; i++) {
                int maior = mat[i, 0];
                for (int j = 1; j < N; j++) {
                    if (mat[i, j] > maior) {
                        maior = mat[i, j];
                    }
                }
                Console.WriteLine(maior);
            }
        } 
    }
}
/*Ler um inteiro N e uma matriz quadrada de ordem N. Mostrar qual o maior elemento de cada linha. Suponha não haver
empates.*/