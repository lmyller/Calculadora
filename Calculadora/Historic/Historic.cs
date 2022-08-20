using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Historic
{
    internal class Historic
    {
        List<string> listHistoric;

        public Historic()
        {
            listHistoric = new List<string>();
        }

        public void AddCalculate(string calculate)
        {
            listHistoric.Add(calculate);    
        }

        public string GetCalculate(int index)
        {
            return listHistoric.ElementAt(index);
        }

        public int SizeHistoric()
        {
            return listHistoric.Count;
        }
    }
}
