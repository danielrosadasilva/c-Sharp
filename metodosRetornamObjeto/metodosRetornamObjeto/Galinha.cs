using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodosRetornamObjeto
{
    internal class Galinha
    {
      protected  int numOvo;
      protected string nomeGalinha;

        public Galinha(string nomeGalinha)
        {
            numOvo = 0;
            this.nomeGalinha = nomeGalinha;
        }
        public Ovo botar()
        {
            numOvo++;
            return new Ovo(numOvo, nomeGalinha);
            
        }
        public void info()
        {
            new Ovo(numOvo, nomeGalinha);
        }
       
    }
}
