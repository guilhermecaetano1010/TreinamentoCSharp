using System;
using System.Globalization;

namespace ExercicioProposto1009
{
    public class ExercicioProposto1009
    {
        static void Main(string[] args){
            string name = Console.ReadLine();
            double fixSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double sales = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double commission = sales*15/100;
            double total = fixSalary+commission ;
            
            Console.WriteLine("TOTAL = R$ "+total.ToString("F2", CultureInfo.InvariantCulture));
        }
        
    }
}
/*Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês (em dinheiro). Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas, informar o total a receber no final do mês, com duas casas decimais.*/