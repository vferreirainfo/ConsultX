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


    public class Morada:ControlaMorada
    {
        int morId;
        ClassificacaoMorada classMorada;
        int numPorta;
        string codPostal;
        Pais p;

        public Morada() { }


        public override int IdentificacaoMorada
        {
            get
            {
                return IdentificacaoMorada;
            }
            set
            {
                IdentificacaoMorada = value;
            }
        }

        public override ClassificacaoMorada ClassificacaoMorada {
            get => classMorada;   
            set => classMorada = value;
        }

        public override int NumeroResidencia {
            get => numPorta; set => numPorta = value;
        }
    }

    public abstract class ControlaMorada
    {
       public abstract int IdentificacaoMorada { get; set; }

       public abstract ClassificacaoMorada ClassificacaoMorada { get; set; }

        public abstract int NumeroResidencia { get; set; }


    }
}