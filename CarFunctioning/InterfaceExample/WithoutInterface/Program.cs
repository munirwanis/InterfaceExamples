using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutInterface
{
    public class Uno
    {
        public void Partida()
        {
            Console.WriteLine("Uno deu partida");
        }
    }

    public class Gol
    {
        public void Partida()
        {
            Console.WriteLine("Gol deu partida");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Uno uno = new Uno();

            Gol gol = new Gol();

            Program.Action(uno);

            Program.Action(gol);

            Console.Read();
        }

        public static void Action(Uno uno)
        {
            uno.Partida();
        }

        public static void Action(Gol gol)
        {
            gol.Partida();
        }
    }
}
