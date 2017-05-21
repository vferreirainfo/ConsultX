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
    public class Pais
    {
        int id;
        string nomePais;
        string continentePertencente;
        bool existemIlhas;


        public Pais() { }

        public Pais(string nome, string continente, bool temIlhas)
        {
            nomePais = nome;
            continentePertencente = continente;
            existemIlhas = temIlhas;
        }
        public string NomePais
        {
            get { return nomePais; }
            set { nomePais = value; }
        }
        public string Continente
        {
            get { return continentePertencente; }
            set { continentePertencente = value; }
        }
        public bool ExistemIlhas
        {
            get { return existemIlhas; }
            set { existemIlhas = value; }
        }

    }
}