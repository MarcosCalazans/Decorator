using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Inimigo : Personagem
    {
        public Inimigo()
        {

        }

        public override void quemSou()
        {
            Console.WriteLine("Sou um Inimigo... hahahah");
        }
    }
}
