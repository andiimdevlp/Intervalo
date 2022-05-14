using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ponto
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MarcaPonto();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
