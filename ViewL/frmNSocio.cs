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
    public partial class frmNSocio : Form
    {
        private SocioBLL socioBLL = SocioBLL.Instance();
        private SucursalBLL sucursalBLL = SucursalBLL.Instance();
        Socio socio = new Socio();
        int idSocio = 0;
        int idSucursal = 0;

        public frmNSocio()
        {
            
            InitializeComponent();
        }

        public frmNSocio(int idSocio)
        {
            InitializeComponent();
            this.idSocio = idSocio;
            socio.idSocio = idSocio;
            txtNombre.Text = socioBLL.GetByID(socio).nombre.ToString();
            txtApellido.Text = socioBLL.GetByID(socio).apellido.ToString();
            txtEdad.Text = socioBLL.GetByID(socio).edad.ToString();
            txtDireccion.Text = socioBLL.GetByID(socio).direccion.ToString();
        }

        private void frmNSocio_Load(object sender, EventArgs e)
        {
            
            Sucursales sucursales = sucursalBLL.GetAll();
            foreach(Sucursal sucursal in sucursales)
            {
                cbSucursal.Items.Add(sucursal.nombre);
            }
            txtNombre.Focus();
        }

        public void Clean()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            txtDireccion.Text = "";
            cbSucursal.Text = "";
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtEdad.Text)
                || string.IsNullOrEmpty(txtEdad.Text) || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(cbSucursal.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }





            if (!cbSucursal.Text.Equals(""))
            {
                idSucursal = sucursalBLL.GetByDescripcion(new Sucursal()
                {
                    nombre = cbSucursal.Text
                }).idSucursal;
            }

            if (idSocio > 0)
            {
                if (socioBLL.Update(new BOL.Socio()
                {
                    idSocio = idSocio,
                    nombre = txtNombre.Text,
                    apellido = txtApellido.Text,
                    edad = int.Parse(txtEdad.Text),
                    direccion = txtDireccion.Text,
                    idSucursal = idSucursal
                }))
                {
                    MessageBox.Show("Socio actualizado correctamente", Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                }
            }
            else
            {
                if (socioBLL.Add(new BOL.Socio()
                {
                    nombre = txtNombre.Text,
                    apellido = txtApellido.Text,
                    edad = int.Parse(txtEdad.Text),
                    direccion = txtDireccion.Text,
                    idSucursal = idSucursal
                }))
                {
                    MessageBox.Show("Socio ingresado correctamente", Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                }

            }

        }

        private void frmNSocio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
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

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten letras", "Precaucion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten letras", "Precaucion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
