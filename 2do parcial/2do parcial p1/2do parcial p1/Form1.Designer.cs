namespace _2do_parcial_p1
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
            this.btnobtener = new System.Windows.Forms.Button();
            this.btncolocar = new System.Windows.Forms.Button();
            this.lblcotizacion = new System.Windows.Forms.Label();
            this.txtcotizacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnobtener
            // 
            this.btnobtener.Location = new System.Drawing.Point(402, 58);
            this.btnobtener.Name = "btnobtener";
            this.btnobtener.Size = new System.Drawing.Size(75, 23);
            this.btnobtener.TabIndex = 0;
            this.btnobtener.Text = "Obtener";
            this.btnobtener.UseVisualStyleBackColor = true;
            this.btnobtener.Click += new System.EventHandler(this.btnobtener_Click);
            // 
            // btncolocar
            // 
            this.btncolocar.Location = new System.Drawing.Point(402, 108);
            this.btncolocar.Name = "btncolocar";
            this.btncolocar.Size = new System.Drawing.Size(75, 23);
            this.btncolocar.TabIndex = 1;
            this.btncolocar.Text = "Colocar";
            this.btncolocar.UseVisualStyleBackColor = true;
            this.btncolocar.Click += new System.EventHandler(this.btncolocar_Click);
            // 
            // lblcotizacion
            // 
            this.lblcotizacion.AutoSize = true;
            this.lblcotizacion.Location = new System.Drawing.Point(71, 58);
            this.lblcotizacion.Name = "lblcotizacion";
            this.lblcotizacion.Size = new System.Drawing.Size(0, 13);
            this.lblcotizacion.TabIndex = 2;
            // 
            // txtcotizacion
            // 
            this.txtcotizacion.Location = new System.Drawing.Point(74, 110);
            this.txtcotizacion.Name = "txtcotizacion";
            this.txtcotizacion.Size = new System.Drawing.Size(100, 20);
            this.txtcotizacion.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 174);
            this.Controls.Add(this.txtcotizacion);
            this.Controls.Add(this.lblcotizacion);
            this.Controls.Add(this.btncolocar);
            this.Controls.Add(this.btnobtener);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnobtener;
        private System.Windows.Forms.Button btncolocar;
        private System.Windows.Forms.Label lblcotizacion;
        private System.Windows.Forms.TextBox txtcotizacion;
    }
}

