using System;
namespace DiggersAndFliers.Animals
{
    public class Gerbils : Interfaces.IAnimals, Interfaces.IGrounders
    {

        public string RunInBall { get; set; }
        public void Crawl()
        {
            Console.WriteLine("I'm crawling in my gerbil ball!");
        }

        public void CleanCage()
        {
            Console.WriteLine("Clean that Gerbil cage!");
        }
    }
}