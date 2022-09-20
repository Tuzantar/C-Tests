using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania.Zadania
{
    internal class Zadanie2
    {
        private string _numbers;
        public string Result { get { return _numbers; } set { _numbers = value; } }
        public Zadanie2(string numbers)
        {
            _numbers = numbers;
        }
        public void Calculate()
        {
            string ToCheck = "";
            List<Int64> Checked = new List<Int64>();
            if(_numbers.Length > 0)
            {
                foreach (char i in _numbers)
                {
                    if (i.ToString() == " ")
                    {
                        Int64 number;
                        if (Int64.TryParse(ToCheck, out number))
                        {
                            Checked.Add(number);
                        }
                        ToCheck = "";
                    }
                    else
                    {
                        ToCheck += i.ToString();
                    }
                }
            }
            if (Checked.Count > 0)
            {
                Int64 biggest = Checked[0];
                Int64 lowest = Checked[0];
                //Buble
                foreach (Int64 number in Checked)
                {
                    if (number > biggest) { biggest = number; }
                    if (number < lowest) { lowest = number; }
                }
                _numbers = "Largest number is: " + biggest.ToString() + Environment.NewLine;
                _numbers += "Smallest number is: " + lowest.ToString() + Environment.NewLine;
                _numbers += "the remaining: " + Environment.NewLine;
                foreach (Int64 number in Checked)
                {
                    if (number != biggest && number != lowest) { _numbers += number.ToString() + Environment.NewLine; }
                }
            }
            else
            {
                _numbers = "No numbers found";
            }
        }
    }
}
