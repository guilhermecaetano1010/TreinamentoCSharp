//Exemplo de funções matemáticas
using System;


namespace FuncoesMat
{
    public class FuncoesMat
    {
        static void Main (string[] args){

        double numero1 = 3.0;
        double numero2 = 4.0;
        double numero3 = -5.0;
        double A, B, C;

        A = Math.Sqrt(numero1);
        B = Math.Sqrt(numero2);
        C = Math.Sqrt(25.0);
        Console.WriteLine("Raiz quadrada de "+ numero1 + " = " + A);
        Console.WriteLine("Raiz quadrada de "+ numero2 + " = " + B);
        Console.WriteLine("Raiz quadrada de 25 = "+ C);

        A = Math.Pow(numero1, numero2);
        B = Math.Pow(numero1, 2.0);
        C = Math.Pow(5.0, 2.0);
        Console.WriteLine(numero1+" elevado a "+ numero2 + " = " + A);
        Console.WriteLine(numero1+" elevado ao quadrado = "+ B);
        Console.WriteLine("5 elevado ao quadrado = "+ C);

        A = Math.Abs(numero2);
        B = Math.Abs(numero3);
        Console.WriteLine("O valor absoluto de "+ numero2 + " = " + A);
        Console.WriteLine("O valor absoluto de "+ numero3 + " = " + B);
        


        }

    }
}