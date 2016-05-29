using System;

using UIKit;

namespace NativeCalculator.iOS
{
	public partial class ViewController : UIViewController
	{

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
            // Perform any additional setup after loading the view, typically from a nib.

            CalcButton.TouchUpInside += (sender, e) =>
            {
                double d;
                if (double.TryParse(PriceText.Text, out d))
                    TotalPriceText.Text = $"{Calc.GetTax(d)}円";
            };
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

