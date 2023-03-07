using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Projeto3b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IVeiculo v = new IVeiculo ()
            Caminhao c = new Caminhao();
            //c.Info();
            c.MostrarModelo();

            Console.ReadKey();

        }
    }
}
