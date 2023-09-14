using System;


namespace ExercicioProposto1134
{
    public class ExercicioProposto1134
    {
        static void Main(string[] args)
        {

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int codigo = int.Parse(Console.ReadLine());

            while (codigo < 1 || codigo > 4) {
                codigo = int.Parse(Console.ReadLine());
            }


            while (codigo != 4) {
                if (codigo == 1) {
                    alcool = alcool + 1;
                } 
                
                else if (codigo == 2) {                  
                    gasolina = gasolina + 1;

                } else if (codigo == 3) {
                    diesel = diesel + 1;
                }

                codigo = int.Parse(Console.ReadLine());
            }
                Console.WriteLine("MUITO OBRIGADO");
                Console.WriteLine("Alcool: "+alcool);
                Console.WriteLine("Gasolina: "+gasolina);
                Console.WriteLine("Diesel: "+diesel);
        }
    }
}
/*Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até que seja válido). O programa será encerrado quando o código informado for o número 4.*/