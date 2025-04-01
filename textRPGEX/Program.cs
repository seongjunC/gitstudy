using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textRPGEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game.Start();
            Game.Run();
            Game.End();
        }
    }
}
