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
    public partial class frmSocio : DevExpress.XtraEditors.XtraForm
    {
        public frmSocio()
        {
            InitializeComponent();
        }

        private void frmSocio_Load(object sender, EventArgs e)
        {
            socioBindingSource.DataSource = new Socio().GetAll();
            gvSocio.BestFitColumns();
        }
    }
}