//Exemplo de processamento de dados
using System;


namespace Exemplo3
{
    public class Exemplo3
    {
       static void Main(string[] args) {
        int a, b;
        double resultado;
        a = 5;
        b = 2;
        resultado = (double)a / b; //quando escreve (double) o resultado vem com número com virgula se não ele vem inteiro por causa das entradas
        Console.WriteLine(resultado);
       }
    }
}