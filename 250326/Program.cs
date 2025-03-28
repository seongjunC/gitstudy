using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _250326
{
    public interface Iinteractable
    {
        void Interact();
    }
    public interface IOpenable
    {
        void Open();
    }
    public interface IPickable
    {
        void Pick();
    }
    public interface ITalkable
    {
        void Talk();
    }
    public class Utils
    {
        public static void KeyDown(ConsoleKey key, Iinteractable interactable)
        {
            if( key == ConsoleKey.G)
            {
                if ( interactable is IOpenable)
                {
                    IOpenable Openable = (IOpenable)interactable;
                    Openable.Open();
                    Console.WriteLine();
                }
                else if (interactable is IPickable)
                {
                    IPickable pickable = (IPickable)interactable;
                    pickable.Pick();
                    Console.WriteLine();
                }
                else if ( interactable is ITalkable)
                {
                    ITalkable talkable = (ITalkable)interactable;
                    talkable.Talk();
                    Console.WriteLine();
                }
                else
                {
                    interactable.Interact();
                    Console.WriteLine();
                }

            }
        }
    }
    public class Door : Iinteractable, IOpenable
    {
        bool isOpen;
        public Door()
        {
            isOpen = false;
        }
        public void Open()
        {
            isOpen = true;
            Console.WriteLine("문이 열립니다.");
        }
        public void Close()
        {
            isOpen = false;
            Console.WriteLine("문이 닫힙니다.");
        }

        public void Interact()
        {
            if (isOpen)
            {
                Close();
            }
            else
            {
                Open();
            }
        }
    }
    public class NPC : ITalkable, Iinteractable
    {
        public virtual void Talk()
        {
            Console.WriteLine("안녕하세요! 모험가님");
        }
        public void Interact()
        {
            Console.WriteLine("당신은 NPC에게 말을 건다");
            Talk();
        }
    }
    public class Merchant : NPC
    {
        public override void Talk()
        {
            Console.WriteLine("나와 거래를 하러 온건가");
            Shop();
        }
        public void Shop()
        {
            Console.WriteLine("---------  상점창 ---------  " );
        }
    }

    public class Mokoko : Iinteractable, IPickable
    {
        public void Interact()
        {
            Pick();
        }
        public void Pick()
        {
            Console.WriteLine("기분좋은 향기가 솔솔 피어난다.");
        }
    }

    public class ViewPoint : Iinteractable
    {
        public void Interact()
        {
            Console.WriteLine("보기만 해도 기분이 상쾌해지는 풍경이 보인다.");
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            NPC Merchant = new Merchant();
            NPC npc = new NPC();
            Mokoko mokoko = new Mokoko();
            Door door = new Door();
            ViewPoint viewpoint = new ViewPoint();

            Utils.KeyDown(ConsoleKey.G, npc);
            Utils.KeyDown(ConsoleKey.G, Merchant);
            Utils.KeyDown(ConsoleKey.G, mokoko);
            Utils.KeyDown(ConsoleKey.G, door);
            Utils.KeyDown(ConsoleKey.G, viewpoint);

        }
    }
}
