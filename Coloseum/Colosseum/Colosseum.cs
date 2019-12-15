using System;
using System.Collections.Generic;
using System.Text;

namespace Coloseum.Colosseum
{
      
    class Colosseum
    {
        int battleSize;
        double gladiatorsQuantity;
        static Array gladTypes = Enum.GetValues(typeof(GladiatorType));
        GladiatorType randomGladiator;
        List<Gladiators.Gladiator> gladiatorList = new List<Gladiators.Gladiator>();
        Gladiators.Gladiator redWarrior;
        Gladiators.Gladiator blueWarrior;
        Boolean battleOnAir;
        int gladiatorSelector = 0;
        int battleLevelNumber = 1;
        int oneBattleNumber = 0;
        int chanceForCritivalHit = 15;
        static string[] sentance_1_WhatToDo = { "Eat", "Kiss", "Look at", "Smell" ,"Think about" , "Try", "Catch", "Keep in mind"};
        static string[] sentance_2_Whose = { " my", " yours", " this", " that", " some", " any" };
        static string[] sentance_3_Which = { " dirty", " powerfull", " noisy", " fucking", " invincible", " stinky", " unbefuckinglievable" };
        static string[] sentance_4_What = { " sword", " weapon", " shit", " ass", " power", " pizza" ," force"};
        static string[] sentance_5_Who = { ", scum!", ", moron!", ", bugger!", ", wanker!", ", cocksucker!", ", tosser!", ", dickhead!", ", fool!", " motherfucker!", ", young man!", ", mr. nobody!", ", bastard!", ", tinny boy!", ", whore!", ", looser!", ", cheap bitch!", ", asshole!"};

        public void createGaldiatorsList()
        {
            
            Boolean correctInput = false;

            while (!correctInput)
            {
                try
                {
                    string input;
                    Console.Write("How many steps? ");
                    input = Console.ReadLine();
                    battleSize = Convert.ToInt32(input);
                    gladiatorsQuantity = Math.Pow(2, battleSize);
                    Console.WriteLine(gladiatorsQuantity);
                    correctInput = true;
                }
                catch (FormatException)
                {
                    Console.Clear();
                    correctInput = false;
                }
                fillList();
            }           
        }

        private void fillList()
        {
            for (Double i = 0; i < gladiatorsQuantity; i++)
            {
                RandomGladiator();

                switch (randomGladiator)
                {
                    case GladiatorType.ARCHER:
                        gladiatorList.Add(new Gladiators.Archer());
                        break;

                    case GladiatorType.ASSASIN:
                        gladiatorList.Add(new Gladiators.Assassin());
                        break;

                    case GladiatorType.BRUTAL:
                        gladiatorList.Add(new Gladiators.Brutal());
                        break;

                    case GladiatorType.SWORDMEN:
                        gladiatorList.Add(new Gladiators.Swordsman());
                        break;
                }
            }
        }

        private void RandomGladiator()
        {
            Random random = new Random();
            randomGladiator = (GladiatorType)gladTypes.GetValue(random.Next(gladTypes.Length));
        }

        public void beginTurnament()
        {
            //gladiatorSelector;
            while(gladiatorList.Count > 1)
            {
                battlesOnOneLevel();
            }
            endGameMessage();
        }

        private void battlesOnOneLevel()
        {
            while (gladiatorList.Count > gladiatorSelector + 1)
            {
                Console.WriteLine("DD");
            //}
                redWarrior = gladiatorList[gladiatorSelector];
                blueWarrior = gladiatorList[gladiatorSelector + 1];
                oneBattle(redWarrior, blueWarrior);
                gladiatorSelector ++;
            }
            gladiatorSelector = 0;
            oneBattleNumber = 0;
            battleLevelNumber ++;

        }

        private void oneBattle(Gladiators.Gladiator redWarrior, Gladiators.Gladiator blueWarrior)
        {
            battleOnAir = true;
            oneBattleNumber++;
            while (battleOnAir)
            {
                printBattleInfo();
                printStatusMessage("Red Warrior", redWarrior);
                printStatusMessage("Blue Warrior", blueWarrior);
                specialAttackEffect(redWarrior);
                checkIsSombodyDead(redWarrior, blueWarrior);
                specialAttackEffect(blueWarrior);
                checkIsSombodyDead(redWarrior, blueWarrior);
                attack(redWarrior, blueWarrior);
                attack(blueWarrior, redWarrior);
                System.Threading.Thread.Sleep(200);   
            }
            finishBattle(redWarrior, gladiatorSelector);
            finishBattle(blueWarrior, gladiatorSelector + 1);
        }

        private void specialAttackEffect(Gladiators.Gladiator warrior)
        {
            if (warrior.Bleeding == true)
            {
                warrior.battleHP -= 15;
            }
            if(warrior.BurningFor > 0)
            {
                warrior.battleHP -= 15;
                warrior.BurningFor -= 1;
            }
            if (warrior.PoisonFor > 0)
            {
                warrior.battleHP -= 15;
                warrior.PoisonFor -= 1;
            }
        }

        private void attack(Gladiators.Gladiator attacker, Gladiators.Gladiator defender)        
        {
            int unclampedChance = attacker.battleDEX - defender.battleDEX;
            int chance = Math.Clamp(unclampedChance, 10, 100);
            Random tryToHit = new Random();
            if (tryToHit.Next(100) < chance && battleOnAir)
            {
                printAttackMessage(AttackMessage.HIT, attacker, defender);
                defender.battleHP -= attacker.battleSP;
                specialAttack(attacker, defender);
                if (defender.battleHP <= 0)
                {
                    printAttackMessage(AttackMessage.KILL, attacker, defender);
                }
            } else if (attacker.battleHP < 0)
            {
                    printAttackMessage(AttackMessage.DEAD, attacker, defender);
            }
            else
            {
                printAttackMessage(AttackMessage.MISS, attacker, defender);
            }
            checkIsSombodyDead(attacker, defender);
        }

        private void specialAttack(Gladiators.Gladiator attacker, Gladiators.Gladiator defender)
        {
            switch (attacker.weaponType)
            {
                case WeaponType.BURNING:
                    defender.BurningFor = 4;
                    break;
                case WeaponType.POISONED:
                    defender.PoisonFor = 3;
                    break;
            }
            Random random = new Random();
            if (random.Next(100) < chanceForCritivalHit)
            {
                defender.Bleeding = true;
            }

        }
        
        private void checkIsSombodyDead(Gladiators.Gladiator attacker, Gladiators.Gladiator defender)
        {
            if (attacker.battleHP < 0 || defender.battleHP < 0)
            {
                battleOnAir = false;
            }
        }
        
        private void printBattleInfo()
        {
            Console.WriteLine("Battle number: " + battleLevelNumber + "." + oneBattleNumber);
        }
       
        private void printStatusMessage(String color, Gladiators.Gladiator Warrior)
        {
            Console.WriteLine(color + ": " + Warrior.Name + 
                ", Level: " + Warrior.LVL + 
                ", HP: " + Warrior.battleHP + 
                ", DEX: " + Warrior.battleDEX + 
                ", SP: " + Warrior.battleSP +
                ", Weapon: " + Warrior.weaponType +
                ", Burning: " + Warrior.BurningFor +
                ", Bleeding: " + Warrior.Bleeding + 
                ", Poison: " + Warrior.PoisonFor);
        }

        private void printAttackMessage(AttackMessage attackResult, Gladiators.Gladiator attacker, Gladiators.Gladiator defender)
        {
            switch (attackResult)
            {
                case AttackMessage.HIT:
                    Console.WriteLine(attacker.Name + " hit! - " + verfluchenGenerator());
                    break;
                case AttackMessage.MISS:
                    Console.WriteLine(attacker.Name + " miss...");
                    break;
                case AttackMessage.KILL:
                    Console.WriteLine(attacker.Name + " kills" + defender.Name);
                    break;
                case AttackMessage.DEAD:
                    Console.WriteLine(attacker.Name + " is dead.");
                    break;

            }
            System.Threading.Thread.Sleep(100);
        }
    
        private void finishBattle(Gladiators.Gladiator warrior, int gladiatorSelector)
        {
            if (warrior.battleHP <= 0)
            {
                gladiatorList.RemoveAt(gladiatorSelector);
            } else
            {
                warrior.LVL++;
                warrior.battleParametersSetter();
            }
        }

        private String verfluchenGenerator()
        {
            StringBuilder curse = new StringBuilder();
            Random random = new Random();
            curse.Append(sentance_1_WhatToDo[random.Next(sentance_1_WhatToDo.Length)]);
            curse.Append(sentance_2_Whose[random.Next(sentance_2_Whose.Length)]);
            curse.Append(sentance_3_Which[random.Next(sentance_3_Which.Length)]);
            curse.Append(sentance_4_What[random.Next(sentance_4_What.Length)]);
            curse.Append(sentance_5_Who[random.Next(sentance_5_Who.Length)]);

            return curse.ToString();
        }

        private void endGameMessage()
        {
      
            Console.WriteLine("And the winner is ..... " + gladiatorList[0].Name);
        }
    }

}

enum GladiatorType
{
    ARCHER,
    ASSASIN,
    BRUTAL,
    SWORDMEN
}

enum AttackMessage
{
    HIT,
    MISS,
    KILL,
    DEAD
}

