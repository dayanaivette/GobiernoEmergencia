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
            txtClave.PasswordChar = '*';
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Usuario usuario = new Usuario();
            //usuario.Show();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }
        
    }
}
