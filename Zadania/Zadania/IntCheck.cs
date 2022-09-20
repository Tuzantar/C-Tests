using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania.Zadania
{
    internal class IntCheck
    {
        private string _number;
        private int _int_number;
        public int Get { get { return _int_number; } }
        public string Set { set { _number = value; } }
        public IntCheck(string number)
        {
            _number = number;
        }
        public void Calculate()
        {
            string NewNumber = "";
            int NewNum;
            char c;
            for (int i = 0; i < _number.Length; i++)
            {
                c = _number[i];
                if (c == '-' && i == 0)
                {
                    NewNumber += c;
                }
                if (int.TryParse(c.ToString(), out NewNum))
                {
                    NewNumber += NewNum.ToString();
                }
            }
            int.TryParse(NewNumber, out NewNum);
            _int_number = NewNum;
        }
    }
}
