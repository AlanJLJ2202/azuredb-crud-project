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
    public partial class frmUsuario : Form
    {
        private UsuarioBLL usuarioBLL = UsuarioBLL.Instance();
        Usuario usuario = new Usuario();
        public int idUsuario = 0;

        public frmUsuario()
        {
            InitializeComponent();
        }



        private void frmUsuario_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = usuarioBLL.GetAll();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            new frmNUsuario { Text = "Nuevo Usuario" }.ShowDialog();
            dgvUsuarios.DataSource = usuarioBLL.GetAll();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idUsuario = (int)(dgvUsuarios.CurrentRow.Cells[0].Value);
            frmNUsuario nUsuario = new frmNUsuario(idUsuario);
            nUsuario.ShowDialog();

            dgvUsuarios.DataSource = usuarioBLL.GetAll();
        }
    }
}
