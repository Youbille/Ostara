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
                "Au bon vegan", "Le valala du fruit", "Avocado Paradise", "Venez manger chez chous", "Vegetarian Shiva",
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
                ListOfRestaurants.RowDefinitions.Add(new RowDefinition{Height = new GridLength(200,GridUnitType.Absolute)});//200pixels pour un restaurant
                studiedRestaurant[i].Text = "Restaurant N°" + i;
                ListOfRestaurants.Children.Add(studiedRestaurant[i],i,0);
            }
        }   
    }
}