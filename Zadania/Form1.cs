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
            txtT3_2.Text = "";
            txtT3_wynik.Text = "";
            int Number;
            Random r = new Random();
            int.TryParse(txtT3_1.Text, out Number);
            var StopWatch = new StopWatch();
            for (int i = 0; i < Number; i++)
            {
                _MyNumbers.Add(r.Next(100000,999999));
            }
            StopWatch.Stop();
            txtT3_2.Text = "Generated in: " + StopWatch.Get + txtT3_2.Text;
            if (_MyNumbers.Count < 5000)
            {
                StopWatch.Start();
                for (int i = 0; i < _MyNumbers.Count; i++)
                {
                    txtT3_2.Text += _MyNumbers[i].ToString() + Environment.NewLine;
                }
                StopWatch.Stop();
                txtT3_2.Text = "filled in: " + StopWatch.Get + txtT3_2.Text;
            }
        }

        private void btnTS_Click(object sender, EventArgs e)
        {
            txtT3_wynik.Text += "Test sort (with 2 stacks)" + Environment.NewLine;
            List<Int64> SortNumbers = new List<Int64>(_MyNumbers);
            var StopWatch = new StopWatch();
            var TestSort = new TestSort(SortNumbers);
            TestSort.Sort();
            StopWatch.Stop();
            txtT3_wynik.Text += "Generated in: " + StopWatch.Get;
            SortNumbers = TestSort.Get;
            if (SortNumbers.Count < 5000)
            {
                StopWatch.Start();
                for (int i = 0; i < SortNumbers.Count; i++)
                {
                    txtT3_wynik.Text += SortNumbers[i].ToString() + Environment.NewLine;
                }
                StopWatch.Stop();
                txtT3_wynik.Text += "Test sort, " + StopWatch.Get;
            }
        }

        private void bttn_bb_Click(object sender, EventArgs e)
        {
            txtT3_wynik.Text += "Bubble sort" + Environment.NewLine;
            List<Int64> SortNumbers = new List<Int64>(_MyNumbers);
            var StopWatch = new StopWatch();
            var BubbleSort = new BubbleSort(SortNumbers);
            BubbleSort.Sort();
            StopWatch.Stop();
            txtT3_wynik.Text += "Generated in: " + StopWatch.Get;
            SortNumbers = BubbleSort.Get;
            if (SortNumbers.Count < 5000)
            {
                StopWatch.Start();
                for (int i = 0; i < SortNumbers.Count; i++)
                {
                    txtT3_wynik.Text += SortNumbers[i].ToString() + Environment.NewLine;
                }
                StopWatch.Stop();
                txtT3_wynik.Text += "Bubble sort, " + StopWatch.Get;
            }
        }

        private void btn_T3_QS_Click(object sender, EventArgs e)
        {
            txtT3_wynik.Text += "Quick sort" + Environment.NewLine;
            List<Int64> SortNumbers = new List<Int64>(_MyNumbers);
            var StopWatch = new StopWatch();
            var QuickSort = new QuickSort(SortNumbers);
            QuickSort.Sort();
            StopWatch.Stop();
            txtT3_wynik.Text += "Generated in: " + StopWatch.Get;
            SortNumbers = QuickSort.Get;
            if (SortNumbers.Count < 5000)
            {
                StopWatch.Start();
                for (int i = 0; i < SortNumbers.Count; i++)
                {
                    txtT3_wynik.Text += SortNumbers[i].ToString() + Environment.NewLine;
                }
                StopWatch.Stop();
                txtT3_wynik.Text += "Quick sort, " + StopWatch.Get;
            }
        }
    }
}