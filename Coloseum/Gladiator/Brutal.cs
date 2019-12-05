using System;

namespace Coloseum.Gladiators
{
    public class Brutal : Gladiator
    {
        public Brutal()
        {
            Random random = new Random();
            HP = random.Next(700, 1001);
            SP = random.Next(700, 1001);
            DEX = random.Next(1, 301);
            LVL = 1;
        }
    }
}