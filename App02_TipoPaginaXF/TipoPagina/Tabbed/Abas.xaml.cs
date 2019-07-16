using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace App02_TipoPaginaXF.TipoPagina.Tabbed
{
    public partial class Abas : TabbedPage
    {
        public Abas()
        {
            InitializeComponent();


            Children.Add(new NavigationPage(new TipoPagina.Navigation.Pagina1()) { Title = "Item 3" });
        }
    }
}
