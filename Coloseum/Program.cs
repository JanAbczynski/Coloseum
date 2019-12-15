using System;
using Coloseum.Gladiators;

namespace Coloseum
{
    class Program
    {
        static void Main(string[] args)
        {
            Colosseum.Colosseum colosseum = new Colosseum.Colosseum();
            colosseum.createGaldiatorsList();
            colosseum.beginTurnament();
        }
    }
}
