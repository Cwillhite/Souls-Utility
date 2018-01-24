using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace SoulsUtility
{
    public partial class DS2SummonCalcController : UIView
    {
        
        //ItemUsed;
        static List<item> items = new List<item>;

  
        //tool = items[0];
        static int min = 0;
        static int minring = 0;
        static int max = 10000;
        static int maxring = 40000;
        static List<int> tier = new List<int>();

        public DS2SummonCalcController (IntPtr handle) : base (handle)
        {
            items.Add(new item("White Sign Soapstone", 1, 3, true));
            items.Add(new item("Small White Sign Soapstone", 2, 4, true));
            items.Add(new item("Cracked Red Eye Orb", 4, 0, false));
            items.Add(new item("Cracked Blue Eye Orb", 3, 3, false));
            items.Add(new item("Dragon Eye", 5, 5, false));
            items.Add(new item("Crest of the Rat", 1, 3, false));
            items.Add(new item("Bell Keeper's Seal", 3, 1, false));
            items.Add(new item("Gaurdain's Seal", 4, 5, false));
            items.Add(new item("Red Sign Soapstone", 2, 5, false));

            tier.Add(0);
            tier.Add(10000);
            tier.Add(20000);
            tier.Add(30000);
            tier.Add(40000);
            tier.Add(50000);
            tier.Add(70000);
            tier.Add(90000);
            tier.Add(110000);
            tier.Add(130000);
            tier.Add(150000);
            tier.Add(180000);
            tier.Add(210000);
            tier.Add(240000);
            tier.Add(270000);
            tier.Add(300000);
            tier.Add(350000);
            tier.Add(400000);
            tier.Add(450000);
            tier.Add(500000);
            tier.Add(600000);
            tier.Add(700000);
            tier.Add(800000);
            tier.Add(900000);
            tier.Add(1000000);
            tier.Add(1100000);
            tier.Add(1200000);
            tier.Add(1300000);
            tier.Add(1400000);
            tier.Add(1500000);
            tier.Add(1750000);
            tier.Add(2000000);
            tier.Add(2250000);
            tier.Add(2500000);
            tier.Add(2750000);
            tier.Add(3000000);
            tier.Add(5000000);
            tier.Add(7000000);
            tier.Add(9000000);
            tier.Add(12000000);
            tier.Add(15000000);
            tier.Add(20000000);
        }

        partial void Calc_TouchUpInside(UIButton sender)
        {
            int level = int.Parse(LevelInput.Text);
            min = 0;
            minring = 0;
            max = 10000;
            maxring = 40000;

            //ds2calculate(level,items.Find(ItemUsed.Selected));
        }

        public static void ds2calculate(int ds2Mem,item tool)
        {
            var tierIndex = -1;
            for (var i = 0; i < tier.Count && tierIndex < 0; i++)
            {
                if (tier[i] <= ds2Mem && ds2Mem < tier[i + 1])
                {
                    tierIndex = i;
                }
            }

            var tiersMin = tierIndex - tool.getTierDown();
            if (tiersMin < 0)
            {
                min = 0;
                minring = 0;
            }
            else if (tiersMin < 0)
            {
                minring = 0;
            }
            else
            {
                min = tier[tiersMin];
                minring = tier[tiersMin - 3];
            }

            var tiersMax = tierIndex + tool.getTierUp() + 1;
            if (tiersMax > tier.Count)
            {
                //max = "999999999+";
                //maxring = "999999999+";
            }
            else if (tiersMax + 3 > tier.Count)
            {
                //maxring = "999999999+";
            }
            else
            {
                max = tier[tiersMax];
                maxring = tier[tiersMax + 3];
            }

    }

    public class item {
            bool ring;
            int tierUp;
            int tierDown;
            string itemName; 
        public item(string name, int down, int up, bool ring){
            this.itemName = name;
                this.tierUp = up;
            this.tierDown = down;
            this.ring = ring;
        }

            public string getItemName(){
                return this.itemName;
            }

            public int getTierUp()
            {
                return this.tierUp;
            }

            public int getTierDown()
            {
                return this.tierDown;
            }

            public bool getRing()
            {
                return this.ring;
            }
    }
}