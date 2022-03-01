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
    public partial class frmNAhorro : Form
    {
        private SocioBLL socioBLL = SocioBLL.Instance();
        Ahorro ahorro = new Ahorro();
        public int idAhorro = 0;
        public int idSocio = 0;
        private AhorroBLL ahorroBLL = AhorroBLL.Instance();
        public frmNAhorro()
        {
            InitializeComponent();
        }

        public frmNAhorro(int idAhorro)
        {

            InitializeComponent();
            this.idAhorro = idAhorro;
            ahorro.idAhorro = idAhorro;
            cmbSocio.SelectedItem = idSocio;
            txtMonto.Text = ahorroBLL.GetByID(ahorro).monto.ToString();
            txtTasaInteres.Text = ahorroBLL.GetByID(ahorro).tasaInteres.ToString();

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!cmbSocio.Text.Equals(""))
            {
                idSocio = socioBLL.GetByDescripcion(new Socio()
                {
                    nombre = cmbSocio.Text
                }).idSocio;
            }
            if (idAhorro > 0)
            {
                if (ahorroBLL.Update(new BOL.Ahorro()
                {
                    idAhorro = idAhorro,
                    idSocio = idSocio,
                    monto = decimal.Parse(txtMonto.Text),
                    tasaInteres = decimal.Parse(txtTasaInteres.Text)
                }))
                {
                    MessageBox.Show("Ahorro actualizado correctamente", Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                }
            }
            else
            {
                if (ahorroBLL.Add(new BOL.Ahorro()
                {
                    idSocio = idSocio,
                    monto = decimal.Parse(txtMonto.Text),
                    tasaInteres = decimal.Parse(txtTasaInteres.Text)
                }))
                {
                    MessageBox.Show("Ahorro ingresado correctamente", Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                }

            }
        }

        private void frmNAhorro_Load(object sender, EventArgs e)
        {
            Socios socios = socioBLL.GetAll();
            foreach (Socio socio in socios)
            {
                cmbSocio.Items.Add(socio.nombre);
            }
        }
        public void Clean()
        {
            cmbSocio.Text = "";
            txtMonto.Text = "";
            txtTasaInteres.Text = "";
            txtMonto.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
