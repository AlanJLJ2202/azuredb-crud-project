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
    public partial class frmSucursal : Form
    {
        private SucursalBLL sucursalBLL = SucursalBLL.Instance();
        public frmSucursal()
        {
            InitializeComponent();
        }

        private void frmSucursal_Load(object sender, EventArgs e)
        {
            dgvSucursales.DataSource = sucursalBLL.GetAll();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            new frmNSucursal { Text = "Nueva Sucursal" }.ShowDialog();
            dgvSucursales.DataSource = sucursalBLL.GetAll();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idSucursal = (int)(dgvSucursales.CurrentRow.Cells[0].Value);
            frmNSucursal nSucursal = new frmNSucursal(idSucursal);
            nSucursal.ShowDialog();

            dgvSucursales.DataSource = sucursalBLL.GetAll();
        }

        private void frmSucursal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
