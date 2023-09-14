using System;
using System.Globalization;

namespace ExercicioProposto1154
{
    public class ExercicioProposto1154
    {
         static void Main(string[] args) {
            int idade = 0;
            int contador = 0;
            int somaIdade = 0;
            double media;
            idade = int.Parse(Console.ReadLine());
            while (idade >= 0){
                somaIdade +=  idade;
                contador = contador+1;
                idade = int.Parse(Console.ReadLine());
            }
            media = (double)somaIdade / contador;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
/*Faça um algoritmo para ler um número indeterminado de dados, contendo cada um, a idade de um indivíduo. O último dado, que não entrará nos cálculos, contém o valor de idade negativa. Calcular e imprimir a idade média deste grupo de indivíduos.*/