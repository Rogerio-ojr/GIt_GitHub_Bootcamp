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
            Excel excel = new Excel(@"C:\Users\Rogerio\Downloads\Challenge.xlsx", "Sheet1");          
            int row = 2;
            do
            {
                elementos.DadoASerPreenchido(excel.Ws.Cell($"E{row}").Value.ToString(),excel.Ws.Cell($"F{row}").Value.ToString(),excel.Ws.Cell($"C{row}").Value.ToString(),excel.Ws.Cell($"A{row}").Value.ToString(),
                                             excel.Ws.Cell($"B{row}").Value.ToString(),excel.Ws.Cell($"G{row}").Value.ToString(),excel.Ws.Cell($"D{row}").Value.ToString());
                elementos.Start();
                elementos.Acao();
                elementos.Submit();
                row++;
            } while (excel.Ws.Cell($"a{row}").Value.ToString() != "");
            elementos.Congrulations();
            elementos.Reset();
        }
    }
}
