using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsultBO;

namespace ConsultDL
{
    public class GereProjeto:ControlaGestaoProjeto
    {

        Dictionary<string, Projeto> dictProjeto;


        public override bool VerificaSeExisteProjeto (string key)
        {
            return true;
        }
        public override bool AdicionaProjeto(Projeto p)
        {
            return true;
        }
        
    }

    public abstract class ControlaGestaoProjeto
    {
        public abstract bool VerificaSeExisteProjeto(string key);

        public abstract bool VerificaQuantosProjetosTemCustoSuperior(double custo);

        public abstract bool VerificaQuantosProjetosTemCustoInferior(double custo);


        public abstract bool OrdenaProjetosPorCusto();

        public abstract bool OrdenaProjetosPorOrdemAlfabetica();

        public abstract bool AdicionaProjeto(Projeto p);

    }

   
    
}
