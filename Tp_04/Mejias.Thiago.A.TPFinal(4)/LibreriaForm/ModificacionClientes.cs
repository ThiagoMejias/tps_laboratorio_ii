using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Entidades;
using Entidades.Base_de_datos;
using Entidades.Exceptions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaForm
{
    public partial class ModificacionClientes : Form
    {
        bool todoBien;
        Cliente aux;
        Vinoteca bacos;
        public ModificacionClientes(Vinoteca bacos)
        {
            InitializeComponent();
            this.bacos = bacos;
        }

        private void ModificacionClientes_Load(object sender, EventArgs e)
        {
            todoBien = false;
        }

        /// <summary>
        /// Si esta todo bien se modifica el cliente seleccionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Modificar_Click(object sender, EventArgs e)
        {

            if (todoBien)
            {
                int dniABuscar = aux.Dni;
                try
                {


                    if (string.IsNullOrEmpty(txt_Dni.Text) || string.IsNullOrEmpty(txt_Nombre.Text) || string.IsNullOrEmpty(txt_Direccion.Text) || string.IsNullOrWhiteSpace(txt_Direccion.Text) || string.IsNullOrWhiteSpace(txt_Dni.Text) || string.IsNullOrWhiteSpace(txt_Nombre.Text) || string.IsNullOrWhiteSpace(txt_Dni.Text))
                    {
                        new EstaVacioException("No pueden quedar campos vacios");
                    }

                    if (dateTime_cliente.Value.EsMenor())
                    {
                        new EsMenorException("Se debe ser mayor!");

                    }

                    if (int.Parse(this.txt_Dni.Text) != aux.Dni && bacos.existeCliente(int.Parse(txt_Dni.Text)))
                    {
                        MessageBox.Show("Ya existe un cliente registrado con ese dni", "Cliente No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }


                    aux.Dni = int.Parse(this.txt_Dni.Text);
                    aux.NombreCompleto = this.txt_Nombre.Text;
                    aux.FechaDeNacimiento = this.dateTime_cliente.Value;
                    aux.Direccion = this.txt_Direccion.Text;
                    aux.Deuda = float.Parse(this.txt_deuda.Text);
                    ClienteDao.Modificar(dniABuscar, aux);

                    MessageBox.Show("Cliente modificado!", "Modificacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (EstaVacioException ex)
                {
                    MessageBox.Show(ex.Message, "Validacion De Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                }
                catch (BaseDeDatosException ex)
                {
                    MessageBox.Show(ex.Message, "Error modificando en la base datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                catch (EstaOnoEnlalista ex)
                {
                    MessageBox.Show(ex.Message, "Validacion De Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                catch (EsMenorException ex)
                {
                    MessageBox.Show(ex.Message, "Validacion De Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                catch (Exception)
                {

                    MessageBox.Show("Algo ocurrio mal", "Validacion De Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            else
            {
                MessageBox.Show("Por favor, buscar un empleado correctamente antes de modificar", "Validacion De Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }



        }
        /// <summary>
        /// Busca el cliente indicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_dniABuscar.Text))
                {
                    new EstaVacioException("No pueden quedar campos vacios");
                }
                else
                {
                    Cliente c = bacos.buscarCliente(int.Parse(this.txt_dniABuscar.Text));

                    this.txt_Dni.Text = c.Dni.ToString();
                    this.txt_Direccion.Text = c.Direccion;
                    this.txt_Nombre.Text = c.NombreCompleto;
                    this.txt_deuda.Text = c.Deuda.ToString();
                    this.dateTime_cliente.Value = c.FechaDeNacimiento;
                    todoBien = true;
                    aux = c;
                }
            }
            catch (NoExisteException ex)
            {
                MessageBox.Show(ex.Message, "Cliente No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                todoBien = false;
            }
            catch (EstaVacioException ex)
            {
                MessageBox.Show(ex.Message, "Cliente No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                todoBien = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Algo fallo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                todoBien = false;
            }
        }



        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txt_dniABuscar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_deuda_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
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

            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
