using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassCounter counter = new ClassCounter();
            Hadler_1 hadler_1 = new Hadler_1();
            Hadler_2 hadler_2 = new Hadler_2();

            counter.Count();

            counter.onCount += hadler_1.Message;
            counter.onCount += hadler_2.Message;
            counter.onCount += counter.Message;
            counter.Count();
            Console.Read();
        }
    }
}
