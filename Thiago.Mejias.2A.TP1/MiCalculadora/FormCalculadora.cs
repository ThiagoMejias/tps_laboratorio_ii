using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entidades;
namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            cmbOperador.Items.Add(' ');
            cmbOperador.Items.Add('+');
            cmbOperador.Items.Add('-');
            cmbOperador.Items.Add('*');
            cmbOperador.Items.Add('/');
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            string operador = cmbOperador.Text;
            if (string.IsNullOrEmpty(operador))
            {
                operador = "+";
            }
            resultado = Operar(txtNumero1.Text, txtNumero2.Text, operador);
            lblResultado.Text = resultado.ToString();
            lstOperaciones.Items.Add(validarNumero(txtNumero1.Text) + operador + validarNumero(txtNumero2.Text) + "=" + resultado);
        }

        private string validarNumero(string num)
        {
            string retorno;
            retorno = num;
            if (!double.TryParse(num, out double numero))
            {
                retorno = "0";
            }
            return retorno;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando auxiliar = new Operando();
            string strAux;
            strAux = auxiliar.BinarioDecimal(lblResultado.Text);
            lblResultado.Text = strAux;
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando auxiliar = new Operando();
            string strAux;
            strAux = auxiliar.DecimalABinario(lblResultado.Text);
            lblResultado.Text = strAux;
        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            lblResultado.Text = "0";
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.Text = "";
            lstOperaciones.Items.Clear();
        }

        private double Operar(string numero1, string numero2, string Operador)
        {

            return Calculadora.Operar(new Operando(numero1), new Operando(numero2), char.Parse(Operador));

        }



    }
}
