using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250324
{
    public class Trainer
    {
        string name;
        Monster[] coworker= new Monster[0];

        public Trainer(string _name)
        {
            name = _name;
        }

        public void Add( Monster monster)
        {
            int monNum = coworker.Length;
            if (monNum < 6)
            {
                Array.Resize(ref coworker, monNum + 1);
                coworker[monNum - 1] = monster;
            }
            else
            {
                Console.WriteLine("몬스터는 6마리 이상 데리고 다닐 수 없어!");
            }
        }
        public void Remove(Monster monster)
        {
            if (coworker.Contains(monster))
            {
                int index = Array.IndexOf(coworker, monster);
                if (index == coworker.Length - 1)
                {
                    Array.Resize(ref coworker, index);
                }
                else
                {
                    for (int i = index; i < coworker.Length - 1; i++)
                    {
                        coworker[i] = coworker[i + 1];
                    }
                }
            }
        }

        public void PrintAll()
        {
            foreach (Monster monster in coworker)
            {
                Console.WriteLine($"Monster {monster.Print()} ");
            }
        }
    }
    public class Monster
    {
        int monsterLevel;
        string monsterName;

        public Monster(int _level, string _name)
        {
            monsterLevel = _level;
            monsterName = _name;
        }

        public string Print()
        {
            return ($"{monsterName} , {monsterLevel}레벨");
        }
    }
}
