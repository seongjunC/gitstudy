using System;

namespace _250325
{
    public class Trainer
    {
        string name;
        private Pokemon[] pokemons;
        Pokemon field;

        public Trainer(string playername,Pokemon[] _pokemons)
        {
            this.name = playername;
            pokemons = new Pokemon[_pokemons.Length];
            pokemons = _pokemons;
        }
        public void Peek(int index)
        {
            field = pokemons[index];
        }

        public void Print()
        {
            Console.Write("{0}의 포켓몬 : ",this.name);
            for (int i = 0; i < pokemons.Length; i++)
            {
                Peek(i);
                field.PrintPokemon();
            }
            Console.WriteLine();
        }
        public void Attack(int index)
        {
            Peek(index);
            field.Attack();
        }
    }
    public abstract class Pokemon
    {
        public string name;
        protected string move;
        public Pokemon(string _name, string _move)
        {
            name = _name;
            move = _move;
        }

        public abstract void Attack();

        public virtual void PrintPokemon()
        {
            Console.Write("{0} ",this.name);
        }
    }

    public class Pikachuu : Pokemon
    {

        public Pikachuu() : base("피카츄", "백만볼트")
        {

        }

        public override void Attack()
        {
            Console.WriteLine($"{base.name}이 {base.move}로 공격했다! ");
        }
    }
    public class CleFairy : Pokemon
    {
        public CleFairy() : base("삐삐", "손가락흔들기")
        {

        }

        public override void Attack()
        {
            Console.WriteLine($"{base.name}이 {base.move}로 공격했다! ");
        }
    }
    public class TapuLele : Pokemon
    {
        public TapuLele() : base("카푸나비나", "사이코키네시스")
        {

        }

        public override void Attack()
        {
            Console.WriteLine($"{base.name}이 {base.move}로 공격했다! ");
        }
    }

    public class Alcremie : Pokemon
    {
        public Alcremie() : base("마휘핑", "매지컬샤인")
        {

        }

        public override void Attack()
        {
            Console.WriteLine($"{base.name}이 {base.move}으로 공격했다! ");
        }
    }

    public class Milotic : Pokemon
    {
        public Milotic() : base("밀로틱", "하이드로펌프")
        {

        }

        public override void Attack()
        {
            Console.WriteLine($"{base.name}이 {base.move}로 공격했다! ");
        }
    }

    public class Aegislash : Pokemon
    {
        public Aegislash() : base("킬가르도", "철제광선")
        {

        }

        public override void Attack()
        {
            Console.WriteLine($"{base.name}이 {base.move}으로 공격했다! ");
        }
    }

    public class Roserade : Pokemon
    {
        public Roserade() : base("로즈레이드", "에너지볼")
        {

        }

        public override void Attack()
        {
            Console.WriteLine($"{base.name}이 {base.move}로 공격했다! ");
        }
    }

    public class Garchomp : Pokemon
    {
        public Garchomp() : base("한카리아스", "지진")
        {

        }

        public override void Attack()
        {
            Console.WriteLine($"{base.name}이 {base.move}으로 공격했다! ");
        }
    }

    public class Lucario : Pokemon
    {
        public Lucario() : base("루카리오", "파동탄")
        {

        }

        public override void Attack()
        {
            Console.WriteLine($"{base.name}이 {base.move}으로 공격했다! ");
        }
    }

    public class Togekiss : Pokemon
    {
        public Togekiss() : base("토게키스", "물의파동")
        {

        }

        public override void Attack()
        {
            Console.WriteLine($"{base.name}이 {base.move}으로 공격했다! ");
        }
    }

    public class Spiritomb : Pokemon
    {
        public Spiritomb() : base("화강돌", "섀도볼")
        {

        }

        public override void Attack()
        {
            Console.WriteLine($"{base.name}이 {base.move}으로 공격했다! ");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {


            Pokemon[] pokemonP1 = {
            new Pikachuu(),
            new CleFairy(),
            new TapuLele(),
            new Alcremie(),
            new Milotic(),
            new Aegislash()
            };

            Pokemon[] pokemonP2 =
            {
                new Garchomp(),
                new Spiritomb(),
                new Milotic(),
                new Roserade(),
                new Lucario(),
                new Togekiss()
            };

            Trainer Player1 = new Trainer("player1", pokemonP1);
            Player1.Print();
            Player1.Attack(5);

            Console.WriteLine();

            Trainer Player2 = new Trainer("player2", pokemonP2);
            Player2.Print();
            for (int i = 0; i < 6; i++)
            {
                Player2.Attack(i);
            }
        }

    }
}
