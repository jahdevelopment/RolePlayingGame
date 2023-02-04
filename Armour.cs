using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingGame
{
    public class Armour
    {
        private int _armourId;

        public int ArmourId { get { return _armourId; } }

                
        private string _armourName; 

        public string ArmourName { get { return _armourName; } }


        private int _armourPower;

        public int ArmourPower { get { return _armourPower; } }


        public Armour(int armourId, string armourName, int armourPower) 
        {
            _armourId = armourId;

            _armourName = armourName;

            _armourPower = armourPower;
        }
    }
}
