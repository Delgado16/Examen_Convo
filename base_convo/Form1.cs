using base_convo.Formulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace base_convo
{
    public partial class Form1 : Form
    {
        List<string> listTipoUsuario = new List<string>();
        public Form1()
        {
            InitializeComponent();
            listTipoUsuario.Add("ADMINISTRADOR");
            listTipoUsuario.Add("VENDEDOR");
            listTipoUsuario.Add("CAJERO");

            foreach (string elemento in listTipoUsuario)
            {
                cbo_tipouser.Items.Add(elemento);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_acceder.Enabled = false;
        }
        public void vali_vacio(string a, string b)
        {
            if (a != "" && b != "")
            {
                btn_acceder.Enabled = true;
            }
        }

        private void btn_acceder_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
            Form2 iuAdmin = new Form2();
            iuAdmin.lbl_bienvenida.Text = "Bienvenido" + " " + txt_user.Text;
            iuAdmin.Show();
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {
            //if (txt_user.Text != "" && txt_pass.Text != "")
            //{
            //    btn_acceder.Visible = true;
            //}
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            if (txt_user.Text != "" && txt_pass.Text != "")
            {
                btn_acceder.Enabled = true;
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
