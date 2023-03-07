using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Projeto3b
{
    internal class Caminhao : Veiculo
    {
        public override void MostrarModelo()
        {
            Console.WriteLine("Mostrar modelo: ");
        }

        public override void Info()
        {
            Console.WriteLine("Info caminhão: ");
        }
    }
}
