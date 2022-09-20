using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania.Zadania
{
    internal class CalculateDegree
    {

        private decimal _degrees;
        public decimal Fahr { get { return _degrees; } set { _degrees = value; } }
        public CalculateDegree(decimal degree)
        {
            _degrees = degree;
        }
        public void Calculate()
        {
            _degrees = decimal.Multiply(1.8M, _degrees);
            _degrees = decimal.Add(32.0M, _degrees);
        }
    }
}
