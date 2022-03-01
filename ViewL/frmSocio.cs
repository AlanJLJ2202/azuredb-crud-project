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
    public partial class frmSocio : Form
    {
        private SocioBLL socioBLL = SocioBLL.Instance();

        public frmSocio()
        {
            InitializeComponent();
        }



        private void frmSocio_Load(object sender, EventArgs e)
        {
            dgvSocios.DataSource = socioBLL.GetAll();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            new frmNSocio { Text = "Nuevo Socio" }.ShowDialog();
            dgvSocios.DataSource = socioBLL.GetAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int idSocio = (int)(dgvSocios.CurrentRow.Cells[0].Value);
            frmNSocio nSocio = new frmNSocio(idSocio);
            nSocio.ShowDialog();

            dgvSocios.DataSource = socioBLL.GetAll();
        }
    }
}
