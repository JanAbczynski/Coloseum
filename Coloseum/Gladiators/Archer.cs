using System;

namespace Coloseum.Gladiators
{
    public class Archer : Gladiator
    {
        public Archer()
        {
            Random random = new Random();
            HP = random.Next(300, 700);
            SP = random.Next(300, 700);
            DEX = random.Next(700, 1001);
            LVL = 0;
        }
    }
}