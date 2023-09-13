using System;


namespace ExercicioProposto1044
{
    public class ExercicioProposto1044
    {
       static void Main(string[] args){
            string[] vetor = Console.ReadLine().Split(' ');
            int A = int.Parse(vetor[0]);
            int B = int.Parse(vetor[1]);

            if (A % B == 0 || B % A == 0 ) {
                Console.WriteLine("Sao Multiplos");
            } else{
                Console.WriteLine("Nao sao Multiplos");
            }
       } 
    }
}
/*Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si.*/