﻿// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace NativeCalculator.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CalcButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField PriceText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel TotalPriceText { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CalcButton != null) {
                CalcButton.Dispose ();
                CalcButton = null;
            }

            if (PriceText != null) {
                PriceText.Dispose ();
                PriceText = null;
            }

            if (TotalPriceText != null) {
                TotalPriceText.Dispose ();
                TotalPriceText = null;
            }
        }
    }
}