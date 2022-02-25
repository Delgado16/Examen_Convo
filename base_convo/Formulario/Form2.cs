using base_convo.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace base_convo.Formulario
{
    public partial class Form2 : Form
    {
        List<Cliente> listC = new List<Cliente>();
        List<Productos> listPro = new List<Productos>();
        List<Ventas> listVenta = new List<Ventas>();

        int Facturas = 0;
        int Unidades = 0;
        int PrecioProduct = 0;

        public Form2()
        {
            InitializeComponent();
        }

        public void GetSubTotal()
        {


            IEnumerable<Productos> sub = from d in listPro select d;
            IEnumerable<Ventas> sub2 = from s in listVenta select s;

            foreach (var i in sub)
            {
                PrecioProduct = i.Precio;

            }

            foreach (var e in sub2)
            {
                Unidades = e.Cantidad;

            }



            int SubTotal;

            SubTotal = Unidades * PrecioProduct;

            txt_Subtotal.Text = "El Subtotal es de: "+ SubTotal.ToString();
           

        }

        #region linq
        public void nombreyExistencia1()
        {

            IEnumerable<Productos> nom = from d in listPro select d;

            foreach (Productos d in nom)
            {

                txtConsultas.AppendText(d.Nombreyexistencias());
            }
        }
        public void NombreClientes()
        {

            IEnumerable<Cliente> nom = from d in listC select d;

            foreach (Cliente d in nom)
            {

                txtConsultas.AppendText(d.consulta1());
            }
        }

        public void Factura()
        {

            IEnumerable<Productos> nom = from d in listPro select d;
            IEnumerable<Ventas> nom2 = from d in listVenta select d;
            IEnumerable<Cliente> nom3 = from d in listC select d;

            foreach (Cliente i in nom3)
            {
                txtConsultas.AppendText(i.consulta1());

            }
            foreach (Productos i in nom)
            {
                txtConsultas.AppendText(i.consulta2());

            }
            foreach (Ventas i in nom2)
            {
                txtConsultas.AppendText(i.Consulta3());

            }


            Facturas++;

            

        }

            #endregion linq

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            //Capturando los datos ingresados 
            int codi = int.Parse(txt_codiCliente.Text);
            string nom = txt_NomCliente.Text;

            //mandando los datos a los datagireview
            Cliente obje = new Cliente(codi, nom); 
            listC.Add(obje);

            dgvClientes.DataSource = null;
            dgvClientes.DataSource = listC;
            dgvClientes.ReadOnly = true;

            //se limpian los campos de texto
            txt_codiCliente.Clear();
            txt_NomCliente.Clear();

        }

        private void btn_Regis_Click(object sender, EventArgs e)
        {
            //capturando los datos ingresado
            int codiPro = int.Parse(txt_codiPro.Text);
            string nomP = txt_NomPro.Text;
            int precio = int.Parse(txt_Precio.Text);

            //danto un numero aleatorio a la cantidad de articulos existentes 
            Random rnd = new Random();
            int randomun = rnd.Next(0, 100);
            txt_UExisten.Text = randomun.ToString();

            MessageBox.Show("cantidad del articulo en existencia: "+randomun);


            //mandando los datos a los datagrieview
            Productos objePro = new Productos(codiPro, nomP, precio,randomun);
            listPro.Add(objePro);

            dgvProducto.DataSource = null;
            dgvProducto.DataSource = listPro;
            dgvProducto.ReadOnly = true;

            //se limpian los campos de textos
            txt_codiPro.Clear();
            txt_NomPro.Clear();
            txt_Precio.Clear();



        }

        private void btn_Existen_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Registro_Click(object sender, EventArgs e)
        {
            //capturando los datos
            int codisventa = int.Parse(txt_codiventa.Text),
                codiscliente = int.Parse(txt_codicliente2.Text),
                codisproducto = int.Parse(txt_codipro2.Text),
                canti = int.Parse(txt_cant.Text);
               // subtotal = int.Parse(txt_Subtotal.Text);
            DateTime fechas = DateTime.Parse(dtp_date.Text);

            //mandando los datos a los datagrieview
            Ventas objeVentas = new Ventas(codisventa, codiscliente, codisproducto, canti, fechas);
            listVenta.Add(objeVentas);

            dgvVenta.DataSource = null;
            dgvVenta.DataSource = listVenta;
            dgvVenta.ReadOnly = true;

            //Limpiamos lo campos de textos
            txt_codiventa.Clear();
            txt_codicliente2.Clear();
            txt_codipro2.Clear();
            txt_cant.Clear();
            txt_Subtotal.Clear();
            dtp_date.Value = DateTime.Now;

            GetSubTotal();


        }

        private void rdnombreyexistencia_CheckedChanged(object sender, EventArgs e)
        {
            txtConsultas.Clear();
            nombreyExistencia1();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void rdFactu_CheckedChanged(object sender, EventArgs e)
        {
            txtConsultas.Clear();
            Factura();
        }

        private void rdClientes_CheckedChanged(object sender, EventArgs e)
        {
            txtConsultas.Clear();
            NombreClientes();
        }

        private void rdFactottales_CheckedChanged(object sender, EventArgs e)
        {
            txtConsultas.Clear();
            txtConsultas.AppendText("El Total de Facturas Es De " + Facturas);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
