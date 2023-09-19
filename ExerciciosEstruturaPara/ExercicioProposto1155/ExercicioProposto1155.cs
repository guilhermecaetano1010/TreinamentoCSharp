using System;
using System.Globalization;

namespace ExercicioProposto1155
{
    public class ExercicioProposto1155 {
        static void Main(string[] args) {
            double soma = 0;
            for (int i = 1; i <= 100; i++) {
                soma = soma + 1.0 / i;
            }

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    
        }
    }
/*Escreva um algoritmo para calcular e escrever o valor de S, sendo S dado pela fórmula:
S = 1 + 1/2 + 1/3 + … + 1/100*/