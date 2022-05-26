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
    public partial class frmNSucursal : DevExpress.XtraEditors.XtraForm
    {
        private int idSucursal = 0;
        public frmNSucursal()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public frmNSucursal(int idSucursal)
        {
            InitializeComponent();
            this.idSucursal = idSucursal;
            Sucursal sucursal = new Sucursal() { idSucursal = this.idSucursal }.GetById();
            CenterToScreen();
            txtNombre.Text = sucursal.nombre;
            txtDireccion.Text = sucursal.direccion;
            txtTelefono.Text = sucursal.telefono.ToString();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Estas seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmNSucursal_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmNSucursal_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            /*if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtTelefono.Text))
            {

                XtraMessageBox.Show("Debe completar la informacion", "Error 404");

                return;

            }*/


            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                XtraMessageBox.Show("Debe completar el nombre", "Error 404");

                return;
            } else if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                XtraMessageBox.Show("Debe completar la direccion", "Error 404");

                return;
            } else if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                XtraMessageBox.Show("Debe completar el telefono", "Error 404");

                return;
            }

            if (idSucursal > 0)
            {
                if (new Sucursal()
                {
                    idSucursal = idSucursal,
                    nombre = txtNombre.Text,
                    direccion = txtDireccion.Text,
                    telefono = txtTelefono.Text
                    
                }.Update() > 0)
                {
                    XtraMessageBox.Show("Sucursal modificada correctamente", "Sucursales",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                }
            }
            else
            {
                if (new Sucursal()
                {
                    nombre = txtNombre.Text,
                    direccion = txtDireccion.Text,
                    telefono = txtTelefono.Text

                }.Add() > 0)
                {
                    XtraMessageBox.Show("Sucursal almacenada correctamente", "Socios",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                }
            }

        }


        public void Clean()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtNombre.Focus();
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

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                XtraMessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
    }
}