using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Projeto3b
{
    internal class Carro : IVeiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano {  get; set; }   

        public void Info ()
        {
            Console.WriteLine ($"{Marca} - {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
           //Console.WriteLine($"Ano: {Ano}");
        }

    }
}
