namespace examen_final_ej_1
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
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.lblplaca = new System.Windows.Forms.Label();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.lbltipo = new System.Windows.Forms.Label();
            this.rbauto = new System.Windows.Forms.RadioButton();
            this.rbvagoneta = new System.Windows.Forms.RadioButton();
            this.rbmoto = new System.Windows.Forms.RadioButton();
            this.rbcamion = new System.Windows.Forms.RadioButton();
            this.rbjeep = new System.Windows.Forms.RadioButton();
            this.rbotro = new System.Windows.Forms.RadioButton();
            this.lblmonto = new System.Windows.Forms.Label();
            this.txtentrada = new System.Windows.Forms.TextBox();
            this.txtsalida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstvehiculo = new System.Windows.Forms.ListBox();
            this.lstconsultas = new System.Windows.Forms.ListBox();
            this.btnvehiculos = new System.Windows.Forms.Button();
            this.btngconsultas = new System.Windows.Forms.Button();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(125, 40);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(121, 20);
            this.txtplaca.TabIndex = 0;
            // 
            // lblplaca
            // 
            this.lblplaca.AutoSize = true;
            this.lblplaca.Location = new System.Drawing.Point(36, 40);
            this.lblplaca.Name = "lblplaca";
            this.lblplaca.Size = new System.Drawing.Size(34, 13);
            this.lblplaca.TabIndex = 1;
            this.lblplaca.Text = "Placa";
            // 
            // cbtipo
            // 
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Items.AddRange(new object[] {
            "Auto",
            "Vagoneta",
            "Moto",
            "Camión",
            "Jepp",
            "Otros"});
            this.cbtipo.Location = new System.Drawing.Point(125, 87);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(121, 21);
            this.cbtipo.TabIndex = 2;
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(36, 90);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(86, 13);
            this.lbltipo.TabIndex = 3;
            this.lbltipo.Text = "Tipo de vehiculo";
            // 
            // rbauto
            // 
            this.rbauto.AutoSize = true;
            this.rbauto.Location = new System.Drawing.Point(125, 126);
            this.rbauto.Name = "rbauto";
            this.rbauto.Size = new System.Drawing.Size(91, 17);
            this.rbauto.TabIndex = 4;
            this.rbauto.TabStop = true;
            this.rbauto.Text = "Auto: 2 x hora";
            this.rbauto.UseVisualStyleBackColor = true;
            // 
            // rbvagoneta
            // 
            this.rbvagoneta.AutoSize = true;
            this.rbvagoneta.Location = new System.Drawing.Point(125, 150);
            this.rbvagoneta.Name = "rbvagoneta";
            this.rbvagoneta.Size = new System.Drawing.Size(115, 17);
            this.rbvagoneta.TabIndex = 5;
            this.rbvagoneta.TabStop = true;
            this.rbvagoneta.Text = "Vagoneta: 4 x hora";
            this.rbvagoneta.UseVisualStyleBackColor = true;
            // 
            // rbmoto
            // 
            this.rbmoto.AutoSize = true;
            this.rbmoto.Location = new System.Drawing.Point(125, 174);
            this.rbmoto.Name = "rbmoto";
            this.rbmoto.Size = new System.Drawing.Size(93, 17);
            this.rbmoto.TabIndex = 6;
            this.rbmoto.TabStop = true;
            this.rbmoto.Text = "Moto: 1 x hora";
            this.rbmoto.UseVisualStyleBackColor = true;
            // 
            // rbcamion
            // 
            this.rbcamion.AutoSize = true;
            this.rbcamion.Location = new System.Drawing.Point(125, 198);
            this.rbcamion.Name = "rbcamion";
            this.rbcamion.Size = new System.Drawing.Size(104, 17);
            this.rbcamion.TabIndex = 7;
            this.rbcamion.TabStop = true;
            this.rbcamion.Text = "Camión: 5 x hora";
            this.rbcamion.UseVisualStyleBackColor = true;
            // 
            // rbjeep
            // 
            this.rbjeep.AutoSize = true;
            this.rbjeep.Location = new System.Drawing.Point(125, 222);
            this.rbjeep.Name = "rbjeep";
            this.rbjeep.Size = new System.Drawing.Size(92, 17);
            this.rbjeep.TabIndex = 8;
            this.rbjeep.TabStop = true;
            this.rbjeep.Text = "Jeep: 3 x hora";
            this.rbjeep.UseVisualStyleBackColor = true;
            // 
            // rbotro
            // 
            this.rbotro.AutoSize = true;
            this.rbotro.Location = new System.Drawing.Point(125, 246);
            this.rbotro.Name = "rbotro";
            this.rbotro.Size = new System.Drawing.Size(94, 17);
            this.rbotro.TabIndex = 9;
            this.rbotro.TabStop = true;
            this.rbotro.Text = "Otros: 6 x hora";
            this.rbotro.UseVisualStyleBackColor = true;
            // 
            // lblmonto
            // 
            this.lblmonto.AutoSize = true;
            this.lblmonto.Location = new System.Drawing.Point(36, 126);
            this.lblmonto.Name = "lblmonto";
            this.lblmonto.Size = new System.Drawing.Size(37, 13);
            this.lblmonto.TabIndex = 10;
            this.lblmonto.Text = "Monto";
            // 
            // txtentrada
            // 
            this.txtentrada.Location = new System.Drawing.Point(125, 279);
            this.txtentrada.Name = "txtentrada";
            this.txtentrada.Size = new System.Drawing.Size(121, 20);
            this.txtentrada.TabIndex = 11;
            // 
            // txtsalida
            // 
            this.txtsalida.Location = new System.Drawing.Point(125, 323);
            this.txtsalida.Name = "txtsalida";
            this.txtsalida.Size = new System.Drawing.Size(121, 20);
            this.txtsalida.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Hora Entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hora Salida";
            // 
            // lstvehiculo
            // 
            this.lstvehiculo.FormattingEnabled = true;
            this.lstvehiculo.Location = new System.Drawing.Point(332, 40);
            this.lstvehiculo.Name = "lstvehiculo";
            this.lstvehiculo.Size = new System.Drawing.Size(190, 303);
            this.lstvehiculo.TabIndex = 15;
            // 
            // lstconsultas
            // 
            this.lstconsultas.FormattingEnabled = true;
            this.lstconsultas.Location = new System.Drawing.Point(542, 40);
            this.lstconsultas.Name = "lstconsultas";
            this.lstconsultas.Size = new System.Drawing.Size(288, 303);
            this.lstconsultas.TabIndex = 16;
            // 
            // btnvehiculos
            // 
            this.btnvehiculos.Location = new System.Drawing.Point(397, 362);
            this.btnvehiculos.Name = "btnvehiculos";
            this.btnvehiculos.Size = new System.Drawing.Size(75, 23);
            this.btnvehiculos.TabIndex = 17;
            this.btnvehiculos.Text = "Mostrar";
            this.btnvehiculos.UseVisualStyleBackColor = true;
            this.btnvehiculos.Click += new System.EventHandler(this.btnvehiculos_Click);
            // 
            // btngconsultas
            // 
            this.btngconsultas.Location = new System.Drawing.Point(542, 362);
            this.btngconsultas.Name = "btngconsultas";
            this.btngconsultas.Size = new System.Drawing.Size(75, 23);
            this.btngconsultas.TabIndex = 18;
            this.btngconsultas.Text = "Guardar";
            this.btngconsultas.UseVisualStyleBackColor = true;
            this.btngconsultas.Click += new System.EventHandler(this.btnconsultas_Click);
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(654, 362);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 19;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 399);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.btngconsultas);
            this.Controls.Add(this.btnvehiculos);
            this.Controls.Add(this.lstconsultas);
            this.Controls.Add(this.lstvehiculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsalida);
            this.Controls.Add(this.txtentrada);
            this.Controls.Add(this.lblmonto);
            this.Controls.Add(this.rbotro);
            this.Controls.Add(this.rbjeep);
            this.Controls.Add(this.rbcamion);
            this.Controls.Add(this.rbmoto);
            this.Controls.Add(this.rbvagoneta);
            this.Controls.Add(this.rbauto);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.cbtipo);
            this.Controls.Add(this.lblplaca);
            this.Controls.Add(this.txtplaca);
            this.Name = "Form1";
            this.Text = "Parqueo de vehiculos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.Label lblplaca;
        private System.Windows.Forms.ComboBox cbtipo;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.RadioButton rbauto;
        private System.Windows.Forms.RadioButton rbvagoneta;
        private System.Windows.Forms.RadioButton rbmoto;
        private System.Windows.Forms.RadioButton rbcamion;
        private System.Windows.Forms.RadioButton rbjeep;
        private System.Windows.Forms.RadioButton rbotro;
        private System.Windows.Forms.Label lblmonto;
        private System.Windows.Forms.TextBox txtentrada;
        private System.Windows.Forms.TextBox txtsalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstvehiculo;
        private System.Windows.Forms.ListBox lstconsultas;
        private System.Windows.Forms.Button btnvehiculos;
        private System.Windows.Forms.Button btngconsultas;
        private System.Windows.Forms.Button btnmostrar;
    }
}

