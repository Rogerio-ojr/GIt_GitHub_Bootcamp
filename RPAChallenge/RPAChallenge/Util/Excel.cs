using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using ClosedXML.Excel;
using RPAChallenge.Browser;

namespace RPAChallenge.Util
{
    public class Excel
    {
        public XLWorkbook Wb { get; set; }
        public IXLWorksheet Ws { get; set; }    
        public Excel(string path, string sheet)
        {
            Wb = new XLWorkbook(path);
            Ws = Wb.Worksheets.First(w => w.Name == sheet);
        }
    }
}
