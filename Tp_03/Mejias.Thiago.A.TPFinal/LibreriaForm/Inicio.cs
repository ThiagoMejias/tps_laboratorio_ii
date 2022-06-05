using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.Archivos;
using Entidades.Exceptions;
using System.Windows.Forms;
using System.IO;

namespace LibreriaForm
{
    public partial class Inicio : Form
    {
        Vinoteca bacos = new Vinoteca("Vinoteca Bacos");
        ClaseSerializadoraXml<Listado<Cliente>> serializadoraXmlCliente = new ClaseSerializadoraXml<Listado<Cliente>>();
        ArchivoTxt cantidadDeCajasTxt = new ArchivoTxt();
        ClaseSerializadoraXml<Listado<CajaDeVino>> serializadoraXmlCaja = new ClaseSerializadoraXml<Listado<CajaDeVino>>();
        public Inicio()
        {
            InitializeComponent();
        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            bacos.clientes = serializadoraXmlCliente.Leer("Lista De Clientes");
            bacos.cajas = serializadoraXmlCaja.Leer("Lista De Cajas");
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

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            this.GuardarDatos();
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿desea guardar los datos antes de salir?",
             "Confirmacion de baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.Yes)
            {
                GuardarDatos();
            }

        }
        /// <summary>
        /// Se encarga de guardar todos los datos de la aplicacion.
        /// </summary>
        private void GuardarDatos()
        {
            DateTime dt = DateTime.Now;
            string datosTxt;
            datosTxt = cantidadDeCajasTxt.Leer("Cantidad De Cajas");
            datosTxt += "La cantidad de cajas en stock son: " + bacos.cajas.Cantidad.ToString() + "al: " + dt.ToString() + "\n";
            cantidadDeCajasTxt.Escribir(datosTxt, "Cantidad De Cajas");
            serializadoraXmlCliente.Escribir(bacos.clientes, "Lista De Clientes");
            serializadoraXmlCaja.Escribir(bacos.cajas, "Lista De Cajas");
        }
    }
}
