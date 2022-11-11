using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesAbstrata
{
    internal abstract class  Carro
    {
        private int id = 12;

         public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return id;
        }
    }
}
