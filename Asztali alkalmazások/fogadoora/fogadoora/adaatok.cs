using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fogadoora
{
    internal class adaatok
    {
        public string nev;
        public string idopont;
        public DateTime foglalas;

        public adaatok(string sor) 
        {
            string[] vag = sor.Split(" ");
            nev= vag[0]+" "+vag[1];
            idopont = vag[2];
            foglalas = Convert.ToDateTime(vag[3].Replace("-"," "));
        
        
        }
    }

    

}
