using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Windows.Forms;

namespace LibreriaForm
{
    public partial class ListarClientes : Form
    {
        Vinoteca bacos;
        public ListarClientes(Vinoteca bacos)
        {
            InitializeComponent();
            this.bacos = bacos;
        }

        private void ListarClientes_Load(object sender, EventArgs e)
        {
            this.dgv_Clientes.DataSource = this.bacos.clientes.lista;
            //foreach (Cliente item in bacos.clientes.lista)
            //{
            //    int n = dgv_Clientes.Rows.Add();
            //    dgv_Clientes.Rows[n].Cells[0].Value = item.Dni;
            //    dgv_Clientes.Rows[n].Cells[1].Value = item.NombreCompleto;
            //    dgv_Clientes.Rows[n].Cells[2].Value = item.Direccion;
            //    dgv_Clientes.Rows[n].Cells[3].Value = item.Deuda;
            //}
        }
    }
}
