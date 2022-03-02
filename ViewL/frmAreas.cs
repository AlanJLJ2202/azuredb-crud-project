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
    public partial class frmAreas : Form
    {
        private AreaBLL areaBLL = AreaBLL.Instance();
        public frmAreas()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            new frmNArea { Text = "Nueva area" }.ShowDialog();
            dgvAreas.DataSource = areaBLL.GetAll();
        }

        private void frmAreas_Load(object sender, EventArgs e)
        {
            dgvAreas.DataSource = areaBLL.GetAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int idArea = (int)(dgvAreas.CurrentRow.Cells[0].Value);
            frmNArea nArea = new frmNArea(idArea);
            nArea.ShowDialog();

            dgvAreas.DataSource = areaBLL.GetAll();
        }

        private void frmAreas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
