using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania.Zadania
{
    internal class RStringBuilder
    {
        private List<Int64> _SBNumbers;
        private string _SBNumbersString;
        public string Get { get { return _SBNumbersString; } }

        public RStringBuilder(List<Int64> Numbers)
        {
            _SBNumbers = Numbers;
        }
        public void TStr()
        {
            var stringBuilder = new StringBuilder();
            for (int i = 0; i < _SBNumbers.Count; i++)
            {
                stringBuilder.Append(_SBNumbers[i]);
                stringBuilder.Append(Environment.NewLine);
            }
            _SBNumbersString = stringBuilder.ToString();
        }
    }
}
