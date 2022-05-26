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
    public partial class frmNAhorro : DevExpress.XtraEditors.XtraForm
    {
        int idAhorro = 0;
        public frmNAhorro()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public frmNAhorro(int idAhorro)
        {
            InitializeComponent();
            this.idAhorro = idAhorro;
            Ahorro ahorro = new Ahorro() { idAhorro = this.idAhorro }.GetById();
            CenterToScreen();
            cmbSocio.EditValue = ahorro.idSocio;
            txtMonto.Text = ahorro.monto.ToString();
            txtTasaInteres.Text = ahorro.tasaInteres.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*if (string.IsNullOrEmpty(cmbSocio.Text) || string.IsNullOrEmpty(txtMonto.Text) || string.IsNullOrEmpty(txtTasaInteres.Text))
            {

                MessageBox.Show("Falta el socio");

                return;

            }*/

            if (string.IsNullOrEmpty(cmbSocio.Text))
            {
                MessageBox.Show("Falta el socio");

                return;
            }
            else if (string.IsNullOrEmpty(txtCalendar.Text))
            {
                MessageBox.Show("Falta la fecha");

                return;
            }
            else if (string.IsNullOrEmpty(txtMonto.Text))
            {
                MessageBox.Show("Falta el monto");

                return;
            } else if (string.IsNullOrEmpty(txtTasaInteres.Text))
            {
                MessageBox.Show("Falta la tasa de interes");

                return;
            }



            if (idAhorro > 0)
            {
                if (new Ahorro()
                {
                    idAhorro = idAhorro,
                    idSocio = (int) cmbSocio.EditValue,
                    fecha = DateTime.Parse(txtCalendar.Text),
                    monto = decimal.Parse(txtMonto.Text),
                    tasaInteres = decimal.Parse(txtTasaInteres.Text)

                }.Update() > 0)
                {
                    XtraMessageBox.Show("Ahorro actualizado correctamente", "Ahorros",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (new Ahorro()
                {
                    idSocio = (int)cmbSocio.EditValue,
                    fecha = DateTime.Parse(txtCalendar.Text),
                    monto = decimal.Parse(txtMonto.Text),
                    tasaInteres = decimal.Parse(txtTasaInteres.Text)

                }.Add() > 0)
                {
                    XtraMessageBox.Show("Ahorro almacenado correctamente", "Ahorros",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();

                    //Close();
                }
            }
        }

        public void Clean()
        {
            cmbSocio.EditValue = "";
            txtMonto.Text = "";
            txtTasaInteres.Text = "";
            txtMonto.Focus();
        }

        private void frmNAhorro_Load(object sender, EventArgs e)
        {
            socioBindingSource.DataSource = new Socio().GetAll();
            CenterToScreen();
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                XtraMessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtTasaInteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                XtraMessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Estas seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}