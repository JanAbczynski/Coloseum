using System;

namespace Coloseum.Gladiators
{
    public class Assassin : Gladiator
    {
        public Assassin()
        {
            Random random = new Random();
            HP = random.Next(0, 301);
            SP = random.Next(7, 11);
            DEX = random.Next(7, 11);
            LVL = 1;
        }
    }
}