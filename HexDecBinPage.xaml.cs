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
	public partial class HexDecBinPage : ContentPage
	{
		public HexDecBinPage ()
		{
			InitializeComponent ();
            Title = "HEX/BIN/DEC";
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("#1C1C1C");
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.FromHex("#E6E8E6");
        }

        private void Decimal_Completed(object sender, EventArgs e)
        {
            CustomEntry entry = sender as CustomEntry;
            string value = entry.Text;
            Binary.Text = Convert.ToString(Convert.ToInt32(value,10),2);
            Hexadecimal.Text = Convert.ToString(Convert.ToInt32(value, 10),16);
        }

        private void Hexadecimal_Completed(object sender, EventArgs e)
        {
            CustomEntry entry = sender as CustomEntry;
            try
            {
                string value = entry.Text;
                Decimal.Text = Convert.ToString(Convert.ToInt32(value, 16), 10);
                Binary.Text = Convert.ToString(Convert.ToInt32(value, 16), 2);
            }
            catch
            {
                entry.Text = "Incorrect value";
            }
        }

        private void Binary_Completed(object sender, EventArgs e)
        {
            CustomEntry entry = sender as CustomEntry;
            try
            {
                string value = entry.Text;
                Decimal.Text = Convert.ToString(Convert.ToInt32(value, 2), 10);
                Hexadecimal.Text = Convert.ToString(Convert.ToInt32(value, 2), 16);
            }
            catch
            {
                entry.Text = "Incorrect value";
            }
        }
    }
}