namespace RolePlayingGame
{
    public class Hero
    {
        private int _heroId;

        public int HeroId { get { return _heroId; } }


        private string _heroName;

        public string HeroName { get { return _heroName;} }



        private int _heroBaseStrength;

        public int HeroBaseStrength { get { return _heroBaseStrength; } }
            
            
        private int _heroBaseDefense;

        public int HeroBaseDefense { get { return _heroBaseDefense; } }

            
        private int _heroOriginalHealth;

        public int HeroOriginalHealth { get { return _heroOriginalHealth; } }


        private int _heroCurrentHealth;

        public int HeroCurrentHealth 
        { 
            get { return _heroCurrentHealth; }

            set { _heroCurrentHealth = value; }
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


        public void GetStats(int heroId)
        {
            Console.WriteLine($"\nYour knight {HeroName} has won XXXX batles.\n\nPulse any keyboard to return to STATISTICS menu.\n");
        }

        public void GetInventory(int heroId)
        {
           Console.WriteLine($"\nYour selected knight is \"{Game.GetHero(heroId).HeroName}\", his weapon is the \"{Game.GetWeapon(heroId).WeaponName}\", and he is equipped with the \"{Game.GetArmour(heroId).ArmourName}\" armour.\n");
        }


        public void EquipWeapon(Weapon weapon)
        {
            _equippedWeapon = weapon;
        }


        public void EquipArmour(Armour armour)
        {
            _equippedArmour = armour;
        }


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
