using System;
using System.Globalization;

namespace ExerciciosProposto05 {
    class URI {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            int[] vet = new int[n];

            string[] s = Console.ReadLine().Split(' ');

            //For para ler todos os numero do vetor com a quantidade n
            for(int i = 0; i < n; i++) {
                vet[i] = int.Parse(s[i]);
            }

            int soma = 0;
            int count = 0;
            int media;

            //Calculo para saber se o numero do vetor na posicao i é par
            for(int i = 0; i < n; i++) {
                if(vet[i] % 2 == 0) {
                    soma = soma + vet[i];
                    count++;
                }
            }

            if(soma == 0) {
                Console.WriteLine("Não havia nenhum numero par.");
            } else {
                media = soma / count;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }

                
        }
    }
}


