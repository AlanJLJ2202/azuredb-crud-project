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

        private int idSocio = 0;
        public frmSocio()
        {
            InitializeComponent();
        }

        private void frmSocio_Load(object sender, EventArgs e)
        {
            socioBindingSource.DataSource = new Socio().GetAll();
            sucursalBindingSource.DataSource = new Sucursal().GetAll();
            gvSocio.BestFitColumns();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            socioBindingSource.DataSource = new Socio().GetAll();
            sucursalBindingSource.DataSource = new Sucursal().GetAll();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmNSocio))
                {
                    form.Activate();
                    return;
                }
            new frmNSocio { Text = "Socios" }.Show();
            btnActualizar.PerformClick();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNSocio((int)gvSocio.GetFocusedRowCellValue("idSocio")) { Text = "Socios" }.ShowDialog();
            btnActualizar.PerformClick();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int idSocio = (int)gvSocio.GetFocusedRowCellValue("idSocio");

            if (new Socio()
            {
                idSocio = idSocio
            }.Delete() > 0)
            {
                XtraMessageBox.Show("Socio eliminado correctamente", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnActualizar.PerformClick();
            }
            else
                XtraMessageBox.Show("No se eliminó correctamente", "Error 404",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmSocio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("Estas seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}