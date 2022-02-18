using RPAChalenge.Browser;
using System;


namespace RPAChalenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var todosArquivos = Directory.GetFiles(@"C:\Users\Rogerio\Downloads");
            foreach (string arquivo in todosArquivos)
            {
                if (arquivo.Contains("challenge"))
                {
                    File.Delete(arquivo);
                }
            }

            ExecutandoElementos elementos = new ExecutandoElementos();

            elementos.Download();

            Workbook wb = new Workbook(@"C:\Users\Rogerio\Downloads\Challenge.xlsx");
            Worksheet ws = new Worksheet();


            elementos.Start();
            int row = 2;

            do
            {
                elementos.Adress = ws[$"E{row}"].ToString();
                elementos.Email = ws[$"F{row}"].ToString();
                elementos.CompanyName = ws[$"C{row}"].ToString();
                elementos.FirstName = ws[$"A{row}"].ToString();
                elementos.LastName = ws[$"B{row}"].ToString();
                elementos.PhoneNumber = ws[$"G{row}"].ToString();
                elementos.RoleInCompany = ws[$"D{row}"].ToString();
                elementos.Acao();
                elementos.Submit();
                row++;
            } while (ws[$"a{row}"].ToString() != "");

            elementos.Congrulations();
        }
    }
}
