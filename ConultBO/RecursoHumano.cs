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

  
    public class RecursoHumano
    {

        Dictionary<string, Trabalhador> dicTrabalhadoresRecHumano;
        Consorcio consorcioPertencente;
  


        public RecursoHumano() { }

        public RecursoHumano(Dictionary<string,Trabalhador> conjTrabalhador, Consorcio consRH)
        {

        }


        public Dictionary<string, Trabalhador> DicionarioTrabakhadoresPertencentesRH
        {
            get { return dicTrabalhadoresRecHumano; }
            set { dicTrabalhadoresRecHumano = value; }
        }
    }
}