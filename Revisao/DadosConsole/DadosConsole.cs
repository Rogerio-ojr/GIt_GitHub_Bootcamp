using System;

namespace Revisao
{
    public class DadosConsole
    {
        public static string ObterDadosAluno()
        {
            Console.WriteLine("Informe a Opcao Desejada");
            Console.WriteLine();
            Console.WriteLine("1 - Inserir Novo Aluno");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Calcular a Media dos Alunos");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            var opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}