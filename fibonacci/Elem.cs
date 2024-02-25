using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    public class Elem
    {
       public int sorszam { get; set; }
       public long ertek { get; set; }
        public Elem(int sorszam, long ertek)
        {
            this.sorszam = sorszam;
            this.ertek = ertek;
            
        }
    }

    
}
