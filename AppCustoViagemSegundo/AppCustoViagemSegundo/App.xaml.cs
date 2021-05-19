using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppCustoViagemSegundo.View;
using AppCustoViagemSegundo.Model;

using System.Collections.Generic;

namespace AppCustoViagemSegundo
{
    public partial class App : Application
    {
        public List<Pedagio> ArrayPedagios = new List<Pedagio>();        

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new DadosViagem());
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
