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
    public partial class Calificaciones : ContentPage
    {
        public Calificaciones(string user)
        {
            InitializeComponent();
            lblUser.Text = user;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double ns1 = Convert.ToDouble(txtNota1.Text);
                double e1 = Convert.ToDouble(txtExamen1.Text);
                double parcial1 = (ns1 * 0.3) + (e1 * 0.2);
                txtResultado1.Text = parcial1.ToString();

                double ns2 = Convert.ToDouble(txtNota2.Text);
                double e2 = Convert.ToDouble(txtExamen2.Text);
                double parcial2 = (ns2 * 0.3) + (e2 * 0.2);
                txtResultado2.Text = parcial2.ToString();

                double nfinal = parcial1 + parcial2;
                txtResultadoFinal.Text = nfinal.ToString();

                if (nfinal >= 7)
                {
                    txtmensaje.Text = "Aprobado";
                   
                }
                else
                {
                    txtmensaje.Text = "Reprobado";
                   
                }

            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje", "ERROR" + ex.Message, "Aceptar");
            }

        }
    }
}