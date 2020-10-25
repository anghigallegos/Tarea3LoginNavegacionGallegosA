using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea3LoginNavegacionGallegosA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnAbrir_saludo_Clicked(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            string pass = txtpass.Text;
            //Definicion de variables
            string user_val = "estudiante2020";
            string pass_val = "uisrael2020";
            if (user_val == user && pass_val == pass)
            {
                await Navigation.PushAsync(new MainPage(user));
            }
            else
            {
                await DisplayAlert("Usuario o Clave incorrecta", "Ingrese nuevamente", "Aceptar");
            }
        }
    }
}
