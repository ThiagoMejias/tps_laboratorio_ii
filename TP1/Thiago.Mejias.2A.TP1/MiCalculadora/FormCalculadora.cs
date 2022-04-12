﻿using System;
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
        /// <summary>
        /// inicia los items del cmboperador
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
            cmbOperador.Items.Add(' ');
            cmbOperador.Items.Add('+');
            cmbOperador.Items.Add('-');
            cmbOperador.Items.Add('*');
            cmbOperador.Items.Add('/');
        }
        /// <summary>
        /// carga y limpia el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        ///  cierra el form luego de la confirmacion o no.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// realiza la operacion indicada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

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
        /// <summary>
        /// valida si es un double
        /// </summary>
        /// <param name="num"></param>
        /// <returns>retorna el numero si es valido o 0</returns>
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
        /// <summary>
        /// limpia el form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }
        /// <summary>
        /// cierra 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// conveirte a decimal el label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando auxiliar = new Operando();
            string strAux;
            string textAnterior = lblResultado.Text;
            strAux = auxiliar.BinarioDecimal(lblResultado.Text);
            lblResultado.Text = strAux;
            lstOperaciones.Items.Add(textAnterior + "->" + strAux);
        }
        /// <summary>
        /// conviete a binario el label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando auxiliar = new Operando();
            string strAux;
            string textAnterior = lblResultado.Text;
            strAux = auxiliar.DecimalABinario(lblResultado.Text);
            lblResultado.Text = strAux;
            lstOperaciones.Items.Add(textAnterior + "->" + strAux);
        }

        /// <summary>
        /// limpia todos los elementos del form
        /// </summary>
        private void Limpiar()
        {
            lblResultado.Text = "0";
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.Text = "";
            lstOperaciones.Items.Clear();
        }
        /// <summary>
        /// recibe los datos y llamar al metodo operar 
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="Operador"></param>
        /// <returns>retorna el resultado de la operacion Calculadora.Operar</returns>
        private double Operar(string numero1, string numero2, string Operador)
        {
            numero1 = numero1.Replace('.', ',');
            numero2 = numero2.Replace('.', ',');
            return Math.Round(Calculadora.Operar(new Operando(numero1), new Operando(numero2), char.Parse(Operador)), 2);

        }
    }
}
