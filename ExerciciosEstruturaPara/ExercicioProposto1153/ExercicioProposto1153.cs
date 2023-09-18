using System;


namespace ExercicioProposto1153
{
    public class ExercicioProposto1153 {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());
            int Fatorial = 1;
            if (N>0 && N<13) {
            for (int i = N; i >= 1; i--) {
                Fatorial = Fatorial * i;
            }
        }
            Console.WriteLine(Fatorial);

        }
    }
}
/*Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.*/