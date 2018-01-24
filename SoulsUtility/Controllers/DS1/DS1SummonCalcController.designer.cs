// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace SoulsUtility
{
    [Register ("DS1SummonCalcController")]
    partial class DS1SummonCalcController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Calc { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField LevelInput { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ResultLabel { get; set; }

        [Action ("Calc_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Calc_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (Calc != null) {
                Calc.Dispose ();
                Calc = null;
            }

            if (LevelInput != null) {
                LevelInput.Dispose ();
                LevelInput = null;
            }

            if (ResultLabel != null) {
                ResultLabel.Dispose ();
                ResultLabel = null;
            }
        }
    }
}