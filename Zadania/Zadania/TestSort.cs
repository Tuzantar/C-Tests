using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania.Zadania
{
    internal class TestSort
    {
        private List<Int64> _TSNumbers;
        public List<Int64> Get { get { return _TSNumbers; } }

        public TestSort(List<Int64> Numbers)
        {
            _TSNumbers = Numbers;
        }
        public void Sort()
        {
            int ListCount = _TSNumbers.Count;
            List<Int64> Numbers = new List<Int64>();
            Int64 Number;
            int Cur;
            for (int i = 0; i < ListCount; i++)
            {
                Number = _TSNumbers[0];
                Cur = 0;
                for (int j = 0; j < _TSNumbers.Count; j++)
                {
                    if (Number > _TSNumbers[j])
                    {
                        Number = _TSNumbers[j];
                        Cur = j;
                    }
                }
                Numbers.Add(Number);
                _TSNumbers.RemoveAt(Cur);
            }
            _TSNumbers = Numbers;
        }
    }
}
