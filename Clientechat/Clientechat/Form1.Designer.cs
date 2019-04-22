namespace Clientechat
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
            this.btnenviar = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbContactos = new System.Windows.Forms.ListBox();
            this.txtnick = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbConversacion = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnenviar
            // 
            this.btnenviar.Location = new System.Drawing.Point(317, 441);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(75, 23);
            this.btnenviar.TabIndex = 0;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(65, 443);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(246, 20);
            this.txtMensaje.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mensaje";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbContactos
            // 
            this.lbContactos.FormattingEnabled = true;
            this.lbContactos.Location = new System.Drawing.Point(442, 12);
            this.lbContactos.Name = "lbContactos";
            this.lbContactos.Size = new System.Drawing.Size(120, 381);
            this.lbContactos.TabIndex = 3;
            // 
            // txtnick
            // 
            this.txtnick.Location = new System.Drawing.Point(462, 415);
            this.txtnick.Name = "txtnick";
            this.txtnick.Size = new System.Drawing.Size(100, 20);
            this.txtnick.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nick";
            // 
            // lbConversacion
            // 
            this.lbConversacion.FormattingEnabled = true;
            this.lbConversacion.Location = new System.Drawing.Point(15, 12);
            this.lbConversacion.Name = "lbConversacion";
            this.lbConversacion.Size = new System.Drawing.Size(377, 394);
            this.lbConversacion.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 503);
            this.Controls.Add(this.lbConversacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnick);
            this.Controls.Add(this.lbContactos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.btnenviar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbContactos;
        private System.Windows.Forms.TextBox txtnick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbConversacion;
    }
}

