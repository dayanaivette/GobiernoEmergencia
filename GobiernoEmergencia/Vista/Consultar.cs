using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GobiernoEmergencia.MODEL;

namespace GobiernoEmergencia.Vista
{
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }
    
        private void brnAdmin_Click(object sender, EventArgs e)
        {
            Administrador administrador = new Administrador();
            administrador.Show();
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {

            using (EmergenciaGobEntities db = new EmergenciaGobEntities())
            {
                var lista = from usuario in db.Beneficiados
                            where usuario.DUI == txtConsultar.Text

                            select new
                            {
                                Nombre = usuario.Nombre
                            };

                txtConsultar.Clear();

                if (lista.Count() > 0)
                {
                    foreach (var iterar in lista)
                    {
                        lblMensajeBeneficiado.Visible = true;
                        lblBeneficiado.Visible = true;
                        lblNoEres.Visible = false;
                        lblBeneficiado.Text = iterar.Nombre;
                    }

                }
                else
                {
                    lblMensajeBeneficiado.Visible = false;
                    lblBeneficiado.Visible = false;
                    lblNoEres.Visible = true;
                }
            }
        }

        private void Consultar_Load_1(object sender, EventArgs e)
        {
            txtConsultar.Focus();
            lblMensajeBeneficiado.Visible = false;
            lblBeneficiado.Visible = false;
            lblNoEres.Visible = false;
        }
    }
}
