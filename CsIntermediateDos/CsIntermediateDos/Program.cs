using System;

namespace CsIntermediateDos
{
    class StopwatchHP
    {
        private DateTime _start;
        private DateTime _stop;

        public DateTime Start { get; set; }
        public DateTime Stop { get; set; }

        public DateTime PressStart ()
        {
            _start = DateTime.Now;
            return _start;
        }
        public DateTime PressStop ()
        {
            _stop = DateTime.Now;
            return _stop;
        }

        public DateTime ResetStart ()
        {
            _start = new DateTime(0001, 01, 01);
            return _start;
        }

        public DateTime ResetStop ()
        {
            _stop = new DateTime(0001, 01, 01);
            return _stop;
        }
    }

    class Program
    {
        static void Main()
        {
            var stopwatch = new StopwatchHP();
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
                    if (stopwatch.Start == new DateTime(0001,01,01))
                    {
                        stopwatch.Start = stopwatch.PressStart();
                        Console.WriteLine("Stopwatch started at {0}\n", stopwatch.Start);
                    }
                    else
                    {
                        Console.WriteLine("You've already started the stopwatch; 'start' is an invalid selection.\n");
                    }
                }
                else if (userInput == "stop")
                {
                    if (stopwatch.Start != new DateTime(0001,01,01))
                    {
                        stopwatch.Stop = stopwatch.PressStop();
                        TimeSpan span = stopwatch.Stop.Subtract(stopwatch.Start);
                        Console.WriteLine("Stopwatch stopped at {0}", stopwatch.Stop);
                        Console.WriteLine("Total time elapsed:{0}\n", span);
                        stopwatch.Start = stopwatch.ResetStart();
                        stopwatch.Stop = stopwatch.ResetStop();
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
}
