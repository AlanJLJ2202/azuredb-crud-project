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
        //private decimal monto = 0;
       
        public frmNEstadoCuenta()
        {
            InitializeComponent();
        }

        public frmNEstadoCuenta(int idSocio)
        {
            InitializeComponent();
            this.idSocio = idSocio;
            Socio socio = new Socio() { idSocio = this.idSocio }.GetById();
            //Ahorro ahorro = new Ahorro() { monto = this.}.GetAll();
            CenterToScreen();
            txtNombreCompleto.Text = socio.nombre;
            txtApellido.Text = socio.apellido;
            txtEdad.Text = socio.edad.ToString();
            txtDireccionCompleta.Text = socio.direccion;
            txtSucursal.Text = socio.idSucursal.ToString();
            txtIdSocio.Text = socio.idSocio.ToString();
        }

        private void txtTelefono_Click(object sender, EventArgs e)
        {

        }

        private void frmNEstadoCuenta_Load(object sender, EventArgs e)
        {
            //prestamoBindingSource.DataSource = new Prestamo() { idSocio = idSocio }.GetById();
            //gvPrestamo.BestFitColumns();
            prestamoBindingSource.DataSource = new Prestamo(){ idSocio = idSocio }.GetBySocio();
            ahorroBindingSource.DataSource = new Ahorro() { idSocio = idSocio }.GetBySocio();
           
            //ahorroBindingSource.DataSource = new Ahorro().GetAll();
            socioBindingSource.DataSource = new Socio().GetAll();
            gvPrestamo.BestFitColumns();
            gvAhorro.BestFitColumns();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void gcAhorro_Click(object sender, EventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }
    }
}