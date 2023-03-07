using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Projeto3b
{
    internal interface IVeiculo
    {
        string Modelo { get; set; }
        string Marca { get; set; }
        int Ano { get; set; }

        void Info();

    }
}
