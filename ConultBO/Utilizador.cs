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
    public enum EstadoCivil
    {
        Viuvo,
        Solteiro,
        Casado,
        Divorciado,
    }

    public class Utilizador: ControlUtilizador
    {
        int id;
        string nomeCompleto;
        string email;
        int numTelefone;
        int numTelemovel;
        DateTime dtNascimento;
        char genero;
        EstadoCivil estCivilUtilizador;



        public Utilizador (string nome, string emailPessoal, int numTel, int numMob, DateTime dtNasc, char gen, EstadoCivil estCiv)
        {

            nomeCompleto = nome;
            email = emailPessoal;
            numTelefone = numTel;
            numTelemovel = numMob;
            dtNascimento = dtNasc;
            genero = gen;
            estCivilUtilizador = estCiv;

        }

      

        public override string NomeUtilizador
        {
            get { return nomeCompleto; }
            set { nomeCompleto = value; }

        }
        public override string EmailUtilizador
        {
            get { return email; }
            set { email = value; }
        }

        public override int NumeroTelefoneUtilizador
        {
            get => numTelefone;
            set => numTelefone = value;
        }

    }

    public abstract class ControlUtilizador
    {
        public abstract string NomeUtilizador { get; set; }

        public abstract string EmailUtilizador { get; set; }

        public abstract int NumeroTelefoneUtilizador { get; set; }


    }

}