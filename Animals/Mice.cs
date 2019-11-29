using System;
namespace DiggersAndFliers.Animals
{
    public class Mice : Interfaces.IAnimals, Interfaces.IGrounders, Interfaces.ISwimmers
    {

        public string GetCheese { get; set; }
        public void Crawl()
        {
            Console.WriteLine("I'm running toward that cheese!");
        }

        public void CleanCage()
        {
            Console.WriteLine("Clean that mouse cage");
        }

        public void Swim()
        {
            Console.WriteLine("I'm a cute little swimming mouse");
        }
    }
}