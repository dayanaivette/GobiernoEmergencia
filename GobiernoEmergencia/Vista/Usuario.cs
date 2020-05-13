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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        Beneficiados user = new Beneficiados();

     
        void limpiar()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtDUI.Clear();
            txtID.Focus();
        }

        void cargar()
        {
            using (EmergenciaGobEntities db = new EmergenciaGobEntities())
            {
                var tbUsuarios = db.Beneficiados;
                foreach (var iterardatostbUsuario in tbUsuarios)
                {
                    dtvUsuario.Rows.Add(iterardatostbUsuario.idUsuario, iterardatostbUsuario.Nombre,
                        iterardatostbUsuario.DUI);
                }
                //dvgUsuarios.DataSource = db.tb_usuarios.ToList();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (EmergenciaGobEntities db = new EmergenciaGobEntities())
            {
                user.idUsuario = Convert.ToInt32(txtID.Text);
                user.Nombre = txtNombre.Text;
                user.DUI = txtDUI.Text;
                db.Beneficiados.Add(user);
                db.SaveChanges();
            }

            MessageBox.Show("Se agrego corectamente");
            dtvUsuario.Rows.Clear();
            cargar();
            limpiar();
        }

        private void Usuario_Load_1(object sender, EventArgs e)
        {
            limpiar();
            cargar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (EmergenciaGobEntities db = new EmergenciaGobEntities())
            {
                string Id = dtvUsuario.CurrentRow.Cells[0].Value.ToString();
                int IdC = int.Parse(Id);
                user = db.Beneficiados.Where(VerificarId => VerificarId.idUsuario == IdC).First();
                user.idUsuario = Convert.ToInt32(txtID.Text);
                user.Nombre = txtNombre.Text;
                user.DUI = txtDUI.Text;

                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            MessageBox.Show("Se actualizò corectamente");
            dtvUsuario.Rows.Clear();
            cargar();
            limpiar();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            using (EmergenciaGobEntities db = new EmergenciaGobEntities())
            {
                string Id = dtvUsuario.CurrentRow.Cells[0].Value.ToString();

                user = db.Beneficiados.Find(int.Parse(Id));
                db.Beneficiados.Remove(user);
                db.SaveChanges();
            }
            MessageBox.Show("Se Elimino corectamente");
            dtvUsuario.Rows.Clear();
            cargar();
            limpiar();
        }

        private void dtvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String id = dtvUsuario.CurrentRow.Cells[0].Value.ToString();
            String nombre = dtvUsuario.CurrentRow.Cells[1].Value.ToString();
            String dui = dtvUsuario.CurrentRow.Cells[2].Value.ToString();
            txtID.Text = id;
            txtNombre.Text = nombre;
            txtDUI.Text = dui;
        }
    }
}
