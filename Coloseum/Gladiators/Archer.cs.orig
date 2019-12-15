using System;

namespace Coloseum.Gladiators
{
    public class Archer : Gladiator
    {
        public Archer()
        {
<<<<<<< HEAD
           
        }

        public static string GenerateName(int len)
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;


=======
            Random random = new Random();
            HP = random.Next(300, 700);
            SP = random.Next(300, 700);
            DEX = random.Next(700, 1001);
            LVL = 0;
>>>>>>> 75419346c0b7a04b2f4d1c527cef72d5ab06c0c0
        }
    }
}