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
        private int idPrestamo = 0;
        public frmPrestamo()
        {
            InitializeComponent();

        }

        private void frmPrestamo_Load(object sender, EventArgs e)
        {
            socioBindingSource.DataSource = new Socio().GetAll();
            prestamoBindingSource.DataSource = new Prestamo().GetAll();
            //prestamoBindingSource.DataSource = new Prestamo().GetBySocio();
            gvPrestamo.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmNPrestamo))
                {
                    form.Activate();
                    return;
                }
            new frmNPrestamo { Text = "Prestamos" }.Show();
            btnActualizar.PerformClick();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            prestamoBindingSource.DataSource = new Prestamo().GetAll();
            socioBindingSource.DataSource = new Socio().GetAll();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNPrestamo((int)gvPrestamo.GetFocusedRowCellValue("idPrestamo")) { Text = "Prestamos" }.ShowDialog();
            btnActualizar.PerformClick();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int idPrestamo = (int)gvPrestamo.GetFocusedRowCellValue("idPrestamo");

            if (new Prestamo()
            {
                idPrestamo = idPrestamo
            }.Delete() > 0)
            {
                XtraMessageBox.Show("Prestamo eliminado correctamente", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnActualizar.PerformClick();
            }
            else
                XtraMessageBox.Show("No se eliminó correctamente", "Error 404",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void f(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}