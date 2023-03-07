using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Projeto3b
{
    internal abstract class Veiculo
    {
        string Modelo { get; set; }
        string Marca { get; set; }
        int Ano { get; set; }

        public abstract void Info(); 
        public virtual void MostrarModelo()
        {
            Console.WriteLine(Modelo);
        }
    }
}
