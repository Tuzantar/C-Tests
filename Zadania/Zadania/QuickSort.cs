using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania.Zadania
{
    internal class QuickSort
    {
        private List<Int64> _QSNumbers;
        public List<Int64> Get { get { return _QSNumbers; } }

        public QuickSort(List<Int64> Numbers)
        {
            _QSNumbers = Numbers;
        }
        public void Sort()
        {
            List<Int64> Lista = new List<Int64>(_QSNumbers);
            _QSNumbers = QSort(Lista);
        }
        private static List<Int64> QSort(List<Int64> Lista)
        {
            if(Lista.Count <= 1)
            {
                return Lista;
            }
            List<Int64> outNumber = new List<Int64>(); 
            List<Int64> Samller = new List<Int64>(); 
            List<Int64> Bigger = new List<Int64>();
            Int64 pivot = Lista[Lista.Count / 2];
            Lista.RemoveAt(Lista.Count / 2);
            foreach (Int64 obiekt in Lista) 
            { 
                if (obiekt < pivot) 
                {
                    Samller.Add(obiekt); 
                } 
                else 
                {
                    Bigger.Add(obiekt); 
                } 
            }
            Samller = QSort(Samller);
            Bigger = QSort(Bigger);
            outNumber.AddRange(Samller);
            outNumber.Add(pivot);
            outNumber.AddRange(Bigger);
            return outNumber;
        }

    }
}
