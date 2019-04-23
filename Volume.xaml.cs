using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Converter
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Volume : ContentPage
	{
		public Volume ()
		{
			InitializeComponent ();
            Title = "VOLUME";
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("#1C1C1C");
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.FromHex("#E6E8E6");
            CubicCentimeters.Placeholder = "cm" + (char)0x00B3;
            CubicDezimeters.Placeholder = "dm" + (char)0x00B3;
            CubicMeters.Placeholder = "m" + (char)0x00B3;
        }

        

        private void CubicDezimeters_Completed(object sender, EventArgs e)
        {
            CustomEntry entry = sender as CustomEntry;
            float value = float.Parse(entry.Text);
            CubicCentimeters.Text = (value * 1000).ToString();
            CubicMeters.Text = (value /1000).ToString();
        }

        private void CubicCentimeters_Completed(object sender, EventArgs e)
        {
            CustomEntry entry = sender as CustomEntry;
            float value = float.Parse(entry.Text);
            CubicMeters.Text = (value / 1000000).ToString();
            CubicDezimeters.Text = (value/1000).ToString();
        }

        private void CubicMeters_Completed(object sender, EventArgs e)
        {
            CustomEntry entry = sender as CustomEntry;
            float value = float.Parse(entry.Text);
            CubicCentimeters.Text = (value * 1000000).ToString();
            CubicDezimeters.Text = (value * 1000).ToString();
        }
    }
}