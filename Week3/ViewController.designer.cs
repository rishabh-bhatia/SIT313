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

namespace Week3
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField idText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField nameText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton saveButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton showAllButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (idText != null) {
                idText.Dispose ();
                idText = null;
            }

            if (nameText != null) {
                nameText.Dispose ();
                nameText = null;
            }

            if (saveButton != null) {
                saveButton.Dispose ();
                saveButton = null;
            }

            if (showAllButton != null) {
                showAllButton.Dispose ();
                showAllButton = null;
            }
        }
    }
}