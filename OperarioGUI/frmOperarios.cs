using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperarioGUI
{
    public partial class frmOperarios : Form
    {
        double sueldoTotal = 0;
        int capataces = 0;
        int oficiales = 0;
        public frmOperarios()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(txtDni.Text);
            string nombre = txtNombre.Text;
            bool sexo = rbMasculino.Checked;
            DateTime fecNac = dtpFecNac.Value;
            bool categ = true;

            if (cboCategorias.SelectedIndex == 1)
            {
                categ = false;
                oficiales++;
            } else
            {
                capataces++;
            }

            int ht = Convert.ToInt32(txtHrsTrabajadas.Text);
            double ph = Convert.ToDouble(txtPrecioHora.Text);

            Operario operario = new Operario(categ, ht, ph, dni, sexo, nombre, fecNac);

            sueldoTotal += operario.calcularSueldo();

            lblMostrarS.Text = "" + operario.calcularSueldo();
            lblMostrarTotalS.Text = "" + sueldoTotal;
            lblCapataces.Text = "" + capataces;
            lblOficiales.Text = "" + oficiales;

            MessageBox.Show(operario.toString());
        }
    }
}
