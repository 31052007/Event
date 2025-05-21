using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Barrier
    {
        public delegate void BarrierEventHandler();

        public static event BarrierEventHandler Event1; // Событие: открыт
        public static event BarrierEventHandler Event2; // Событие: закрыт

        public void OnOpen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Шлагбаум: Открыто.");
            Console.ResetColor();
        }

        public void OnClose()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Шлагбаум: Закрыто.");
            Console.ResetColor();
        }

        public void TriggerEvent(int eventType)
        {
            if (eventType == 1)
            {
              
                if (Event1 != null)
                    Event1();
            }
            else if (eventType == 2)
            {
                
                if (Event2 != null)
                    Event2();
            }
        }
    }
}
