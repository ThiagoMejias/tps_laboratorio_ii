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
    public partial class ListadoStock : Form
    {
        Vinoteca bacos;
        public ListadoStock(Vinoteca bacos)
        {
            InitializeComponent();
            this.bacos = bacos;
        }

        private void ListadoStock_Load(object sender, EventArgs e)
        {
            this.lbl_Stock.Text = $"La cantidad de Cajas es de {bacos.cajas.Cantidad} ";
            rtx_Cajas.Text += "\n" + bacos.cajas.Listar();
        }

        private void lbl_Stock_Click(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Cantidad.Text) || string.IsNullOrEmpty(txt_Marca.Text) || string.IsNullOrEmpty(txt_Tipo.Text))
                {
                    throw new EstaVacioException("No pueden quedar campos vacios");
                }
                else
                {
                    if (int.Parse(txt_Cantidad.Text) < 1)
                    {
                        throw new EsMenorException("El valor debe ser mayor de 0");
                    }
                }



                for (int i = 0; i < int.Parse(txt_Cantidad.Text); i++)
                {
                    this.bacos.cajas.add(new CajaDeVino(txt_Marca.Text, txt_Tipo.Text));

                }


                rtx_Cajas.Text += "\n" + bacos.cajas.Listar();
            }
            catch (EstaVacioException ex)
            {
                MessageBox.Show(ex.Message, "Validacion De Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (EsMenorException ex)
            {
                MessageBox.Show(ex.Message, "Validacion De Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception)
            {
                MessageBox.Show("Algo Salio Mal", "Validacion De Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
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
