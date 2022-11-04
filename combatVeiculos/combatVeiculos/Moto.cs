using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexadorClasse
{
    internal class Moto:Veiculo,Iveiculo
    {
        String modelo;
        private bool ligado=false;
        private int velocidade=0;

        public void criarMoto(int ano, string placa, string marca,string cor)
        {
            this.marca = marca;
            this.placa = placa;
            this.ano = ano;
            this.cor = cor;
        }
        
        public void ligar()
        {
            ligado=true;
        }
        public void freiar()
        {
            velocidade=0;
        }
        public void acelerar()
        {
            velocidade++;
        }
    }
}
