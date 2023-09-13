using System;
using System.Globalization;

namespace ExercicioResolvido3
{
    public class ExercicioResolvido3
    {
        static void Main(string[] args){
        
            string[] vector;

        Console.WriteLine("Digite seu primeiro nome e sua idade:");
        vector = Console.ReadLine().Split(' ');
        string name1 = vector[0];
        int age1 = int.Parse(vector[1]);


        Console.WriteLine("Digite seu primeiro nome e sua idade:");
        vector = Console.ReadLine().Split(' ');
        string name2 = vector[0];
        int age2 = int.Parse(vector[1]);

        double average = (double)(age1 + age2)/2;
        

        Console.WriteLine("A idade média de "+name1+" e "+name2+" é de "+ average.ToString("F1", CultureInfo.InvariantCulture)+ " anos");

        
        }

    }
}