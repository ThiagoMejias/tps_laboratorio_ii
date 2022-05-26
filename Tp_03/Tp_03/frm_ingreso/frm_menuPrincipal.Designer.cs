
namespace frm_ingreso
{
    partial class frm_menuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_mostrarVentas = new System.Windows.Forms.Button();
            this.btn_Venta = new System.Windows.Forms.Button();
            this.btn_MostrarStock = new System.Windows.Forms.Button();
            this.btn_Pedido = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(129)))));
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Salir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.Location = new System.Drawing.Point(89, 345);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(145, 44);
            this.btn_Salir.TabIndex = 2;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_mostrarVentas
            // 
            this.btn_mostrarVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(129)))));
            this.btn_mostrarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_mostrarVentas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_mostrarVentas.Location = new System.Drawing.Point(89, 295);
            this.btn_mostrarVentas.Name = "btn_mostrarVentas";
            this.btn_mostrarVentas.Size = new System.Drawing.Size(145, 44);
            this.btn_mostrarVentas.TabIndex = 3;
            this.btn_mostrarVentas.Text = "Registro De Ventas";
            this.btn_mostrarVentas.UseVisualStyleBackColor = false;
            // 
            // btn_Venta
            // 
            this.btn_Venta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(129)))));
            this.btn_Venta.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Venta.FlatAppearance.BorderSize = 0;
            this.btn_Venta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Venta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Venta.Location = new System.Drawing.Point(89, 145);
            this.btn_Venta.Name = "btn_Venta";
            this.btn_Venta.Size = new System.Drawing.Size(145, 44);
            this.btn_Venta.TabIndex = 4;
            this.btn_Venta.Text = "Nueva Venta";
            this.btn_Venta.UseVisualStyleBackColor = false;
            this.btn_Venta.Click += new System.EventHandler(this.btn_Venta_Click);
            // 
            // btn_MostrarStock
            // 
            this.btn_MostrarStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(129)))));
            this.btn_MostrarStock.FlatAppearance.BorderSize = 0;
            this.btn_MostrarStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_MostrarStock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_MostrarStock.Location = new System.Drawing.Point(89, 245);
            this.btn_MostrarStock.Name = "btn_MostrarStock";
            this.btn_MostrarStock.Size = new System.Drawing.Size(145, 44);
            this.btn_MostrarStock.TabIndex = 5;
            this.btn_MostrarStock.Text = "Registro De Stock";
            this.btn_MostrarStock.UseVisualStyleBackColor = false;
            // 
            // btn_Pedido
            // 
            this.btn_Pedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(129)))));
            this.btn_Pedido.FlatAppearance.BorderSize = 0;
            this.btn_Pedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Pedido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Pedido.Location = new System.Drawing.Point(89, 195);
            this.btn_Pedido.Name = "btn_Pedido";
            this.btn_Pedido.Size = new System.Drawing.Size(145, 44);
            this.btn_Pedido.TabIndex = 6;
            this.btn_Pedido.Text = "Nuevo Pedido";
            this.btn_Pedido.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::frm_ingreso.Properties.Resources.NEMO_SIN_FONDO;
            this.pictureBox1.Location = new System.Drawing.Point(54, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frm_menuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(333, 456);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Pedido);
            this.Controls.Add(this.btn_MostrarStock);
            this.Controls.Add(this.btn_Venta);
            this.Controls.Add(this.btn_mostrarVentas);
            this.Controls.Add(this.btn_Salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_menuPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_menuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_mostrarVentas;
        private System.Windows.Forms.Button btn_Venta;
        private System.Windows.Forms.Button btn_MostrarStock;
        private System.Windows.Forms.Button btn_Pedido;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

