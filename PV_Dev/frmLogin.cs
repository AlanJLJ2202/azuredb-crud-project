using DAL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV_Dev
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        Usuario usuario = new Usuario();
        public frmLogin()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        public void Login()
        {


            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtClave.Text))
            {

                XtraMessageBox.Show("Debe completar la informacion");

                return;

            }


            if (new Usuario()
            {
                nombre = txtUsuario.Text,
                password = txtClave.Text
            }.Login() != null)
            {

                XtraMessageBox.Show("Ingreso correctamente", "Bienvenido");
                this.Hide();
                new frmMain { Text = "Principal" }.ShowDialog();
                this.Show();

            }
            else
            {
                XtraMessageBox.Show("Usuario no valido", "Error 404");
            }

        }



        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("Estas seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Estas seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}