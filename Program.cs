using System;

namespace ConsoleApp1Aula1jogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resp = "s";
            int contador = 0;
            while (resp == "s") 
            {
                int sorteio = new Random().Next(1, 5);
                contador++;

                Console.WriteLine("Tente descobrir o número que eu pensei entre 1 a 5: ");
                int chute = int.Parse(Console.ReadLine());

                if (chute <1 || chute > 5)
                {
                    Console.WriteLine("Número invalido, escolha novamente!");
                    resp = "s";
                    Console.WriteLine();
                }

                else if (sorteio == chute)
                {
                    Console.WriteLine("Pensei em: {0}", sorteio);
                    Console.WriteLine("Parabéns");
                    resp = "n";
                    Console.WriteLine("---------------------------------------------------");
                }
                else
                {
                    Console.WriteLine($"Não foi desta vez, pensei em {sorteio}");
                    Console.WriteLine("Errou");
                    Console.WriteLine("Tente novamente: (s/n)?");
                    resp = Console.ReadLine();
                    Console.WriteLine("---------------------------------------------------");
                }     
            }
            Console.WriteLine();
            Console.WriteLine($"Você tentou:{contador} vezes!!");
        }
    }
}
