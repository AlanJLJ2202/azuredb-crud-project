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
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }


            if (usuarioBLL.Login(new BOL.Usuario()
            {
                nombre = txtUsuario.Text,
                password = txtPassword.Text
            }))
            {
                
                MessageBox.Show("Usuario correcto", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //DialogResult = DialogResult.OK;
                this.Hide();
                frmMain obj = new frmMain();
                obj.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("El usuario o la contraseña son incorrectos", "Usuario Invalido", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (MessageBox.Show("Estas seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {

            }


            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas salir?","Salir",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
