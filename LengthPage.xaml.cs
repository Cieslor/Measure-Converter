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
	public partial class LengthPage : ContentPage
	{
		public LengthPage ()
		{
			InitializeComponent ();
            Title = "LENGTH";
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("#1C1C1C");
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.FromHex("#E6E8E6");
        }

        private void Centimeters_Completed(object sender, EventArgs e)
        {
            CustomEntry entry = sender as CustomEntry;
            float value = float.Parse(entry.Text);
            Meters.Text = (value / 100).ToString();
            Kilometers.Text = (value / 100000).ToString();
        }

        private void Meters_Completed(object sender, EventArgs e)
        {
            CustomEntry entry = sender as CustomEntry;
            float value = float.Parse(entry.Text);
            Centimeters.Text = (value *100).ToString();
            Kilometers.Text = (value/1000).ToString();
        }

        private void Kilometers_Completed(object sender, EventArgs e)
        {
            CustomEntry entry = sender as CustomEntry;
            float value = float.Parse(entry.Text);
            Centimeters.Text = (value * 100000).ToString();
            Meters.Text = (value*1000).ToString();
        }
    }
}