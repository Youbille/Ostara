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
    public partial class NutritionPage : ContentPage
    {
        string[] Images ={"Socca.png","houmRad.png","CrepChocOr.png","RagLentPom.png","PizzaLegHiv.png","BoulgEpFro.png","SalNic.png","Latkes.png","ChipsAub.png","Auberita.png"}; //This is the initial recipes for our PoC
        private Grid GridofRecipes;
        public NutritionPage()
        {
            InitializeComponent();
            List<string[]> recipesData = recipesListing("recipes.csv");
            Recette[] recipesArray = new Recette[recipesData.Count];
            int i = 0;
            foreach (string[] recipe in recipesData)
            {
                recipesArray[i] = new Recette(recipe[0], Convert.ToInt32(recipe[1]), recipe[2], recipe[3], recipe[4], recipe[5], recipe[6]);
                i++;
            }
            GridofRecipes = this.FindByName<Grid>("recipesView");
            Button[] recipesBUttons = new Button[recipesArray.Length]; 
            for (int j = 0; j < recipesArray.Length-1; j++)
            {
                Image recipeImage = new Image();
                recipeImage.Source = Images[j];
                recipesBUttons[j] = new Button();
                GridofRecipes.RowDefinitions.Add(new RowDefinition { Height = new GridLength(100, GridUnitType.Absolute) });//200pixels pour une recette
                recipesBUttons[j].Text = recipesArray[j].Nom;
                recipesBUttons[j].BackgroundColor = i % 2 == 0 ? Color.ForestGreen : Color.LimeGreen;
                GridofRecipes.Children.Add(recipesBUttons[j],0,j);
                GridofRecipes.Children.Add(recipeImage,1,j);
            }
        }
        static List<string[]> recipesListing(string chemin)//Somehow path is not working
        {
            int compteur = 0;
            string ligne;
            char caractere = ';';
            List<string[]> recipes = new List<string[]> { };
            System.IO.StreamReader fichier = new System.IO.StreamReader(chemin);

            while ((ligne = fichier.ReadLine()) != null)
            {
                string[] substrings = ligne.Split(caractere);
                string[] substrings2 = new string[7];
                int i = 0;
                foreach (var valeur in substrings)
                {
                    if (i > 6)
                    {
                        break;
                    }

                    substrings2[i] = valeur;
                    i++;
                }

                recipes.Add(substrings2);
                compteur++;
            }

            recipes.RemoveAt(0);
            fichier.Close();
            return recipes;
        }

    }
}