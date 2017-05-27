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
using ConsultBO;
namespace ConsultDL
{
    public class DataConnection
    {


        Database dbSettings;

        public DataConnection() { }



        public Database DBSettings
        {
            get { return dbSettings; }
            set { dbSettings = value; }
        }
        
    }
}