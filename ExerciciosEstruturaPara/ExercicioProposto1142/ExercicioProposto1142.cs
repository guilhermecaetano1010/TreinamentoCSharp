using System;


namespace ExercicioProposto1142
{
    public class ExercicioProposto1142 {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            int x = 1 ;
            for (int i = 1; i <= N; i++) {

                int y = x + 1;
                int z = x + 2;

                Console.WriteLine(x + " " + y + " " + z + " PUM");

                x = x + 4;
            }
        }
    }
}
/*Escreva um programa que leia um valor inteiro N. Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.*/