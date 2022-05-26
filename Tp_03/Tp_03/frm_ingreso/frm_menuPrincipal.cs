using System;
using Entidades;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frm_ingreso;


namespace frm_ingreso
{
    public partial class frm_menuPrincipal : Form
    {
        Pescaderia pescaderia;
        public frm_menuPrincipal()
        {
            InitializeComponent();
        }

        private void frm_menuPrincipal_Load(object sender, EventArgs e)
        {
            pescaderia = new Pescaderia();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btn_Venta_Click(object sender, EventArgs e)
        {
            frmVenta venta = new frmVenta(pescaderia);
            venta.Show();





        }
    }
}
