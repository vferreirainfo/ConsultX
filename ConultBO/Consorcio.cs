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
      
        int codPostal;
        bool consLider; // se é ou nao lider

        //List<RecursoHumano>
        public Consorcio()
        {

        }
        public Consorcio (string nomeC, bool consLid)
        {
            nomeConsorcio = nomeC;
            consLider = consLid;
        }
    }
}