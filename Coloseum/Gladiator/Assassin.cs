using System;

namespace Coloseum.Gladiators
{
    public class Assassin : Gladiator
    {
        public int i;

        public Assassin()
        {
            Random random = new Random();
            HP = random.Next(700, 1001);
            SP = random.Next(7, 11);
            DEX = random.Next(7, 11);
            LVL = 1;
        }
    }
}