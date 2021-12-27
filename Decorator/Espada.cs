using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Espada : PersonagemDecorator
    {
        Personagem personagem;

        public Espada(Personagem p)
        {
            personagem = p;
        }

        public override void quemSou()
        {
            personagem.quemSou();
            Console.WriteLine("Com uma Espada.");
        }

        public override Personagem remove()
        {

            return personagem;
        }

    }
}
