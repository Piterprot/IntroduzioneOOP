using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SintassiClassi
{
     class Libro
    {

        // Get = All'esterno la proprietà può essere letta 
        // Set = All'esterno la proprietà può essere scritta
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public int Pagine { get; set; }
        public decimal Prezzo { get; set; }
        private int CodiceSegreto { get; }
        
        //costruttore => Il metodo per assegnare un valore alla proprietà 

        public Libro() { 
        // questo codice verrà eseguito quando si crea un oggetto con questa classe (new) 
        CodiceSegreto = 321;
        }
        public decimal PrezzoInDollari()
        {
            decimal prezzoConvertito = Prezzo * 0.89M; 
            return prezzoConvertito;

        }
    }
}
