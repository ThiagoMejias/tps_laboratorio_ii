
namespace LibreriaForm
{
    partial class AgregarCliente
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
            this.lbl_Dni = new System.Windows.Forms.Label();
            this.txt_Dni = new System.Windows.Forms.TextBox();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.dateTime_cliente = new System.Windows.Forms.DateTimePicker();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Dni
            // 
            this.lbl_Dni.AutoSize = true;
            this.lbl_Dni.Location = new System.Drawing.Point(51, 130);
            this.lbl_Dni.Name = "lbl_Dni";
            this.lbl_Dni.Size = new System.Drawing.Size(25, 15);
            this.lbl_Dni.TabIndex = 2;
            this.lbl_Dni.Text = "Dni";
            // 
            // txt_Dni
            // 
            this.txt_Dni.Location = new System.Drawing.Point(51, 166);
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.ShortcutsEnabled = false;
            this.txt_Dni.Size = new System.Drawing.Size(220, 23);
            this.txt_Dni.TabIndex = 3;
            this.txt_Dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Dni_KeyPress);
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Location = new System.Drawing.Point(474, 44);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(57, 15);
            this.lbl_Direccion.TabIndex = 4;
            this.lbl_Direccion.Text = "Direccion";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(474, 85);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.ShortcutsEnabled = false;
            this.txt_direccion.Size = new System.Drawing.Size(220, 23);
            this.txt_direccion.TabIndex = 6;
            // 
            // dateTime_cliente
            // 
            this.dateTime_cliente.Location = new System.Drawing.Point(474, 166);
            this.dateTime_cliente.Name = "dateTime_cliente";
            this.dateTime_cliente.Size = new System.Drawing.Size(220, 23);
            this.dateTime_cliente.TabIndex = 7;
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AccessibleName = "txt_Fecha";
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Location = new System.Drawing.Point(474, 130);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(117, 15);
            this.lbl_Fecha.TabIndex = 8;
            this.lbl_Fecha.Text = "Fecha de nacimiento";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(218, 332);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(138, 51);
            this.btn_Agregar.TabIndex = 9;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(422, 332);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(138, 51);
            this.btn_Cerrar.TabIndex = 10;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(51, 44);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(51, 15);
            this.lbl_Nombre.TabIndex = 1;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(51, 85);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.ShortcutsEnabled = false;
            this.txt_nombre.Size = new System.Drawing.Size(220, 23);
            this.txt_nombre.TabIndex = 0;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibreriaForm.Properties.Resources.FONDO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.dateTime_cliente);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.lbl_Direccion);
            this.Controls.Add(this.txt_Dni);
            this.Controls.Add(this.lbl_Dni);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.txt_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AgregarCliente";
            this.Text = "AgregarCliente";
            this.Load += new System.EventHandler(this.AgregarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Dni;
        private System.Windows.Forms.TextBox txt_Dni;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.DateTimePicker dateTime_cliente;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox txt_nombre;
    }
}