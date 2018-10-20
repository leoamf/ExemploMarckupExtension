using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExemploMarckupExtension
{
    public partial class MainPage : ContentPage
    {
        public static string TextoPadrao = "Você estar na tela 1";

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SecondScreen()); 
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
