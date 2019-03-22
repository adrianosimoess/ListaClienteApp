using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ListaClienteApp.Model;
using Org.Apache.Http.Client;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace ListaClienteApp
{
    public partial class MainPage : ContentPage
    {
        List<Cliente> lista_cliente = new List<Cliente>();

        protected async void Handle_Completed(object sender, System.EventArgs e)
        {
            var client = new HttpClient();
            string cep = txtcep.Text;
            var json = await client.GetStringAsync($"https://viacep.com.br/ws/{cep}/json/");
            var dados = JsonConvert.DeserializeObject<Cliente>(json);

            lbllogradouro.Text = dados.logradouro;
            lblbairro.Text = dados.bairro;
            lbllocalidade.Text = dados.localidade;
            lbluf.Text = dados.uf;


        }

        void Adicionar(object sender, System.EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.nome = ncliente.Text;
            cliente.logradouro = lbllogradouro.Text;
            cliente.bairro = lblbairro.Text;
            cliente.localidade = lbllocalidade.Text;
            cliente.uf = lbluf.Text;

            lista_cliente.Add(cliente);

            ncliente.Text = string.Empty;

            lbllogradouro.Text = string.Empty;
            lblbairro.Text = string.Empty;
            lbllocalidade.Text = string.Empty;
            lbluf.Text = string.Empty;

        }

        void Checar(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ListaClientePage(lista_cliente));
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
