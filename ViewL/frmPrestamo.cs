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
    public partial class frmPrestamo : Form
    {
        private PrestamoBLL prestamoBLL = PrestamoBLL.Instance();
        public frmPrestamo()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            new frmNPrestamo { Text = "Nuevo Prestamo" }.ShowDialog();
            dgvPrestamos.DataSource = prestamoBLL.GetAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int idPrestamo = (int)(dgvPrestamos.CurrentRow.Cells[0].Value);
            frmNPrestamo nPrestamo = new frmNPrestamo(idPrestamo);
            nPrestamo.ShowDialog();

            dgvPrestamos.DataSource = prestamoBLL.GetAll();
        }

        private void frmPrestamo_Load(object sender, EventArgs e)
        {
            dgvPrestamos.DataSource = prestamoBLL.GetAll();
        }

        private void frmPrestamo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
