using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingGame
{
    public static class Game
    {
        public static HashSet<Hero> Heroes = new HashSet<Hero>();

        public static HashSet<Monster> Monsters = new HashSet<Monster>();

        public static HashSet<Weapon> Weapons = new HashSet<Weapon>();

        public static HashSet<Armour> Armours = new HashSet<Armour>();

        public static Fight Fight;

        public static int numberOfHero;

        private static int _heroIdCount = 1;

        private static int _monsterIdCount = 1;

        private static int _weaponIdCount = 1;

        private static int _armourIdCount = 1;



        public static Hero GetHero(int heroId)
        {
            Hero hero = null;

            foreach (Hero h in Heroes)
            {
                if (h.HeroId == heroId)
                {
                    hero = h;

                    break;
                }
            }
            return hero;
        }


        public static Monster GetMonster(int monsterId)
        {
            Monster monster = null;

            foreach (Monster m in Monsters)
            {
                if (m.MonsterId == monsterId)
                {
                    monster = m;

                    break;
                }
            }
            return monster;
        }


        public static Weapon? GetWeapon(int weaponId)
        {
            Weapon? weapon = null;

            foreach (Weapon w in Weapons)
            {
                if (w.WeaponId == weaponId)
                {
                    weapon = w;

                    break;
                }
            }
            return weapon;
        }


        public static Armour? GetArmour(int armourId)
        {
            Armour? armour = null;

            foreach (Armour a in Armours)
            {
                if (a.ArmourId == armourId)
                {
                    armour = a;

                    break;
                }
            }
            return armour;
        }


        public static void CreateHero(string heroName, int heroBaseStrength, int heroBaseDefense, int heroOriginalHealth, int heroCurrentHealth, int weaponId, int armourId)
        {
            Weapon equippedWeapon = GetWeapon(weaponId);

            Armour equippedArmour = GetArmour(armourId);

            Hero newHero = new Hero(_heroIdCount, heroName, heroBaseStrength, heroBaseDefense, heroOriginalHealth, heroCurrentHealth, equippedWeapon, equippedArmour);

            _heroIdCount++;

            Heroes.Add(newHero);
        }


        public static void CreateMonster(string monsterName, int monsterBaseStrength, int monsterBaseDefense, int monsterOriginalHealth, int monsterCurrentHealth)
        {
            Monster newMonster = new Monster(_monsterIdCount, monsterName, monsterBaseStrength, monsterBaseDefense, monsterOriginalHealth, monsterCurrentHealth);

            _monsterIdCount++;

            Monsters.Add(newMonster);
        }

        
        public static void CreateWeapon(string weaponName, int weaponPower)
        {
            Weapon newWeapon = new Weapon(_weaponIdCount, weaponName, weaponPower);

            _weaponIdCount++;

            Weapons.Add(newWeapon);
        }


        public static void CreateArmour(string armourName, int armourPower)
        {
            Armour newArmour = new Armour(_armourIdCount, armourName, armourPower);

            _armourIdCount++;

            Armours.Add(newArmour);
        }

                
        public static int? SelectKnight()
        {
            bool knightSelection = false;

            int knightSelected = 0;

            while (knightSelection == false)
            try
            {
                Console.WriteLine($"\nSelect the knight by its corresponding number:\n\n      NAME                || STRENGTH  ||  DEFENSE  ||   WEAPON (Attack Power)  ||   ARMOUR (Defense Power)\n1. {GetHero(1).HeroName}        ||    {GetHero(1).HeroBaseStrength}    ||    {GetHero(1).HeroBaseDefense}     ||  {GetWeapon(1).WeaponName} ({GetWeapon(1).WeaponPower})             ||  {GetArmour(1).ArmourName} ({GetArmour(1).ArmourPower})\n2. {GetHero(2).HeroName}  ||    {GetHero(2).HeroBaseStrength}    ||    {GetHero(2).HeroBaseDefense}     ||  {GetWeapon(2).WeaponName} ({GetWeapon(2).WeaponPower})           ||  {GetArmour(2).ArmourName} ({GetArmour(2).ArmourPower})\n3. {GetHero(3).HeroName}           ||    {GetHero(3).HeroBaseStrength}    ||    {GetHero(3).HeroBaseDefense}     ||  {GetWeapon(3).WeaponName} ({GetWeapon(3).WeaponPower})         ||  {GetArmour(3).ArmourName} ({GetArmour(3).ArmourPower})\n4. {GetHero(4).HeroName}            ||    {GetHero(4).HeroBaseStrength}    ||    {GetHero(4).HeroBaseDefense}     ||  {GetWeapon(4).WeaponName} ({GetWeapon(4).WeaponPower})      ||  {GetArmour(4).ArmourName} ({GetArmour(4).ArmourPower})\n5. {GetHero(5).HeroName}            ||    {GetHero(5).HeroBaseStrength}    ||    {GetHero(5).HeroBaseDefense}     ||  {GetWeapon(5).WeaponName} ({GetWeapon(5).WeaponPower})             ||  {GetArmour(5).ArmourName} ({GetArmour(5).ArmourPower})\n");

                knightSelected = Int32.Parse(Console.ReadLine());

                if (knightSelected < 1 || knightSelected > 5)
                {
                    throw new ArgumentException("The number you put doesn't correspond to any knight.");
                }
                else
                {
                        Hero myHero = new Hero(knightSelected, GetHero(knightSelected).HeroName, GetHero(knightSelected).HeroBaseStrength, GetHero(knightSelected).HeroBaseDefense, GetHero(knightSelected).HeroOriginalHealth, GetHero(knightSelected).HeroCurrentHealth, GetHero(knightSelected).EquippedWeapon, GetHero(knightSelected).EquippedArmour);

                        myHero.GetInventory(knightSelected);

                        knightSelection = true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                
                knightSelection = false;
            }
            static Hero getFromHeroes<Hero>(HashSet<Hero> heroes, Hero knightSelected)
            {
                foreach (Hero hero in heroes)
                {
                    if (hero.Equals(knightSelected))
                    {
                        return hero;
                    }
                }
                return default(Hero);
            }
            return knightSelected;
        }

        
        private static int _chooseRandomMonster()
        {
            int min = 1;

            int max = Monsters.Count;

            Random rnd = new Random();

            int monsterNum = rnd.Next(min, max + 1);

            return monsterNum;
        }


        public static void StartFight(int heroId, int monsterId)
        {
            Hero hero = GetHero(heroId);

            Monster monster = GetMonster(monsterId);

            Fight newFight = new Fight(hero, monster);
        }


        public static void Menu() 
        {
            bool selectMenuNum = false;
            
            while(selectMenuNum == false)
            {
                try
                {
                    Console.WriteLine("\nMAIN MENU:\n\nSelect an option by its corresponding number:\n\n    1. STATISTICS\n    2. INVENTORY\n    3. FIGHT\n    4. EXIT\n");

                    int numberSelected = Int32.Parse(Console.ReadLine());

                    if (numberSelected < 1 || numberSelected > 4)
                    {
                        throw new ArgumentException("The number you put doesn't correspond to any option in the MAIN MENU.");
                    }
                    else if (numberSelected == 1) // Statistics menu
                    {
                        selectMenuNum = true;

                        bool statisticChosen = false;

                        while (statisticChosen == false)
                        {
                            try
                            {
                                Console.WriteLine("\nSTATISTICS\n\nSelect an option you want to see by its corresponding number:\n\n    1. Number of games played\n    2. Number of fights won\n    3. Number of fights lost\n    4. Return to MAIN MENU\n");

                                int statisticSelected = Int32.Parse(Console.ReadLine());

                                if (statisticSelected < 1 || statisticSelected > 4)
                                {
                                    throw new ArgumentException("The number you put doesn't correspond to any option in the STATISTICS menu.");
                                }
                                else if (statisticSelected == 1)
                                {
                                    Console.WriteLine($"\nYour knight XXXXX has played XXXX batles.\n\nPulse any keyboard to return to STATISTICS menu.\n");

                                    string anyKey = Console.ReadLine();

                                    statisticChosen = false;
                                }
                                else if (statisticSelected == 2)
                                {
                                    Console.WriteLine($"\nYour knight XXXXX has won XXXX batles.\n\nPulse any keyboard to return to STATISTICS menu.\n");

                                    string anyKey = Console.ReadLine();

                                    statisticChosen = false;
                                }
                                else if (statisticSelected == 3)
                                {
                                    Console.WriteLine($"\nYour knight XXXXX has lost XXXX batles.\n\nPulse any keyboard to return to STATISTICS menu.\n");

                                    string anyKey = Console.ReadLine();

                                    statisticChosen = false;
                                }
                                else if (statisticSelected == 4)
                                {
                                    statisticChosen = true;

                                    selectMenuNum = false;
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);

                                statisticChosen = false;
                            }
                        }
                    }
                    else if (numberSelected == 2) // Inventory menu
                    {
                        selectMenuNum = true;

                        bool inventoryChosen = false;

                        while (inventoryChosen == false)
                        {
                            try
                            {
                                Console.WriteLine("\nINVENTORY\n\nSelect an option by its corresponding number:\n\n    1. Change the equipped weapon\n    2. Change the equipped armour\n    3. Back to MAIN MENU\n");

                                int inventorySelected = Int32.Parse(Console.ReadLine());

                                if (inventorySelected < 1 || inventorySelected > 3)
                                {
                                    throw new ArgumentException("The number you put doesn't correspond to any option in the INVENTORY menu.");
                                }
                                else if (inventorySelected == 1)
                                {
                                    inventoryChosen = true;

                                    bool weaponChosen = false;

                                    while (weaponChosen == false)
                                    {
                                        try
                                        {
                                            Console.WriteLine($"Select a weapon of the list above by its corresponding number:\n\n       NAME         ||    POWER\n    1. Katana       ||     85\n    2. Falchion     ||     95\n    3. Longsword    ||     105\n    4. ArmingSword  ||     100\n    5. Estoc        ||     110\n");

                                            int weaponSelected = Int32.Parse(Console.ReadLine());

                                            if (weaponSelected < 1 || weaponSelected > 5)
                                            {
                                                throw new ArgumentException("The number you put doesn't correspond to any option in the Weapon list.");
                                            }
                                            else
                                            {
                                                Console.WriteLine($"\nNow you have selected the weapon \"{GetWeapon(weaponSelected).WeaponName}\" for your knight {GetHero(weaponSelected).HeroName}.\n\nPulse any keyboard to return to INVENTORY menu.\n");



                                                string anyKey = Console.ReadLine();

                                                weaponChosen = true;

                                                inventoryChosen = false;
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine(ex.Message);
                                        }
                                    }
                                }
                                else if (inventorySelected == 2)
                                {
                                    inventoryChosen = true;

                                    bool armourChosen = false;

                                    while (armourChosen == false)
                                    {
                                        try
                                        {
                                            Console.WriteLine($"Select an armour of the list above by its corresponding number:\n\n       NAME               ||    POWER\n    1. The Iron Fortress  ||     55\n    2. Death's Oath       ||     65\n    3. The Brass Dome     ||     70\n    4. Gambeson           ||     85\n    5. Scale Armour       ||     90\n");

                                            int armourSelected = Int32.Parse(Console.ReadLine());

                                            if (armourSelected < 1 || armourSelected > 5)
                                            {
                                                throw new ArgumentException("The number you put doesn't correspond to any option in the Armour list.\"");
                                            }
                                            else
                                            {
                                                Console.WriteLine($"\nNow you have selected the armour \"{armourSelected}\" for your knight XXXX.\n\nPulse any keyboard to return to INVENTORY menu.\n");

                                                string anyKey = Console.ReadLine();

                                                armourChosen = true;

                                                inventoryChosen = false;
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine(ex.Message);
                                        }
                                    }
                                }
                                else if (inventorySelected == 3)
                                {
                                    inventoryChosen = true;

                                    selectMenuNum = false;
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                    }
                    else if (numberSelected == 3) // Fight menu
                    {
                        selectMenuNum = true;

                        Hero myHero = new Hero(GetHero(numberOfHero).HeroId, GetHero(numberOfHero).HeroName, GetHero(numberOfHero).HeroBaseStrength, GetHero(numberOfHero).HeroBaseDefense, GetHero(numberOfHero).HeroOriginalHealth, GetHero(numberOfHero).HeroCurrentHealth, GetHero(numberOfHero).EquippedWeapon, GetHero(numberOfHero).EquippedArmour);

                        Monster monsterChosen = new Monster(GetMonster(_chooseRandomMonster()).MonsterId, GetMonster(_chooseRandomMonster()).MonsterName, GetMonster(_chooseRandomMonster()).MonsterBaseStrength, GetMonster(_chooseRandomMonster()).MonsterBaseDefense, GetMonster(_chooseRandomMonster()).MonsterOriginalHealth, GetMonster(_chooseRandomMonster()).MonsterCurrentHealth);

                        
                        StartFight(myHero.HeroId, monsterChosen.MonsterId);

                    }
                    else if (numberSelected == 4)
                    {
                        Console.WriteLine("\n            Thanks...\n\n\n                                Bye Bye!!\n\n");

                        selectMenuNum = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                    selectMenuNum = false;
                }
            }
        }

        public static void Start()
        {
            CreateMonster("Hidrocervus", 195, 65, 1000, 1000);
            CreateMonster("Manticore", 205, 60, 1000, 1000);
            CreateMonster("Mermaid", 220, 75, 1000, 1000);
            CreateMonster("Monoceros", 190, 70, 1000, 1000);
            CreateMonster("Ogre", 200, 60, 1000, 1000);

            CreateArmour("Iron Fortress", 65);
            CreateArmour("Death's Oath", 75);
            CreateArmour("Brass Dome", 70);
            CreateArmour("Gambeson", 85);
            CreateArmour("Scale Armour", 90);

            CreateWeapon("Katana", 90);
            CreateWeapon("Falchion", 95);
            CreateWeapon("Longsword", 105);
            CreateWeapon("Arming Sword", 100);
            CreateWeapon("Estoc", 110);

            CreateHero("William Wallace", 145, 45, 500, 500, 1, 1);
            CreateHero("Rodrigo Díaz De Vivar", 125, 30, 500, 500, 2, 2);
            CreateHero("Saint George", 110, 40, 500, 500, 3, 3);
            CreateHero("John Dunbar", 140, 35, 500, 500, 4, 4);
            CreateHero("Sir Galahad", 130, 50, 500, 500, 5, 5);

            Console.WriteLine("|||||||||||||||=============== \"MEDIEVAL KNIGHTS Vs EPIC MONSTERS\" ===============|||||||||||||||\n");

            Console.WriteLine("Loading...\n\nPulse any key to start the game...\n");
            
            Console.ReadLine();
            
            numberOfHero = SelectKnight().Value;
            
            Menu();
        
        }     
    }
}
