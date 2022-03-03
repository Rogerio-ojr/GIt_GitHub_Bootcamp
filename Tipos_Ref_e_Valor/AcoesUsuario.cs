using System;

namespace Tipos_Ref_e_Valor
{
    public class AcoesUsuario
    {
        public static Pessoa Cadastro()
        {
            Pessoa pessoa = new Pessoa();
            List<Pessoa> pessoas = new List<Pessoa>();

            Console.WriteLine("Digite o Nome");
            pessoa.Nome = Console.ReadLine();

            Console.WriteLine("Digite a Idade");
            pessoa.Idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o Documento");
            pessoa.Documento = Console.ReadLine();

            return pessoa;
        }

        public static string ProcurarIdade(List<Pessoa> pessoa, string nome)
        {            
            foreach (var item in pessoa)
            {
                if(item.Nome.Trim().Equals(nome.Trim()))
                {
                    return item.Idade.ToString();
                }
            }
            return null;
        }

        public static string ProcurarDocumento(List<Pessoa> pessoa, string nome)
        {
            foreach (var item in pessoa)
            {
                if(item.Nome.Trim().Equals(nome.Trim()))
                {
                    return item.Documento.ToString();
                }
            }
            return null;
        }        
    }
}