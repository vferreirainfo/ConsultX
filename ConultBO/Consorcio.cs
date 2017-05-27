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
using SQLite.Net.Attributes;

namespace ConsultBO
{

    public class Consorcio
    {
        [PrimaryKey, AutoIncrement]
        string nomeConsorcio { get; set; }
        Morada m { get; set; }
        bool consLider { get; set; } // se é ou nao lider
        Dictionary<string, RecursoHumano> conjRecursos { get; set; }
        
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