using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexadorClasse
{
    internal class Carro:Veiculo,Iveiculo,Icombate
    {
        private int[]velocidade=new int[5] {0,10,20,30,40};
        private bool ligado = false;
        private int municao=100;
        private int hp = 100;

       
        public int this[int i]
        {
            get
            {
                return velocidade[i];
            }
            set
            {
               velocidade[i] = value;
            }
        }

        public void criarCarro(int ano, string placa, string marca, string cor)
        {
            this.ano = ano;
            this.placa = placa;
            this.marca = marca;
            this.cor = cor;

        }
        public void infoCarro()
        {
            Console.WriteLine("Ano:"+ano);
            Console.WriteLine("Placa:"+placa);
            Console.WriteLine("Marca:"+marca);
            Console.WriteLine("ligado:{0} , municao:{1}, hp:{2}",ligado,municao,hp);
        }

        public void ligar()
        {
            ligado=true;
         
        }
        public void atirar()
        {

            municao -= 1;

        }
        public void curar()
        {
            while(hp < 100 )
            {
                hp += 1;
            }
            
        }
        public void dano()
        {
            if (hp > 0)
            {
                hp -=1;
            }
            else
            {
                Console.WriteLine("killed");
            }
        }
        public void freiar()
        {
            velocidade[1] = 0;
        }
        public void acelerar()
        {
            velocidade[1] ++;
        }

    }

    
}
