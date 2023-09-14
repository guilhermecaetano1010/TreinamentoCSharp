using System;
using System.Globalization;

namespace ExercicioProposto1118
{
    public class ExercicioPeoposto1118
    {
       static void Main(string[] args) {
            
            int continuar = 1;

            while (continuar  == 1) {

            double A1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (A1 < 0 || A1 > 10) {

                Console.WriteLine("nota invalida");
                A1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double A2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (A2 < 0 || A2 > 10) {
                Console.WriteLine("nota invalida");
                A2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double media = (A1 + A2)/2;
            Console.WriteLine("media = "+ media.ToString("F2", CultureInfo.InvariantCulture));
            
            Console.WriteLine("novo calculo (1-sim 2-nao)");
            continuar = int.Parse(Console.ReadLine());
            while(continuar != 1 && continuar != 2){
            Console.WriteLine("novo calculo (1-sim 2-nao)");
            continuar = int.Parse(Console.ReadLine());
            }   
            }

       } 
    }
}
/*Escreva um programa para ler as notas da primeira e a segunda avaliação de um aluno. Calcule e imprima a média semestral. O programa só deverá aceitar notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). Cada nota deve ser validada separadamente.

No final deve ser impressa a mensagem “novo calculo (1-sim 2-nao)”, solicitando ao usuário que informe um código (1 ou 2) indicando se ele deseja ou não executar o algoritmo novamente, (aceitar apenas os código 1 ou 2). Se for informado o código 1 deve ser repetida a execução de todo o programa para permitir um novo cálculo, caso contrário o programa deve ser encerrado.*/