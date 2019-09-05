using System;

namespace CsIntermediateDos
{
    class StopwatchHP
    {
        private DateTime _starting;
        private DateTime _stopping;

        public DateTime Starting { get; set; }
        public DateTime Stopping { get; set; }
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
                Console.WriteLine("Type 'start', 'stop', or 'end': ");
                userInput = Console.ReadLine();
                userInput = userInput.ToLower();
                if (userInput == "end")
                {
                    i = 0;
                }
                else if (userInput == "start")
                {
                    stopwatch.Starting = DateTime.Now;
                }
                else if (userInput == "stop")
                {
                    stopwatch.Stopping = DateTime.Now;
                    TimeSpan span = stopwatch.Stopping.Subtract(stopwatch.Starting);
                    Console.WriteLine("Total time elapsed:{0}", span);
                    stopwatch.Starting = new DateTime(1950,01,01);
                    stopwatch.Stopping = new DateTime(1950,01,01);
                }
            }
        }
    }
}
