using System;

namespace Tipos_Ref_e_Valor
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Documento { get; set; }
        public static int QtdPessoas { get; set; }
        public Pessoa()
        {            
            QtdPessoas++;
        }
    }
}