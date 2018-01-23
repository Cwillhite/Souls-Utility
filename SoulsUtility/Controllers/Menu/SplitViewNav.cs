using System;
using Foundation;

namespace SoulsUtility.Controllers.Menu
{   
    [Register("SplitViewNav")]
    partial class SplitViewNav: UIKit.UISplitViewController
    {
        protected SplitViewNav(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
