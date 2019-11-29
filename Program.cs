using System;
using System.Collections.Generic;
using System.Linq;

namespace DiggersAndFliers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Interfaces.IDigging> diggerRoom = new List<Interfaces.IDigging>();
            List<Interfaces.IGrounders> groundRoom = new List<Interfaces.IGrounders>();
            List<Interfaces.IFlying> birdCage = new List<Interfaces.IFlying>();
            List<Interfaces.ISwimmers> pond = new List<Interfaces.ISwimmers>();
            List<Interfaces.IAnimals> zoo = new List<Interfaces.IAnimals>();

            var myAnts = new Animals.Ants();
            var myBettaFish = new Animals.BettaFish();
            var myCopperheadSnakes = new Animals.CopperheadSnakes();
            var myEarthworms = new Animals.Earthworms();
            var myFinches = new Animals.Finches();
            var myGirbils = new Animals.Gerbils();
            var myMice = new Animals.Mice();
            var myParakeets = new Animals.Parakeets();
            var myTerrapins = new Animals.Terrapins();
            var myTimberRattlesnakes = new Animals.TimberRattlesnakes();


        }
    }
}
