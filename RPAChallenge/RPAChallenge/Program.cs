using RPAChallenge.Browser;
using RPAChallenge.Util;
using System;


namespace RPAChallenge
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
            Thread.Sleep(5000);

            Excel excel = new Excel();
            var wb = excel.AbrindoArquivo(@"C:\Users\Rogerio\Downloads\Challenge.xlsx");
            var ws = wb.Worksheets.First(w => w.Name == "Sheet1");

            elementos.Start();

            int row = 2;
            do
            {
                elementos.Adress = ws.Cell($"E{row}").Value.ToString();
                elementos.Email = ws.Cell($"F{row}").Value.ToString();
                elementos.CompanyName = ws.Cell($"C{row}").Value.ToString();
                elementos.FirstName = ws.Cell($"A{row}").Value.ToString();
                elementos.LastName = ws.Cell($"B{row}").Value.ToString();
                elementos.PhoneNumber = ws.Cell($"G{row}").Value.ToString();
                elementos.RoleInCompany = ws.Cell($"D{row}").Value.ToString();
                elementos.Acao();
                elementos.Submit();
                row++;
            } while (ws.Cell($"a{row}").Value.ToString() != "");

            elementos.Congrulations();

            elementos.Reset();
        }
    }
}
