using System;


namespace ExercicioProposto1143
{
    public class ExercicioProposto1143 {
        static void Main(string[] args) {

        int N = int.Parse(Console.ReadLine());

        if (1 <= N && N <= 1000) {
            
         for (int i = 1; i <= N; i++) {
        
        int x = i;
        int y = i * i;
        int z = i * i * i;

        Console.WriteLine($"{x} {y} {z}");
            

         }

        }

        }
    }
}
/*Escreva um programa que leia um valor inteiro N (1 < N < 1000). Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.*/