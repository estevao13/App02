using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace App02_TipoPaginaXF.TipoPagina.Master
{
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void MudarPagina1 (object sender, EventArgs args)
        {
            Detail = new Navigation.Pagina1();
            IsPresented = false;
        }
        private void MudarPagina2(object sender, EventArgs args)
        {
            Detail = new Navigation.Pagina2();
            IsPresented = false;
        }
        private void MudarPagina3(object sender, EventArgs args)
        {
            Detail = new Conteudo();
            IsPresented = false;
        }
    }
}
