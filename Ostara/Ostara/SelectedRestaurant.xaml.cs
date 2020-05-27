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
    public partial class SelectedRestaurant : ContentPage
    {
        private Label specsLabel;
        private Label nameLabel;
        private Label markLabel;
        public SelectedRestaurant(Restaurant displayedRestaurant)
        {
            nameLabel = this.FindByName<Label>("Nom");
            nameLabel.Text = displayedRestaurant.Name;
            specsLabel = this.FindByName<Label>("Specs");
            specsLabel.Text = "Spécificités + \n" + displayedRestaurant.SpecsofRes;
            markLabel = this.FindByName<Label>("Mark");
            markLabel.Text = "Note du restaurant : " + displayedRestaurant.MarkofRes;
            //add the external link seems dur


        }
    }
}