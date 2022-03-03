using System;
using System.Collections;

namespace Tipos_Ref_e_Valor
{
    class program
    {
        static void Main()
        {
            var opcaoSelecionadaPeloUsusario = OpcaoUsuario.SelecionarOpcaoUsuario();

            List<Pessoa> pessoas = new List<Pessoa>();
            while(opcaoSelecionadaPeloUsusario.ToUpper() != "X")
            {
                switch(opcaoSelecionadaPeloUsusario)
                {
                    case "1":
                        var cadastroPessoa = AcoesUsuario.Cadastro();
                        var indice = Pessoa.QtdPessoas;                     
                        pessoas.Insert(indice-1, cadastroPessoa);
                        break;
                    case "2":
                        var nome = OpcaoUsuario.NomeQueDeveSerConsultado();
                        var DocumentoConsultada = AcoesUsuario.ProcurarDocumento(pessoas, nome);
                        if(DocumentoConsultada is null)
                        {
                            Console.WriteLine($"O Nome Digitado não consta na base de Pessoas:");
                        }else
                        {
                            Console.WriteLine($"O Documento de {nome} e: {DocumentoConsultada}");
                        }
                        break;                        
                    case "3":
                        nome = OpcaoUsuario.NomeQueDeveSerConsultado();
                        var IdadeConsultada = AcoesUsuario.ProcurarIdade(pessoas, nome);
                        if(IdadeConsultada is null)
                        {
                            Console.WriteLine($"O Nome Digitado não consta na base de Pessoas:");
                        }else
                        {
                            Console.WriteLine($"A Idade de {nome} e: {IdadeConsultada}");
                        }                        
                        break;
                    default:
                        throw new ArgumentException("Digite um valor Valido no Menu de Opções:");
                        break;
                }
                opcaoSelecionadaPeloUsusario = OpcaoUsuario.SelecionarOpcaoUsuario();
            }
        }
    }
}