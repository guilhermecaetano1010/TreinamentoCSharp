using System;


namespace TreinamentoCSharp.ExercicioEstruturaPara
{
    public class ExercicioProposto1067
    {
        public static void Main(string[] args) {
            int X = int.Parse(Console.ReadLine());

            if(X <= 1 || X <= 1000){
            for (int i = 1; i <= X ; i++) {
                if(i % 2 == 1){
                    Console.WriteLine(i);
                }
            }
        }
    }
  }
}
/*Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.*/