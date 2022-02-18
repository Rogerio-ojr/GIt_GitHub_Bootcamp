using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using ClosedXML.Excel;

namespace RPAChallenge.Util
{
    public class Excel
    {
        public XLWorkbook Wb { get; set; }

        public XLWorkbook AbrindoArquivo(string path)
        {
            Wb = new XLWorkbook(path);    
            return Wb;  
        }

        public Excel()
        {

        }

        public Excel(string path)
        {
            Wb = new XLWorkbook(path);
        }
    }
}
