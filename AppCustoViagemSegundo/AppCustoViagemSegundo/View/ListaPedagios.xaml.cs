using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCustoViagemSegundo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaPedagios : ContentPage
    {

        App PropriedadesApp;


        public ListaPedagios()
        {
            InitializeComponent();

            PropriedadesApp = (App)Application.Current;

            lst_lista_pedagios.ItemsSource = PropriedadesApp.ArrayPedagios;
        }
    }
}