using System;


namespace ExercicioProposto1075
{
    public class ExercicioProposto1075
    {
        static void Main(string[] args) {
        int N = int.Parse(Console.ReadLine()); 
        for (int i = 1; i <= 10000; i++) {
            if(i % N == 2) {
             Console.WriteLine(i);
            }
          }

        }
    }
}
/*Leia um valor inteiro N. Apresente todos os números entre 1 e 10000 que divididos por N dão resto igual a 2.*/