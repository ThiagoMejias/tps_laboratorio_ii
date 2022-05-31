
namespace LibreriaForm
{
    partial class ListadoStock
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
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.rtx_Cajas = new System.Windows.Forms.RichTextBox();
            this.txt_Tipo = new System.Windows.Forms.TextBox();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.AutoSize = true;
            this.lbl_Stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(0)))), ((int)(((byte)(21)))));
            this.lbl_Stock.Font = new System.Drawing.Font("Symbola", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Stock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Stock.Location = new System.Drawing.Point(101, 33);
            this.lbl_Stock.Name = "lbl_Stock";
            this.lbl_Stock.Size = new System.Drawing.Size(69, 21);
            this.lbl_Stock.TabIndex = 0;
            this.lbl_Stock.Text = "adasd";
            this.lbl_Stock.Click += new System.EventHandler(this.lbl_Stock_Click);
            // 
            // rtx_Cajas
            // 
            this.rtx_Cajas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(0)))), ((int)(((byte)(21)))));
            this.rtx_Cajas.Location = new System.Drawing.Point(436, 24);
            this.rtx_Cajas.Name = "rtx_Cajas";
            this.rtx_Cajas.Size = new System.Drawing.Size(352, 194);
            this.rtx_Cajas.TabIndex = 1;
            this.rtx_Cajas.Text = "";
            // 
            // txt_Tipo
            // 
            this.txt_Tipo.Location = new System.Drawing.Point(34, 239);
            this.txt_Tipo.Name = "txt_Tipo";
            this.txt_Tipo.Size = new System.Drawing.Size(100, 23);
            this.txt_Tipo.TabIndex = 2;
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Location = new System.Drawing.Point(34, 203);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(30, 15);
            this.lbl_Tipo.TabIndex = 3;
            this.lbl_Tipo.Text = "Tipo";
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Location = new System.Drawing.Point(187, 203);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(40, 15);
            this.lbl_Marca.TabIndex = 4;
            this.lbl_Marca.Text = "Marca";
            // 
            // txt_Marca
            // 
            this.txt_Marca.Location = new System.Drawing.Point(187, 239);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(100, 23);
            this.txt_Marca.TabIndex = 5;
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(344, 239);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(100, 23);
            this.txt_Cantidad.TabIndex = 6;
            this.txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cantidad_KeyPress);
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Location = new System.Drawing.Point(344, 203);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(55, 15);
            this.lbl_Cantidad.TabIndex = 7;
            this.lbl_Cantidad.Text = "Cantidad";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(34, 358);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(119, 49);
            this.btn_Agregar.TabIndex = 8;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(646, 358);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(120, 49);
            this.btn_Cerrar.TabIndex = 9;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // ListadoStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibreriaForm.Properties.Resources.FONDO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lbl_Cantidad);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.txt_Marca);
            this.Controls.Add(this.lbl_Marca);
            this.Controls.Add(this.lbl_Tipo);
            this.Controls.Add(this.txt_Tipo);
            this.Controls.Add(this.rtx_Cajas);
            this.Controls.Add(this.lbl_Stock);
            this.Name = "ListadoStock";
            this.Text = "ListadoStock";
            this.Load += new System.EventHandler(this.ListadoStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Stock;
        private System.Windows.Forms.RichTextBox rtx_Cajas;
        private System.Windows.Forms.TextBox txt_Tipo;
        private System.Windows.Forms.Label lbl_Tipo;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.TextBox txt_Marca;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Cerrar;
    }
}