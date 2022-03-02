using System;
using System.Collections;

namespace Tipos_Ref_e_Valor
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Cadastro");
            Console.WriteLine("x - Finalizar Cadastro");

            var opcaoUsuario = Console.ReadLine();
            
            List<Pessoa> pessoas = new List<Pessoa>();

            while(opcaoUsuario.ToUpper() != "X")
            {
                Pessoa pessoa = new Pessoa();
                var index = Pessoa.QtdPessoas;

                Console.WriteLine("Digite o Nome");
                pessoa.Nome = Console.ReadLine();

                Console.WriteLine("Digite a Idade");
                pessoa.Idade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o Documento");
                pessoa.Documento = Console.ReadLine();


                pessoas.Insert(index-1, pessoa); 

                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Cadastro");
                Console.WriteLine("x - Finalizar Cadastro");
                opcaoUsuario = Console.ReadLine();
            }
            foreach (var item in pessoas)
            {
                Console.WriteLine($"{item.Nome} - {item.Idade} - {item.Documento}");
            }
        }
    }
}