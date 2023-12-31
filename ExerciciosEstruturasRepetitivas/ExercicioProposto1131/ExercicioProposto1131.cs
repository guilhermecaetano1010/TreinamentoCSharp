using System;


namespace ExercicioProposto1131
{
    public class ExercicioProposto1131
    {
        public static void Main(string[] args)
        {
            int vitoriasInter = 0;
            int vitoriasGremio = 0;
            int empates = 0;
            int novoGrenal = 1;

            while (novoGrenal == 1) {
                string[] valores = Console.ReadLine().Split(' ');
                int golsInter = int.Parse(valores[0]);
                int golsGremio = int.Parse(valores[1]);

                if (golsInter > golsGremio) {
                    vitoriasInter = vitoriasInter + 1;

                } else if (golsGremio > golsInter) {
                    vitoriasGremio = vitoriasGremio + 1;
                }
                else{
                    empates = empates + 1;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoGrenal = int.Parse(Console.ReadLine());
            }

            int total = vitoriasGremio + vitoriasInter + empates;

            Console.WriteLine(total + " grenais");
            Console.WriteLine("Inter:" + vitoriasInter);
            Console.WriteLine("Gremio:" + vitoriasGremio);
            Console.WriteLine("Empates:" + empates);

            if (vitoriasInter > vitoriasGremio) {
                Console.WriteLine("Inter venceu mais");
            }
            else if (vitoriasGremio > vitoriasInter) {
                Console.WriteLine("Gremio venceu mais");
            }
            else {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}

/*A Federação Gaúcha de Futebol contratou você para escrever um programa para fazer uma estatística do resultado de vários GRENAIS. Escreva um programa para ler o número de gols marcados pelo Inter e pelo Grêmio em um GRENAL. Logo após escrever a mensagem "Novo grenal (1-sim 2-nao)" e solicitar uma resposta. Se a resposta for 1, o algoritmo deve ser executado novamente solicitando o número de gols marcados pelos times em uma nova partida, caso contrário deve ser encerrado imprimindo:

- Quantos GRENAIS fizeram parte da estatística.
- O número de vitórias do Inter.
- O número de vitórias do Grêmio.
- O número de Empates.
- Uma mensagem indicando qual o time que venceu o maior número de GRENAIS (ou "Nao houve vencedor", caso termine empatado).*/
