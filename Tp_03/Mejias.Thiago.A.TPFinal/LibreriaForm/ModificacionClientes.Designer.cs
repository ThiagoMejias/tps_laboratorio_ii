
namespace LibreriaForm
{
    partial class ModificacionClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_dniABuscar = new System.Windows.Forms.TextBox();
            this.lbl_DniABuscar = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.txt_Dni = new System.Windows.Forms.TextBox();
            this.dateTime_cliente = new System.Windows.Forms.DateTimePicker();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Dni = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_deuda = new System.Windows.Forms.TextBox();
            this.lbl_Deuda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_dniABuscar
            // 
            this.txt_dniABuscar.Location = new System.Drawing.Point(35, 107);
            this.txt_dniABuscar.Name = "txt_dniABuscar";
            this.txt_dniABuscar.Size = new System.Drawing.Size(157, 23);
            this.txt_dniABuscar.TabIndex = 0;
            this.txt_dniABuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_DniABuscar
            // 
            this.lbl_DniABuscar.AutoSize = true;
            this.lbl_DniABuscar.Location = new System.Drawing.Point(35, 74);
            this.lbl_DniABuscar.Name = "lbl_DniABuscar";
            this.lbl_DniABuscar.Size = new System.Drawing.Size(163, 15);
            this.lbl_DniABuscar.TabIndex = 1;
            this.lbl_DniABuscar.Text = "Dni del empleado a modificar";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(373, 74);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(138, 23);
            this.txt_Nombre.TabIndex = 2;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(572, 74);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(172, 23);
            this.txt_Direccion.TabIndex = 3;
            this.txt_Direccion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_Dni
            // 
            this.txt_Dni.Location = new System.Drawing.Point(373, 161);
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.Size = new System.Drawing.Size(138, 23);
            this.txt_Dni.TabIndex = 4;
            // 
            // dateTime_cliente
            // 
            this.dateTime_cliente.Location = new System.Drawing.Point(457, 240);
            this.dateTime_cliente.Name = "dateTime_cliente";
            this.dateTime_cliente.Size = new System.Drawing.Size(172, 23);
            this.dateTime_cliente.TabIndex = 8;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(373, 39);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(51, 15);
            this.lbl_Nombre.TabIndex = 9;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Dni
            // 
            this.lbl_Dni.AutoSize = true;
            this.lbl_Dni.Location = new System.Drawing.Point(373, 132);
            this.lbl_Dni.Name = "lbl_Dni";
            this.lbl_Dni.Size = new System.Drawing.Size(25, 15);
            this.lbl_Dni.TabIndex = 10;
            this.lbl_Dni.Text = "Dni";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Location = new System.Drawing.Point(572, 39);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(57, 15);
            this.lbl_Direccion.TabIndex = 11;
            this.lbl_Direccion.Text = "Direccion";
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AccessibleName = "txt_Fecha";
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Location = new System.Drawing.Point(480, 213);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(117, 15);
            this.lbl_Fecha.TabIndex = 12;
            this.lbl_Fecha.Text = "Fecha de nacimiento";
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(415, 300);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(105, 56);
            this.btn_Modificar.TabIndex = 14;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(572, 300);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(105, 56);
            this.btn_Cerrar.TabIndex = 15;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(57, 300);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(105, 56);
            this.btn_Buscar.TabIndex = 16;
            this.btn_Buscar.Text = "Buscar Empleado";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_deuda
            // 
            this.txt_deuda.Location = new System.Drawing.Point(572, 161);
            this.txt_deuda.Name = "txt_deuda";
            this.txt_deuda.Size = new System.Drawing.Size(172, 23);
            this.txt_deuda.TabIndex = 17;
            // 
            // lbl_Deuda
            // 
            this.lbl_Deuda.AutoSize = true;
            this.lbl_Deuda.Location = new System.Drawing.Point(572, 132);
            this.lbl_Deuda.Name = "lbl_Deuda";
            this.lbl_Deuda.Size = new System.Drawing.Size(41, 15);
            this.lbl_Deuda.TabIndex = 18;
            this.lbl_Deuda.Text = "Deuda";
            // 
            // ModificacionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibreriaForm.Properties.Resources.FONDO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 395);
            this.Controls.Add(this.lbl_Deuda);
            this.Controls.Add(this.txt_deuda);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.lbl_Direccion);
            this.Controls.Add(this.lbl_Dni);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.dateTime_cliente);
            this.Controls.Add(this.txt_Dni);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_DniABuscar);
            this.Controls.Add(this.txt_dniABuscar);
            this.Name = "ModificacionClientes";
            this.Text = "ModificacionClientes";
            this.Load += new System.EventHandler(this.ModificacionClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_dniABuscar;
        private System.Windows.Forms.Label lbl_DniABuscar;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_Dni;
        private System.Windows.Forms.DateTimePicker dateTime_cliente;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Dni;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_deuda;
        private System.Windows.Forms.Label lbl_Deuda;
    }
}