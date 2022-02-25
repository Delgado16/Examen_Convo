using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_convo.clases
{
    internal class Productos
    {
        int codiproducto;
        string nombreProcto;
        int precio;
        int existencia;

        public Productos()
        {
            codiproducto = 0;
            nombreProcto = string.Empty;
            precio = 0;
            existencia = 0;
        }

        public Productos(int codiproducto, string nombreProcto, int precio, int random)
        {
            this.codiproducto = codiproducto;
            this.nombreProcto = nombreProcto;
            this.precio = precio;
            this.existencia = random;
        }

        public int Codigo_Producto { get => codiproducto; set => codiproducto = value; }
        public string Nombre_Producto { get => nombreProcto; set => nombreProcto = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Existencia { get => existencia; set => existencia = value; }



        public string Nombreyexistencias()
        {

            return Nombre_Producto + " Tiene en existencia: " + Existencia+ " ";
        } 
        public string consulta2()
        {

            return "Codigo de producto " + Codigo_Producto + "\r\n" + "Nombre de Producto " + Nombre_Producto + "\r\n" + "Precio Unitario" + Precio + "\r\n";
        }
    }
}
