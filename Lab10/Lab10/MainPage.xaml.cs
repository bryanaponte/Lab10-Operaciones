
using Lab10.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab10
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


         
            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Operaciones());

            };
         
            

            
        }
    }
}
