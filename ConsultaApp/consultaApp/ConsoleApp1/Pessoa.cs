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
        public void setEmail(string email)
        {
            this.email = email;
        }
        public  string getEmail()
        {
            return this.email;
        }
        public void setEndereco(string endereco)
        {
            this.endereco = endereco;
        }
        public string getEndereco()
        {
            return this.endereco;
        }
    }
    
}
