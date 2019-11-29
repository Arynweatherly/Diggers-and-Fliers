using System;
namespace DiggersAndFliers.Animals
{
    public class Earthworms : Interfaces.IAnimals, Interfaces.IDigging, Interfaces.IGrounders
    {

        public string InchBy { get; set; }
        public void Dig()
        {
            Console.WriteLine("I'm digging through the dirt!");
        }

        public void CleanCage()
        {
            Console.WriteLine("Clean that earthworm bucket");
        }
        public void Crawl()
        {
            Console.WriteLine("I'm crawling across the parking lot because its raining");
        }
    }
}