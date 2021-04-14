using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

using PastelWlsySdP.Dominio;

namespace PastelWlsySdP.Persistencia
{
    class ClassChavesWin_Per
    {
        public ClassChavesWin_Dom chaves = new ClassChavesWin_Dom();
        public string erro;
        public RegistryKey registryKey;
        public bool ObterChaves(ClassChavesWin_Dom chavesWin_Dom)
        {
            try
            {
                registryKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\CoringaSolutions_PastelWslySdP");

                chavesWin_Dom.Servidor = registryKey.GetValue("Servidor").ToString();
                chavesWin_Dom.Instancia = registryKey.GetValue("Instancia").ToString();
                chavesWin_Dom.Autenticacao = registryKey.GetValue("Autenticacao").ToString();
                chavesWin_Dom.Usuario = registryKey.GetValue("Usuario").ToString();
                chavesWin_Dom.Senha = registryKey.GetValue("Senha").ToString();
                chavesWin_Dom.Bd = registryKey.GetValue("Bd").ToString();
                chavesWin_Dom.Serial = registryKey.GetValue("Serial").ToString();
                chaves = chavesWin_Dom;
                registryKey.Close();

                return true;
            }
            catch (Exception error)
            {
                erro = error.Message;
                return false;
            }
            finally
            {
                //registryKey.Close();
            }
        }

        public bool CriarChaves(ClassChavesWin_Dom chaves)
        {
            try
            {
                registryKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\CoringaSolutions_PastelWslySdP");

                registryKey.SetValue("Servidor", chaves.Servidor);
                registryKey.SetValue("Instancia", chaves.Instancia);
                registryKey.SetValue("Autenticacao", chaves.Autenticacao);
                registryKey.SetValue("Usuario", chaves.Usuario);
                registryKey.SetValue("Senha", chaves.Senha);
                registryKey.SetValue("Bd", chaves.Bd);
                registryKey.SetValue("Serial", chaves.Serial);

                return true;
            }
            catch (Exception error)
            {
                erro = error.Message;
                return false;
            }
            finally
            {
                registryKey.Close();
            }
        }
    }
}
