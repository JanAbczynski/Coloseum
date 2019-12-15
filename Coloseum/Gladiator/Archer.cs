using System;

namespace Coloseum.Gladiators
{
    public class Archer : Gladiator
    {
      
        public Archer()
        {
            int factorHP = (int)statFactor.MEDIUM;
            int factorSP = (int)statFactor.MEDIUM;
            int factorDEX = (int)statFactor.HIGH;
            changeBaseStat(factorHP, factorSP, factorDEX);
            battleParametersSetter();
        }
    }
}