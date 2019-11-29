using System;
namespace DiggersAndFliers.Animals
{
    public class Parakeets : Interfaces.IAnimals, Interfaces.IFlying
    {

        public string talk { get; set; }
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }

        public void CleanCage()
        {
            Console.WriteLine("Clean that Parakeet poop");
        }
    }
}