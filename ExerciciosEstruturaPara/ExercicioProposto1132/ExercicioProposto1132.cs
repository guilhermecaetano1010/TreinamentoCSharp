using System;


namespace ExercicioProposto1132
{
    public class ExercicioProposto1132 {
        static void Main(string[] args) {
             int X = int.Parse(Console.ReadLine());
             int Y = int.Parse(Console.ReadLine());
             int soma = 0;
            if(Y > X){
             for (int i = X; i <= Y; i++) {
                if(i % 13 != 0){
                soma = soma + i;
                }
             }  
            }
            else{
             for (int j = Y; j <= X; j++) {
                if(j % 13 != 0){
                soma = soma + j;
                }
            }
            }  
             Console.WriteLine(soma);
        }
    }
}
/**/

