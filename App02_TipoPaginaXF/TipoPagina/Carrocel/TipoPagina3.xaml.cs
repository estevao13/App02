using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace App02_TipoPaginaXF.TipoPagina.Carrocel
{
    public partial class TipoPagina3 : ContentPage
    {
        public TipoPagina3()
        {
            InitializeComponent();
        }

        private void MudarPagina(object sender, EventArgs args)
        {
            //App.Current.MainPage = new NavigationPage(new Navigation.Pagina1()) { BarBackgroundColor = Color.Blue};
            App.Current.MainPage = new Tabbed.Abas();
        }
    }
}
