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
        public int TotalAhorro = 0;

       
        public frmNEstadoCuenta()
        {
            InitializeComponent();
        }

        public frmNEstadoCuenta(int idSocio)
        {
            InitializeComponent();
            this.idSocio = idSocio;
            Socio socio = new Socio() { idSocio = this.idSocio }.GetById();
            Ahorro ahorro = new Ahorro() { idSocio = this.idSocio }.GetTotal();
            CenterToScreen();
            txtNombreCompleto.Text = socio.nombre;
            txtApellido.Text = socio.apellido;
            txtEdad.Text = socio.edad.ToString();
            txtDireccionCompleta.Text = socio.direccion;
            //txtSucursal.Text = socio.idSucursal.ToString();
            //txtIdSocio.Text = socio.idSocio.ToString();
            
        }

        public void CalcularTotal()
        {
           
            //Console.WriteLine(total.ToString());
        }



        private void txtTelefono_Click(object sender, EventArgs e)
        {

        }

        private void frmNEstadoCuenta_Load(object sender, EventArgs e)
        {
            prestamoBindingSource.DataSource = new Prestamo(){ idSocio = idSocio }.GetBySocio();
            ahorroBindingSource.DataSource = new Ahorro() { idSocio = idSocio }.GetBySocio();

            

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

        private void btnTotales_Click(object sender, EventArgs e)
        {
            Decimal totalAhorro = 0;
            
            for (int i = 0; i < gvAhorro.DataRowCount; i++)
            {
                Decimal ahorro = (Decimal)gvAhorro.GetRowCellValue(i, "monto");
                totalAhorro += ahorro;
            }
            Double interesAhorro = (Double)totalAhorro * 0.02;
            Double totalAhorroInteres = (Double)totalAhorro + interesAhorro;
            txtAhorroTotal.Text = totalAhorro.ToString();
            txtInteresAhorro.Text = totalAhorroInteres.ToString();

            Decimal totalPrestamo = 0;

            for (int i = 0; i < gvPrestamo.DataRowCount; i++)
            {
                Decimal ahorro = (Decimal)gvPrestamo.GetRowCellValue(i, "monto");
                totalPrestamo += ahorro;
            }

            Double interesPrestamo = (Double)totalPrestamo * 0.02;
            Double totalPrestamoInteres = (Double)totalPrestamo + interesPrestamo;
            txtPrestamoTotal.Text = totalPrestamo.ToString();
            txtInteresPrestamo.Text = totalPrestamoInteres.ToString();


            if (totalAhorroInteres > totalPrestamoInteres)
            {
                txtDeuda.Text = "Actualmente no debe dinero";
            }
            else
            {
                Double deuda = (Double)totalPrestamoInteres - totalAhorroInteres;
                txtDeuda.Text = deuda.ToString();
            }

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }
    }
}