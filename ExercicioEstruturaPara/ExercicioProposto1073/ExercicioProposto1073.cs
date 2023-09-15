using System;


namespace ExercicioProposto1073
{
    public class ExercicioProposto1073
    {
        static void Main(string[] args) {
                        int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++) {
                if (i % 2 == 0) {
                    int quadrado = i * i;
                    Console.WriteLine(i + "^2 = " + quadrado);
                }
            }
        }
    }
}
/*Leia um valor inteiro N. Apresente o quadrado de cada um dos valores pares, de 1 até N, inclusive N, se for o caso.*/