using System;


namespace ExercicioProposto1097
{
    public class ExercicioProposto1097
    {
        static void Main(string[] args) {
            int j = 7;
            for (int i = 1; i <= 9; i = i + 2) {
                Console.WriteLine("I="+i+" "+"J="+j);
                Console.WriteLine("I="+i+" "+"J="+(j -1));
                Console.WriteLine("I="+i+" "+"J="+(j - 2));
                j += 2; 
            }
        }
    }
}