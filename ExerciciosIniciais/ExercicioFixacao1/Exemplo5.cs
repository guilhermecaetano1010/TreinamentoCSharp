// Exercicio de fixação da aula de entrada de dados 2
using System;
using System.Globalization;


namespace Exemplo5
{
    public class Exemplo5
    {
       static void Main(string[] args) {

           Console.WriteLine("Digite seu nome completo: ");

           string nome = Console.ReadLine();

           Console.WriteLine("Quantos quartos tem na sua casa?");
           int quanto = int.Parse(Console.ReadLine());

           Console.WriteLine("Digite o preço de um produto:");
           double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           Console.WriteLine("Digite seu último nome, idade e altura: ");

           string[] vetor = Console.ReadLine().Split(' ');
           string ultimoNome = vetor[0];
           int idade = int.Parse(vetor[1]);
           double altura = double.Parse(vetor[2], CultureInfo.InvariantCulture);


           Console.WriteLine(nome);
           Console.WriteLine(quanto);
           Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
           Console.WriteLine(ultimoNome);
           Console.WriteLine(idade);
           Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
           
       }
    }
}