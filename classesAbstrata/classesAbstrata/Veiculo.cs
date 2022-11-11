using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace classesAbstrata
{
    internal class Veiculo:Carro
        
    {
        public void info()
        {
            Console.WriteLine("Classe Abstratas não podem ser instaciadas,as derivadas fazem essa função");
        }
      
        
    }

}
