using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem p;
            p = new Personagem();
            p.quemSou();
            Console.ReadKey();           

            p = new Armadura(p);
            p.quemSou();

            Console.ReadKey();

            Personagem p2 = new Personagem();
            p2 = new Armadura(p2);
            p2.quemSou();
            Console.ReadKey();

            p = new Cajado(p);
            p.quemSou();

            Console.ReadKey();

            p = p.remove();
            p.quemSou();

            Console.ReadKey();


            Personagem i = new Inimigo();
            i.quemSou();

            Console.ReadKey();

            i = new Espada(i);
            i.quemSou();

            Console.ReadKey();
         
        }
    }
}
