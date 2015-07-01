using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherInterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Processador procesador = new Processador(new CarroRepositorioMock2());
            
            foreach (var item in procesador.Executar())
            {
                Console.WriteLine(String.Format("Nome: {0} - Ano:{1}", item.Nome, item.Ano));
            }
            Console.Read();
        }
    }

    public class Processador
    {
        private IRepositorioMock _repositorioMock;

        public Processador(IRepositorioMock repositorioMock)
        {
            this._repositorioMock = repositorioMock;
        }

        public Processador()
        {
            this._repositorioMock = new CarroRepositorioMock();
        }

        public IList<Carro> Executar()
        {
            return this._repositorioMock.Listar();
        }

        public IList<Carro> Executar(IRepositorioMock repositorioMock)
        {
            return repositorioMock.Listar();
        }
    }



    public interface IRepositorioMock
    {
        IList<Carro> Listar();
    }

    public class CarroRepositorioMock : IRepositorioMock
    {
        public IList<Carro> Listar()
        {
            return new List<Carro>(){
                new Carro(){
                     Ano = 2001,
                     Nome = "Uno",
                },

                new Carro(){
                     Ano = 2002,
                     Nome = "Gol",
                },

                new Carro(){
                     Ano = 2004,
                     Nome = "Ferrari",
                },
            };
        }
    }

    public class CarroRepositorioMock2 : IRepositorioMock
    {
        public IList<Carro> Listar()
        {
            return new List<Carro>(){
                new Carro(){
                     Ano = 2012,
                     Nome = "AUno",
                },

                new Carro(){
                     Ano = 2032,
                     Nome = "AGol",
                },

                new Carro(){
                     Ano = 2034,
                     Nome = "AFerrari",
                },
            };
        }
    }

    public class Carro
    {
        public string Nome { get; set; }

        public int Ano { get; set; }
    }
}