using Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Class1
    {
        public abstract void AnimalSounds();

        public void Sleep()
        {
            Console.WriteLine("zzzz");
        }

    }

    class pig : Class1
    {
        public override void AnimalSounds()
        {
            Console.WriteLine("The pig's sound is");
            Console.WriteLine("oink oink");
        }
    }
}

  
