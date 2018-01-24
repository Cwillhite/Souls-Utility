using Foundation;
using System;
using UIKit;

namespace SoulsUtility
{
    public partial class DS1SummonCalcController : UIView
    {
        public DS1SummonCalcController (IntPtr handle) : base (handle)
        {
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