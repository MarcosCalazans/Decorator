using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    abstract class PersonagemDecorator : Personagem
    {
        abstract override public void quemSou();

        public abstract override Personagem remove();
    }
}
