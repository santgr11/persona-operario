namespace OperarioGUI
{
    partial class frmOperarios
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboCategorias = new System.Windows.Forms.ComboBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHrsTrabajadas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioHora = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFecNac = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbInforme = new System.Windows.Forms.GroupBox();
            this.lblOficiales = new System.Windows.Forms.Label();
            this.lblCapataces = new System.Windows.Forms.Label();
            this.lblMostrarTotalS = new System.Windows.Forms.Label();
            this.lblMostrarS = new System.Windows.Forms.Label();
            this.lblTotOfi = new System.Windows.Forms.Label();
            this.lblCtdCapa = new System.Windows.Forms.Label();
            this.lblTotSueldos = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.gbInforme.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // cboCategorias
            // 
            this.cboCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategorias.FormattingEnabled = true;
            this.cboCategorias.Items.AddRange(new object[] {
            "Capataz",
            "Oficial"});
            this.cboCategorias.Location = new System.Drawing.Point(64, 135);
            this.cboCategorias.Name = "cboCategorias";
            this.cboCategorias.Size = new System.Drawing.Size(138, 21);
            this.cboCategorias.TabIndex = 1;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(64, 23);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(138, 20);
            this.txtDni.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(64, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(138, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Categoria:";
            // 
            // txtHrsTrabajadas
            // 
            this.txtHrsTrabajadas.Location = new System.Drawing.Point(128, 162);
            this.txtHrsTrabajadas.Name = "txtHrsTrabajadas";
            this.txtHrsTrabajadas.Size = new System.Drawing.Size(74, 20);
            this.txtHrsTrabajadas.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Horas trabajadas:";
            // 
            // txtPrecioHora
            // 
            this.txtPrecioHora.Location = new System.Drawing.Point(128, 188);
            this.txtPrecioHora.Name = "txtPrecioHora";
            this.txtPrecioHora.Size = new System.Drawing.Size(74, 20);
            this.txtPrecioHora.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio Hora:";
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(64, 81);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbFemenino.TabIndex = 10;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(131, 81);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 11;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sexo:";
            // 
            // dtpFecNac
            // 
            this.dtpFecNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecNac.Location = new System.Drawing.Point(64, 109);
            this.dtpFecNac.Name = "dtpFecNac";
            this.dtpFecNac.Size = new System.Drawing.Size(138, 20);
            this.dtpFecNac.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fec. Nac:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(46, 226);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 15;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(127, 226);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // gbInforme
            // 
            this.gbInforme.Controls.Add(this.lblOficiales);
            this.gbInforme.Controls.Add(this.lblCapataces);
            this.gbInforme.Controls.Add(this.lblMostrarTotalS);
            this.gbInforme.Controls.Add(this.lblMostrarS);
            this.gbInforme.Controls.Add(this.lblTotOfi);
            this.gbInforme.Controls.Add(this.lblCtdCapa);
            this.gbInforme.Controls.Add(this.lblTotSueldos);
            this.gbInforme.Controls.Add(this.lblSueldo);
            this.gbInforme.Location = new System.Drawing.Point(218, 23);
            this.gbInforme.Name = "gbInforme";
            this.gbInforme.Size = new System.Drawing.Size(280, 226);
            this.gbInforme.TabIndex = 17;
            this.gbInforme.TabStop = false;
            this.gbInforme.Text = "Informe de carga";
            // 
            // lblOficiales
            // 
            this.lblOficiales.AutoSize = true;
            this.lblOficiales.Location = new System.Drawing.Point(216, 139);
            this.lblOficiales.Name = "lblOficiales";
            this.lblOficiales.Size = new System.Drawing.Size(13, 13);
            this.lblOficiales.TabIndex = 7;
            this.lblOficiales.Text = "0";
            // 
            // lblCapataces
            // 
            this.lblCapataces.AutoSize = true;
            this.lblCapataces.Location = new System.Drawing.Point(216, 107);
            this.lblCapataces.Name = "lblCapataces";
            this.lblCapataces.Size = new System.Drawing.Size(13, 13);
            this.lblCapataces.TabIndex = 6;
            this.lblCapataces.Text = "0";
            // 
            // lblMostrarTotalS
            // 
            this.lblMostrarTotalS.AutoSize = true;
            this.lblMostrarTotalS.Location = new System.Drawing.Point(216, 70);
            this.lblMostrarTotalS.Name = "lblMostrarTotalS";
            this.lblMostrarTotalS.Size = new System.Drawing.Size(13, 13);
            this.lblMostrarTotalS.TabIndex = 5;
            this.lblMostrarTotalS.Text = "0";
            // 
            // lblMostrarS
            // 
            this.lblMostrarS.AutoSize = true;
            this.lblMostrarS.Location = new System.Drawing.Point(216, 41);
            this.lblMostrarS.Name = "lblMostrarS";
            this.lblMostrarS.Size = new System.Drawing.Size(13, 13);
            this.lblMostrarS.TabIndex = 4;
            this.lblMostrarS.Text = "0";
            // 
            // lblTotOfi
            // 
            this.lblTotOfi.AutoSize = true;
            this.lblTotOfi.Location = new System.Drawing.Point(23, 141);
            this.lblTotOfi.Name = "lblTotOfi";
            this.lblTotOfi.Size = new System.Drawing.Size(93, 13);
            this.lblTotOfi.TabIndex = 3;
            this.lblTotOfi.Text = "Cantidad oficiales:";
            // 
            // lblCtdCapa
            // 
            this.lblCtdCapa.AutoSize = true;
            this.lblCtdCapa.Location = new System.Drawing.Point(23, 107);
            this.lblCtdCapa.Name = "lblCtdCapa";
            this.lblCtdCapa.Size = new System.Drawing.Size(105, 13);
            this.lblCtdCapa.TabIndex = 2;
            this.lblCtdCapa.Text = "Cantidad capataces:";
            // 
            // lblTotSueldos
            // 
            this.lblTotSueldos.AutoSize = true;
            this.lblTotSueldos.Location = new System.Drawing.Point(23, 70);
            this.lblTotSueldos.Name = "lblTotSueldos";
            this.lblTotSueldos.Size = new System.Drawing.Size(75, 13);
            this.lblTotSueldos.TabIndex = 1;
            this.lblTotSueldos.Text = "Total Sueldos:";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(23, 41);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(43, 13);
            this.lblSueldo.TabIndex = 0;
            this.lblSueldo.Text = "Sueldo:";
            // 
            // frmOperarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 262);
            this.Controls.Add(this.gbInforme);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFecNac);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbMasculino);
            this.Controls.Add(this.rbFemenino);
            this.Controls.Add(this.txtPrecioHora);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHrsTrabajadas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.cboCategorias);
            this.Controls.Add(this.label1);
            this.Name = "frmOperarios";
            this.Text = "Operarios";
            this.gbInforme.ResumeLayout(false);
            this.gbInforme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCategorias;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHrsTrabajadas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioHora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFecNac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbInforme;
        private System.Windows.Forms.Label lblTotOfi;
        private System.Windows.Forms.Label lblCtdCapa;
        private System.Windows.Forms.Label lblTotSueldos;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblOficiales;
        private System.Windows.Forms.Label lblCapataces;
        private System.Windows.Forms.Label lblMostrarTotalS;
        private System.Windows.Forms.Label lblMostrarS;
    }
}

