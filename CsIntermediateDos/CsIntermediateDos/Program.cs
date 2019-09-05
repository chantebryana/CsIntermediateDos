using System;

namespace CsIntermediateDos
{
    class StopwatchHP
    {
        private DateTime _start;
        private DateTime _stop;

        public DateTime Start { get; set; }
        public DateTime Stop { get; set; }
        public DateTime Reset (DateTime timeStamp)
        {
            timeStamp = new DateTime(0001, 01, 01);
            return timeStamp;
        }
        public void RunStopwatch ()
        {
            int i = 1;
            var userInput = "";
            while (i == 1)
            {
                Console.WriteLine("Type 'start', 'stop', or 'close': ");
                userInput = Console.ReadLine();
                userInput = userInput.ToLower();
                if (userInput == "close")
                {
                    Console.WriteLine("Closing...");
                    i = 0;
                }
                else if (userInput == "start")      //add error logic if _start != 01/01/0001 and user types 'start'
                {
                    // if (_start == 01/01/0001)
                    _start = DateTime.Now;
                    Console.WriteLine("Stopwatch started at {0}", _start);
                    //else {error log, loop back to beginning of while loop}
                }
                else if (userInput == "stop")       //add error logic if _start == 01/01/0001 and user types 'stop'
                {
                    //if (_start != DateTime(0001,01,01)
                    _stop = DateTime.Now;
                    TimeSpan span = _stop.Subtract(_start);
                    Console.WriteLine("Stopwatch stopped at {0}", _stop);
                    Console.WriteLine("Total time elapsed:{0}", span);
                    _start = Reset(_start);
                    _start = Reset(_stop);
                    // else {error log, loop back to beginning of while loop}
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            var stopwatch = new StopwatchHP();
            stopwatch.RunStopwatch();
        }
    }
}
