using System;

namespace InterfaceSegregation
{
    // ISP states that it's better to have many small interfaces than a few larger ones.
    // Rather than creating a single interface for Mammal, we can seperate interfaces for all the behaviours.
    // This is decoupling and moving towards composition based design.
    // We can build a Mammal with composition without being forced to utilize behaviours contained within a single Mammal class.
    // For example, a Giraffe is a Mammal that doesn't make loud noises therefore we don't need this behaviour.
    // If we seperate all behaviours into seperate and single interfaces we can build each Mammal exactly how it represents itself.
    public interface IEat
    {
        public void Eat();
    }
    public interface IMakeLoudNoise
    {
        public void MakeLoudNoise();
    }

    public class Dog : IEat, IMakeLoudNoise
    {
        public void Eat()
        {
            Console.WriteLine("Dog is eating...");
        }

        public void MakeLoudNoise()
        {
            Console.WriteLine("Dog is making loud noise...");
        }
    }
}
