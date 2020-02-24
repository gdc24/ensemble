using System;

using UIKit;

namespace ensemble
{
    public partial class FirstViewController : UIViewController
    {
        public FirstViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void UIButton655_TouchUpInside(UIButton sender)
        {
            throw new NotImplementedException();
        }

        partial void UIButton657_TouchUpInside(UIButton sender)
        {
            throw new NotImplementedException();
        }

        partial void EditConflictsButton_TouchUpInside(UIButton sender)
        {
            throw new NotImplementedException();
        }
    }
}