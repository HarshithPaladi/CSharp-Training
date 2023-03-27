using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal sound");
        }
    }
     class Dog : Animal 
    {
        // Sealed method
        sealed public override void Sound()
        {
            Console.WriteLine("Dog Sound");
        }
    }
//    class Puppy: Dog
//    {
//        // Trying to override sealed method
//        public override void Sound()
//        {
//            Console.WriteLine("Puppy Sound");
//        }
//    }
}

