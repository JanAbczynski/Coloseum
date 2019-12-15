using System;
using System.Text;

namespace Coloseum.Gladiators
{
    public abstract class Gladiator
    {
        public int HP { get; protected set; }
        public int battleHP;
        public int SP {get; set;}
        public int battleSP;
        public int DEX {get; set;}
        public int battleDEX;
        public int LVL {get; set;}
        public string Name {get; }

        static Array weaponTypes = Enum.GetValues(typeof(WeaponType));
        public WeaponType weaponType;

        private static int gladNumber;
        public Boolean Bleeding = false;
        public int PoisonFor = 0;
        public int BurningFor = 0;

        static string[] firstName = { "Golan", "Kresh", "Maroth", "Find", "Gevi", "Eral", "Rims", "Herboh", "Venhar", "Laria", "Wanol", "Semic", "Send", "Tazat", "Barth", "Diterr", "Golaje", "Ossk", "Heger", "Rhayma", "Goorak", "Deri" };
        static string[] secondName = { "Cenzordr", "Neiduran", "Gerranel", "Crawfor", "Kimikona", "Ifalnino", "Fingild", "Lokaczar", "Adarashir", "Araltar", "Haronsi", "Rreortho", "Wonzolaro", "Lcemirius", "Ravoldot", "Kanelver", "Iuserir", "Bisojerm", "Krokshen", "Raganur", "Urrorais", "Lanoend" };


        public Gladiator()
        {
            //Name = GenerateName();
            this.Name = GiveName();
            Random random = new Random();
            HP = random.Next(0, 100);
            SP = random.Next(0, 100);
            DEX = random.Next(0, 100);
            LVL = 1;
            chooseWeaponType();

        }

        private void chooseWeaponType()
        {
            Random random = new Random();
            weaponType = (WeaponType)weaponTypes.GetValue(random.Next(weaponTypes.Length));
        }

        public void changeBaseStat(int factorHP, int factorSP, int factorDEX)
        {
            HP = (HP * factorHP) / 100;
            SP = (SP * factorSP) / 100;
            DEX = (DEX * factorDEX) / 100;
        }

        public void battleParametersSetter()
        {
            this.battleHP = LVL * HP;
            this.battleSP = LVL * SP;
            this.battleDEX = LVL * DEX;
        }

        public void battleParametersSetter(int factorHP, int factorSP, int factorDEX)
        {
            this.battleHP = (LVL * HP * factorHP) / 100;
            this.battleSP = (LVL * SP * factorSP) / 100;
            this.battleDEX = (LVL * DEX * factorDEX) / 100;
        }

        protected string GiveName()
        {
            if (gladNumber == null)
            {
                gladNumber = 1;
            }

            Random randomName = new Random();
            int firstNameIndex = randomName.Next(firstName.Length);
            int secondNameIndex = randomName.Next(secondName.Length);

            StringBuilder newName = new StringBuilder();
            newName.Append(gladNumber.ToString());
            newName.Append(" - ");
            newName.Append(firstName[firstNameIndex]);
            newName.Append(" ");
            newName.Append(secondName[secondNameIndex]);

            gladNumber++;
            return newName.ToString();

        }

        public int GetHP()
        {
            return HP;
        }
    }
}

enum statFactor
{
    LOW = 75,
    MEDIUM = 100,
    HIGH = 125
}

public enum WeaponType
{
    NORMAL,
    POISONED,
    BURNING
}