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
    public partial class frmPrestamo : DevExpress.XtraEditors.XtraForm
    {
        public frmPrestamo()
        {
            InitializeComponent();
        }

        private void frmPrestamo_Load(object sender, EventArgs e)
        {
            socioBindingSource.DataSource = new Socio().GetAll();
            prestamoBindingSource.DataSource = new Prestamo().GetAll();
            gvPrestamo.BestFitColumns();
        }
    }
}