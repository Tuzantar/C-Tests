using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania.Zadania
{
    internal class BubbleSort
    {
        private List<Int64> _BSNumbers;
        public List<Int64> Get { get { return _BSNumbers; } }

        public BubbleSort(List<Int64> Numbers)
        {
            _BSNumbers = Numbers; 
        }
        public void Sort()
        {
            for (int i = 0; i < _BSNumbers.Count; i++)
            {
                for(int j = 1; j < _BSNumbers.Count; j++)
                {
                    if (_BSNumbers[j-1] > _BSNumbers[j])
                    {
                        _BSNumbers[j - 1] += _BSNumbers[j];
                        _BSNumbers[j] = _BSNumbers[j - 1] - _BSNumbers[j];
                        _BSNumbers[j-1] -= _BSNumbers[j];
                    }
                }
            }
        }
    }
}
