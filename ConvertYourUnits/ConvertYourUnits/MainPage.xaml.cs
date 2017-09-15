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
			picker.Items.Add("Km to Miles");
			picker.SelectedIndex = 0;
			
		}

		private void picker_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (picker.SelectedIndex == 0)
			{
				sliderMain.Minimum = 0;
				sliderMain.Maximum = 100;
				sliderMain.Value = 0;
				labelMain.Text = sliderMain.Value.ToString("##.#") + " Kg" + " = " +
				ConvertKgToPounds(sliderMain.Value).ToString("##.#") + " lbs";
			}
			else if (picker.SelectedIndex == 1)
			{
				sliderMain.Minimum = -100;
				sliderMain.Maximum = 100;
				sliderMain.Value = 0;
				labelMain.Text = sliderMain.Value.ToString("##.#") + " °C" + " = " +
					CelciusToFarenheit(sliderMain.Value).ToString("##.#") + " °F";
			}
			else if (picker.SelectedIndex == 2)
			{
				sliderMain.Minimum = 0;
				sliderMain.Maximum = 100;
				sliderMain.Value = 0;
				labelMain.Text = sliderMain.Value.ToString("##.#") + " Meters" + " = " +
				ConvertMetersToFeet(sliderMain.Value).ToString("##.#") + " Feet";
			}
			else if (picker.SelectedIndex == 3)
			{
				sliderMain.Minimum = 0;
				sliderMain.Maximum = 1000;
				sliderMain.Value = 0;
				labelMain.Text = sliderMain.Value.ToString("##.#") + " Km" + " = " +
				ConvertKmToMiles(sliderMain.Value).ToString("##.#") + " Miles";
			}
		}

		private void sliderMain_ValueChanged(object sender, ValueChangedEventArgs e)
		{
			if(picker.SelectedIndex == 0)
			{

				labelMain.Text = sliderMain.Value.ToString("##.#") + " Kg" + " = " +
				ConvertKgToPounds(sliderMain.Value).ToString("##.#") + " lbs";
			}
			else if(picker.SelectedIndex == 1)
			{
				labelMain.Text = sliderMain.Value.ToString("##.#") + " °C" + " = " +
					CelciusToFarenheit(sliderMain.Value).ToString("##.#") + " °F";
			}
			else if (picker.SelectedIndex == 2)
			{
				labelMain.Text = sliderMain.Value.ToString("##.#") + " Meters" + " = " +
				ConvertMetersToFeet(sliderMain.Value).ToString("##.#") + " Feet";
			}
			else if (picker.SelectedIndex == 3)
			{
				labelMain.Text = sliderMain.Value.ToString("##.#") + " Km" + " = " +
				ConvertKmToMiles(sliderMain.Value).ToString("##.#") + " Miles";
			}
		}

		double CelciusToFarenheit(double cel)
		{
			double faren = (cel * 9 / 5) + 32;
			return faren;
		}

		double ConvertKgToPounds(double kg)
		{
			double lbs = 2.204623;
			lbs = kg * lbs;
			return lbs;
		}

		double ConvertMetersToFeet(double meters)
		{
			double feet = 3.280839895;
			feet = meters * feet;
			return feet;
		}

		double ConvertKmToMiles(double km)
		{
			double miles = 0.621371;
			miles = km * miles;
			return miles;
		}
	}
}
