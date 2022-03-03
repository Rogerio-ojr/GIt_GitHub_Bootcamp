using System;

namespace Tipos_Ref_e_Valor
{
    public class OpcaoUsuario
    {
        public static string SelecionarOpcaoUsuario()
        {
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Cadastro");            
            Console.WriteLine("2 - Procurar Documento");
            Console.WriteLine("3 - Procurar Idade");
            Console.WriteLine("x - Finalizar Cadastro");
            var opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }

        public static string NomeQueDeveSerConsultado()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Qual o Nome da Pessoa, que deseja Consultar?");
            Console.WriteLine("----------------------------------------------------");
            var nome = Console.ReadLine();
            return nome;            
        }
    }
}