using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    public delegate void TimerDelegate();
    public class Timer
    {

        public static event TimerDelegate TickEvent;
        //public static void Main()
        //{
        //    Timer timer = new Timer();
        //    Console.WriteLine("   ######   hello   ####");
        //    CheckTimer.Func1();
        //    for (int i = 0; i < 20; i++)
        //    {
        //        timer.RunTickEvents(5); 
        //    }

        //    ;

        //}
        public void RunTickEvents(int sec)
        {
            MakeTick(sec).Wait();
            //         Console.WriteLine("   ######   hello2   ####");
            TickEvent();

        }






        public static async Task MakeTick(int sec)
        {
            await Task.Run(() =>
            {
                Task.Delay(sec * 1000).Wait();
                Console.WriteLine("mt");
            });

        }
        public static class CheckTimer
        {

            public static void Func1()
            {
                Timer.TickEvent += Print;

            }
            public static void Print()
            {
                Console.WriteLine("tk  -----");
            }
        }
    }

}
