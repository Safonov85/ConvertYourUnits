using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConvertYourUnits
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			//picker.SelectedItem = "Kg to Lbs";
			picker.Items.Add("Kg to Lbs");
			picker.Items.Add("Celcius to Farhrenheit");
			picker.Items.Add("Meters to Feet");
			picker.Items.Add("Kg to Lbs");
			picker.SelectedIndex = 3;
		}

		private void picker_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void sliderMain_ValueChanged(object sender, ValueChangedEventArgs e)
		{
			labelMain.Text = sliderMain.Value.ToString() + " Kg" + " = " +
				ConvertKgToPounds(sliderMain.Value).ToString("##.#") + " lbs";
		}

		double ConvertKgToPounds(double kg)
		{
			double lbs = 2.204623;
			lbs = kg * lbs;
			return lbs;
		}
	}
}
