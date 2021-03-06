﻿using System;
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
    public enum GrauAcademico
    {
        THIRD, //9º
        SEC, // 12º
        Licenciatura,
        Mestrado,
        Doutoramento,

    }

    public class Trabalhador: Utilizador
    {
        string identificacao;
        bool isLider;
        GrauAcademico grauAcademicoRH;
        static string nome;
        static string emailPessoal;
        static int numTel;
        static int numMob;
        static DateTime dtNasc;
        static char gen;
        static EstadoCivil estCiv;
        int pertenceARecHumano;
        



        public Trabalhador(string codigo, bool trbLider):base(nome,emailPessoal,numTel,numMob,dtNasc,gen,estCiv)
        {
            identificacao = codigo;
            isLider = trbLider;
        }

        public string IdentificacaoTrabalhador
        {
            get { return identificacao; }
            set { identificacao = value; }
        }
        public bool TrabalhadorLider
        {
            get { return isLider; }
            set { isLider = value; }
        }
        
        public int IdentificacaoRecHum
        {
            get { return pertenceARecHumano; }
            set { pertenceARecHumano = value; }
        }


        public GrauAcademico GrauAcademicoTrabalhadores
        {
            get { return grauAcademicoRH; }
            set { grauAcademicoRH = value; }
        }



    }
}