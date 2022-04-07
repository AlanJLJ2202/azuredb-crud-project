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
    public partial class frmNColaborador : DevExpress.XtraEditors.XtraForm
    {
        private int idColaborador = 0;
        public frmNColaborador()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public frmNColaborador(int idColaborador)
        {
            InitializeComponent();
            this.idColaborador = idColaborador;
            Colaborador colaborador = new Colaborador() { idColaborador = this.idColaborador }.GetById();
            CenterToScreen();
            txtNombre.Text = colaborador.nombre;
            txtApellido.Text = colaborador.apellido;
            txtEdad.Text = colaborador.edad.ToString();
            txtDireccion.Text = colaborador.direccion;
            txtSueldo.Text = colaborador.sueldo.ToString();
            cmbArea.EditValue = colaborador.idArea;
            cmbSucursal.EditValue = colaborador.idSucursal;
        }

        private void frmNColaborador_Load(object sender, EventArgs e)
        {
            
            areaBindingSource.DataSource = new Area().GetAll();
            sucursalBindingSource.DataSource = new Sucursal().GetAll();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Estas seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtEdad.Text)
                || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtSueldo.Text) || string.IsNullOrEmpty(cmbArea.Text) || string.IsNullOrEmpty(cmbSucursal.Text))
            {

                XtraMessageBox.Show("Debe completar la informacion", "Error 404");

                return;
            }

            if (idColaborador > 0)
            {
                if (new Colaborador()
                {
                    idColaborador = idColaborador,
                    nombre = txtNombre.Text,
                    apellido = txtApellido.Text,
                    edad = int.Parse(txtEdad.Text),
                    direccion = txtDireccion.Text,
                    sueldo = decimal.Parse(txtSueldo.Text),
                    idArea = (int)cmbArea.EditValue,
                    idSucursal = (int)cmbSucursal.EditValue

                }.Update() > 0)
                {
                    XtraMessageBox.Show("Colaborador modificado correctamente", "Colaborador",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                }
            }
            else
            {
                if (new Colaborador()
                {
                    nombre = txtNombre.Text,
                    apellido = txtApellido.Text,
                    edad = int.Parse(txtEdad.Text),
                    direccion = txtDireccion.Text,
                    sueldo = decimal.Parse(txtSueldo.Text),
                    idArea = (int)cmbArea.EditValue,
                    idSucursal = (int)cmbSucursal.EditValue
                }.Add() > 0)
                {
                    XtraMessageBox.Show("Colaborador almacenado correctamente", "Colaborador",
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
            txtSueldo.Text = "";
            cmbArea.EditValue = "";
            cmbSucursal.EditValue = "";
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

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
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