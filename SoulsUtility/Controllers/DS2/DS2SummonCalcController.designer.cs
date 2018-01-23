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
    [Register ("DS2SummonCalcController")]
    partial class DS2SummonCalcController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView Calc { get; set; }

        [Action ("Calc_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Calc_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (Calc != null) {
                Calc.Dispose ();
                Calc = null;
            }

            if (Calc != null) {
                Calc.Dispose ();
                Calc = null;
            }
        }
    }
}