using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ponto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MarcaPonto : ContentPage
    {
        public MarcaPonto()
        {
            InitializeComponent();
            btnCalcular.Clicked += BtnCalcular_Clicked;
        }

        private void BtnCalcular_Clicked(object sender, EventArgs e)
        {
            TimeSpan intervalo = new TimeSpan(01, 30, 00);
            lblRetorno.Text = "Você deve voltar ao trabalho\n" + DateTime.Parse(etrSaida.Text).Add(intervalo);
        }
    }
}