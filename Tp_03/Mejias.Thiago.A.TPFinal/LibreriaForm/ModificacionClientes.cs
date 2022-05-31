using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Entidades;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModificacionClientes_Load(object sender, EventArgs e)
        {
            todoBien = false;
        }
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (todoBien)
            {
                try
                {

                    if (string.IsNullOrEmpty(txt_Dni.Text) || string.IsNullOrEmpty(txt_Nombre.Text) || string.IsNullOrEmpty(txt_Direccion.Text) || string.IsNullOrEmpty(txt_deuda.Text))
                    {
                        throw new EstaVacioException("No pueden quedar campos vacios");
                    }
                    if (dateTime_cliente.Value.AddYears(18) > DateTime.Today)
                    {
                        throw new EsMenorException("Se debe ser mayor de edad");
                    }
                    if (int.Parse(this.txt_Dni.Text) != aux.Dni && bacos.existeCliente(int.Parse(txt_Dni.Text)))
                    {
                        throw new EstaOnoEnlalista("Ya existe un cliente registrado con ese dni");
                    }
                    aux.Dni = int.Parse(this.txt_Dni.Text);
                    aux.NombreCompleto = this.txt_Nombre.Text;
                    aux.FechaDeNacimiento = this.dateTime_cliente.Value;
                    aux.Direccion = this.txt_Direccion.Text;
                    aux.Deuda = float.Parse(this.txt_deuda.Text);
                    MessageBox.Show("Cliente modificado!", "Modificacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        private void btn_Buscar_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txt_dniABuscar.Text))
                {
                    throw new EstaVacioException("No se introducion ningun valor!");


                }
;
                Cliente c = bacos.buscarCliente(int.Parse(this.txt_dniABuscar.Text));

                this.txt_Dni.Text = c.Dni.ToString();
                this.txt_Direccion.Text = c.Direccion;
                this.txt_Nombre.Text = c.NombreCompleto;
                this.txt_deuda.Text = c.Deuda.ToString();
                this.dateTime_cliente.Value = c.FechaDeNacimiento;
                todoBien = true;
                aux = c;
            }
            catch (NoExisteException ex)
            {
                MessageBox.Show(ex.Message, "Cliente No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                todoBien = false;
            }
            catch (EstaVacioException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                todoBien = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Algo fallo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                todoBien = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
