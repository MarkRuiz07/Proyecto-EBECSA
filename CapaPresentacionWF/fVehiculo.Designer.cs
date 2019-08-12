namespace CapaPresentacionWF
{
    partial class FVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FVehiculo));
            this.tabControlVehiculo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCirculacion = new System.Windows.Forms.TextBox();
            this.labelCircu = new System.Windows.Forms.Label();
            this.textBoxNumPas = new System.Windows.Forms.TextBox();
            this.labelNumero = new System.Windows.Forms.Label();
            this.textBoxVersionCar = new System.Windows.Forms.TextBox();
            this.labelVersion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxAñoFab = new System.Windows.Forms.TextBox();
            this.labelAñoFab = new System.Windows.Forms.Label();
            this.textBoxColorSecun = new System.Windows.Forms.TextBox();
            this.lblColorSec = new System.Windows.Forms.Label();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewVehiculo = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.comboBoxidSeguros = new System.Windows.Forms.ComboBox();
            this.comboBoxidCategoria = new System.Windows.Forms.ComboBox();
            this.comboBoxidProspecto = new System.Windows.Forms.ComboBox();
            this.tabControlVehiculo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlVehiculo
            // 
            this.tabControlVehiculo.Controls.Add(this.tabPage1);
            this.tabControlVehiculo.Controls.Add(this.tabPage2);
            this.tabControlVehiculo.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlVehiculo.Location = new System.Drawing.Point(3, 0);
            this.tabControlVehiculo.Name = "tabControlVehiculo";
            this.tabControlVehiculo.SelectedIndex = 0;
            this.tabControlVehiculo.Size = new System.Drawing.Size(935, 536);
            this.tabControlVehiculo.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.comboBoxidProspecto);
            this.tabPage1.Controls.Add(this.comboBoxidCategoria);
            this.tabPage1.Controls.Add(this.comboBoxidSeguros);
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxCirculacion);
            this.tabPage1.Controls.Add(this.labelCircu);
            this.tabPage1.Controls.Add(this.textBoxNumPas);
            this.tabPage1.Controls.Add(this.labelNumero);
            this.tabPage1.Controls.Add(this.textBoxVersionCar);
            this.tabPage1.Controls.Add(this.labelVersion);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.textBoxAñoFab);
            this.tabPage1.Controls.Add(this.labelAñoFab);
            this.tabPage1.Controls.Add(this.textBoxColorSecun);
            this.tabPage1.Controls.Add(this.lblColorSec);
            this.tabPage1.Controls.Add(this.textBoxColor);
            this.tabPage1.Controls.Add(this.lblColor);
            this.tabPage1.Controls.Add(this.textBoxModelo);
            this.tabPage1.Controls.Add(this.lblModelo);
            this.tabPage1.Controls.Add(this.textBoxMarca);
            this.tabPage1.Controls.Add(this.lblMarca);
            this.tabPage1.Controls.Add(this.textBoxID);
            this.tabPage1.Controls.Add(this.labelID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(927, 504);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGuardar.Location = new System.Drawing.Point(403, 464);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(106, 34);
            this.buttonGuardar.TabIndex = 29;
            this.buttonGuardar.Text = "Registrar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 27;
            // 
            // textBoxCirculacion
            // 
            this.textBoxCirculacion.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCirculacion.Location = new System.Drawing.Point(645, 253);
            this.textBoxCirculacion.Name = "textBoxCirculacion";
            this.textBoxCirculacion.Size = new System.Drawing.Size(236, 22);
            this.textBoxCirculacion.TabIndex = 22;
            // 
            // labelCircu
            // 
            this.labelCircu.AutoSize = true;
            this.labelCircu.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCircu.Location = new System.Drawing.Point(503, 252);
            this.labelCircu.Name = "labelCircu";
            this.labelCircu.Size = new System.Drawing.Size(92, 19);
            this.labelCircu.TabIndex = 21;
            this.labelCircu.Text = "Circulación";
            this.labelCircu.Click += new System.EventHandler(this.labelCircu_Click);
            // 
            // textBoxNumPas
            // 
            this.textBoxNumPas.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumPas.Location = new System.Drawing.Point(645, 184);
            this.textBoxNumPas.Name = "textBoxNumPas";
            this.textBoxNumPas.Size = new System.Drawing.Size(72, 22);
            this.textBoxNumPas.TabIndex = 20;
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumero.Location = new System.Drawing.Point(503, 171);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(98, 38);
            this.labelNumero.TabIndex = 19;
            this.labelNumero.Text = "Numero de \r\n Pasajeros";
            // 
            // textBoxVersionCar
            // 
            this.textBoxVersionCar.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVersionCar.Location = new System.Drawing.Point(645, 305);
            this.textBoxVersionCar.Multiline = true;
            this.textBoxVersionCar.Name = "textBoxVersionCar";
            this.textBoxVersionCar.Size = new System.Drawing.Size(260, 76);
            this.textBoxVersionCar.TabIndex = 18;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.Location = new System.Drawing.Point(503, 305);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(117, 38);
            this.labelVersion.TabIndex = 17;
            this.labelVersion.Text = "Version/\r\nCaracteristicas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(244, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxAñoFab
            // 
            this.textBoxAñoFab.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAñoFab.Location = new System.Drawing.Point(645, 109);
            this.textBoxAñoFab.Name = "textBoxAñoFab";
            this.textBoxAñoFab.Size = new System.Drawing.Size(195, 22);
            this.textBoxAñoFab.TabIndex = 15;
            // 
            // labelAñoFab
            // 
            this.labelAñoFab.AutoSize = true;
            this.labelAñoFab.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAñoFab.Location = new System.Drawing.Point(503, 93);
            this.labelAñoFab.Name = "labelAñoFab";
            this.labelAñoFab.Size = new System.Drawing.Size(96, 38);
            this.labelAñoFab.TabIndex = 14;
            this.labelAñoFab.Text = "Año \r\nFabricacion";
            // 
            // textBoxColorSecun
            // 
            this.textBoxColorSecun.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxColorSecun.Location = new System.Drawing.Point(167, 321);
            this.textBoxColorSecun.Name = "textBoxColorSecun";
            this.textBoxColorSecun.Size = new System.Drawing.Size(195, 22);
            this.textBoxColorSecun.TabIndex = 13;
            // 
            // lblColorSec
            // 
            this.lblColorSec.AutoSize = true;
            this.lblColorSec.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorSec.Location = new System.Drawing.Point(59, 305);
            this.lblColorSec.Name = "lblColorSec";
            this.lblColorSec.Size = new System.Drawing.Size(97, 38);
            this.lblColorSec.TabIndex = 12;
            this.lblColorSec.Text = "Color\r\n Secundario";
            // 
            // textBoxColor
            // 
            this.textBoxColor.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxColor.Location = new System.Drawing.Point(167, 253);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(195, 22);
            this.textBoxColor.TabIndex = 11;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(107, 252);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(49, 19);
            this.lblColor.TabIndex = 10;
            this.lblColor.Text = "Color";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModelo.Location = new System.Drawing.Point(167, 203);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(195, 22);
            this.textBoxModelo.TabIndex = 9;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(95, 202);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(66, 19);
            this.lblModelo.TabIndex = 8;
            this.lblModelo.Text = "Modelo";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMarca.Location = new System.Drawing.Point(167, 148);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(195, 22);
            this.textBoxMarca.TabIndex = 7;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(106, 147);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(55, 19);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(167, 93);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(43, 22);
            this.textBoxID.TabIndex = 5;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(135, 94);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 19);
            this.labelID.TabIndex = 4;
            this.labelID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Bold ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(350, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datos del Vehiculo";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.dataGridViewVehiculo);
            this.tabPage2.Controls.Add(this.buttonEliminar);
            this.tabPage2.Controls.Add(this.buttonEditar);
            this.tabPage2.Controls.Add(this.textBoxBuscar);
            this.tabPage2.Controls.Add(this.labelBuscar);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(927, 504);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalles";
            // 
            // dataGridViewVehiculo
            // 
            this.dataGridViewVehiculo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehiculo.Location = new System.Drawing.Point(25, 103);
            this.dataGridViewVehiculo.Name = "dataGridViewVehiculo";
            this.dataGridViewVehiculo.Size = new System.Drawing.Size(874, 357);
            this.dataGridViewVehiculo.TabIndex = 4;
            this.dataGridViewVehiculo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVehiculo_CellContentClick);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Location = new System.Drawing.Point(514, 21);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(91, 28);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.Gold;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Location = new System.Drawing.Point(402, 21);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(89, 27);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Font = new System.Drawing.Font("Eras Medium ITC", 10F);
            this.textBoxBuscar.Location = new System.Drawing.Point(94, 21);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(279, 23);
            this.textBoxBuscar.TabIndex = 1;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBuscar.Location = new System.Drawing.Point(29, 21);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(59, 19);
            this.labelBuscar.TabIndex = 0;
            this.labelBuscar.Text = "Buscar";
            // 
            // comboBoxidSeguros
            // 
            this.comboBoxidSeguros.FormattingEnabled = true;
            this.comboBoxidSeguros.Location = new System.Drawing.Point(167, 369);
            this.comboBoxidSeguros.Name = "comboBoxidSeguros";
            this.comboBoxidSeguros.Size = new System.Drawing.Size(43, 27);
            this.comboBoxidSeguros.TabIndex = 30;
            // 
            // comboBoxidCategoria
            // 
            this.comboBoxidCategoria.FormattingEnabled = true;
            this.comboBoxidCategoria.Location = new System.Drawing.Point(167, 418);
            this.comboBoxidCategoria.Name = "comboBoxidCategoria";
            this.comboBoxidCategoria.Size = new System.Drawing.Size(43, 27);
            this.comboBoxidCategoria.TabIndex = 31;
            // 
            // comboBoxidProspecto
            // 
            this.comboBoxidProspecto.FormattingEnabled = true;
            this.comboBoxidProspecto.Location = new System.Drawing.Point(526, 406);
            this.comboBoxidProspecto.Name = "comboBoxidProspecto";
            this.comboBoxidProspecto.Size = new System.Drawing.Size(35, 27);
            this.comboBoxidProspecto.TabIndex = 32;
            // 
            // FVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(943, 548);
            this.Controls.Add(this.tabControlVehiculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FVehiculo";
            this.Text = "Seguros EBECSA";
            this.Load += new System.EventHandler(this.FVehiculo_Load);
            this.tabControlVehiculo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlVehiculo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxAñoFab;
        private System.Windows.Forms.Label labelAñoFab;
        private System.Windows.Forms.TextBox textBoxColorSecun;
        private System.Windows.Forms.Label lblColorSec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxVersionCar;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.TextBox textBoxNumPas;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.TextBox textBoxCirculacion;
        private System.Windows.Forms.Label labelCircu;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewVehiculo;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.ComboBox comboBoxidSeguros;
        private System.Windows.Forms.ComboBox comboBoxidCategoria;
        private System.Windows.Forms.ComboBox comboBoxidProspecto;
    }
}

