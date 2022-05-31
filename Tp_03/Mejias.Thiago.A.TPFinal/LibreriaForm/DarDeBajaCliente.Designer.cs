
namespace LibreriaForm
{
    partial class DarDeBajaCliente
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
            this.txt_buscarPorDni = new System.Windows.Forms.TextBox();
            this.lbl_BuscarPorDni = new System.Windows.Forms.Label();
            this.rtb_Cliente = new System.Windows.Forms.RichTextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_buscarPorDni
            // 
            this.txt_buscarPorDni.Location = new System.Drawing.Point(29, 71);
            this.txt_buscarPorDni.Name = "txt_buscarPorDni";
            this.txt_buscarPorDni.Size = new System.Drawing.Size(156, 23);
            this.txt_buscarPorDni.TabIndex = 0;
            this.txt_buscarPorDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscarPorDni_KeyPress);
            // 
            // lbl_BuscarPorDni
            // 
            this.lbl_BuscarPorDni.AutoSize = true;
            this.lbl_BuscarPorDni.Location = new System.Drawing.Point(29, 33);
            this.lbl_BuscarPorDni.Name = "lbl_BuscarPorDni";
            this.lbl_BuscarPorDni.Size = new System.Drawing.Size(84, 15);
            this.lbl_BuscarPorDni.TabIndex = 1;
            this.lbl_BuscarPorDni.Text = "Buscar Por Dni";
            this.lbl_BuscarPorDni.Click += new System.EventHandler(this.label1_Click);
            // 
            // rtb_Cliente
            // 
            this.rtb_Cliente.Location = new System.Drawing.Point(373, 33);
            this.rtb_Cliente.Name = "rtb_Cliente";
            this.rtb_Cliente.Size = new System.Drawing.Size(387, 69);
            this.rtb_Cliente.TabIndex = 4;
            this.rtb_Cliente.Text = "";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.AccessibleName = "btn_Buscar";
            this.btn_Buscar.Location = new System.Drawing.Point(29, 319);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(130, 47);
            this.btn_Buscar.TabIndex = 5;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(411, 316);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(128, 53);
            this.btn_eliminar.TabIndex = 6;
            this.btn_eliminar.Text = "Dar De Baja";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(624, 311);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(136, 55);
            this.btn_cerrar.TabIndex = 7;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // DarDeBajaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibreriaForm.Properties.Resources.FONDO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.rtb_Cliente);
            this.Controls.Add(this.lbl_BuscarPorDni);
            this.Controls.Add(this.txt_buscarPorDni);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "DarDeBajaCliente";
            this.Text = "DarDeBajaCliente";
            this.Load += new System.EventHandler(this.DarDeBajaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_buscarPorDni;
        private System.Windows.Forms.Label lbl_BuscarPorDni;
        private System.Windows.Forms.RichTextBox rtb_Cliente;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_cerrar;
    }
}