using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace NativeCalculator.Droid
{
	[Activity (Label = "NativeCalculator.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Main);

            var totalPriceText = FindViewById<TextView>(Resource.Id.TotalPriceText);
            var priceText = FindViewById<EditText>(Resource.Id.PriceText);
            var calcButton = FindViewById<Button>(Resource.Id.CalcButton);
            calcButton.Click += (sender, e) =>
            {
                double d;
                if (double.TryParse(priceText.Text, out d))
                    totalPriceText.Text = $"{Calc.GetTax(d)}円";
            };
		}
	}
}


