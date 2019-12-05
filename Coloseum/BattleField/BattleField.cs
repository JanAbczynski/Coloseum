using System;
using System.Collections.Generic;
using Coloseum.Gladiators;

namespace Coloseum.BattleField
{
    public class BattleField
    {
        public static void Fight(List<Gladiator> gladiators)
        {
            List<Gladiator>.Enumerator gladiatorsEnumerator = gladiators.GetEnumerator();
            while (gladiators.Count != 0)
            {
                Gladiator gladiator1 = gladiatorsEnumerator.Current;
                gladiatorsEnumerator.MoveNext();
                Gladiator gladiator2 = gladiatorsEnumerator.Current;
                gladiatorsEnumerator.MoveNext();


                while (gladiator1?.HP > 0 || gladiator2?.HP > 0)
                {
                    Console.WriteLine(null > 0);
                    gladiators.Remove()
                }

            }
        }

        public void PrintFight()
        {

        }

    }
}