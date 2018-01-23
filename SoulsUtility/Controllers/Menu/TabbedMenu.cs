using System;
using Foundation;
using System.CodeDom.Compiler;

namespace SoulsUtility.Controllers
{
    [Register("TabbedMenu")]
    partial class TabbedMenu : UIKit.UITableView
    {
        protected TabbedMenu(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

    }
}
