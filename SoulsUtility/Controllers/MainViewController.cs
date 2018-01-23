using System;
using UIKit;
using Foundation;

namespace SoulsUtility.Controllers
{
    [Register("MainViewController")]
    public partial class MainViewController : UIViewController
    {
        //UIViewController pinkViewController;

        public MainViewController(IntPtr handle) : base(handle)
        {

        }

        public override void AwakeFromNib()
        {
            // Called when loaded from xib or storyboard.

            this.Initialize();
        }

        public void Initialize()
        {

            //Instantiating View Controller with Storyboard ID 'PinkViewController'
            //pinkViewController = Storyboard.InstantiateViewController("FirstViewController") as FirstViewController;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //When we push the button, we will push the pinkViewController onto our current Navigation Stack
            //PinkButton.TouchUpInside += (o, e) = &gt;
            {
                //this.NavigationController.PushViewController(pinkViewController, true);
            };
        }

    }
}
