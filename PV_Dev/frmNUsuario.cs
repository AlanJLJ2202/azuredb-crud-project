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
    public partial class frmNUsuario : DevExpress.XtraEditors.XtraForm
    {
        private int idUsuario = 0;
        public frmNUsuario()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public frmNUsuario(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            Usuario usuario = new Usuario() { idUsuario = this.idUsuario }.GetById();
            CenterToScreen();
            txtNombre.Text = usuario.nombre;
            txtPassword.Text = usuario.password;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Estas seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {

                XtraMessageBox.Show("Debe completar la informacion", "Error 404");

                return;

            }

            if (idUsuario > 0)
            {
                if (new Usuario()
                {
                    idUsuario = idUsuario,
                    nombre = txtNombre.Text,
                    password = txtPassword.Text,
                    

                }.Update() > 0)
                {
                    XtraMessageBox.Show("Usuario modificado correctamente", "Usuarios",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                }
            }
            else
            {
                if (new Usuario()
                {
                    nombre = txtNombre.Text,
                    password = txtPassword.Text,
                    
                }.Add() > 0)
                {
                    XtraMessageBox.Show("Usuario almacenado correctamente", "Usuarios",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                }
            }
        }

        public void Clean()
        {
            txtNombre.Text = "";
            txtPassword.Text = "";
            txtNombre.Focus();
        }

        private void frmNUsuario_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                XtraMessageBox.Show("Solo se permiten letras", "Precaucion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
    }
}