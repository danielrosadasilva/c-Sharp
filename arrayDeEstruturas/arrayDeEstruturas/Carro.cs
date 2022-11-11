using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayDeEstruturas
{
    internal struct Carro
    {
       private string cor;
       private string modelo;

        public void info()
        {
            Console.WriteLine(this.modelo);
            Console.WriteLine(this.cor);
            Console.WriteLine("-------------");
        }
        public void setCor(string cor)
        {
            this.cor = cor;
        }
        public string getCor()
        {
            return this.cor;
        }
        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public string getModelo()
        {
            return modelo;
        }
    }

}
