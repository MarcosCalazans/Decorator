using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Armadura : PersonagemDecorator
    {

        private Personagem personagem;

        public Armadura(Personagem p)
        {
            personagem = p;
        }

        public override void quemSou()
        {
            personagem.quemSou();
            Console.WriteLine("Com uma Armadura");
        }

        public override Personagem remove()
        {

            return personagem;
        }
    }
}
