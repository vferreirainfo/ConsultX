using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConultBO
{
    public class Projeto:ControlProject
    {

        Dictionary<string, Consorcio> conjuntoConsorcios;
        DateTime dtInicio;
        DateTime dtFim;


        public Projeto()
        {

        }


        public Projeto(List<Consorcio> cons)
        {

        }

        public Dictionary<string, Consorcio> AcessoDicConsorcios
        {
            get { return conjuntoConsorcios; }
            set { conjuntoConsorcios = value; }
        }
    }
    public abstract class ControlProject
    {
       public abstract Dictionary<string,Consorcio> AcessoDicConsorcios
        {
            get;
            set;
        }
        public abstract DateTime DataInicioProjeto
        {
            get;
            set;
        }
        public abstract DateTime DataFimProjeto
        {
            get;
            set;
        }
    }
    
}
