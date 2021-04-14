using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

using PastelWlsySdP.Dominio;
using PastelWlsySdP.Persistencia;

namespace PastelWlsySdP.Aplicacao
{
    class ClassChavesWin_Apl
    {
        public ClassChavesWin_Dom chaves = new ClassChavesWin_Dom();
        public ClassChavesWin_Per lerChaves = new ClassChavesWin_Per();
        public RegistryKey chave;
        public string erro;

        public bool VerChaves()
        {
            if (!lerChaves.ObterChaves(chaves))
            {
                erro = lerChaves.erro;
                return false;
            }   
            else
            {
                chaves = lerChaves.chaves;
                chave = lerChaves.registryKey;
                return true;
            }
        }

        public bool CriarChaves(ClassChavesWin_Dom chavesWin_Dom)
        {
            if (!lerChaves.CriarChaves(chavesWin_Dom)) 
            {
                erro = lerChaves.erro;
                return false;
            }
            else
            {
                chave = lerChaves.registryKey;
                return true;
            }
        }
    }
}
