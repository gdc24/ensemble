using System;

using UIKit;

namespace ensemble
{
    public partial class ScheduleTableViewController : UIViewController
    {
        public ScheduleTableViewController() : base("ScheduleTableViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            UITableView _scheduleTable;

            _scheduleTable = new UITableView
            {
                Frame = new CoreGraphics.CGRect(0, 50, View.Bounds.Width, View.Bounds.Height)
            };

            View.AddSubview(_scheduleTable);
        }


        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

