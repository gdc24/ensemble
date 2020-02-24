using Foundation;
using System;
using UIKit;

namespace ensemble
{
    public partial class ConflictsViewController : UITableViewController
    {
        public ConflictsViewController(IntPtr handle) : base(handle)
        {
           
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            UITableView _conflictsTable;

            _conflictsTable = new UITableView
            {
                Frame = new CoreGraphics.CGRect(0, 50, View.Bounds.Width, View.Bounds.Height)
            };

            View.AddSubview(_conflictsTable);
        }


    }
}