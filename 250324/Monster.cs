using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250324
{
    internal class Monster
    {
        int level;
        string name;

        public Monster(int _level, string _name)
        {
            level = _level;
            name = _name;
        }

        public string Print()
        {
            return ($"{name} , {level}레벨");
        }
    }
}
