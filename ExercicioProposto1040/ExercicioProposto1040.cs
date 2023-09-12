using System;
using System.Globalization;

namespace ExercicioProposto1040
{
    public class ExercicioProposto1040
    {
        static void Main(string[] args){
            string[] vetor = Console.ReadLine().Split(' ');

            double N1 = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            double N2 = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            double N3 = double.Parse(vetor[2], CultureInfo.InvariantCulture);
            double N4 = double.Parse(vetor[3], CultureInfo.InvariantCulture);

            double media;

            media = (double)(N1*2+N2*3+N3*4+N4*1)/10;
            
            Console.WriteLine("Media: "+media.ToString("F1", CultureInfo.InvariantCulture));
            if(media>=7.0){
                Console.WriteLine("Aluno aprovado.");
            }else if(media<5.0){
                Console.WriteLine("Aluno reprovado.");
            }else if(5.0<= media && media<=6.9){
                Console.WriteLine("Aluno em exame.");
                double notaExame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: "+notaExame.ToString("F1", CultureInfo.InvariantCulture));
                media = (media+notaExame)/2;
                if(media >= 5.0){
                    Console.WriteLine("Aluno aprovado.");  
                    Console.WriteLine("Media final: "+media.ToString("F1", CultureInfo.InvariantCulture));  
                }
                else{
                    Console.WriteLine("Aluno reprovado.");  
                    Console.WriteLine("Media final: "+media.ToString("F1", CultureInfo.InvariantCulture)); 
                }
            }
        }
    }
}