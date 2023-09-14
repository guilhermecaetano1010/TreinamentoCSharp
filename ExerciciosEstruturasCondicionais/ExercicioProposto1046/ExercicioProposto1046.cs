using System;


namespace ExercicioProposto1046
{
    public class ExercicioProposto1046
    {
        static void Main(string[] args){
            string[] vetor = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(vetor[0]);
            int horaFinal = int.Parse(vetor[1]);
            int duracao;

            if(horaFinal > horaInicial){
                duracao = horaFinal - horaInicial;
            } else {
                duracao = 24 - horaInicial + horaFinal;
            }
            Console.WriteLine("O JOGO DUROU "+duracao+" HORA(S)");
        }
    }
}
/*Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.*/