using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textRPGEX.Scenes
{
    internal class TitleScene : Scene
    {


        public override void Render()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("*      TEXT RPG         *");
            Console.WriteLine("*************************");
            Console.WriteLine();
        }

        public override void Result()
        {
            throw new NotImplementedException();
        }

        public override void Choice()
        {
            Console.WriteLine("1. 게임 시작");
            Console.WriteLine("2. 불러오기");// TODO : 불러오기 구현
            Console.WriteLine("3. 게임 종료");
        }

        public override void Wait()
        {
            throw new NotImplementedException();
        }
        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("Town");
                    break;
            }
        }

    }
}
