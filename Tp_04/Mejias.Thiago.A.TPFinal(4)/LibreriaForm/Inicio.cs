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
using Entidades.Base_de_datos;
using Entidades.Exceptions;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace LibreriaForm
{
    public partial class Inicio : Form
    {
        CargarLista cargarInformacion;
        Action LeerLocales;
        public event VerificarData DatosCargados;

        Vinoteca bacos = new Vinoteca("Vinoteca Bacos");
        ClaseSerializadoraXml<Listado<Cliente>> serializadoraXmlCliente = new ClaseSerializadoraXml<Listado<Cliente>>();
        ArchivoTxt cantidadDeCajasTxt = new ArchivoTxt();
        ClaseSerializadoraXml<Listado<CajaDeVino>> serializadoraXmlCaja = new ClaseSerializadoraXml<Listado<CajaDeVino>>();



        public Inicio()
        {
            InitializeComponent();
            cargarInformacion += cargarDatosCaja;
            cargarInformacion += cargarDatosClientes;
            DatosCargados += activacionDeBotones;
            LeerLocales += cargarClientes;
            btn_DarDeBajaCliente.Enabled = false;
            btn_ListarCliente.Enabled = false;
            btn_ModificarCliente.Enabled = false;
        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            cargarInformacion.Invoke();

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

        /// <summary>
        /// Carga los datos de clientes de la base de datos a la coleccion si no puede cargar de la base datos carga la base
        /// local
        /// </summary>
        private async void cargarDatosClientes()
        {
            try

            {
                //Simulo que tarda en buscar a la base de datos.
                this.bacos.clientes.lista = await Task.Run<List<Cliente>>(() =>
                {
                    Thread.Sleep(3000);
                    return ClienteDao.Leer();
                });
                if (this.bacos.clientes.Cantidad < 1)
                {
                    MessageBox.Show("No se pudieron cargar los archivos de la base de datos. Se cargaron los archivos locales!");
                    this.cargarClientes();
                }
                DatosCargados.Invoke();
            }
            catch (BaseDeDatosException ex)
            {
                MessageBox.Show(ex.Message, "Error en carga de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salio mal", "Error en carga de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Carga los datos de la caja.
        /// </summary>
        private void cargarDatosCaja()
        {
            bacos.cajas = serializadoraXmlCaja.Leer("Lista De Cajas");
        }
        /// <summary>
        /// Cargar Cliente locales.
        /// </summary>
        private void cargarClientes()
        {
            bacos.clientes = serializadoraXmlCliente.Leer("Lista De Clientes");
        }

        /// <summary>
        /// Activa los botones les cambia el texto y les pone el color predeterminado
        /// </summary>
        public void activacionDeBotones()
        {
            this.btn_DarDeBajaCliente.Enabled = true;
            this.btn_DarDeBajaCliente.Text = "Dar De Baja Cliente";
            this.btn_DarDeBajaCliente.BackColor = Color.FromArgb(170, 39, 107);

            this.btn_ListarCliente.Enabled = true;
            this.btn_ListarCliente.Text = "Listar Clientes";
            this.btn_ListarCliente.BackColor = Color.FromArgb(170, 39, 107);

            this.btn_ModificarCliente.Enabled = true;
            this.btn_ModificarCliente.Text = "Modificar Clientes";
            this.btn_ModificarCliente.BackColor = Color.FromArgb(170, 39, 107);
        }

        /// <summary>
        /// Guarda los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            this.GuardarDatos();
        }

        /// <summary>
        /// Se encarga de cerrar la aplicacion y segun lo que el usuario decida 
        /// se hace una cosa diferente.
        /// </summary>
        /// <param name="guardar"> Delegado de tipo action</param>
        /// <param name="e"></param>
        private void CerrarAplicacion(GuardarInformacion guardar, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿desea guardar los datos antes de salir?",
            "Confirmacion de baja", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogo == DialogResult.Yes)
            {
                guardar.Invoke();
            }
            else
            {
                if (dialogo == DialogResult.Cancel)
                {
                    _ = e.Cancel = true;
                }
            }
        }
        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarAplicacion(GuardarDatos, e);

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
            serializadoraXmlCaja.Escribir(bacos.cajas, "Lista De Cajas");
            serializadoraXmlCliente.Escribir(bacos.clientes, "Lista De Clientes");
        }


    }
}

