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
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnUsuario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmUsuario))
                {
                    form.Activate();
                    return;
                }
            new frmUsuario { MdiParent = this }.Show();
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnSucursal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmSucursal))
                {
                    form.Activate();
                    return;
                }
            new frmSucursal { MdiParent = this }.Show();
        }

        private void btnSocio_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmSocio))
                {
                    form.Activate();
                    return;
                }
            new frmSocio { MdiParent = this }.Show();
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnAhorro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmAhorro))
                {
                    form.Activate();
                    return;
                }
            new frmAhorro { MdiParent = this }.Show();
        }

        private void btnArea_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmArea))
                {
                    form.Activate();
                    return;
                }
            new frmArea { MdiParent = this }.Show();
        }

        private void btnColaborador_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmColaborador))
                {
                    form.Activate();
                    return;
                }
            new frmColaborador { MdiParent = this }.Show();
        }

        private void btnPrestamo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmPrestamo))
                {
                    form.Activate();
                    return;
                }
            new frmPrestamo { MdiParent = this }.Show();
        }
    }
}