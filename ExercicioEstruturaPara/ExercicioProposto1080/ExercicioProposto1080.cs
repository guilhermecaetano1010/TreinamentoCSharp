using System;


namespace ExercicioProposto1080
{
    public class ExercicioProposto1080
    {
      static void Main(string[] args) {

            int maior = int.Parse(Console.ReadLine());
            int posicao = 1;


            for (int i = 2; i <= 100; i++) {
                int x = int.Parse(Console.ReadLine());
                if (x > maior) {
                    maior = x;
                    posicao = i;
                }
            }

            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }
      }  
    }
    /*Leia 100 valores inteiros. Apresente então o maior valor lido e a posição dentre os 100 valores lidos.*/

