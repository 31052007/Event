using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Barrier barrier = new Barrier();

           
            Barrier.Event1 += barrier.OnOpen;
            Barrier.Event2 += barrier.OnClose;

            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                Man man = new Man("Человек_" + (i + 1));

               
                Barrier.Event1 += man.Go;
                Barrier.Event2 += man.Wait;

                
                int eventType = rand.Next(1, 3);

                barrier.TriggerEvent(eventType);

                Console.ReadKey();


            }

            Console.ReadLine();
        }
    }
}
