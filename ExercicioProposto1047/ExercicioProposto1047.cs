using System;


namespace ExercicioProposto1047
{
    public class ExercicioProposto1047
    {
        static void Main(string[] args){
            string[] vetor = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(vetor[0]);
            int minutoInicial = int.Parse(vetor[1]);
            int horaFinal = int.Parse(vetor[2]);
            int minutoFinal = int.Parse(vetor[3]);

            int instanteInicial = horaInicial * 60 + minutoInicial;
            int instanteFinal = horaFinal * 60 + minutoFinal;

            int duracao;
            if (instanteInicial < instanteFinal) {
                duracao = instanteFinal - instanteInicial;
            }
            else {
                duracao = (24 * 60 - instanteInicial) + instanteFinal;
            }

            int duracaoHoras = duracao / 60;
            int duracaoMinutos = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");

        }
    }
}
/*Leia a hora inicial, minuto inicial, hora final e minuto final de um jogo. A seguir calcule a duração do jogo.

Obs: O jogo tem duração mínima de um (1) minuto e duração máxima de 24 horas.*/