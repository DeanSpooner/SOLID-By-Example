using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation.Bad
{
    // ISP states that it's better to have many small interfaces than a few larger ones.
    // In this example we are creating a single interface that includes multiple behaviours for a Mammal, Eat() and MakeNoise().
    public interface IMammal
    {
        public void Eat();
        public void MakeNoise();
    }

    public class Dog : IMammal
    {
        public void Eat()
        {
            Console.WriteLine("Dog is eating...");
        }

        public void MakeNoise()
        {
            Console.WriteLine("Dog is making noise...");
        }
    }
}
