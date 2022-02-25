using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_convo.clases
{
    internal class Ventas
    {
        int codiVenta;
        int codiCliente;
        int codiProduto;
        int cantidad;
       // int subtotal;
        DateTime fecha;

        public Ventas()
        {
            codiVenta = 0;
            codiCliente = 0;
            codiProduto = 0;
            cantidad = 0;
           // subtotal = 0;
            fecha = DateTime.MaxValue;
        }

        public Ventas(int codiVenta, int codiCliente, int codiProduto, int cantidad, 
            DateTime fecha)
        {
            this.codiVenta = codiVenta;
            this.codiCliente = codiCliente;
            this.codiProduto = codiProduto;
            this.cantidad = cantidad;
          //  this.subtotal = subtotal;
            this.fecha = fecha;
        }

        public int Codigo_Venta { get => codiVenta; set => codiVenta = value; }
        public int Codigo_Cliente { get => codiCliente; set => codiCliente = value; }
        public int Codigo_Produto { get => codiProduto; set => codiProduto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
      //  public int Subtotal { get => subtotal; set => subtotal = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        public string Consulta3()
        {

            return "Codigo de Venta " + Codigo_Venta + "\r\n" + "Cantidad Comprada " + Cantidad + "\r\n" + "Fecha de Pedido " + Fecha + "\r\n";
        }
    }
}
