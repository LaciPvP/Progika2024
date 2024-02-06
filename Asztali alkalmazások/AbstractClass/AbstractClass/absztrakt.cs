using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal abstract class absztrakt:Interface1
    {
        public int szam()
        {
            return 1000000;
        }

        public abstract void kiir();

        int privatTusko = 0;
        public int tusko 
        {
            get { return privatTusko; }
            set { privatTusko = value; }
        }
    }
}
