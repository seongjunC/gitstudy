using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textRPGEX.Scenes
{
    internal class TitleScene : Scene
    {
        ConsoleKey inpyt
        public override void Input()
        {
            Input = Console.ReadKey(true).Key;
        }

        public override void Next()
        {
            throw new NotImplementedException();
        }

        public override void Render()
        {
            throw new NotImplementedException();
        }

        public override void Result()
        {
            throw new NotImplementedException();
        }

        public override void SelectChoice()
        {
            throw new NotImplementedException();
        }

        public override void Wait()
        {
            throw new NotImplementedException();
        }
    }
}
