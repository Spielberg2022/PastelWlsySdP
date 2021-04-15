using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.IO;
using System.Net;
using System.Web;

using PastelWlsySdP.Dominio;

namespace PastelWlsySdP.Persistencia
{
    class ClassCEP_Per
    {
        public ClassCEP_Dom cep_Dom = new ClassCEP_Dom();
        public string erro;
        public bool Buscar(string text)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + text + "/json/");
                request.AllowAutoRedirect = false;
                HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

                if (ChecaServidor.StatusCode != HttpStatusCode.OK)
                {
                    erro = ChecaServidor.StatusCode.ToString();
                }

                using (Stream webStream = ChecaServidor.GetResponseStream())
                {
                    if (webStream != null)
                    {
                        using (StreamReader responseReader = new StreamReader(webStream))
                        {
                            String response = responseReader.ReadToEnd();
                            response = Regex.Replace(response, "[{},]", string.Empty);
                            response = response.Replace("\"", "");

                            String[] substrings = response.Split('\n');

                            int cont = 0;
                            foreach (var substring in substrings)
                            {
                                // CEP
                                if (cont == 1)
                                {
                                    string[] valor = substring.Split(':');
                                    cep_Dom.Cep = valor[1].ToString();
                                }

                                // Logradouro
                                if (cont == 2)
                                {
                                    string[] valor = substring.Split(':');
                                    cep_Dom.Logradouro = valor[1].ToString().Trim();
                                }


                                // Bairro
                                if (cont == 4)
                                {
                                    string[] valor = substring.Split(':');
                                    cep_Dom.Bairro = valor[1].ToString().Trim();
                                }

                                // Cidade
                                if (cont == 5)
                                {
                                    string[] valor = substring.Split(':');
                                    cep_Dom.Localidade = valor[1].ToString().Trim();
                                }

                                // UF
                                if (cont == 6)
                                {
                                    string[] valor = substring.Split(':');
                                    cep_Dom.Uf = valor[1].ToString().Trim();
                                }
                                cont++;
                            }
                        }
                    }
                }

                return true;
            }
            catch (Exception error)
            {
                erro = erro + "\n" + error.Message; 
                return false;
            }
            finally
            {

            }
        }
    }
}
