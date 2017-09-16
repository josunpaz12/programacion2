using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajoPractico_1
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperacion.Text = "";
            lblResultado.Text = "0";

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Numero numero1 = new Numero(txtNumero1.Text);
            Numero numero2 = new Numero(txtNumero2.Text);
            double resultado;

            resultado=Calculadora.operar(numero1,numero2,Calculadora.validarOperador(cmbOperacion.Text));
            cmbOperacion.Text = Calculadora.validarOperador(cmbOperacion.Text);


            lblResultado.Text = resultado.ToString();


        }
    }
}
