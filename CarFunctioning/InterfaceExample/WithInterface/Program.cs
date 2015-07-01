using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithInterface
{
    public interface ICarro
    {
        void Partida();
    }

    public class Uno : ICarro
    {
        public void Partida()
        {
            Console.WriteLine("Uno deu a partida");
        }
    }
    
    public class Ferrari : ICarro
    {
        public void Partida()
        {
            Console.WriteLine("Ferrari deu partida");
        }
    }
    
    public class Gol : ICarro
    {
        public void Partida()
        {
            Console.WriteLine("Gol deu a partida");
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

            Program.Action(new Ferrari());

            Console.Read();
        }

        public static void Action(ICarro carro)
        {
            carro.Partida();
        }
    }
}
