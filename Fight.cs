using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingGame
{
    public class Fight
    {
        private Hero _hero;

        public Hero Hero { get { return _hero; } }


        private int _gamesPlayed;

        public int GamesPlayed{ get { return _gamesPlayed; } }


        private int _gamesWon;

        public int GamesWon { get { return _gamesWon; } }


        private int _gamesLost;

        public int GamesLost { get { return _gamesLost; } } 


        private Monster _monster;

        public Monster Monster { get { return _monster; } }

        
        public void TurnToStart(Hero hero, Monster monster)
        {
            int min = 1;

            int max = 2;

            Random rnd = new Random();

            int turn = rnd.Next(min, max +1);



            if (turn == 1)
            {
                Console.WriteLine($"\nOriginal \"{hero.HeroName}\" health is: {hero.HeroCurrentHealth}, and original \"{monster.MonsterName}\" health is: {monster.MonsterCurrentHealth}\n");
                
                Console.WriteLine($"\nThe Hero \"{hero.HeroName}\" starts the fight.\n");

                Console.WriteLine("Pulse Enter to continue...");

                Console.ReadLine();

                while (monster.MonsterCurrentHealth > 0 || hero.HeroCurrentHealth > 0)
                {
                    HeroTurn(hero, monster);

                    Console.WriteLine("Pulse Enter to continue...");

                    Console.ReadLine();

                    MonsterTurn(hero, monster);

                    Console.WriteLine("Pulse Enter to continue...");

                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine($"\nOriginal \"{hero.HeroName}\" health is: {hero.HeroCurrentHealth}, and original \"{monster.MonsterName}\" health is: {monster.MonsterCurrentHealth}\n");

                Console.WriteLine($"\nThe Monster \"{monster.MonsterName}\" starts the fight.\n");

                Console.WriteLine("Pulse Enter to continue...");

                Console.ReadLine();

                while (monster.MonsterCurrentHealth > 0 || hero.HeroCurrentHealth > 0)
                {
                    MonsterTurn(hero, monster);

                    Console.WriteLine("Pulse Enter to continue...");

                    Console.ReadLine();

                    HeroTurn(hero, monster);

                    Console.WriteLine("Pulse enter to continue...");

                    Console.ReadLine();
                }
            }
        }

        public int HeroTurn(Hero hero, Monster monster)
        {
            Hero hero1 = hero;

            Monster monster1 = monster;
            
            int HeroAttachDamage = hero1.HeroBaseStrength + hero1.EquippedWeapon.WeaponPower - monster1.MonsterBaseDefense;

            Console.WriteLine($"The Hero \"{hero1.HeroName}\" attacks!\n");

            monster1.MonsterCurrentHealth -= HeroAttachDamage;

            if (monster1.MonsterCurrentHealth <= 0)
            {
                monster1.MonsterCurrentHealth = 0;

                Console.WriteLine($"\"{hero1.HeroName}\" Wins! The Monster \"{monster1.MonsterName}\" has lost.\n");

                Console.WriteLine($"Now the current \"{hero1.HeroName}\" health is: {hero1.HeroCurrentHealth}, and the current \"{monster1.MonsterName}\" health is: {monster1.MonsterCurrentHealth}\n");

                hero1.HeroCurrentHealth = hero1.HeroOriginalHealth;

                monster1.MonsterCurrentHealth = monster1.MonsterOriginalHealth;

                _gamesWon++;

                _gamesPlayed++;

                Console.WriteLine($"Fight number {Game.numberOfFights+=_gamesPlayed}. Hero \"{hero1.HeroName}\" has won {Game.numberOfWins+=_gamesWon} battles, and lost {Game.numberOfLoses+=_gamesLost} battles.");

                Game.Menu();
            }
            Console.WriteLine($"Now the current \"{hero1.HeroName}\" health is: { hero1.HeroCurrentHealth}, and the current \"{monster1.MonsterName}\" health is: { monster1.MonsterCurrentHealth}\n");
            
            return monster1.MonsterCurrentHealth;
        }

        public int MonsterTurn(Hero hero, Monster monster)
        {
            Hero hero1 = hero;

            Monster monster1 = monster;

            int MonsterAttachDamage = monster1.MonsterBaseStrength - hero1.HeroBaseDefense - hero1.EquippedArmour.ArmourPower;

            Console.WriteLine($"The Monster \"{monster1.MonsterName}\" attacks!\n");

            hero1.HeroCurrentHealth -= MonsterAttachDamage;

            if (hero1.HeroCurrentHealth <= 0)
            {
                hero1.HeroCurrentHealth = 0;

                Console.WriteLine($"\"{monster1.MonsterName}\" Wins! The Hero \"{hero1.HeroName}\" has lost.\n");

                Console.WriteLine($"Now the current \"{hero1.HeroName}\" health is: {hero1.HeroCurrentHealth}, and the current \"{monster1.MonsterName}\" health is: {monster1.MonsterCurrentHealth}\n");

                hero1.HeroCurrentHealth = hero1.HeroOriginalHealth;

                monster1.MonsterCurrentHealth = monster1.MonsterOriginalHealth;

                _gamesLost++;

                _gamesPlayed++;

                Console.WriteLine($"Fight number {Game.numberOfFights += _gamesPlayed}. Hero \"{hero1.HeroName}\" has won {Game.numberOfWins+=_gamesWon} battles, and lost {Game.numberOfLoses+=_gamesLost} battles.");

                Game.Menu();
            }
            Console.WriteLine($"Now the current \"{hero1.HeroName}\" health is: {hero1.HeroCurrentHealth}, and the current \"{monster1.MonsterName}\" health is: {monster1.MonsterCurrentHealth}\n");

            return hero1.HeroCurrentHealth;
        }

        public Fight(Hero hero, Monster monster)
        {
            Console.WriteLine($"\nYour hero \"{hero.HeroName}\" will fight against \"{monster.MonsterName}\".");

            _hero = hero;

            _monster = monster;
            
            TurnToStart(hero, monster);
        }
    }
}
