using System;

namespace Coloseum.Gladiators
{
    public class Swordsman : Gladiator
    {
        public Swordsman()
        {
            Random random = new Random();
            HP = random.Next(300, 700);
            SP = random.Next(3, 7);
            DEX = random.Next(3, 7);
            LVL = 1;
        }
    }
}