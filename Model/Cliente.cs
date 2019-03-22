using System;
namespace ListaClienteApp.Model
{
    public class Cliente
    {
        public string nome { get; set; }
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string endereco
        {
            get { return logradouro + ", " + bairro + ", " + localidade + ", " + uf; }
        }

        public Cliente()
        {
        }
    }
}
