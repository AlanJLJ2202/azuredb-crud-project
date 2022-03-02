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
    public partial class frmAhorros : Form
    {
        private AhorroBLL ahorroBLL = AhorroBLL.Instance();
        public frmAhorros()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            new frmNAhorro { Text = "Nuevo ahorro" }.ShowDialog();
            dgvAhorros.DataSource = ahorroBLL.GetAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int idAhorro = (int)(dgvAhorros.CurrentRow.Cells[0].Value);
            frmNAhorro nAhorro = new frmNAhorro(idAhorro);
            nAhorro.ShowDialog();

            dgvAhorros.DataSource = ahorroBLL.GetAll();
        }

        private void frmAhorros_Load(object sender, EventArgs e)
        {
            dgvAhorros.DataSource = ahorroBLL.GetAll();
        }

        private void frmAhorros_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
