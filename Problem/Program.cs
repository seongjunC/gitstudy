using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    internal class Program
    {
        //1번 문제
        //public static int FindKeyIndex(string text, char key)
        //{
        //    int i = 0;
        //    foreach (char c in text)
        //    {
        //        if (c == key)
        //        {
        //            return i;
        //        }
        //        i++;
        //    }
        //    return -1;
        //}
        //static void Main(string[] args)
        //{
        //    int index;
        //    index = FindKeyIndex("abcdef", 'd');
        //    Console.WriteLine(index);
        //    index = FindKeyIndex("Winner winner chicken dinner", 'c');
        //    Console.WriteLine(index);
        //    index = FindKeyIndex("Not your lucky day", 'p');
        //    Console.WriteLine(index);
        //}

        //2번 문제
        //public static bool IsPrime(int number)
        //{
        //    for (int i = 2; i < number; i++)
        //    {
        //        if (number % i == 0)
        //        {
        //            return false;
        //        }
        //    }
        //    if (number == 1)
        //    {
        //        return false;
        //    }
        //    return true;
        //}
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(IsPrime(7));
        //    Console.WriteLine(IsPrime(4));
        //    Console.WriteLine(IsPrime(1));
        //}

        //3번 문제
        //public static int SumOfDigits(int number)
        //{
        //    int sum = 0;
        //    while (number > 0)
        //    {
        //        sum += number % 10;
        //        number /= 10;
        //    }
        //    return sum;
        //}
        //static void Main(string[] args)
        //{
        //    int number = 1;
        //    Console.WriteLine(SumOfDigits(number));
        //}


        //4번 문제
        //public static int[] FindCommonItems(int[] array1, int[] array2)
        //{
        //    int[] result = new int[0];
        //    foreach (int num1 in array1)
        //    {
        //        foreach (int num2 in array2)
        //        {
        //            if (num1 == num2)
        //            {
        //                bool isIn = false;
        //                for (int i = 0; i < result.Length; i++)
        //                {
        //                    if (result[i] == num1)
        //                    {
        //                        isIn = true;
        //                    }
        //                }
        //                if (!isIn)
        //                {
        //                    Array.Resize(ref result, result.Length + 1);
        //                    result[result.Length - 1] = num1;
        //                };
        //            }
        //        }
        //    }
        //    return result;
        //}

        //static void Main(string[] args)
        //{
        //    int[] array1 = { 5, 6, 7, 8 };
        //    int[] array2 = { 1, 2, 3, 4 };
        //    int[] array = FindCommonItems(array1, array2);
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (i == 0)
        //        {
        //            Console.Write("{ ");
        //        }
        //        Console.Write(array[i]);
        //        if (i != array.Length - 1)
        //        {
        //            Console.Write(", ");
        //        }
        //        else
        //        {
        //            Console.Write(" }");
        //        }

        //    }
        //}


        //5번 문제
        //public static int FindClosestNumber(int[] array, int number)
        //{
        //    int minNum = Math.Abs(array[0] - number + 1);
        //    foreach (int num in array)
        //    {
        //        if (minNum > num - number)
        //        {
        //            minNum = num;
        //        }
        //    }

        //    return minNum;
        //}

        //static void Main(string[] args)
        //{
        //    int[] arrayInput = { 10, 11, 12 };
        //    int number = 12;
        //    Console.WriteLine(FindClosestNumber(arrayInput, number));

        //}


        //6번 문제
        //public static int FindModeNumber(int[] array)
        //{
        //    Array.Sort(array);
        //    int numCount = 1;
        //    int beforeNum = array[0] - 1;
        //    int maxMode = 0;
        //    int modeCount = 0;
        //    foreach (int i in array)
        //    {
        //        if (i == beforeNum)
        //        {
        //            numCount++;
        //        }
        //        else
        //        {
        //            if (modeCount == 0)
        //            {
        //                maxMode = i;
        //                modeCount = 1;
        //            }
        //            if (modeCount < numCount)
        //            {
        //                maxMode = beforeNum;
        //                modeCount = numCount;
        //            }
        //            numCount = 1;
        //            beforeNum = i;
        //        }

        //        if (i == array[array.Length - 1])
        //        {
        //            if (modeCount < numCount)
        //            {
        //                maxMode = beforeNum;
        //                modeCount = numCount;
        //            }
        //        }

        //    }
        //    return maxMode;
        //}
        //static void Main(string[] args)
        //{
        //    int[] arrayInput = { 1, 1, 2, 2, 3, 3, 3 };
        //    Console.WriteLine(FindModeNumber(arrayInput));
        //}


        //7번 문제
        //static void Main(string[] args)
        //{
        //    Random random = new Random();
        //    int[] randNum = new int[4];
        //    for (int i = 0; i < 4; i++)
        //    {

        //        int rand = random.Next(10);
        //        if (randNum.Contains(rand))
        //        {
        //            while (randNum.Contains(rand))
        //            {
        //                rand = random.Next(10);
        //            }
        //        }
        //        randNum[i] = rand;
        //        Console.WriteLine(randNum[i]);
        //    }
        //    int life = 10;
        //    while (life > 0)
        //    {
        //        Console.WriteLine($"============{11 - life}번째 기회===========");
        //        Console.Write("숫자를 입력하세요 : ");
        //        int inputNum = int.Parse(Console.ReadLine());
        //        int ball = 0;
        //        int strike = 0;
        //        for (int i = 0; i < 4; i++)
        //        {
        //            if (inputNum % 10 == randNum[3 - i])
        //            {
        //                strike++;
        //            }
        //            else if (randNum.Contains(inputNum % 10))
        //            {
        //                ball++;
        //            }
        //            inputNum /= 10;
        //        }
        //        if (strike == 4)
        //        {
        //            Console.WriteLine("Home Run!");
        //            Console.WriteLine("승리했습니다!");
        //            break;
        //        }
        //        else if (strike == 0 && ball == 0)
        //        {
        //            Console.WriteLine("OUT!");
        //            life--;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Strike : {0}, Ball : {1}", strike, ball);
        //            life--;
        //        }
        //    }
        //    if( life == 0){
        //        Console.WriteLine("game Over...");
        //    }

        //}


        //8번 문제
        struct Item
        {
            public string name;
            public string description;
            public int price;
            public Type type;
            public int value;
            public string effect;
        }
        enum Type
        {
            weapon, armor, accessory
        }
        struct Player
        {
            public int gold;
            public int attack;
            public int defence;
            public int health;
            public Inventory inventory;
        }
        struct Inventory
        {
            public Item[] items;
        }
        static void Main(string[] args)
        {
            Inventory things = new Inventory();
            Player player = new Player();
            SetPlayer(ref player);
            SetItem(ref things);
            int num = 0;
            while (true)
            {
                Render(ref num, ref things, ref player);
            }
        }
        static void SetPlayer(ref Player player) {
            player.gold = 10000;
            player.attack = 15;
            player.defence = 15;
            player.health = 400;
            player.inventory = new Inventory();
        }

        static void SetItem(ref Inventory things)
        {
            things.items = new Item[3];
            SetInventory(ref things.items[0], "롱소드", "기본적인 검이다.", 15, Type.weapon, 450);
            SetInventory(ref things.items[1], "천갑옷", "얇은 갑옷이다.", 10, Type.armor, 450);
            SetInventory(ref things.items[2], "여신의 눈물", "희미하게 푸른 빛을 품고 있는 보석이다.", 300, Type.accessory, 800);
        }

        static void SetInventory(ref Item item, string name, string description, int value, Type type , int price)
        {
            item.name = name;
            item.description = description;
            item.value = value;
            item.type = type;
            item.price = price; 
            if (item.type == Type.weapon)
            {
                item.effect = "공격력";
            }
            else if (item.type == Type.armor)
            {
                item.effect = "방어력";
            }
            else if (item.type == Type.accessory)
            {
                item.effect = "체력";
            }
        }
        static void Render(ref int num, ref Inventory things, ref Player player)
        {
            if (num == 0)
            {
                num = RevealMenu();
                return;
            }
            else if (num == 1)
            {
                num = RevealShop(ref things, ref player);
                return;
            }
            else if (num == 2)
            {
                num = RevealShopSell(ref things, ref player);
                return;
            }
            else if(num == 3)
            {
                SearchItem(player);
                num = 0;
                return;
            }
        }
        static int RevealMenu()
        {
            Console.WriteLine("\n*********************************");
            Console.WriteLine("********* 아이템 상점 ***********");
            Console.WriteLine("*********************************");
            Console.WriteLine();
            Console.WriteLine("========== 상점  메뉴  ==========");
            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("2. 아이템 판매");
            Console.WriteLine("3. 아이템 확인");
            Console.Write("메뉴를 선택하세요 : ");
            return int.Parse(Console.ReadLine());
        }
        static int RevealShop(ref Inventory things, ref Player player )
        {
            Console.WriteLine("\n========== 아이템 구매 ===========");
            Console.WriteLine($"보유한 골드 : {player.gold}");
            if (player.inventory.items != null && player.inventory.items.Length == 6)
            {
                Console.WriteLine();
                Console.WriteLine("플레이어의 인벤토리가 꽉 찼습니다.");
                Console.WriteLine("메뉴로 돌아갑니다.\n");
                return 0;
            }
            for (int i = 0; i < things.items.Length; i++)
            {
                Console.WriteLine($"{i + 1,3}. {things.items[i].name}");
                Console.WriteLine($"   가격 : {things.items[i].price}G");
                Console.WriteLine($"   설명 : {things.items[i].description}");
                Console.WriteLine($"   {things.items[i].effect} 상승 : {things.items[i].value}");
                Console.WriteLine();
            }
            Console.Write("구매할 아이템을 선택하세요 (취소 0 ) : ");
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if(key == 0)
            {
                return 0;
            }
            UpdatePlayer(ref player, key, ref things, true);
            Item buyItem = things.items[key-1];
            Console.WriteLine($"{buyItem.name}를 구매합니다.");
            if(buyItem.effect == "공격력")
            {
                Console.WriteLine($"플레이어의 공격력이 {buyItem.value} 상승하여 {player.attack}이 됩니다.");
            }
            else if(buyItem.effect == "방어력")
            {
                Console.WriteLine($"플레이어의 방어력이 {buyItem.value} 상승하여 {player.defence}이 됩니다.");
            }
            else if (buyItem.effect == "체력")
            {
                Console.WriteLine($"플레이어의 체력이 {buyItem.value} 상승하여 {player.health}이 됩니다.");
            }
            Console.WriteLine($"보유한 골드가 {buyItem.price}G 감소하여 {player.gold}G가 됩니다.");
            return 0;
        }

        static int RevealShopSell(ref Inventory things, ref Player player)
        {
            Console.WriteLine("\n========== 아이템 판매 ===========");
            if(player.inventory.items == null || player.inventory.items.Length == 0)
            {
                Console.WriteLine();
                Console.WriteLine("플레이어의 아이템이 없습니다.");
                Console.WriteLine("메뉴로 돌아갑니다.\n");
                return 0;
            }
    
            for (int i = 0; i < player.inventory.items.Length; i++)
            {
                Console.WriteLine($"{i + 1,3}. {player.inventory.items[i].name}");
                Console.WriteLine($"   가격 : {player.inventory.items[i].price}G");
                Console.WriteLine($"   설명 : {player.inventory.items[i].description}");
                Console.WriteLine($"   {player.inventory.items[i].effect} 상승 : {player.inventory.items[i].value}");
                Console.WriteLine();
            }
            Console.Write("판매할 아이템을 선택하세요 (취소 0 ) : ");
            int key = int.Parse(Console.ReadLine());
            if (key == 0)
            {
                return 0;
            }
            Item sellItem = player.inventory.items[key - 1];
            UpdatePlayer(ref player, key, ref things, false);           
            Console.WriteLine($"{sellItem.name}를 판매합니다.");
            if (sellItem.effect == "공격력")
            {
                Console.WriteLine($"플레이어의 {sellItem.effect}이 {sellItem.value} 감소하여 {player.attack}이 됩니다.");
            }
            else if (sellItem.effect == "방어력")
            {
                Console.WriteLine($"플레이어의 {sellItem.effect}이 {sellItem.value} 감소하여 {player.defence}이 됩니다.");
            }
            else if (sellItem.effect == "체력")
            {
                Console.WriteLine($"플레이어의 {sellItem.effect}이 {sellItem.value} 감소하여 {player.health}이 됩니다.");
            }
            Console.WriteLine($"보유한 골드가 {sellItem.price}G 상승하여 {player.gold}G가 됩니다.");
            return 0;
        }


        static void UpdatePlayer(ref Player player, int key, ref Inventory things, bool isBuy)
        {
            Item updateItem;
            if (!isBuy)
            {
                updateItem = player.inventory.items[key - 1];
            }
            else
            {
                updateItem = things.items[key-1] ;
                if (player.gold < updateItem.price)
                {
                    Console.WriteLine("플레이어의 골드가 부족합니다.");
                    return;
                }
            }
            
            string upEffect = updateItem.effect;
            if ( upEffect == "공격력")
            {
                if (isBuy)
                {
                    player.attack += updateItem.value;
                    player.gold -= updateItem.price;
                    UpdateInventory(ref player, updateItem);
                }
                else
                {
                    player.attack -= updateItem.value;
                    player.gold += updateItem.price;
                    DivideInventory(ref player, key);
                }
            }
            else if (upEffect == "방어력")
            {
                if (isBuy)
                {
                    player.defence += updateItem.value;
                    player.gold -= updateItem.price;
                    UpdateInventory(ref player, updateItem);
                }
                else
                {
                    player.defence -= updateItem.value;
                    player.gold += updateItem.price;
                    DivideInventory(ref player, key);
                }
            }
            else if(upEffect == "체력")
            {
                if (isBuy)
                {
                    player.health += updateItem.value;
                    player.gold -= updateItem.price;
                    UpdateInventory(ref player, updateItem);
                }
                else
                {
                    player.health -= updateItem.value;
                    player.gold += updateItem.price;
                    DivideInventory(ref player, key);
                }
            }
        }
        static void UpdateInventory(ref Player player, Item updateItem)
        {
            if (player.inventory.items == null)
            {
                player.inventory.items = new Item[1] { updateItem };
            }
            else {
                Array.Resize(ref player.inventory.items, player.inventory.items.Length + 1);
                player.inventory.items[player.inventory.items.Length-1] = updateItem;
            }
        }
        static void DivideInventory(ref Player player, int key)
        {
            for(int i = key; i<player.inventory.items.Length -1; i++)
            {
                player.inventory.items[i] = player.inventory.items[i + 1];   
            } 
            Array.Resize(ref player.inventory.items, player.inventory.items.Length -1);
        }

        static void SearchItem(Player player)
        {
            Console.WriteLine("\n========== 아이템 확인 ===========");
            Console.WriteLine($"플레이어   골드 보유량 : {player.gold}G");
            Console.WriteLine($"플레이어 공격력 상승량 : {player.attack-15}");
            Console.WriteLine($"플레이어 방어력 상승량 : {player.defence-15}");
            Console.WriteLine($"플레이어   체력 상승량 : {player.health-400}");
            if (player.inventory.items == null || player.inventory.items.Length == 0)
            {
                Console.WriteLine();
                Console.WriteLine("플레이어의 아이템이 없습니다.");
                Console.WriteLine("메뉴로 돌아갑니다.\n");
                return;
            }
            for (int i = 0; i < player.inventory.items.Length; i++)
            {
                Console.WriteLine($"{i + 1,3}. {player.inventory.items[i].name}");
                Console.WriteLine($"   가격 : {player.inventory.items[i].price}G");
                Console.WriteLine($"   설명 : {player.inventory.items[i].description}");
                Console.WriteLine($"   {player.inventory.items[i].effect} 상승 : {player.inventory.items[i].value}");
                Console.WriteLine();
            }
            Console.Write("계속하려면 아무키나 입력하세요 : ");
            Console.ReadKey(true);
        }
    }
}
