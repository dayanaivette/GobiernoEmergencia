using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GobiernoEmergencia
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.Text = "admin";
            txtClave.Text = "123";
            txtClave.PasswordChar = '*';
        }
        
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" && txtClave.Text == "")
            {
                MessageBox.Show("usuario o clave incorrecta.");
            }
            else
            {
                Usuario usuario = new Usuario();
                usuario.Show();
            }
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }
    }
}
