using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Zadania.Zadania
{
    internal class StopWatch
    {
        private string _time;
        private Stopwatch timer;
        public String Get { get { return _time; } }

        public StopWatch()
        {
            Start();
        }
        public void Start()
        {
            timer = new Stopwatch();
            timer.Start();
        }
        public void Stop()
        {
            timer.Stop();

            TimeSpan timeTaken = timer.Elapsed;
            _time = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff") + Environment.NewLine;
        }
    }
}
