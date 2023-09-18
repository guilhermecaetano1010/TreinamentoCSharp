using System;


namespace ExercicioProposto1144
{
    public class ExercicioProposto1144 {
        
        static void Main(string[] args) {
            
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                    int x = i;
                    int y = i * i;
                    int z = i * i * i;

                    Console.WriteLine($"{x} {y} {z}");
                    Console.WriteLine($"{x} {y+1} {z+1}");

            }

        }

    }
}
/*Escreva um programa que leia um valor inteiro N. N * 2 linhas de saída serão apresentadas na execução do programa, seguindo a lógica do exemplo abaixo. Para valores com mais de 6 dígitos, todos os dígitos devem ser apresentados.*/