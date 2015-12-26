using System;

namespace SpaceStationPrototype
{
    class Program
    {
        // ReSharper disable once InconsistentNaming
        private static void Main()
        {
            using (var game = new SpaceStationGame())
            {
                game.Run(60);
            }
        }
    }
}
