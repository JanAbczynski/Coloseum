using System;

namespace Coloseum.Gladiators
{
    public class Swordsman : Gladiator
    {
        public Swordsman()
        {
            int factorHP = (int)statFactor.MEDIUM;
            int factorSP = (int)statFactor.MEDIUM;
            int factorDEX = (int)statFactor.MEDIUM;
            battleParametersSetter();
        }
    }
}