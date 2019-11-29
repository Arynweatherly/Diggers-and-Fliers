using System;
namespace DiggersAndFliers.Animals
{
    public class Terrapins : Interfaces.IAnimals, Interfaces.ISwimmers, Interfaces.IGrounders, Interfaces.IDigging
    {

        public string makeBeer { get; set; }
        public void Swim()
        {
            Console.WriteLine("I'm a swimming turtle!!");
        }
        public void Crawl()
        {
            Console.WriteLine("I'm a slow moving turtle!!");
        }

        public void Dig()
        {
            Console.WriteLine("google says im a turtle that digs");
        }

        public void CleanCage()
        {
            Console.WriteLine("Clean that terrapin tank");
        }
    }
}