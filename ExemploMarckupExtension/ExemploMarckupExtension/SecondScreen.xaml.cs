using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ExemploMarckupExtension
{
    public partial class SecondScreen : ContentPage
    {
        public static string TextoPadrao = "Você estar na tela 2";

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

        public SecondScreen()
        {
            InitializeComponent();
        }
    }
}
