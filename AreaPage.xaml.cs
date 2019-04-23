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
	public partial class AreaPage : ContentPage
	{
		public AreaPage ()
		{
			InitializeComponent ();
            Title = "  AREA";
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("#1C1C1C");
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.FromHex("#E6E8E6");
            SquareCentimeters.Placeholder = "cm" + (char)0x00B2;
            SquareKilometers.Placeholder = "km" + (char)0x00B2;
            SquareMeters.Placeholder = "m" + (char)0x00B2;
        }

        private void SquareCentimeters_Completed(object sender, EventArgs e)
        {
            CustomEntry entry = sender as CustomEntry;
            float value = float.Parse(entry.Text);
            SquareMeters.Text = (value/10000).ToString() ;
            SquareKilometers.Text = (value / 10000000000).ToString();
            Ares.Text = (value / 1000000).ToString();
            Hectares.Text = (value / 100000000).ToString();
        }

        private void SquareMeters_Completed(object sender, EventArgs e)
        {
            CustomEntry entry = sender as CustomEntry;
            float value = float.Parse(entry.Text);
            SquareCentimeters.Text = (value * 10000).ToString();
            SquareKilometers.Text = (value / 1000000).ToString();
            Ares.Text = (value / 100).ToString();
            Hectares.Text = (value / 10000).ToString();
        }

        private void SquareKilometers_Completed(object sender, EventArgs e)
        {
            CustomEntry entry = sender as CustomEntry;
            float value = float.Parse(entry.Text);
            SquareMeters.Text = (value * 1000000).ToString();
            SquareCentimeters.Text = (value *10000000000).ToString();
            Ares.Text = (value *10000).ToString();
            Hectares.Text = (value *100).ToString();
        }

        private void Ares_Completed(object sender, EventArgs e)
        {
            CustomEntry entry = sender as CustomEntry;
            float value = float.Parse(entry.Text);
            SquareMeters.Text = (value *100).ToString();
            SquareKilometers.Text = (value / 10000).ToString();
            SquareCentimeters.Text = (value *1000000).ToString();
            Hectares.Text = (value / 100).ToString();
        }

        private void Hectares_Completed(object sender, EventArgs e)
        {
            CustomEntry entry = sender as CustomEntry;
            float value = float.Parse(entry.Text);
            SquareMeters.Text = (value * 10000).ToString();
            SquareKilometers.Text = (value / 100).ToString();
            Ares.Text = (value * 100).ToString();
            SquareCentimeters.Text = (value *100000000).ToString();
        }
    }
}