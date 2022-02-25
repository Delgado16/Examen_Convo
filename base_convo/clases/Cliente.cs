using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_convo.clases
{
    internal class Cliente
    {
        int codiCliente;
        string nombrecliente;

        public Cliente()
        {
            codiCliente = 0;
            nombrecliente = string.Empty;
        }

        public Cliente(int Codigo_Cliente, string Nombre_Cliente)
        {
            this.codiCliente = Codigo_Cliente;
            this.nombrecliente = Nombre_Cliente;
        }

        public int Codigo_Cliente { get => codiCliente; set => codiCliente = value; }
        public string Nombre_Cliente { get => nombrecliente; set => nombrecliente = value; }


        public string consulta1()
        {

            return "Codigo de Cliente " +codiCliente + "\r\n" + "Nombre " + nombrecliente +"\r\n";

        }


    }
}
