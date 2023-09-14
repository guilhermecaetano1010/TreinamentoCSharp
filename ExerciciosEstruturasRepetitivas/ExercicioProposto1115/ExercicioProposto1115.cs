using System;


namespace ExercicioProposto1115
{
    public class ExercicioProposto1115
    {
         static void Main(string[] args) {
            string[] vetor = Console.ReadLine().Split(' ');
            int X = int.Parse(vetor[0]);
            int Y = int.Parse(vetor[1]);

            while (X != 0 && Y != 0) {

                if (X > 0 && Y > 0) {
                    Console.WriteLine("primeiro");
                } else if(X < 0 && Y > 0) {
                    Console.WriteLine("segundo");  
                } else if(X < 0 && Y < 0) {
                    Console.WriteLine("terceiro");
                } else {
                    Console.WriteLine("quarto");
                }
                vetor = Console.ReadLine().Split(' ');
                X = int.Parse(vetor[0]);
                Y = int.Parse(vetor[1]);
            }
        }
    }
}
/*Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).*/