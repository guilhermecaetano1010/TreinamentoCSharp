using System;
using System.Globalization;

namespace ExercicioProposto1048
{
    public class ExercicioProposto1048
    {
        static void Main(string[] args) {

            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double percentual;
            if (salario <= 400.0) {
                percentual = 15.0;
            }
            else if (salario <= 800.0) {
                percentual = 12.0;
            }
            else if (salario <= 1200.0) {
                percentual = 10.0;
            }
            else if (salario <= 2000.0) {
                percentual = 7.0;
            }
            else {
                percentual = 4.0;
            }

            double reajuste = salario * percentual / 100.0;
            double novoSalario = salario + reajuste;

            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual.ToString("F0", CultureInfo.InvariantCulture) + " %");
        } 
    }
}
/*A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo:


Salário	Percentual de Reajuste
0 - 400.00
400.01 - 800.00
800.01 - 1200.00
1200.01 - 2000.00
Acima de 2000.00

15%
12%
10%
7%
4%

Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste ganho e o índice reajustado, em percentual.*/