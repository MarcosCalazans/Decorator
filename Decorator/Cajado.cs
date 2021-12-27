using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Cajado : PersonagemDecorator
    {
        private Personagem personagem;

        public Cajado(Personagem p)
        {
            personagem = p;
        }

        public override void quemSou()
        {
            personagem.quemSou();
            Console.WriteLine("Com um Cajado...");
        }

        public override Personagem remove()
        {

            return personagem;
        }
    }
}
