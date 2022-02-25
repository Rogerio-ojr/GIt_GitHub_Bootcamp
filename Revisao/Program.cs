using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var tamanhoArray = alunos.Length;               
            int indiceAluno = 0;
            string opcaoUsuario = DadosConsole.ObterDadosAluno();

            while(opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1": 
                        if(indiceAluno < alunos.Length)
                        {
                            Aluno aluno = new Aluno(); //Instacia de Alunos                                            
                            Console.WriteLine("Gentileza informar o Nome Completo do Aluno");
                            aluno.Nome = Console.ReadLine();
                            Console.WriteLine("Gentileza informar a nota do aluno");                        
                            if(decimal.TryParse(Console.ReadLine(), out decimal a))
                            {
                                aluno.Nota = a;
                            }else
                            {
                                throw new ArgumentException("Favor informar a nota do aluno no sistema decimal.");
                            }
                            alunos[indiceAluno] = aluno;
                            indiceAluno++;
                        }else
                        {
                            Console.WriteLine("O numero Maximo de alunos já foi inserido no sistema");
                        }
                        break;
                    case "2":
                        Console.WriteLine("---------------------------------------------------------");
                        Console.WriteLine($"Segue a lista dos alunos e suas respectivas notas:\n");
                        Console.WriteLine("---------------------------------------------------------");
                        foreach(var alu in alunos)
                        {
                            if(alu.Nome is null)
                            {
                                
                            }else
                            {
                                Console.WriteLine($"{alu.Nome} - {alu.Nota}");
                            }
                        }
                        break;
                    case "3":
                        Decimal somaNota = 0;  
                        foreach(var alu in alunos)
                        {
                            if(alu.Nome is null)
                            {
                                
                            }else
                            {                                                              
                                somaNota += Convert.ToDecimal(alu.Nota);
                            }
                        }
                        try
                        {
                            Console.WriteLine($"A Media dos alunos e {Math.Round(somaNota/indiceAluno,2)}");
                        }catch
                        {
                            throw new DivideByZeroException();
                        }                                                
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();                    
                }
                opcaoUsuario = DadosConsole.ObterDadosAluno();
            }

        }
    }
}
