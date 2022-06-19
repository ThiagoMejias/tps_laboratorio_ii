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
            cmb_Tipo.DataSource = Enum.GetNames(typeof(CajaDeVino.Tipo));
            this.lbl_Stock.Text = $"La cantidad de Cajas es de {bacos.cajas.Cantidad} ";
            rtx_Cajas.Text = bacos.ListarPorTipo();
        }

        /// <summary>
        /// Retorna la cantidad de cajas del tipo pasado por parametro
        /// </summary>
        /// <param name="tipo"> enum de tipos</param>
        /// <returns></returns>
        private int cantidadDeTipoSeleccionada(CajaDeVino.Tipo tipo)
        {
            int cantidad;
            if (tipo == CajaDeVino.Tipo.tinto)
            {
                cantidad = bacos.ContadorTinto;
            }
            else
            {
                if (tipo == CajaDeVino.Tipo.blanco)
                {
                    cantidad = bacos.ContadorBlanco;
                }
                else
                {
                    if (tipo == CajaDeVino.Tipo.espumante)
                    {
                        cantidad = bacos.ContadorEspumante;
                    }
                    else
                    {
                        cantidad = bacos.ContadorRosado;
                    }
                }
            }
            return cantidad;
        }

        /// <summary>
        /// Si sale todo bien se agrega a la lsita de cajas lo seleccionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            CajaDeVino.Tipo tipo = (CajaDeVino.Tipo)cmb_Tipo.SelectedIndex;

            try
            {
                if (string.IsNullOrEmpty(txt_Cantidad.Text) || string.IsNullOrWhiteSpace(txt_Cantidad.Text))
                {
                    throw new EstaVacioException("El campo esta vacio!");
                }

                if (int.Parse(txt_Cantidad.Text) < 1)
                {
                    throw new NumeroInvalidoException("El valor debe ser mayor de 0");
                }

                for (int i = 0; i < int.Parse(txt_Cantidad.Text); i++)
                {
                    this.bacos.cajas.add(new CajaDeVino(tipo));
                }

                rtx_Cajas.Text = bacos.ListarPorTipo();
            }

            catch (NumeroInvalidoException ex)
            {
                MessageBox.Show(ex.Message, "Validacion De Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (EstaVacioException ex)
            {
                MessageBox.Show(ex.Message, "Validacion De Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception)
            {
                MessageBox.Show("Algo salio mal!", "Validacion De Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            this.lbl_Stock.Text = $"La cantidad de Cajas es de {bacos.cajas.Cantidad} ";
        }

        /// <summary>
        /// Borra lo seleccionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            CajaDeVino.Tipo tipoSeleccionado = (CajaDeVino.Tipo)cmb_Tipo.SelectedIndex;
            int cantidad = cantidadDeTipoSeleccionada(tipoSeleccionado);
            try
            {
                if (string.IsNullOrEmpty(txt_Cantidad.Text) || string.IsNullOrWhiteSpace(txt_Cantidad.Text))
                {
                    throw new EstaVacioException("No pueden quedar campos vacios");
                }

                if (int.Parse(txt_Cantidad.Text) < 1)
                {
                    throw new NumeroInvalidoException("El valor debe ser mayor de 0");
                }
                if (int.Parse(txt_Cantidad.Text) > cantidad)
                {
                    throw new NumeroInvalidoException("La cantidad a eliminar supera las cajas en stock");
                }


                for (int i = 0; i < int.Parse(txt_Cantidad.Text); i++)
                {
                    bacos.eliminarPorTipo(tipoSeleccionado);
                }

                rtx_Cajas.Text = bacos.ListarPorTipo();
            }

            catch (NumeroInvalidoException ex)
            {
                MessageBox.Show(ex.Message, "Validacion De Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (EstaVacioException ex)
            {
                MessageBox.Show(ex.Message, "Validacion De Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception)
            {
                MessageBox.Show("Algo Salio Mal", "Validacion De Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            this.lbl_Stock.Text = $"La cantidad de Cajas es de {bacos.cajas.Cantidad} ";
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
