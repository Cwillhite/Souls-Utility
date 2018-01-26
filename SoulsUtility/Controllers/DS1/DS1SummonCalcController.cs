using Foundation;
using System;
using UIKit;
using System.CodeDom.Compiler;
using ObjCRuntime;

namespace SoulsUtility
{
    public partial class DS1SummonCalcController : UIView
    {
        public DS1SummonCalcController (IntPtr handle) : base (handle)
        {
        }

        public static DS1SummonCalcController Create()
        {

            var arr = NSBundle.MainBundle.LoadNib("DS1SummonCalc", null, null);
            var v = Runtime.GetNSObject<DS1SummonCalcController>(arr.ValueAt(0));

            return v;
        }

        partial void Calc_TouchUpInside(UIButton sender)
        {
            int level = int.Parse(LevelInput.Text);
            decimal range = 10 + Decimal.Floor((decimal)(.1 * level));
            int rangeBegin = level - (int)range;
            int rangeMax = level + (int)range;

            ResultLabel.Text = String.Format("Your summon range is {0}-{1}", rangeBegin, rangeMax);
        }
    }
}