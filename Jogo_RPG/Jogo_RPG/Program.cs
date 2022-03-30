using Jogo_RPG.Entities;
using System;

namespace Jogo_RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight aurus = new Knight("Aurus", 42, 749, 72, "Knight");
            Ninja wedge = new Ninja("Wedge", 42, 574, 89, "Ninja");
            Wizard jenica  = new Wizard("Jenica", 42, 601, 482, "Wizard White");
            Wizard topapa = new Wizard("Topapa", 42, 385, 641, "Wizard Black");


            Console.WriteLine(jenica.Attack(jenica));
            Console.WriteLine(jenica.Attack(jenica));
            Console.WriteLine(jenica.Attack(jenica));

            Console.WriteLine(topapa.Attack(topapa));
            Console.WriteLine(topapa.Attack(topapa));

            Console.WriteLine(wedge.Attack(wedge));

            Console.WriteLine(jenica);
            Console.WriteLine(topapa);
            Console.WriteLine(aurus);
            Console.WriteLine(wedge);

        }
    }
}
