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
    }
}
