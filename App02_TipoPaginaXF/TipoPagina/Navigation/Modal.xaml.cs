using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace App02_TipoPaginaXF.TipoPagina.Navigation
{
    public partial class Modal : ContentPage
    {
        public Modal()
        {
            InitializeComponent();
        }

        private void FecharModal (object sender, EventArgs args)
        {
            Navigation.PopModalAsync();
        }
    }
}
