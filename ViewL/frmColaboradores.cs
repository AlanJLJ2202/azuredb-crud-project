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
    public partial class frmColaboradores : Form
    {
        private ColaboradorBLL colaboradorBLL = ColaboradorBLL.Instance();

        public frmColaboradores()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            new frmNColaborador { Text = "Nuevo colaborador" }.ShowDialog();
            dgvColaboradores.DataSource = colaboradorBLL.GetAll();
        }

        private void frmColaboradores_Load(object sender, EventArgs e)
        {
            dgvColaboradores.DataSource = colaboradorBLL.GetAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int idColaborador = (int)(dgvColaboradores.CurrentRow.Cells[0].Value);
            frmNColaborador nColaborador = new frmNColaborador(idColaborador);
            nColaborador.ShowDialog();

            dgvColaboradores.DataSource = colaboradorBLL.GetAll();
        }
    }
}
