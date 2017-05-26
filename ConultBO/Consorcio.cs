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

namespace ConsultBO
{
   
    public class Consorcio
    {
        string nomeConsorcio;
        Morada m;
        bool consLider; // se é ou nao lider
        Dictionary<string, RecursoHumano> conjRecursos;
        
        public Consorcio()
        {

        }
        public Consorcio (string nomeC, bool consLid)
        {
            nomeConsorcio = nomeC;
            consLider = consLid;
        }


        public string NomeConsorcio
        {
            get { return nomeConsorcio; }
            set { nomeConsorcio = value; }

        }
        public Morada MoradaConsorcio
        {
            get { return m; }
            set { m = value; }
        }
    }
}