using System;
using System.Globalization;

namespace ExercicioProposto1038
{
    public class ExercicioProposto1038
    {
        static void Main(string[] args){

            string[] vetor = Console.ReadLine().Split(' ');

            int codigo = int.Parse(vetor[0]);
            int quantidade = int.Parse(vetor[1]);

            double pagamento = 0.0;

            switch (codigo) {
               case 1:
               pagamento = (double)quantidade*4.00;
               break; 
               case 2:
               pagamento = (double)quantidade*4.50;
               break; 
               case 3:
               pagamento = (double)quantidade*5.00;
               break; 
               case 4:
               pagamento = (double)quantidade*2.00;
               break; 
               case 5:
               pagamento = (double)quantidade*1.50;
               break; 
            }

                Console.WriteLine("Total: R$ "+pagamento.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
/*Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.*/