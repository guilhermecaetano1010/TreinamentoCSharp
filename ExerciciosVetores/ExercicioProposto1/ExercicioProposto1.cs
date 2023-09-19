using System;


namespace ExercicioProposto1
{
    public class ExercicioProposto1 {
        static void Main(string[] args) {
            
            int N;
            double[] vetor;

            N = int.Parse(Console.ReadLine());
            vetor = new double[N];

            for (int i = 0; i < N; i++) {
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            for (int i = 0; i < N; i++) {
                if () {
                    
                }
            }
        }
    }
}
/*Faça um programa que leia N números reais e armazene-os em um vetor. Em seguida, mostrar na tela o maior número
do vetor (supor não haver empates). Mostrar também a posição do maior elemento.*/