using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Negocio;

namespace Biblioteca.Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = new DataTable();
                tabla = NUsuario.Login(txtEmail.Text.Trim(), txtClave.Text.Trim());
                if (tabla.Rows.Count <= 0)
                {
                    MessageBox.Show("El email o la clave es incorrecta", "Sistema de biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FrmHome frm = new FrmHome();
                    frm.idUsuario = Convert.ToInt32(tabla.Rows[0][0]);
                    frm.idRol = Convert.ToInt32(tabla.Rows[0][1]);
                    frm.nombreRol = Convert.ToString(tabla.Rows[0][2]);
                    frm.nombre = Convert.ToString(tabla.Rows[0][3]);
                    frm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
