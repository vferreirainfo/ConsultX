using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsultBO;

namespace ConsultDL
{
    public class GereProjeto:ControlaGestaoProjeto
    {

        Dictionary<int, Projeto> dictProjeto;


        public override bool VerificaSeExisteProjeto (Projeto p,int key)
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
        public abstract bool VerificaSeExisteProjeto(Projeto p, int key);

        public abstract bool AdicionaProjeto(Projeto p);

    }

   
    
}
