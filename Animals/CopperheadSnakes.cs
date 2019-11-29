using System;
namespace DiggersAndFliers.Animals
{
    public class CopperheadSnakes : Interfaces.IAnimals, Interfaces.IGrounders
    {

        public string Bite { get; set; }
        public void Crawl()
        {
            Console.WriteLine("I'm crawling on my belly!");
        }

        public void CleanCage()
        {
            Console.WriteLine("Clean that copperhead cage!");
        }
    }
}