using System;

namespace Referencias
{
    class program
    {
        static void AlterandoNome(string [] nomes, string nome, string nomeNovo)
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                if(nomes[i] == nome)
                {
                    nomes[i] = nomeNovo;
                }
            }
        }

        static void Main()
        {
            var nomes = new string[] { "José", "Maria", "Ricardo", "Alice", "Pedro" };

            Console.WriteLine($@"A Lista atual de Pessoas e: 
            {string.Join(", \n", nomes)}");

            Console.WriteLine("Digite o Nome a ser substituido:");
            Console.WriteLine("--------------------------------");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite o novo Nome:");
            Console.WriteLine("-------------------");
            var nomeNovo = Console.ReadLine();

            AlterandoNome(nomes, nome, nomeNovo);
            
            Console.WriteLine($@"A Lista atual de Pessoas e: 
            {string.Join(", \n", nomes)}");


        }
    }
}