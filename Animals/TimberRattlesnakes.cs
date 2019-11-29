using System;
namespace DiggersAndFliers.Animals
{
    public class TimberRattlesnakes : Interfaces.IAnimals, Interfaces.IGrounders
    {

        public string Slither { get; set; }
        public void Crawl()
        {
            Console.WriteLine("I'm slithering/crawling!");
        }

        public void CleanCage()
        {
            Console.WriteLine("Clean that snake box");
        }
    }
}