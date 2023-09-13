using System;


namespace ExercicioResolvido4
{
    public class ExercicioResolvido4
    {
        static void Main(string[] args){
            int N = int.Parse(Console.ReadLine());
            int hours = N/3600; 
            int minutes = (N % 3600) / 60;
            int seconds = (N % 60);
            Console.WriteLine(hours+":"+ minutes+":"+seconds);
        }
    }
}

/*Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, e informe-o expresso no formato horas:minutos:segundos. 1019*/