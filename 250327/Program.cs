using System;

namespace _250327
{


    internal class Program
    {
        public class Player
        {
            public Armor armor;
            private int hp { get; set; }
            private int defense { get; set; }
            public event Action OnTakeDamaged;

            public Player() {
                hp = 100;
                defense = 10;
            }


            public void TakeDamage(int damage)
            {
                int totalDamage = defense > damage ? 0 : damage - defense;
                hp -= totalDamage;

                OnTakeDamaged?.Invoke();
                armor.OnBreaked += TakeOff;
            }

            public void TakeOff()
            {
                if (armor != null)
                {
                    defense -= armor.Defense;
                    this.armor = null;

                    OnTakeDamaged -= armor.TakeDamage;

                    defense -= armor.Defense;
                    this.armor = null;

                }
            }
            public void Equip(Armor armor)
            {
                this.armor = armor;
                defense += armor.Defense;

                OnTakeDamaged += armor.TakeDamage;

            }
        }

        public class Armor
        {
            private int durability = 3;
            private int defense = 10;
            public int Defense { get { return defense; } set { defense = value; } }

            public event Action OnBreaked;

            public void TakeDamage()
            {
                durability -= 1;
                if (durability <= 0)
                {
                    Break();
                }
            }

            private void Break()
            {
                OnBreaked?.Invoke();
            }




        }


        static void Main(string[] args)
        {
            Player player = new Player();
            player.ArmorRate -= 1;
        }
                        
    }




} 

    

