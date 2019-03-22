using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ListaClienteApp
{
    public partial class ListaClientePage : ContentPage
    {
        public ListaClientePage(List<Model.Cliente> lista_cliente)
        {
            InitializeComponent();
            listView_deClientes.ItemsSource = lista_cliente;
        }
    }
}
