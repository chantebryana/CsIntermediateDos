using System;

namespace CsIntermediateDos
{
    class StopwatchHP
    {
        private DateTime _starting;
        private DateTime _stopping;

        public DateTime Starting { get; set; }
        public DateTime Stopping { get; set; }

        public void LogTime(string word)
        {
            if (word == "start")
            {
                _starting = DateTime.Now;
                Console.WriteLine("Start: {0}", _starting);
            }
            else if (word == "stop")
            {
                _stopping = DateTime.Now;
                Console.WriteLine("Stop: {0}", _stopping);
            }
            else
            {
                Console.WriteLine("Please type 'start' or 'stop'.");
            }
        }

        public TimeSpan Calculate(DateTime starting, DateTime stopping)
        {
            return stopping.Subtract(starting);
        }

    }

    class Program
    {
        static void Main()
        {
            var stopwatch = new StopwatchHP();
            string userInput;
            Console.WriteLine("Type 'start' or 'stop': ");
            userInput = Console.ReadLine();
            userInput = userInput.ToLower();
            stopwatch.LogTime(userInput);
        }
    }
}
