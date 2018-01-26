using System;

using UIKit;

namespace SoulsUtility
{
    public partial class FirstViewController : UIViewController
    {
        DS1SummonCalcController v;

        protected FirstViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            v = DS1SummonCalcController.Create();
            v.Frame = View.Frame;
            View.AddSubview(v);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
