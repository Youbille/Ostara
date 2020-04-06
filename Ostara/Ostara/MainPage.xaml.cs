using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ostara
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Nutrition_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NutritionPage());
        }

        private void Restaurants_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RestaurantsPage());
        }

        private void LaVieDuVegetarien_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VegetarianLifePage());
        }

        private void Settings_Clicked(object sender, EventArgs e)
        {

        }
    }
}
