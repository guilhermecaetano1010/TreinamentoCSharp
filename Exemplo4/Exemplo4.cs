//Exemplo de entrada de dados com split
using System;
using System.Globalization;

namespace Exemplo4
{
    public class Exemplo4
    {
       static void Main(string[] args) {
        int numero1 = int.Parse(Console.ReadLine());
        char char1 = char.Parse(Console.ReadLine());
        double numero2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        string[] vetor = Console.ReadLine().Split(' ');
        string nome = vetor[0];
        char sexo = char.Parse(vetor[1]);
        int idade = int.Parse(vetor[2]);
        double altura = double.Parse(vetor[3], CultureInfo.InvariantCulture);


        Console.WriteLine("Você digitou:");
        Console.WriteLine(numero1);
        Console.WriteLine(char1);
        Console.WriteLine(numero2.ToString(CultureInfo.InvariantCulture)); // Não foi necessário colocar a quantidade de casas depois da vírgula se quiser ToString("F2", Culture...)

        Console.WriteLine(nome);
        Console.WriteLine(sexo);
        Console.WriteLine(idade);
        Console.WriteLine(altura.ToString(CultureInfo.InvariantCulture));
       }
    }
}
