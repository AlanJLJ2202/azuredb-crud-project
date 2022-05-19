using DAL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV_Dev
{
    public partial class frmNEstadoCuenta : DevExpress.XtraEditors.XtraForm
    {
        private int idSocio = 0;
        public frmNEstadoCuenta()
        {
            InitializeComponent();
        }

        public frmNEstadoCuenta(int idSocio)
        {
            InitializeComponent();
            this.idSocio = idSocio;
            Socio socio = new Socio() { idSocio = this.idSocio }.GetById();
            CenterToScreen();
            txtNombreCompleto.Text = socio.nombre;
            txtApellido.Text = socio.apellido;
            txtEdad.Text = socio.edad.ToString();
            txtDireccionCompleta.Text = socio.direccion;
            txtSucursal.Text = socio.idSucursal.ToString();
        }

        private void txtTelefono_Click(object sender, EventArgs e)
        {

        }

        private void frmNEstadoCuenta_Load(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }
    }
}