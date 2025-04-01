using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textRPGEX.Scenes
{
    internal class TownScene : Scene
    {


        public override void Render()
        {
            Console.WriteLine("사람들이 오다나는 마을이다.");
            Console.WriteLine("당신의 앞에선 탐스러운 사과를 팔고 있는 상인이 있다.");
            Console.WriteLine("그런데 저 앞에 보이는 첨탑에 수상한 사람이 보이는 것 같다.");
            Console.WriteLine("당신은 어떤 행동을 하시겠습니까?");
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("상인에게 접근합니다.");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("당신은 수상한 사람에 집중하고 있었습니다.");
                    Console.WriteLine("하지만 집중하는 동안 소매치기가 다가오는 것을 몰랐습니다.");
                    Console.WriteLine("당신이 집중하고 있는 틈을 타 소매치기가 당신을 찌르고 물건을 훔쳐갑니다.");
                    Console.WriteLine("당신의 시야가 서서히 흐려집니다.");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("필드로 나갑니다.");
                    break;
                default:
                    Console.WriteLine("잘못 입력하였습니다.");
                    break;
            }
        }

        public override void Choice()
        {
            Console.WriteLine("1. 상인에게 간다.");
            Console.WriteLine("2. 멀리있는 수상한 남성을 주시한다.");
            Console.WriteLine("3. 일단 파밍이지, 필드로 나간다.");
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
                case ConsoleKey.D1:
                    Game.ChangeScene("Shop");
                    break;
                case ConsoleKey.D2:
                    Game.GameOver(" 너무 높은 집중력...");
                    break;
            }
            
        }
    }
}
