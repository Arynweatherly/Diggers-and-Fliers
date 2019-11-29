using System;
namespace DiggersAndFliers.Animals
{
    public class BettaFish : Interfaces.IAnimals, Interfaces.ISwimmers
    {

        public string Fight { get; set; }
        public void Swim()
        {
            Console.WriteLine("I'm a fighting fish!");
        }

        public void CleanCage()
        {
            Console.WriteLine("Clean that beta fish tank!");
        }
    }
}