using System;
namespace DiggersAndFliers.Animals
{
    public class Finches : Interfaces.IAnimals, Interfaces.IFlying
    {

        public string Chirp { get; set; }
        public void Fly()
        {
            Console.WriteLine("I'm a flying finch!");
        }

        public void CleanCage()
        {
            Console.WriteLine("Clean that finch cage!");
        }
    }
}