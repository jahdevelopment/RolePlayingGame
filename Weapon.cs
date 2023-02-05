using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingGame
{
    public class Weapon
    {
        private int _weaponId;

        public int WeaponId { get { return _weaponId; } }

                
        private string _weaponName;

        public string WeaponName { get { return _weaponName;} }


        private int _weaponPower;

        public int WeaponPower { get { return _weaponPower;} }

        

        public Weapon(int weaponId, string weaponName, int weaponPower)
        {
            _weaponId = weaponId;

            _weaponName = weaponName;

            _weaponPower = weaponPower;
        }
    }
}
