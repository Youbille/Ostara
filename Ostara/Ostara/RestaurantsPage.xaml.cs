using System;
using System.Collections.Generic;
using System.IO;
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
        private Grid ListOfRestaurants;
        private Restaurant[] RestaurantList;

        static List<string[]> listeResto(string chemin)//Somehow path is not working
        {
            int compteur = 0;
            string ligne;
            char caractere = ';';
            List<string[]> restaurants = new List<string[]> { };
            System.IO.StreamReader fichier = new System.IO.StreamReader(chemin);

            while ((ligne = fichier.ReadLine()) != null)
            {
                string[] substrings = ligne.Split(caractere);
                string[] substrings2 = new string[5];
                int i = 0;
                foreach (var valeur in substrings)
                {
                    if (i > 4)
                    {
                        break;
                    }

                    substrings2[i] = valeur;
                    i++;
                }

                restaurants.Add(substrings2);
                compteur++;
            }

            restaurants.RemoveAt(0);
            fichier.Close();
            return restaurants;
        }

        public RestaurantsPage()
        {
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            List<string[]> dataList = listeResto("dataBase.csv"); //the path is not working
            RestaurantList = new Restaurant[dataList.Count];
            for (int i =0;i<dataList.Count;i++)
            {
                RestaurantList[i] = new Restaurant(dataList[i][0], dataList[i][1], dataList[i][2], dataList[i][3],
                    Convert.ToDouble(dataList[i][4]));
            }
            InitializeComponent();
            //string[] allRestaurants =
            //{
            //    "Au bon vegan", "Le valhalla du fruit", "Avocado Paradise", "Venez manger chez choux", "Vegetarian Shiva",
            //    "le festin du lapin"
            //};
            AddingRestaurants(RestaurantList);
            
        }
        private void AddingRestaurants(Restaurant[] listRestaurants)
        {
            Button[] studiedRestaurant = new Button[listRestaurants.Length];
            ListOfRestaurants = this.FindByName<Grid>("RestaurantsList");
            for (int i = 0; i < listRestaurants.Length; i++)
            {
                studiedRestaurant[i] = new Button();
                ListOfRestaurants.RowDefinitions.Add(new RowDefinition{Height = new GridLength(100,GridUnitType.Absolute)});//200pixels pour un restaurant
                studiedRestaurant[i].Text = listRestaurants[i].Name;
                studiedRestaurant[i].BackgroundColor = i%2 == 0 ? Color.ForestGreen : Color.LimeGreen;
                studiedRestaurant[i].Clicked += OnButtonClicked;
                ListOfRestaurants.Children.Add(studiedRestaurant[i],0,i+1);
            }
        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SelectedRestaurant(RestaurantList[1]));
        }
    }
}