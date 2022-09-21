using System.Collections.Generic;
using Zadania.Zadania;

namespace Zadania
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Int64> _MyNumbers = new List<Int64>();

        private void btn_Task1_Click(object sender, EventArgs e)
        {
            decimal degree;
            if(decimal.TryParse(txt_Task1a.Text, out degree))
            {
                Przelicz();
            }
            else 
            {
                MessageBox.Show("B³êdna wartoœæ!");
            }
        }
        private void Przelicz()
        {

            decimal degree;
            decimal.TryParse(txt_Task1a.Text, out degree);
            var CalculateDegree = new CalculateDegree(degree);
            CalculateDegree.Calculate();
            degree = CalculateDegree.Fahr;
            txt_Task1b.Text = Convert.ToString(degree);
        }

        private void txt_T2a_TextChanged(object sender, EventArgs e)
        {

            var Zadanie2 = new Zadanie2(txt_T2a.Text);
            Zadanie2.Calculate();
            txt_T2b.Text = Zadanie2.Result;
        }

        private void txt_Task1a_TextChanged(object sender, EventArgs e)
        {

            int pos = txt_Task1a.SelectionStart;
            var DecimalCheck = new DecimalCheck(txt_Task1a.Text);
            DecimalCheck.Calculate();
            txt_Task1a.Text = DecimalCheck.Get;
            txt_Task1a.SelectionStart = pos;
        }

        private void txtT3_1_TextChanged(object sender, EventArgs e)
        {
            int pos = txtT3_1.SelectionStart;
            var IntCheck = new IntCheck(txtT3_1.Text);
            IntCheck.Calculate();
            txtT3_1.Text = IntCheck.Get.ToString();
            txtT3_1.SelectionStart = pos;
        }

        private void btnT3_Click(object sender, EventArgs e)
        {
            _MyNumbers.Clear();
            int Number;
            Random r = new Random();
            int.TryParse(txtT3_1.Text, out Number);
            var StopWatch = new StopWatch();
            for (int i = 0; i < Number; i++)
            {
                _MyNumbers.Add(r.Next(100000,999999));
            }
            StopWatch.Stop();
            string opis = "Generated in: " + StopWatch.Get + Environment.NewLine;
            AddTextToTextboxWithStringBuilder(_MyNumbers, txtT3_2, opis);
    }

        private void btnTS_Click(object sender, EventArgs e)
        {
            string opis = "Test sort (with 2 stacks)" + Environment.NewLine;
            List<Int64> SortNumbers = new List<Int64>(_MyNumbers);
            var StopWatch = new StopWatch();
            var TestSort = new TestSort(SortNumbers);
            TestSort.Sort();
            StopWatch.Stop();
            opis += "Generated in: " + StopWatch.Get;
            SortNumbers = TestSort.Get;
            AddTextToTextboxWithStringBuilder(SortNumbers, txtT3_wynik, opis);
        }

        private void bttn_bb_Click(object sender, EventArgs e)
        {
            string opis = "Bubble sort" + Environment.NewLine;
            List<Int64> SortNumbers = new List<Int64>(_MyNumbers);
            var StopWatch = new StopWatch();
            var BubbleSort = new BubbleSort(SortNumbers);
            BubbleSort.Sort();
            StopWatch.Stop();
            opis += "Generated in: " + StopWatch.Get;
            SortNumbers = BubbleSort.Get;
            AddTextToTextboxWithStringBuilder(SortNumbers, txtT3_wynik, opis);
        }

        private void btn_T3_QS_Click(object sender, EventArgs e)
        {
            string opis = "Quick sort" + Environment.NewLine;
            List<Int64> SortNumbers = new List<Int64>(_MyNumbers);
            var StopWatch = new StopWatch();
            var QuickSort = new QuickSort(SortNumbers);
            QuickSort.Sort();
            StopWatch.Stop();
            opis += "Generated in: " + StopWatch.Get;
            SortNumbers = QuickSort.Get;
            AddTextToTextboxWithStringBuilder(SortNumbers, txtT3_wynik, opis);
        }
        private void AddTextToTextboxWithStringBuilder(List<Int64> list, TextBox txbx, string opis)
        {
            var StopWatch = new StopWatch();
            var RStringBuilder = new RStringBuilder(list);
            RStringBuilder.TStr();
            string Rtext = RStringBuilder.Get;
            txbx.Text = Rtext;
            StopWatch.Stop();
            txbx.Text = opis + "filled in textbox with stringBuilder: " + StopWatch.Get + Environment.NewLine + txbx.Text;
        }
    }
}