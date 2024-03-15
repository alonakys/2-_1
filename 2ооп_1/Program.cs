using System;
using System.Threading;

namespace _2oop_1
{

    class Timer
    {
        private readonly Action timerAction;
        private readonly int interval;
        private volatile bool isRunning;

        public Timer(Action action, int intervalInSeconds)
        {
            timerAction = action;
            interval = intervalInSeconds * 1000;
            isRunning = false;
        }

        public void Start()
        {
            if (isRunning)
            {
                return;
            }
            isRunning = true;

            Thread timerThread = new Thread(() =>
            {
                while (isRunning)
                {
                    Thread.Sleep(interval);
                    timerAction.Invoke();
                }
            });

            timerThread.Start();
        }

        public void Stop()
        {
            isRunning = false;
        }
    }

    class Program
    {
        static void Main()
        {
            Timer timer1 = new Timer(() => Console.WriteLine("1"), 1);
            Timer timer2 = new Timer(() => Console.WriteLine("2"), 5);

            Thread thread1 = new Thread(timer1.Start);
            Thread thread2 = new Thread(timer2.Start);

            thread1.Start();
            thread2.Start();

            Thread.Sleep(10000);

            timer1.Stop();
            timer2.Stop();

            thread1.Join();
            thread2.Join();
        }
    }
}
