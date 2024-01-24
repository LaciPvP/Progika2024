using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzemanyag
{
    internal class adatok
    {
        public  DateTime datum;
        public int benzinAr;
        public int gazolajAr;

        public adatok(string sor) 
        {
            string[] vag = sor.Split(";");
            datum = Convert.ToDateTime(vag[0]);
            benzinAr = int.Parse(vag[1]);
            gazolajAr = int.Parse(vag[2]);    
        
        }
        public int kulobseg()
        {
            return Math.Abs(benzinAr - gazolajAr);
        
        }
    }
}
