using System;

namespace Coloseum.Gladiators
{
    public class Brutal : Gladiator
    {
        public Brutal()
        {
            int factorHP = (int)statFactor.HIGH;
            int factorSP = (int)statFactor.HIGH;
            int factorDEX = (int)statFactor.LOW;
            battleParametersSetter();
        }
    }
}