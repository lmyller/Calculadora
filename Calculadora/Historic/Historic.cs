using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Calculator.Historic
{
    internal class Historic
    {
        List<string> listHistoric;

        public Historic()
        {
            listHistoric = new List<string>();
        }

        public void Add(string calculate)
        {
            listHistoric.Add(calculate);    
        }

        public string Get(int index)
        {
            return listHistoric.ElementAt(index);
        }

        public int Size()
        {
            return listHistoric.Count;
        }
    }
}
