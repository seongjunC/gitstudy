using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using textRPGEX.Scenes;

namespace textRPGEX
{
    public static class Game
    {
        // 게임에 필요한 정보들
        private static bool gameOver;
        private static Dictionary<string, Scene> sceneDic;
        private static Scene curScene;

        private static Player player;
        public static Player Player { get { return player; } }

        // 게임에 필요한 기능들

        //1. 게임시작
        public static void Start()
        {
            // 게임 시작시에 필요한 작업들
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Town", new TownScene());
            sceneDic.Add("Shop", new ShopScene());

            curScene = sceneDic["Title"] ;
        }

        // 2. 게임종료
        public static void End()
        { 
        
        }
        // 3. 게임 동작 
        public static void Run()
        {
            while (!gameOver) {
                curScene.Render();
                Console.WriteLine();
                curScene.Choice();
                curScene.Input();
                Console.WriteLine();
                curScene.Result();
                Console.WriteLine();
                curScene.Wait();
                curScene.Next();
            }

        }
        public static void ChangeScene(string scenename)
        {
            curScene = sceneDic[scenename];
        }
        public static void GameOver(string reason)
        {
            Console.Clear();
            Console.WriteLine("*************************");
            Console.WriteLine("*      GAME OVER        *");
            Console.WriteLine("*************************");
            Console.WriteLine();
            Console.WriteLine(reason);

            gameOver = true;
        }
        public static void PrintInfo()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("플레이어");
            Console.WriteLine(" 힘 : {0}\t 속도 : {1}", player.Power, player.Speed);
            Console.WriteLine("*************************");
            Console.WriteLine();
        }
    }
}
