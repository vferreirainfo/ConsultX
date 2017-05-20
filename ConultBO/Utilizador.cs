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
    public enum EstadoCivil
    {
        Viuvo,
        Solteiro,
        Casado,
        Divorciado,
    }

    public class Utilizador
    {

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

        }
    }
}