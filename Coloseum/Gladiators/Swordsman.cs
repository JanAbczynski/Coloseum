using System;

namespace Coloseum.Gladiators
{
    public class Swordsman : Gladiator
    {
        public Swordsman()
        {
            Random random = new Random();
            HP = random.Next(300, 700);
            SP = random.Next(300, 700);
            DEX = random.Next(300, 700);
            LVL = 0;
        }
    }
}