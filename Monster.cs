using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayingGame
{
    public class Monster
    {
        private int _monsterId;

        public int MonsterId { get { return _monsterId; } }


        
        private string _monsterName;

        public string MonsterName { get { return _monsterName; } }



        private int _monsterBaseStrength;

        public int MonsterBaseStrength { get { return _monsterBaseStrength; } }



        private int _monsterBaseDefense;

        public int MonsterBaseDefense { get { return _monsterBaseDefense; } }



        private int _monsterOriginalHealth;

        public int MonsterOriginalHealth { get { return _monsterOriginalHealth; } }



        private int _monsterCurrentHealth;

        public int MonsterCurrentHealth { get { return _monsterCurrentHealth; } }


        public Monster(int monsterId, string monsterName, int monsterBaseStrength, int monsterBaseDefense, int monsterOriginalHealth, int monsterCurrentHealth)
        {
            _monsterId = monsterId;

            _monsterName = monsterName;

            _monsterBaseStrength = monsterBaseStrength;

            _monsterBaseDefense = monsterBaseDefense;

            _monsterOriginalHealth = monsterOriginalHealth;

            _monsterCurrentHealth = monsterCurrentHealth;
        }
    }
}
