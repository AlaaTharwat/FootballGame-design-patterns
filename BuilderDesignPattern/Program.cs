using System;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var GroundCreator = new GroundCreator(new ItalyGround());
            GroundCreator.CreateGround();
            var Ground = GroundCreator.GetGround();
            Ground.ShowInfo();

            Console.WriteLine("---------------------------------------------");

            var GroundCreator1 = new GroundCreator(new EnglandGround());
            GroundCreator1.CreateGround();
            var Ground1 = GroundCreator1.GetGround();
            Ground1.ShowInfo();
        }
    }
}
