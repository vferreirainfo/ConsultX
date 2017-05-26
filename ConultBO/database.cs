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

namespace ConsultBO
{
    public class Database: DataBaseControlConfig
    {
        // A classe contem as definicoes de base de dados e metodos estaticos para trabalhar com BD

        string serverName;
        string userName;
        string dbname;// workspace
        string password; 

        
        public Database() { }


        public Database(string hostName, string userInfo, string name, string pass)
        {
            serverName = hostName;
            userName = userInfo;
            dbname = name;
            password = pass;
        }


        public override string ApexServerName
        {
            get { return serverName; }
            set { serverName = value; }
        }

        public override string ApexUserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public override string ApexDBName
        {
            get { return dbname; }
            set { dbname = value; }
        }


        public override string ApexUserPassword
        {
            get { return password; }
            set { password = value; }
        }

    }


    public abstract class DataBaseControlConfig
    {
        public abstract string ApexServerName
        {
            get; set;
        }

        public abstract string ApexUserName
        {
            get; set;
        }
        public abstract string ApexDBName
        {
            get; set;
        }
        public abstract string ApexUserPassword
        {
            get; set;
        }
    }
}