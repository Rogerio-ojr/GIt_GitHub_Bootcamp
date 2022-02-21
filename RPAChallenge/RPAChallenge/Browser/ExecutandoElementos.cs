using System;
using System.Collections.Generic;
using System.Text;

namespace RPAChallenge.Browser
{
    public class ExecutandoElementos
    {
        public string FirstName { get; private set; }
        public string CompanyName { get; private set; }
        public string PhoneNumber { get; private set; }
        public string RoleInCompany { get; private set; }
        public string Adress { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }

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

        public void DadoASerPreenchido(string adress, string email, string companyName, string firstName, string lastName, string phoneNumber, string roleInCompany)
        {
            Adress = adress;
            Email = email;
            CompanyName = companyName;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            RoleInCompany = roleInCompany;
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
