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
    public partial class frmNColaborador : Form
    {
        private AreaBLL areaBLL = AreaBLL.Instance();
        private SucursalBLL sucursalBLL = SucursalBLL.Instance();
        Colaborador colaborador = new Colaborador();
        public int idColaborador = 0;
        public int idArea = 0;
        public int idSucursal = 0;
        private ColaboradorBLL colaboradorBLL = ColaboradorBLL.Instance();
        public frmNColaborador()
        {
            InitializeComponent();
        }

        public frmNColaborador(int idColaborador)
        {

            InitializeComponent();
            this.idColaborador = idColaborador;
            colaborador.idColaborador = idColaborador;
            txtNombre.Text = colaboradorBLL.GetByID(colaborador).nombre.ToString();
            txtApellido.Text = colaboradorBLL.GetByID(colaborador).apellido.ToString();
            txtEdad.Text = colaboradorBLL.GetByID(colaborador).edad.ToString();
            txtDireccion.Text = colaboradorBLL.GetByID(colaborador).direccion.ToString();
            txtSueldo.Text = colaboradorBLL.GetByID(colaborador).sueldo.ToString();
            cmbAreas.SelectedItem = idArea;
            cmbSucursales.SelectedItem = idSucursal;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtEdad.Text)
                || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtSueldo.Text) || string.IsNullOrEmpty(cmbAreas.Text) || string.IsNullOrEmpty(cmbSucursales.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }



            if (!cmbAreas.Text.Equals(""))
            {
                idArea = areaBLL.GetByDescripcion(new Area()
                {
                    nombre = cmbAreas.Text
                }).idArea;
            }
            if (!cmbSucursales.Text.Equals(""))
            {
                idSucursal = sucursalBLL.GetByDescripcion(new Sucursal()
                {
                    nombre = cmbSucursales.Text
                }).idSucursal;
            }
            if (idColaborador > 0)
            {
                if (colaboradorBLL.Update(new BOL.Colaborador()
                {
                    idColaborador = idColaborador,
                    nombre = txtNombre.Text,
                    apellido = txtApellido.Text,
                    edad = int.Parse(txtEdad.Text),
                    direccion = txtDireccion.Text,
                    sueldo = Decimal.Parse(txtSueldo.Text),
                    idArea = idArea,
                    idSucursal = idSucursal
                }))
                {
                    MessageBox.Show("Colaborador actualizado correctamente", Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                }
            }
            else
            {
                if (colaboradorBLL.Add(new BOL.Colaborador()
                {
                    nombre =txtNombre.Text,
                    apellido = txtApellido.Text,
                    edad = int.Parse(txtEdad.Text),
                    direccion = txtDireccion.Text,
                    sueldo = Decimal.Parse(txtSueldo.Text),
                    idArea = idArea,
                    idSucursal = idSucursal
                }))
                {
                    MessageBox.Show("Colaborador ingresado correctamente", Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                }

            }
        }

        private void frmNColaborador_Load(object sender, EventArgs e)
        {
            Areas areas = areaBLL.GetAll();
            foreach (Area area in areas)
            {
                cmbAreas.Items.Add(area.nombre);
            }

            Sucursales sucursales = sucursalBLL.GetAll();
            foreach (Sucursal sucursal in sucursales)
            {
                cmbSucursales.Items.Add(sucursal.nombre);
            }
        }
        public void Clean()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            txtDireccion.Text = "";
            txtSueldo.Text = "";
            cmbAreas.Text = "";
            cmbSucursales.Text = "";
            txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNColaborador_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten letras", "Precaucion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten letras", "Precaucion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten letras", "Precaucion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
    }
}
