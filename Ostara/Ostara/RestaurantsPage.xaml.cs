using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ostara
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RestaurantsPage : ContentPage
    {
        Grid ListOfRestaurants;
        
        public RestaurantsPage()
        {
            InitializeComponent();
            string[] allRestaurants =
            {
                "Au bon vegan", "Le valhalla du fruit", "Avocado Paradise", "Venez manger chez choux", "Vegetarian Shiva",
                "le festin du lapin"
            };
            AddingRestaurants(allRestaurants);
            
        }
        private void AddingRestaurants(string[] listRestaurants)
        {
            Label[] studiedRestaurant = new Label[listRestaurants.Length];
            ListOfRestaurants = this.FindByName<Grid>("RestaurantsList");
            for (int i = 0; i < listRestaurants.Length; i++)
            {
                studiedRestaurant[i] = new Label();
                ListOfRestaurants.RowDefinitions.Add(new RowDefinition{Height = new GridLength(100,GridUnitType.Absolute)});//200pixels pour un restaurant
                studiedRestaurant[i].Text = listRestaurants[i];
                if(i%2 == 0) studiedRestaurant[i].BackgroundColor = Color.ForestGreen;
                else studiedRestaurant[i].BackgroundColor = Color.LimeGreen;
                ListOfRestaurants.Children.Add(studiedRestaurant[i],0,i+1);
            }
        }   
    }
}