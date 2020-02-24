// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace ensemble
{
    [Register ("FirstViewController")]
    partial class FirstViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CheckInButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton EditConflictsButton { get; set; }

        [Action ("EditConflictsButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void EditConflictsButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton655_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton655_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (CheckInButton != null) {
                CheckInButton.Dispose ();
                CheckInButton = null;
            }

            if (EditConflictsButton != null) {
                EditConflictsButton.Dispose ();
                EditConflictsButton = null;
            }
        }
    }
}