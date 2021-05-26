using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppCustoViagemSegundo.Model;

namespace AppCustoViagemSegundo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DadosViagemMelhorada : ContentPage
    {
        App PropriedadesApp;


        public DadosViagemMelhorada()
        {
            InitializeComponent();

            PropriedadesApp = (App)Application.Current;
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new ListaPedagios());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ooops", ex.Message, "OK");
            }
        }

        private void Button_Add_Clicked(object sender, EventArgs e)
        {
            try
            {
                PropriedadesApp.ArrayPedagios.Add(new Pedagio()
                {
                    Id = PropriedadesApp.ArrayPedagios.Count + 1,
                    Localizacao = txt_localizacao.Text,
                    Valor = Convert.ToDouble(txt_preco_pedagio.Text)
                });
            }
            catch (Exception ex)
            {
                DisplayAlert("Ooops", ex.Message, "OK");
            }
        }

        private void Button_Limpar_Clicked(object sender, EventArgs e)
        {
            try
            {


            }
            catch (Exception ex)
            {
                DisplayAlert("Ooops", ex.Message, "OK");
            }
        }

        private void Button_Calcular_Clicked(object sender, EventArgs e)
        {
            try
            {


            }
            catch (Exception ex)
            {
                DisplayAlert("Ooops", ex.Message, "OK");
            }
        }
    }
}