using System;
using System.Globalization;

namespace ExercicioProposto1012
{
    public class ExercicioProposto1012
    {
        static void Main(string[] args){
            string[] vector = Console.ReadLine().Split(' ');
            double A = double.Parse(vector[0], CultureInfo.InvariantCulture);
            double B = double.Parse(vector[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vector[2], CultureInfo.InvariantCulture);

            double triangle = A*C/2;
            double circle = 3.14159*(Math.Pow(C, 2));
            double trapeze = (A+B)*C/2;
            double square = B*B;
            double rectangle = A*B;

            Console.WriteLine("TRIANGULO: "+ triangle.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: "+ circle.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: "+ trapeze.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: "+ square.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: "+ rectangle.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
/*Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B.*/