using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodosRetornamObjeto
{
    internal class Ovo
    {
        int numOvo;
        string nomeGalinha;
        public Ovo(int numOvo, string nomeGalinha)
        {
            this.numOvo = numOvo;
            this.nomeGalinha = nomeGalinha;
            Console.WriteLine("Ovo :{0} Galinha:{1} ", this.numOvo, this.nomeGalinha);
        }
    }
}
