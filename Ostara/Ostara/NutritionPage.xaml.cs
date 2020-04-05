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
        public NutritionPage()
        {
            InitializeComponent();
        }

        private void Basket_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void News_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Forum_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}