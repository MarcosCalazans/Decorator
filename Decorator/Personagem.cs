using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Personagem
    {
        public Personagem()
        {


        }

        public virtual void quemSou()
        {
            Console.WriteLine("Sou o Personagem!");
        }

        public virtual Personagem remove()
        {
            return this;
        }
    }
}
