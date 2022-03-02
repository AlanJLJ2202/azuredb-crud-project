using BLL;
using BOL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewL
{
    public partial class frmNPrestamo : Form
    {
        private PrestamoBLL prestamoBLL = PrestamoBLL.Instance();
        private SocioBLL socioBLL = SocioBLL.Instance();
        Prestamo prestamo = new Prestamo();
        Socio socio = new Socio();
        public int idPrestamo = 0;
        public int idSocio = 0;

        public frmNPrestamo()
        {
            InitializeComponent();
        }

        public frmNPrestamo(int idPrestamo)
        {

            InitializeComponent();
            this.idPrestamo = idPrestamo;
            prestamo.idPrestamo = idPrestamo;
            //cbSocio.SelectedItem = socioBLL.GetByID(socio).nombre.ToString();
            txtFecha.Text = prestamoBLL.GetByID(prestamo).fecha.ToString();
            txtMonto.Text = prestamoBLL.GetByID(prestamo).monto.ToString();
            txtTasaInteres.Text = prestamoBLL.GetByID(prestamo).tasaInteres.ToString();

        }


        private void frmNPrestamo_Load(object sender, EventArgs e)
        {
            Socios socios = socioBLL.GetAll();
            foreach(Socio socio in socios)
            {
                cbSocio.Items.Add(socio.nombre);
            }
        }

        public void Clean()
        {
            txtFecha.Text = "";
            txtMonto.Text = "";
            txtTasaInteres.Text = "";
            txtMonto.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFecha.Text) || string.IsNullOrEmpty(txtMonto.Text) || string.IsNullOrEmpty(txtTasaInteres.Text) || string.IsNullOrEmpty(cbSocio.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }



            if (!cbSocio.Text.Equals(""))
            {
                idSocio = socioBLL.GetByDescripcion(new Socio()
                {
                    nombre = cbSocio.Text
                }).idSocio;
            }

            if (idPrestamo > 0)
            {
                if(prestamoBLL.Update(new BOL.Prestamo()
                {
                    idPrestamo = idPrestamo,
                    idSocio = idSocio,
                    fecha = DateTime.Parse(txtFecha.Text),
                    monto = decimal.Parse(txtMonto.Text),
                    tasaInteres = decimal.Parse(txtTasaInteres.Text)
                }))
                {
                    MessageBox.Show("Prestamo actualizado correctamente", Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                }
            }
            else
            {
                if (prestamoBLL.Add(new BOL.Prestamo()
                {
                    idSocio = idSocio,
                    fecha = DateTime.Parse(txtFecha.Text),
                    monto = decimal.Parse(txtMonto.Text),
                    tasaInteres = decimal.Parse(txtTasaInteres.Text)
                }))
                {
                    MessageBox.Show("Prestamo ingresado correctamente", Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                }

            }



        }

        private void frmNPrestamo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtTasaInteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
