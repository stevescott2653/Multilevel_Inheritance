using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel_Inheritance
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        /// <summary>
        /// The dog.
        /// </summary>
        public class Dog: Animal
        {
            public void Bark()
            {
                Console.WriteLine("Barking...");
            }
        }

        public class BabyDog : Dog
        {
            public void Weep()
            {
                Console.WriteLine("Weeping...");
            }
        }

        class TestInheritance2
        {
            public static void Main(string[] args)
            {
                BabyDog d1 = new BabyDog();
                d1.Eat();
                d1.Bark();
                d1.Weep();
            }
        }
    }
}
