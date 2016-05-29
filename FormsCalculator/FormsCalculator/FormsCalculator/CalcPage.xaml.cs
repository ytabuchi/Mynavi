using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FormsCalculator
{
    public partial class CalcPage : ContentPage
    {
        public CalcPage()
        {
            InitializeComponent();

            calcButton.Clicked += (sender, e) =>
            {
                double d;
                if (double.TryParse(priceText.Text, out d))
                    totalPriceText.Text = $"{Calc.GetTax(d)}円";
            };
        }
    }
}
