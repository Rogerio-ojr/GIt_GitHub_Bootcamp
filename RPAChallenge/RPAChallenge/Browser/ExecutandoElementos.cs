using System;
using System.Collections.Generic;
using System.Text;

namespace RPAChallenge.Browser
{
    public class ExecutandoElementos
    {
        public string FirstName { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public string RoleInCompany { get; set; }
        public string Adress { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        Elementos elementos = new Elementos();
        public void Download()
        {
            elementos.Url("https://www.rpachallenge.com/");
            elementos.Download();
        }
        public void Acao()
        {
            elementos.Andres(Adress);
            elementos.CompanyName(CompanyName);
            elementos.FirstName(FirstName);
            elementos.LabelEmail(Email);
            elementos.LabelName(LastName);
            elementos.LabelPhone(PhoneNumber);
            elementos.LabelRole(RoleInCompany);
        }

        public void Start()
        {
            elementos.Start();
        }

        public void Reset()
        {
            elementos.Reset();
        }

        public void Submit()
        {
            elementos.Submit();
        }

        public void Congrulations()
        {
            var texto = elementos.Congrulations();
            Console.WriteLine(texto);

        }
    }
}
