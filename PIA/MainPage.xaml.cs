using PIA.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PIA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel(Navigation);
        }
    }
}

//        private async void Ingresar_Clicked(object sender, EventArgs e)
//        {
//            string username = txtemail.Text;
//            string password = txtclave.Text;

//            if(IsValidDate(username, password))
//            {
//                await DisplayAlert("Logrado","Inicio exitoso", "Ok");

//                await Navigation.PushAsync(new MenuPrincipalPage());
//            }
//            else
//            {
//                await DisplayAlert("Error", "Datos Incorrectos", "Ok");
//            }
//        }
//        private bool IsValidDate(string username, string password)
//        {
//            return username == "1" && password == "1234";
//        }

//    }
//}
