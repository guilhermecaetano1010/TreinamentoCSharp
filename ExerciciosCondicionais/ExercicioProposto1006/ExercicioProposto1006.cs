using System;
using System.Globalization;

namespace ExercicioProposto1006
{
    public class ExercicioProposto1006
    {
        static void Main(string[] args){
        double A,B,C,MEDIA;
        A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        MEDIA = ((A*2)+(B*3)+(C*5))/10;

        Console.WriteLine("MEDIA = "+MEDIA.ToString("F1",CultureInfo.InvariantCulture));
        }
    }
}
//Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2, a nota B tem peso 3 e a nota C tem peso 5. Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.