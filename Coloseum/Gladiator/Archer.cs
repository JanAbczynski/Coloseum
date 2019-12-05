using System;

namespace Coloseum.Gladiators
{
    public class Archer : Gladiator
    {
        public Archer()
        {
            Random random = new Random();
            HP = random.Next(300, 700);
            SP = random.Next(3, 7);
            DEX = random.Next(7, 11);
            LVL = 1;
        }
    }
}