using System;

namespace Pensionato
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudantes[] vet = new Estudantes[10];

            Console.Write("Quantos quartos serao alugados: ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vet[quarto] = new Estudantes(nome, email);
            }

            Console.WriteLine();

            Console.WriteLine("Quartos Ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine(i+": "+ vet[i]);
                }
            }

        }
    }
}
