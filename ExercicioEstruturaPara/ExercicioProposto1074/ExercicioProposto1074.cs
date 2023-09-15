using System;


namespace ExercicioProposto1074
{
    public class ExercicioProposto1074 {
        static void Main(string[] args) {

                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++) {

                int x = int.Parse(Console.ReadLine());

                if (x == 0) {
                    Console.WriteLine("NULL");
                }
                else if (x > 0) {
                    if (x % 2 == 0) {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                    else {
                        Console.WriteLine("ODD POSITIVE");
                    }
                }
                else {
                    if (x % 2 == 0) {
                        Console.WriteLine("EVEN NEGATIVE");
                    }
                    else {
                        Console.WriteLine("ODD NEGATIVE");
                    }
          
                }
                
            }    
        }
    }
}
/*Leia um valor inteiro N. Este valor será a quantidade de valores que serão lidos em seguida. Para cada valor lido, mostre uma mensagem em inglês dizendo se este valor lido é par (EVEN), ímpar (ODD), positivo (POSITIVE) ou negativo (NEGATIVE). No caso do valor ser igual a zero (0), embora a descrição correta seja (EVEN NULL), pois por definição zero é par, seu programa deverá imprimir apenas NULL.*/