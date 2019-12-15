using System;

namespace Coloseum.Gladiators
{
    public class Assassin : Gladiator
    {
        public int i;

        public Assassin()
        {
            int factorHP = (int)statFactor.LOW;
            int factorSP = (int)statFactor.HIGH;
            int factorDEX = (int)statFactor.HIGH;
            battleParametersSetter();
        }
    }
}