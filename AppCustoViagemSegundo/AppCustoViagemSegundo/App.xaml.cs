using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppCustoViagemSegundo.View;
using AppCustoViagemSegundo.Model;

using System.Collections.Generic;
using System.Globalization;

namespace AppCustoViagemSegundo
{
    public partial class App : Application
    {
        public List<Pedagio> ArrayPedagios = new List<Pedagio>();        

        public App()
        {
            CultureInfo.CurrentCulture = new CultureInfo("pt-BR");

            InitializeComponent();

            MainPage = new NavigationPage(new DadosViagemMelhorada());



           // CurrentCulture = new CultureInfo("pt-BR");

          //  Current.

            //CultureInfo = new CultureInfo("pt-BR").NumberFormat;
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
