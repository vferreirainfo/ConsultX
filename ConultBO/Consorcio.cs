using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ConultBO
{
    public enum ClassificacaoMorada
    {
        Rua,
        Avenida,
        Travessa,
        Beco,
        Praca,
        Marginal,


    }

    public class Consorcio
    {
        string nomeConsorcio;
        string pais;
        string localidade;
        string morada;
        int codPostal;
        ClassificacaoMorada tipoMorada;
        bool consLider; // se é ou nao lider


        public Consorcio()
        {

        }
        public Consorcio (string nomeC, string paisResid, string loc, int zip)
        {
            nomeConsorcio = nomeC;
            pais = paisResid;
            localidade = loc;
            zip = codPostal;
        }
    }
}