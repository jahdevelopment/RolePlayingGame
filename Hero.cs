using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingGame
{
    public class Hero
    {
        private int _heroId;

        public int _HeroId { get { return _heroId; } }


        private string _heroName;

        public string HeroName { get { return _heroName;} }


        private int _heroBaseStrength;

        public int HeroBaseStrength 
        { 
            get { return _heroBaseStrength;} 
            
            set 
            {
                if (value < 0)
                {
                    throw new Exception("Hero Base Strenght cannot be less than zero.");

                    value = 0;
                }
                else
                {
                _heroBaseStrength = value; 
                }
            } 
        }


        private int _heroBaseDefense;

        public int HeroBaseDefense
        {
            get { return _heroBaseDefense; }

            set
            {
                if (value < 0)
                {
                    throw new Exception("Hero Base Defense cannot be less than zero.");
                }
                else
                {
                    _heroBaseDefense = value;
                }
            }
        }


        private int _heroOriginalHealth;

        public int HeroOriginalHealth
        {
            get { return _heroOriginalHealth; }

            set
            {
                if (value < 0)
                {
                    throw new Exception("Hero Base Defense cannot be less than zero.");
                }
                else
                {
                    _heroOriginalHealth = value;
                }
            }
        }


        private int _heroCurrentHealth;

        public int HeroCurrentHealth { get { return _heroCurrentHealth; } }

        private int _setHeroCurrentHealth(int heroCurrentHealth)
        {
            if (heroCurrentHealth < 0)
            {
                _heroCurrentHealth = 0;
            }
            else
            {
                _heroCurrentHealth = heroCurrentHealth;
            }
            return _heroCurrentHealth;
        }


        private Weapon _equippedWeapon;

        public Weapon EquippedWeapon { get { return _equippedWeapon; } }
        
        //private int? _setEquippedWeapon(int equippedWeapon)
        //{
        //    _equippedWeapon = equippedWeapon;

        //    return _equippedWeapon;
        //}


        private Armour _equippedArmour;

        public Armour EquippedArmour { get { return _equippedArmour; } }

        //private int? _setEquippedArmour(int equippedArmour)
        //{
        //    _equippedArmour = equippedArmour;

        //    return _equippedArmour;
        //}

        public Hero(int heroId, string heroName,int heroBaseStrength, int heroBaseDefense, int heroOriginalHealth, int heroCurrentHealth, Weapon equippedWeapon, Armour equippedArmour)
        {
            _heroId = heroId;

            _heroName = heroName;

            _heroBaseStrength = heroBaseStrength;

            _heroBaseDefense = heroBaseDefense;

            _heroOriginalHealth = heroOriginalHealth;

            _heroCurrentHealth = heroCurrentHealth;

            _equippedWeapon = equippedWeapon;

            _equippedArmour = equippedArmour;

        }
    }
}
