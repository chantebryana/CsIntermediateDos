using System;

namespace CsIntermediateDos
{
    class StopwatchHP
    {
        private DateTime _start;
        private DateTime _stop;
        private DateTime _default = new DateTime(0001, 01, 01);

        public DateTime Start { get; set; }
        public DateTime Stop { get; set; }
        public void ResetStopwatch ()
        {
            _start = _default;
            _stop = _default;
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
                    Console.WriteLine("Closing...\n");
                    i = 0;
                }
                else if (userInput == "start")
                {
                    if (_start == _default) {
                        _start = DateTime.Now;
                        Console.WriteLine("Stopwatch started at {0}\n", _start);
                    }
                    else
                    {
                        Console.WriteLine("You've already started the stopwatch; 'start' is an invalid selection.\n");
                    }
                }
                else if (userInput == "stop")
                {
                    if (_start != _default) {
                        _stop = DateTime.Now;
                        TimeSpan span = _stop.Subtract(_start);
                        Console.WriteLine("Stopwatch stopped at {0}", _stop);
                        Console.WriteLine("Total time elapsed:{0}\n", span);
                        ResetStopwatch();
                    }
                    else
                    {
                        Console.WriteLine("You haven't started the stopwatch yet; 'stop' is an invalid selection.\n");
                    }
                }
                else
                {
                    Console.WriteLine("'{0}' is an invalid selection. Try again.\n", userInput);
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
