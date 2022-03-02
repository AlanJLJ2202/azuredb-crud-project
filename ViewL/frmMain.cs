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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAhorros_Click(object sender, EventArgs e)
        {
            frmAhorros obj = new frmAhorros();
            obj.ShowDialog();
        }

        private void btnAreas_Click(object sender, EventArgs e)
        {
            frmAreas obj = new frmAreas();
            obj.Show();
        }

        private void btnColaboradores_Click(object sender, EventArgs e)
        {
            frmColaboradores obj = new frmColaboradores();
            obj.Show();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            frmPrestamo obj = new frmPrestamo();
            obj.Show();
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            
            frmSocio obj = new frmSocio();
            obj.ShowDialog();
            
        }

        private void btnSucursales_Click(object sender, EventArgs e)
        {
            frmSucursal obj = new frmSucursal();
            obj.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuario obj = new frmUsuario();
            obj.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void salir()
        {
            
                this.Close();
            
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            salir();
        }
    }
}
