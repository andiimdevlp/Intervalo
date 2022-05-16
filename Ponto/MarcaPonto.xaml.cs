using Plugin.LocalNotification;
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
            lblRetorno.Text = "Você deve voltar ao trabalho\n" + DateTime.Parse(etrSaida.Text).AddMinutes(90);

            var notificacao = new NotificationRequest
            {
                BadgeNumber = 1,
                Description = "Seu horario de almoço acabou!",
                Sound = "soundNotification.wav",
                Title = "Anna - Alerta!",
                ReturningData = "Dummy Data",
                NotificationId = 1337,
                Image =
                {
                    ResourceName = "icon.png"
                },
                Schedule =
                {
                   NotifyTime = DateTime.Parse(etrSaida.Text).AddMinutes(80),
                   RepeatType = NotificationRepeat.TimeInterval,
                   NotifyRepeatInterval = TimeSpan.FromSeconds(30)
                },
                Android = new Plugin.LocalNotification.AndroidOption.AndroidOptions
                {
                    AutoCancel = false,
                    Priority = Plugin.LocalNotification.AndroidOption.AndroidPriority.High,
                    IconSmallName =
                    {
                        ResourceName = "icon.png"
                    }
                }
            };
            NotificationCenter.Current.Show(notificacao);
        }
    }
}