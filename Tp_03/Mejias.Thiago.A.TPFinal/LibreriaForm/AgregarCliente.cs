using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.Exceptions;
using System.Windows.Forms;

namespace LibreriaForm
{
    public partial class AgregarCliente : Form
    {
        Vinoteca bacos;
        public AgregarCliente(Vinoteca vinoteca)
        {
            InitializeComponent();
            this.bacos = vinoteca;
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {
            dateTime_cliente.Value = DateTime.Today.AddYears(-18);
        }


        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Dni.Text) || string.IsNullOrEmpty(txt_nombre.Text) || string.IsNullOrEmpty(txt_direccion.Text))
                {
                    throw new EstaVacioException("No pueden quedar campos vacios");
                }
                if (dateTime_cliente.Value.AddYears(18) > DateTime.Today)
                {
                    throw new EsMenorException("Se debe ser mayor de edad");
                }

                if (bacos.clientes.add(new Cliente(dateTime_cliente.Value, this.txt_nombre.Text, int.Parse(this.txt_Dni.Text), this.txt_direccion.Text, 0)))
                {
                    MessageBox.Show($"Cliente con Dni: {this.txt_Dni.Text} agregado correctamente!");
                }
            }
            catch (EstaVacioException ex)
            {
                MessageBox.Show(ex.Message, "Validacion De Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (EstaOnoEnlalista ex)
            {
                MessageBox.Show(ex.Message, "Validacion De Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (EsMenorException ex)
            {
                MessageBox.Show(ex.Message, "Validacion De Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salio mal", "Validacion De Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        // validaciones.
        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            //si no cumple nada de lo anterior que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txt_Dni_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación Dni", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
