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
    public class GereUtilizadores:ControlaGestaoUtilizadores
    {
        int a;
        Dictionary<string, Utilizador> conjuntoUtilizadores;
        bool returnResult = false;
        string msgExcecao;

        public override bool AdicionaEProcessaUtilizador(Utilizador user, out string excepcao)
        {

            try
            {
               
                conjuntoUtilizadores.Add(user.NomeUtilizador, user);
                returnResult = true;

                // falta conectar a BD !! 
            }
            catch(ImpossivelAdicionarUtilizadorException ex)
            {
                msgExcecao = ex.Message;
                
            }

            //Excecao de impossibilidade de conectar a BD!
            excepcao = msgExcecao;
            return returnResult;
        }
    }

    public abstract class ControlaGestaoUtilizadores
    {
        public abstract Dictionary<string, Utilizador> DicionarioUtilizadores { get; set; }

        public abstract bool AdicionaEProcessaUtilizador(Utilizador user, out string excepcao);

        public abstract Utilizador ProcuraUtilizador(Utilizador user, out string excecao);

        public abstract Utilizador DeterminaLiderProjeto();

        public abstract Utilizador DeterminaResponsaveisProjeto();

        public abstract List<Utilizador> DevolveUtilizadoresPorDTN (DateTime dtNascimento);

        public abstract List<Utilizador> DevolveTodosOsUtilizadoresCoordenadores (string typeUser);

        public abstract List<Utilizador> DevolveTodosOsTrabalhadoresEnvolvidosEmProjeto(string nomeProjeto, string typeUser);

        public abstract List<Utilizador> DevolveTodosOsUtilizadoresEnvolvidosEmProjeto(string nomeprojeto);

        public abstract int DeterminaQuantidadeDeTrabalhadoresPorProjeto(Projeto p, out string excecao);

        public abstract bool EfetuaLoginProcessaUtilizador(Utilizador user, out string excepcao);

        public abstract bool EliminaUtilizador(Utilizador user, out string excepcao);
    }
}