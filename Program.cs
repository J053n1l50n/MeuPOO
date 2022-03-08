using System;
using ProjetoUm.source.Entidade;

namespace ProjetoUm
{
    class Program
    {
        static void Main(string[] args)
        {
            Heroi hero = new Heroi("Carlinhos", 32, 45, "Cavaleiro");
            Mago Boss = new Mago("serfitore", 95, 32, "Padino");
            Ninjacs naruto = new Ninjacs("Sasuke", 16, 26, "Shinobi");
            MagoN Yugi = new MagoN("Gaji", 25, 13, "Mago");
            Console.WriteLine(hero.ToString());
            Console.WriteLine(Boss.ToString());
            Console.WriteLine(naruto.ToString());
            Console.WriteLine(Yugi.ToString());
        }
    }
}
