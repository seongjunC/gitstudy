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
        // 게임에 필요한 기능들

        //1. 게임시작
        public static void Start()
        {
            // 게임 시작시에 필요한 작업들
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());

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
                
            }

        }
    }
}
