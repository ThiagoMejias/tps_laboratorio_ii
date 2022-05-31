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
    public partial class Inicio : Form
    {
        Vinoteca bacos = new Vinoteca("Vinoteca Bacos");
        public Inicio()
        {
            InitializeComponent();
        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            bacos.clientes.add(new(new DateTime(2003, 02, 09), "Catalina Klemen", 44628123, "calle 59 460", 0));
            bacos.clientes.add(new(new DateTime(2003, 04, 24), "Thiago Mejias", 44816634, "Inclan 3541", 0));
        }
        private void btn_AgregarCliente_Click(object sender, EventArgs e)
        {
            AgregarCliente formCliente = new AgregarCliente(bacos);
            formCliente.ShowDialog();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_DarDeBajaCliente_Click(object sender, EventArgs e)
        {
            DarDeBajaCliente bajaForm = new DarDeBajaCliente(bacos);
            bajaForm.ShowDialog();
        }

        private void btn_ListarCliente_Click(object sender, EventArgs e)
        {


            ListarClientes ListadoForm = new ListarClientes(bacos);
            ListadoForm.ShowDialog();




        }

        private void btn_ModificarCliente_Click(object sender, EventArgs e)
        {
            ModificacionClientes modificarForm = new ModificacionClientes(bacos);
            modificarForm.ShowDialog();
        }

        private void btn_VerCantidadDeStock_Click(object sender, EventArgs e)
        {

            ListadoStock listadoForm = new ListadoStock(bacos);
            listadoForm.ShowDialog();

        }
    }
}
