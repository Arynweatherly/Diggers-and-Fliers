using System;
namespace DiggersAndFliers.Animals
{
    public class Ants : Interfaces.IAnimals, Interfaces.IGrounders, Interfaces.IDigging
    {

        public string LiftHeavyThings { get; set; }
        public void Dig()
        {
            Console.WriteLine("I'm a little ant that digs in the ground!");
        }

        public void Crawl()
        {
            Console.WriteLine("I'm a little ant that crawls around in my ant hill!");
        }

        public void CleanCage()
        {
            Console.WriteLine("Clean that ant hill?");
        }
    }
}