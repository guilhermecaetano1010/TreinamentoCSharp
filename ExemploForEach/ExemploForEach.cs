using System;


namespace ExemploForEach
{
    public class ExemploForEach {
        static void Main(string[] args) {
            
            int N;
            N = int.Parse(Console.ReadLine());
            string[] vet = new string[N];

            for (int i = 0; i < N; i++) {
                vet[i] = Console.ReadLine();
            }

            Console.WriteLine("Nomes lidos:");
            foreach (string x in vet) {
                Console.WriteLine(x);
            }
        }
    }
}   
// foreach




// using System;


// namespace ExemploForEach
// {
//     public class ExemploForEach {
//         static void Main(string[] args) {
            
//             int N;
//             N = int.Parse(Console.ReadLine());
//             string[] vet = new string[N];

//             for (int i = 0; i < N; i++) {
//                 vet[i] = Console.ReadLine();
//             }

//             Console.WriteLine("Nomes lidos:");
//             for (int i = 0; i < N; i++) {
//                 Console.WriteLine(vet[i]);
//             }
//         }
//     }
// }               FOR normal

      

