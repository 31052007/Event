using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Man
    {
        private string name;

        public Man(string name)
        {
            this.name = name;
        }

        public void Go()
        {
            Console.WriteLine(name + ": Иду.");

           
            Barrier.Event1 -= this.Go;
            Barrier.Event2 -= this.Wait;
        }

        public void Wait()
        {
            Console.WriteLine(name + ": Стою.");
        }
    }
}
