using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastelWlsySdP.Dominio
{
    class ClassCEP_Dom
    {
        private string cep;
        private string logradouro;
        private string complemento;
        private string bairro;
        private string localidade;
        private string uf;
        private string ibge;
        private string gia;
        private string ddd;
        private string siafi;

        public string Cep { get => cep; set => cep = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Localidade { get => localidade; set => localidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Ibge { get => ibge; set => ibge = value; }
        public string Gia { get => gia; set => gia = value; }
        public string Ddd { get => ddd; set => ddd = value; }
        public string Siafi { get => siafi; set => siafi = value; }
    }
}
