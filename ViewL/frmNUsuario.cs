using BLL;
using BOL;
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
    public partial class frmNUsuario : Form
    {

        private UsuarioBLL usuarioBLL = UsuarioBLL.Instance();
        Usuario usuario = new Usuario();
        public int idUsuario = 0;
        public bool vacio;
        public frmNUsuario()
        {
            InitializeComponent();
        }

        public frmNUsuario(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            usuario.idUsuario = idUsuario;
            txtNombre.Text = usuarioBLL.GetByID(usuario).nombre.ToString();
            txtPassword.Text = usuarioBLL.GetByID(usuario).password.ToString();
        }



        private void validar(Form formulario)
        {
            foreach (Control oControls in formulario.Controls) // Buscamos en cada TextBox de nuestro Formulario.
            {
                if (oControls is TextBox & oControls.Text == String.Empty) // Verificamos que no este vacio.
                {
                    vacio = true; // Si esta vacio el TextBox asignamos el valor True a nuestra variable.
                }
            }
            if (vacio == true) MessageBox.Show("Favor de llenar todos los campos."); // Si nuestra variable es verdadera mostramos un mensaje.
            vacio = false; // Devolvemos el valor original a nuestra variable.
            Clean();
        }

        private void frmNUsuario_Load(object sender, EventArgs e)
        {
            
        }

        public void Clean()
        {
            txtNombre.Text = "";
            txtPassword.Text = "";
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }
            if (idUsuario > 0)
            {
                if (usuarioBLL.Update(new BOL.Usuario()
                {
                    idUsuario = idUsuario,
                    nombre = txtNombre.Text,
                    password = txtPassword.Text,
                    
                }))
                {
                    MessageBox.Show("Usuario actualizado correctamente", Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                }
            }
            else
            {
                if (usuarioBLL.Add(new BOL.Usuario()
                {
                    nombre = txtNombre.Text,
                    password = txtPassword.Text
                    
                }))
                {
                    MessageBox.Show("Usuario ingresado correctamente", Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                }

            }
        }

        private void frmNUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten letras", "Precaucion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten letras", "Precaucion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
    }
}
