using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PastelWlsySdP.Dominio;
using PastelWlsySdP.Persistencia;

namespace PastelWlsySdP.Aplicacao
{
    class ClassCEP_Apl
    {
        public ClassCEP_Dom cep_Dom = new ClassCEP_Dom();
        public ClassCEP_Per cep_Per = new ClassCEP_Per();
        public string erro;

        public bool BuscaCEP(string text)
        {
            if(!cep_Per.Buscar(text))
            {
                erro = cep_Per.erro;
                return false;
            }
            else
            {
                cep_Dom = cep_Per.cep_Dom;
                return true;
            }
        }
    }
}
