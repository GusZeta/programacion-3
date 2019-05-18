namespace ahorcado
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
            this.btnempezar = new System.Windows.Forms.Button();
            this.btnenviar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtletra = new System.Windows.Forms.TextBox();
            this.lblletra = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpalabra = new System.Windows.Forms.TextBox();
            this.btnenviarpalabra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnempezar
            // 
            this.btnempezar.Location = new System.Drawing.Point(386, 59);
            this.btnempezar.Name = "btnempezar";
            this.btnempezar.Size = new System.Drawing.Size(75, 23);
            this.btnempezar.TabIndex = 0;
            this.btnempezar.Text = "Empezar";
            this.btnempezar.UseVisualStyleBackColor = true;
            this.btnempezar.Click += new System.EventHandler(this.btnempezar_Click);
            // 
            // btnenviar
            // 
            this.btnenviar.Location = new System.Drawing.Point(386, 98);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(75, 23);
            this.btnenviar.TabIndex = 1;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(102, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 326);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Introduzca letra";
            // 
            // txtletra
            // 
            this.txtletra.Location = new System.Drawing.Point(130, 66);
            this.txtletra.MaxLength = 1;
            this.txtletra.Name = "txtletra";
            this.txtletra.Size = new System.Drawing.Size(100, 20);
            this.txtletra.TabIndex = 4;
            // 
            // lblletra
            // 
            this.lblletra.AutoSize = true;
            this.lblletra.Location = new System.Drawing.Point(50, 143);
            this.lblletra.Name = "lblletra";
            this.lblletra.Size = new System.Drawing.Size(13, 13);
            this.lblletra.TabIndex = 5;
            this.lblletra.Text = "_";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Palabra adivinar";
            // 
            // txtpalabra
            // 
            this.txtpalabra.Location = new System.Drawing.Point(130, 107);
            this.txtpalabra.Name = "txtpalabra";
            this.txtpalabra.Size = new System.Drawing.Size(100, 20);
            this.txtpalabra.TabIndex = 7;
            // 
            // btnenviarpalabra
            // 
            this.btnenviarpalabra.Location = new System.Drawing.Point(369, 138);
            this.btnenviarpalabra.Name = "btnenviarpalabra";
            this.btnenviarpalabra.Size = new System.Drawing.Size(92, 23);
            this.btnenviarpalabra.TabIndex = 8;
            this.btnenviarpalabra.Text = "Enviar palabra";
            this.btnenviarpalabra.UseVisualStyleBackColor = true;
            this.btnenviarpalabra.Click += new System.EventHandler(this.btnenviarpalabra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 535);
            this.Controls.Add(this.btnenviarpalabra);
            this.Controls.Add(this.txtpalabra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblletra);
            this.Controls.Add(this.txtletra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.btnempezar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnempezar;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtletra;
        private System.Windows.Forms.Label lblletra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpalabra;
        private System.Windows.Forms.Button btnenviarpalabra;
    }
}

