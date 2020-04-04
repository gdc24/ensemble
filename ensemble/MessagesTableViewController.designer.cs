using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace ensemble {
    [Register ("MessagesTableViewController")]
    partial class MessagesTableViewController {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem ScanButton { get; set; }

        [Action ("Scan:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Scan (UIKit.UIBarButtonItem sender);

        void ReleaseDesignerOutlets () {
            if (ScanButton != null) {
                ScanButton.Dispose ();
                ScanButton = null;
            }
        }
    }
}
