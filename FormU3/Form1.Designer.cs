namespace FormU3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxDivisas = new System.Windows.Forms.GroupBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.groupBoxDivisas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDivisas
            // 
            this.groupBoxDivisas.Controls.Add(this.btnCalcular);
            this.groupBoxDivisas.Controls.Add(this.lstHistorial);
            this.groupBoxDivisas.Controls.Add(this.lblCantidad);
            this.groupBoxDivisas.Controls.Add(this.txtCantidad);
            this.groupBoxDivisas.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDivisas.Name = "groupBoxDivisas";
            this.groupBoxDivisas.Size = new System.Drawing.Size(776, 426);
            this.groupBoxDivisas.TabIndex = 0;
            this.groupBoxDivisas.TabStop = false;
            this.groupBoxDivisas.Text = "Casa de cambio - Conversor de divisas";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(211, 110);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(151, 20);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad de dólares";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(192, 184);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(177, 35);
            this.txtCantidad.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(215, 267);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(133, 61);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular cambio";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lstHistorial
            // 
            this.lstHistorial.FormattingEnabled = true;
            this.lstHistorial.ItemHeight = 20;
            this.lstHistorial.Location = new System.Drawing.Point(424, 49);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.Size = new System.Drawing.Size(313, 344);
            this.lstHistorial.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxDivisas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxDivisas.ResumeLayout(false);
            this.groupBoxDivisas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDivisas;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ListBox lstHistorial;
    }
}

