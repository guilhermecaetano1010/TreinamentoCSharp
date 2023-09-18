using System;



namespace ExercicioProposto1133
{
    public class ExercicioProposto1133 {
        static void Main(string[] args) {

            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int soma = 0;

            if(Y > X)
            for (int i = X + 1; i < Y; i++) {
                if(i % 5 == 2 || i % 5 == 3){
                Console.WriteLine(i);
                }
            }

            else {     
            for (int j = Y + 1; j < X; j++) {
                if(j % 5 == 2 || j % 5 == 3){
                  Console.WriteLine(j); 
                }
            }
            }
        }
    }
}
/*Escreva um programa que leia 2 valores X e Y e que imprima todos os valores entre eles cujo resto da divisão dele por 5 for igual a 2 ou igual a 3.*/