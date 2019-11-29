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

            diggerRoom.Add(myAnts);
            diggerRoom.Add(myEarthworms);
            diggerRoom.Add(myTerrapins);

            groundRoom.Add(myAnts);
            groundRoom.Add(myEarthworms);
            groundRoom.Add(myCopperheadSnakes);
            groundRoom.Add(myGirbils);
            groundRoom.Add(myMice);
            groundRoom.Add(myTerrapins);
            groundRoom.Add(myTimberRattlesnakes);

            birdCage.Add(myFinches);
            birdCage.Add(myParakeets);

            pond.Add(myBettaFish);
            pond.Add(myTerrapins);
            pond.Add(myMice);

            zoo.Add(myAnts);
            zoo.Add(myBettaFish);
            zoo.Add(myCopperheadSnakes);
            zoo.Add(myEarthworms);
            zoo.Add(myFinches);
            zoo.Add(myGirbils);
            zoo.Add(myMice);
            zoo.Add(myParakeets);
            zoo.Add(myTerrapins);
            zoo.Add(myTimberRattlesnakes);



        }
    }
}
