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
    public partial class frmNSucursal : Form
    {
        private SucursalBLL sucursalBLL = SucursalBLL.Instance();
        Sucursal sucursal = new Sucursal();
        public int idSucursal = 0;

        public frmNSucursal()
        {
            InitializeComponent();
        }

        public frmNSucursal(int idSucursal)
        {
            InitializeComponent();
            this.idSucursal = idSucursal;
            sucursal.idSucursal = idSucursal;
            txtNombre.Text = sucursalBLL.GetByID(sucursal).nombre.ToString();
            txtDireccion.Text = sucursalBLL.GetByID(sucursal).direccion.ToString();
            txtTelefono.Text = sucursalBLL.GetByID(sucursal).telefono.ToString();
        }


        public void Clean()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtNombre.Focus();
        }

        private void frmNSucursal_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (idSucursal > 0)
            {
                if (sucursalBLL.Update(new BOL.Sucursal()
                {
                    idSucursal = idSucursal,
                    nombre = txtNombre.Text,
                    direccion = txtDireccion.Text,
                    telefono = txtTelefono.Text
                }))
                {
                    MessageBox.Show("Sucursal actualizada correctamente", Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                }
            }
            else
            {
                if (sucursalBLL.Add(new BOL.Sucursal()
                {
                    nombre = txtNombre.Text,
                    direccion = txtDireccion.Text,
                    telefono = txtTelefono.Text
                }))
                {
                    MessageBox.Show("Sucursal ingresada correctamente", Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                }

            }
        }
    }
}
