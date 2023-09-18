using System;


namespace TreinamentoCSharp.ExerciciosEstruturaPara.ExercicioProposto1151
{
    public class ExercicioProposto1151 {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());

            int x = 0;
            int y = 1;

            for (int i = 0; i < N; i ++) {
                if (i == N - 1) {
                    Console.WriteLine(x);
                }
                else {
                    Console.Write(x + " ");
                }
                int a = y;
                y = x;
                x = a + y;
                }
            }
        }
    }
    /*A seguinte sequência de números 0 1 1 2 3 5 8 13 21... é conhecida como série de Fibonacci. Nessa sequência, cada número, depois dos 2 primeiros, é igual à soma dos 2 anteriores. Escreva um algoritmo que leia um inteiro N (N < 46) e mostre os N primeiros números dessa série.*/
