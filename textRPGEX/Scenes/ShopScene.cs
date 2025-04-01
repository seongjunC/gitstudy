using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textRPGEX.Scenes
{
    internal class ShopScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("\"어서오세요\"");
            Console.WriteLine("\"좋은 물건이 많습니다~ \"");
            Console.WriteLine("어떤 것을 찾고 계십니까?");
        }

        public override void Choice()
        {
            Console.WriteLine("1. 수상한 구슬을 산다.");
            Console.WriteLine("2. 신발을 구매한다.");
            Console.WriteLine("3. 상인을 위협한다.");
            Console.WriteLine("4. 마을로 돌아갑니다.");
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D2:
                    Console.WriteLine("당신은 발걸음이 빨라진 것을 느낍니다.");
                    Console.WriteLine("이걸로 더욱 많은 곳을 다닐 수 있겠지요...");
                    Game.Player.Speed += 3;
                    Console.WriteLine("플레이어 스탯 상승! 속도 : {0}", Game.Player.Speed);
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("당신의 위협을 본 상인은 총을 꺼내들었습니다.");
                    Console.WriteLine("당신은 그것을 보자 몸을 틀었지만 직격으로 맞았습니다.");
                    Console.WriteLine("당신의 시야가 서서히 흐려집니다...");
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("당신은 마을로 돌아갑니다.");
                    break;
                default:
                    Console.WriteLine("잘못 입력하였습니다.");
                    break;
            }
        }

        public override void Wait()
        {
            Console.WriteLine("계속하려면 아무키나 눌러주세요...");
            Console.ReadKey();
        }

        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D3:
                    Game.GameOver("위협할 상대를 잘못 찾았다...");
                    break;
                case ConsoleKey.D4:
                    Game.ChangeScene("Town");
                    break;
                default:
                    Console.WriteLine("잘못 입력하였습니다.");
                    break;
            }
        }


    }
}
