using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea3LoginNavegacionGallegosA
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string user)
        {
            InitializeComponent();
            lblUser.Text = user;
        }

        private async void btnSaludo_Clicked(object sender, EventArgs e)
        {
           
            string texto = txtNombre.Text;
            string mensaje = "Hola " + texto;
            DisplayAlert("Mensaje de bienvenida", mensaje, "Gracias");
            await Navigation.PushAsync(new Calificaciones(lblUser.Text));
        }
    }
}
