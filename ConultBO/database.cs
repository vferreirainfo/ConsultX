using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ConultBO;
using SQLite.Net.Interop;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using SQLite.Net;

//[assembly : DefaultDependency(typeof(ConsultBO.Database))]


namespace ConsultBO
{
    public class Database: DataBaseControlConfig, IDisposable
    {
        // A classe contem as definicoes de base de dados e metodos estaticos para trabalhar com BD

       
        string dbname;// workspace
        string password;
        ISQLitePlatform plataforma;
        SQLiteConnection con;
        
        public Database() { }


        public Database(string name, string pass)
        {
          
            dbname = name;
            password = pass;
        }


  

        public override string DiretoriaDB
        {
            get {
                if (string.IsNullOrEmpty(dbname))
                {
                    var dir = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                    dbname = System.IO.Path.Combine(dir, "..", "Library");
                       
                }
                return dbname;
                    
            }
            set { dbname = value; }
        }
    

        public ISQLitePlatform Plataforma
        {
            get
            {
                if(plataforma==null)
                {

                    plataforma = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
                }
                return plataforma;

            }
        }

        public override string ApexUserPassword
        {
            get { return password; }
            set { password = value; }
        }

        public override bool CriaConexaoDB(out string errorMsg)
        {
            string msg = string.Empty;
            bool result = false;
            try
            { 
                var config = DependencyService.Get<IConfig>();
                con = new SQLiteConnection(config.Plataforma, System.IO.Path.Combine(config.DiretoriaDB, "ConsultX.db3"));
                result = true;
            }
            catch(Exception ex)
            {
                msg = ex.Message;
                result = false;
                
            }
            errorMsg = msg;
            return result;
        }

        public void Dispose()
        {
           
        }
    }


    public abstract class DataBaseControlConfig
    {
       

    
        public abstract string ApexUserPassword
        {
            get; set;
        }
        public abstract string DiretoriaDB { get; set; }
        public ISQLitePlatform Plataforma { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public abstract bool CriaConexaoDB(out string errorMsg);
    }
}