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
    public partial class frmNSocio : DevExpress.XtraEditors.XtraForm
    {
        private int idSocio = 0;

        public frmNSocio()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public frmNSocio(int idSocio)
        {
            InitializeComponent();
            this.idSocio = idSocio;
            Socio socio = new Socio() { idSocio = this.idSocio }.GetById();
            CenterToScreen();
            txtNombre.Text = socio.nombre;
            txtApellido.Text = socio.apellido;
            txtEdad.Text = socio.edad.ToString();
            txtDireccion.Text = socio.direccion;
            cbSucursal.EditValue = socio.idSucursal;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Estas seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmNSocio_Load(object sender, EventArgs e)
        {
            sucursalBindingSource.DataSource = new Sucursal().GetAll();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtEdad.Text)
                || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(cbSucursal.Text))
            {

                XtraMessageBox.Show("Debe completar la informacion", "Error 404");

                return;

            }

            if (idSocio > 0)
            {
                if (new Socio()
                {
                    idSocio = idSocio,
                    nombre = txtNombre.Text,
                    apellido = txtApellido.Text,
                    edad = int.Parse(txtEdad.Text),
                    direccion = txtDireccion.Text,
                    idSucursal = (int)cbSucursal.EditValue

                }.Update() > 0)
                {
                    XtraMessageBox.Show("Socio modificado correctamente", "Socios",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                }
            }
            else
            {
                if (new Socio()
                {
                    nombre = txtNombre.Text,
                    apellido = txtApellido.Text,
                    edad = int.Parse(txtEdad.Text),
                    direccion = txtDireccion.Text,
                    idSucursal = (int)cbSucursal.EditValue
                }.Add() > 0)
                {
                    XtraMessageBox.Show("Socio almacenado correctamente", "Socios",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                }
            }


           
        }

        public void Clean()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            txtDireccion.Text = "";
            cbSucursal.EditValue = "";
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

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                XtraMessageBox.Show("Solo se permiten letras", "Precaucion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
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