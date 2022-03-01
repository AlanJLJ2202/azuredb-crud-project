using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewL
{
    public partial class frmLogin : Form
    {
        UsuarioBLL usuarioBLL = UsuarioBLL.Instance();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (usuarioBLL.Login(new BOL.Usuario()
            {
                nombre = txtUsuario.Text,
                password = txtPassword.Text
            }))
            {
                MessageBox.Show("Usuario correcto", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Clean();
                frmMain obj = new frmMain();
                obj.ShowDialog();
            }
            else
                MessageBox.Show("El usuario o la contraseña son incorrectos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clean();
        }

        private void Clean()
        {
            txtUsuario.Text = "";
            txtPassword.Text = "";
            txtUsuario.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
