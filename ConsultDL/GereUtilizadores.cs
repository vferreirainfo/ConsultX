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
        int b;
        Dictionary<string, Utilizador> conjuntoUtilizadores;
        Dictionary<string, Projeto> conjuntoProjetos;
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

        public override Utilizador DeterminaLiderProjeto(Projeto p)
        {
            foreach (KeyValuePair<string, Projeto> proj in conjuntoProjetos)
            {
                // se p existe
                if (p == proj.Value)
                {
                        
                }
            }
        }
    }

    public abstract class ControlaGestaoUtilizadores
    {
        public abstract Dictionary<string, Utilizador> DicionarioUtilizadores { get; set; }

        public abstract bool AdicionaEProcessaUtilizador(Utilizador user, out string excepcao);

        public abstract Utilizador ProcuraUtilizador(Utilizador user, out string excecao);

        public abstract Utilizador DeterminaLiderProjeto(Projeto p);

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