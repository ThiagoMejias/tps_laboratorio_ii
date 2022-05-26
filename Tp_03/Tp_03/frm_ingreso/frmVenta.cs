using System;
using Entidades;
using Entidades.Excepcion;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_ingreso
{
    public partial class frmVenta : Form
    {
        Pescaderia pescaderiaNemo;
        public frmVenta(Pescaderia pescaderiaNemo)
        {
            InitializeComponent();
            this.pescaderiaNemo = pescaderiaNemo;
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            foreach (Producto item in pescaderiaNemo.productos)
            {
                int n = dgv_listado.Rows.Add();
                dgv_listado.Rows[n].Cells[0].Value = item.descripcion;
                dgv_listado.Rows[n].Cells[1].Value = item.Precio;
                dgv_listado.Rows[n].Cells[2].Value = item.Id;
                dgv_listado.Rows[n].Cells[3].Value = item.cantidad;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_menuDeVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

            try
            {
                int lugar = this.dgv_listado.CurrentRow.Index;
                float valorDeCantidadListadoDeProductos = (float)this.dgv_listado.Rows[lugar].Cells[3].Value;
                if (string.IsNullOrEmpty(txtCantidad.Text))
                {
                    throw new ParametrosVaciosException();

                }
                if (float.Parse(txtCantidad.Text) > valorDeCantidadListadoDeProductos)
                {
                    throw new CantidadSuperadaExcepcion();
                }
                int n = this.dgv_menuDeVentas.Rows.Add();

                this.dgv_menuDeVentas.Rows[n].Cells[0].Value = this.dgv_listado.Rows[lugar].Cells[0].Value;
                this.dgv_menuDeVentas.Rows[n].Cells[1].Value = this.dgv_listado.Rows[lugar].Cells[1].Value;
                this.dgv_menuDeVentas.Rows[n].Cells[2].Value = this.dgv_listado.Rows[lugar].Cells[2].Value;
                this.dgv_menuDeVentas.Rows[n].Cells[3].Value = this.txtCantidad.Text;
                this.dgv_listado.Rows[lugar].Cells[3].Value = (valorDeCantidadListadoDeProductos - float.Parse(txtCantidad.Text));

            }
            catch (ParametrosVaciosException)

            {
                MessageBox.Show("No se inserto una cantidad", "Validación cantidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
            catch (CantidadSuperadaExcepcion)
            {
                MessageBox.Show("La cantidad ingresada supera la cantidad disponible", "Validación cantidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Algo ocurrio mal", "Validación cantidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }





        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            /*verifica que pueda ingresar punto y también que solo pueda
           ingresar un punto*/
            else if ((e.KeyChar == ',') && (!txtCantidad.Text.Contains(",")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow copia = this.dgv_menuDeVentas.CurrentRow;

                this.dgv_menuDeVentas.Rows.Remove(dgv_menuDeVentas.CurrentRow);

                foreach (DataGridViewRow item in dgv_listado.Rows)
                {
                    if (item.Cells[2].Value == copia.Cells[2].Value)
                    {

                        item.Cells[3].Value = (float.Parse(item.Cells[3].Value.ToString()) + float.Parse(copia.Cells[3].Value.ToString()));
                    }
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No se puede eliminar una celda vacia", "Validacion eliminar producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("No hay ninguna celda seleccionada", "Validacion eliminar producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salio mal", "Validacion eliminar producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            Producto aux;
            int id;
            float cantidad;
            //recorro las filas del datagrid
            for (int fila = 0; fila < dgv_menuDeVentas.Rows.Count - 1; fila++)
            {
                id = (int)dgv_menuDeVentas.Rows[fila].Cells[2].Value;
                cantidad = float.Parse(dgv_menuDeVentas.Rows[fila].Cells[3].Value.ToString());
                aux = pescaderiaNemo.BuscarProductoPorId(id);
                if (aux is not null)
                {
                    venta.productos.agregarProducto(aux, cantidad);
                }
            }

        }



        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {


        }
        private void lbl_cantidad_Click(object sender, EventArgs e)
        {

        }
    }
}
