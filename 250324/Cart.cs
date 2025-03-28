using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250324
{
    public class Cart
    {
        public enum Stat{
            boostAcc, driftAcc, boostTime, boosterCharge, driftTime, protect, startBooster, draftAcc, driftAuto
        }
        public enum Rank
        {
            common, uncommon, rare, hero
        }


        string name;
        string rank;
        int gear;
        int[] maxOption;
        int[] nowOption;
        bool upgradeable;

        public Cart(string _name, Rank _rank = 0 )
        {
            name = _name;
            rank = _rank.ToString();
            switch (_rank)
            {
                case (Rank)0:
                    gear += 20;
                    upgradeable = true;
                    break;
                case (Rank)1:
                    gear += 30;
                    upgradeable = true;
                    break;
                case (Rank)2:
                    gear += 40;
                    upgradeable = true;
                    break;
                case (Rank)3:
                    gear += 50;
                    upgradeable = false;
                    break;
            }

            switch (_name)
            {
                case "저스티스":
                    maxOption = new int[9] { 6,6,7,6,10,10,10,10,5 };
                    nowOption = new int[9] { 1, 2, 2, 2, 2, 3, 2, 2, 1 };
                    break;
                case "스파이크":
                    maxOption = new int[9] { 7, 7, 5, 4, 12, 6, 12, 12, 3 };
                    nowOption = new int[9] { 3, 3, 1, 1, 5, 1, 3, 3, 0 };
                    break;
            }
        }

        public void SetStat(Stat stat, bool isUp) 
        {
            if(isUp && gear >= 3 && maxOption[(int)stat] > nowOption[(int)stat] )
            {
                nowOption[(int)stat] += 1;
                gear -= 3;
            }
            else if (nowOption[(int)stat]>0)
            {
                nowOption[(int)stat] -= 1;
                gear += 3;
            }
        }

        public int[] GetStat() {
            return nowOption;
        }

        public void UpgradeRank()
        {
            if (!upgradeable) return;
            if( rank == "common")
            {
                rank = "uncommon";
                gear += 10;
            }
            else if ( rank == "uncommon")
            {
                rank = "rare";
                gear += 10;
            }
            else if( rank == "rare")
            {
                rank = "hero";
                gear += 10;
                upgradeable = false;
            }
        }

    }
}
