using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania.Zadania
{
    internal class DecimalCheck
    {
        private string _number;
        public string Get { get { return _number; } }
        public string Set { set { _number = value; } }
        public DecimalCheck(string number)
        {
            _number = number;
        }
        public void Calculate()
        {
            int point = 0;
            string NewNumber ="";
            int NewNum;
            char c;
            for(int i = 0; i < _number.Length; i++)
            {
                c=_number[i];
                if (c == '-' && i == 0)
                {
                    NewNumber += c;
                }
                if ((c == ',' || c == '.') && point == 0 && i > 0)
                {
                    point += 1;
                    NewNumber += ",";
                }
                if (int.TryParse(c.ToString(), out NewNum))
                {
                    NewNumber += NewNum.ToString();
                }
            }
            _number = NewNumber;
        }
    }
}
