using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pessoa
    {
        private string nome;
        private string email;  
        private string endereco;
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;   
        }
        public  string getEmail()
        {
            return this.email;
        }
        
    }
    
}
