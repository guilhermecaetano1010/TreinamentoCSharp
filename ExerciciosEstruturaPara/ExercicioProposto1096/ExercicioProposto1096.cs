using System;

namespace ExercicioProposto1096
{
    public class ExercicioProposto1096
    {
        static void Main(string[] args)
        {
          int i = 1;
            if (i % 2 == 1)
            {
                for (i = 1; i <= 9; i = i + 2)
                {
                    for (int j = 7; j >= 5; j--) {
                        Console.WriteLine("I=" + i + " " + "J=" + j);
                    }
                }
            }

        }
    }
}



/*Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.*/