using System;

namespace CsIntermediateDos
{
    class StopwatchHP
    {
        private DateTime _start;

        //public StopwatchHP ()
        //{
        //}

        //public DateTime Start { get; set; }

        public void PressStart ()
        {
            if (_start != DateTime.MinValue)
            {
                throw new InvalidOperationException();
            }
            _start = DateTime.Now;
        }
        public TimeSpan PressStop ()
        {
            if (_start == DateTime.MinValue)
            {
                throw new InvalidOperationException();
            }
            TimeSpan span = DateTime.Now.Subtract(_start);
            ResetStart();
            return span;
        }

        private DateTime ResetStart ()
        {
            _start = DateTime.MinValue;
            return _start;
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
                    try
                    {
                        stopwatch.PressStart();
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine("You've already started the stopwatch; 'start' is an invalid selection.\n");
                    }
                }
                else if (userInput == "stop")
                {
                    try
                    {
                        var a = stopwatch.PressStop();
                        Console.WriteLine("Total time elapsed: {0}", a);
                    }
                    catch (InvalidOperationException e)
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
