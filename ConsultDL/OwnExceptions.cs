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

namespace ConsultDL
{
    public class ImpossivelAdicionarUtilizadorException: Exception
    {
        static string message = "Ñão foi possivel adicionar. Tente novamente!";
        public ImpossivelAdicionarUtilizadorException():base(message)
        {

        }
    }
}