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
    public partial class frmAhorro : DevExpress.XtraEditors.XtraForm
    {
        public frmAhorro()
        {
            InitializeComponent();
        }

        private void frmAhorro_Load(object sender, EventArgs e)
        {
            socioBindingSource.DataSource = new Socio().GetAll();
            ahorroBindingSource.DataSource = new Ahorro().GetAll();
            gvAhorros.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmNAhorro))
                {
                    form.Activate();
                    return;
                }
            new frmNAhorro { Text = "Ahorros" }.Show();
            btnActualizar.PerformClick();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ahorroBindingSource.DataSource = new Ahorro().GetAll();
            socioBindingSource.DataSource = new Socio().GetAll();

        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNAhorro((int)gvAhorros.GetFocusedRowCellValue("idAhorro")) { Text = "Ahorros" }.ShowDialog();
            btnActualizar.PerformClick();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int idAhorro = (int)gvAhorros.GetFocusedRowCellValue("idAhorro");

            if (new Ahorro()
            {
                idAhorro = idAhorro
            }.Delete() > 0)
            {
                XtraMessageBox.Show("Ahorro eliminado correctamente", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnActualizar.PerformClick();
            }
            else
                XtraMessageBox.Show("No se eliminó correctamente", "Error 404",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

        private void frmAhorro_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void gcAhorros_Click(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}