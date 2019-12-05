using System;
using System.Text;

namespace Coloseum.Gladiators
{
    public abstract class Gladiator
    {
        public int HP {set; get;}
        public int SP {set; get;}
        public int DEX {set; get;}
        public int LVL {set; get;}
        public string Name {set; get;}

        public Gladiator()
        {
            Name = GenerateName();
        }
        protected static string GenerateName()
        {
            Random r = new Random();
            int len = r.Next(5, 12);
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2;
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }
            return Name;
        }

        public override string ToString()
        {
            StringBuilder data = new StringBuilder();
            data.Append($"Gladiator Name: {Name}\n");
            data.Append($"HP:  {HP}\n");
            data.Append($"SP:  {SP}\n");
            data.Append($"DEX: {DEX}\n");
            data.Append($"LVL: {LVL}\n");
            return data.ToString();
        }
    }
}