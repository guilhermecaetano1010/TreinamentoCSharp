using System;
using System.Globalization;

namespace ExercicioProposto1041
{
    public class ExercicioProposto1041
    {
        static void Main(string[] args) {
            string[] vetor = Console.ReadLine().Split(' ');
            double x = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            double y = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");

            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");

            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");

            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");

            } else if (x > 0.0 && y < 0.0) {

                Console.WriteLine("Q4"); 

            }else if (x == 0) {
                Console.WriteLine("Eixo Y");
            } else if(y == 0) {
                Console.WriteLine("Eixo X");
            }
        }
    }
}
/*Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).*/