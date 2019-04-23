using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Converter
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if(button.ClassId == "Length")
            {
                Navigation.PushAsync(new LengthPage());
            }
            else if(button.ClassId == "Volume")
            {
                Navigation.PushAsync(new Volume());
            }
            else if(button.ClassId == "Decimal")
            {
                Navigation.PushAsync(new HexDecBinPage());
            }
            else
            {
                Navigation.PushAsync(new AreaPage());
            }
        }
    }
}
