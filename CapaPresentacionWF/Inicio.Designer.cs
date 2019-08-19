namespace CapaPresentacionWF
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblinicio = new System.Windows.Forms.Label();
            this.picBoxInicio = new System.Windows.Forms.PictureBox();
            this.pictureBoxEbecsa = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEbecsa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lblinicio);
            this.panel1.Controls.Add(this.picBoxInicio);
            this.panel1.Controls.Add(this.pictureBoxEbecsa);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 677);
            this.panel1.TabIndex = 0;
            // 
            // lblinicio
            // 
            this.lblinicio.AutoSize = true;
            this.lblinicio.BackColor = System.Drawing.Color.FloralWhite;
            this.lblinicio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblinicio.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinicio.Location = new System.Drawing.Point(824, 603);
            this.lblinicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblinicio.Name = "lblinicio";
            this.lblinicio.Size = new System.Drawing.Size(203, 28);
            this.lblinicio.TabIndex = 4;
            this.lblinicio.Text = "Iniciar cotización";
            // 
            // picBoxInicio
            // 
            this.picBoxInicio.Image = ((System.Drawing.Image)(resources.GetObject("picBoxInicio.Image")));
            this.picBoxInicio.Location = new System.Drawing.Point(1036, 603);
            this.picBoxInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBoxInicio.Name = "picBoxInicio";
            this.picBoxInicio.Size = new System.Drawing.Size(32, 32);
            this.picBoxInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxInicio.TabIndex = 3;
            this.picBoxInicio.TabStop = false;
            this.picBoxInicio.Click += new System.EventHandler(this.picBoxInicio_Click);
            // 
            // pictureBoxEbecsa
            // 
            this.pictureBoxEbecsa.Image = global::CapaPresentacionWF.Properties.Resources.Ebecsa1;
            this.pictureBoxEbecsa.Location = new System.Drawing.Point(207, 117);
            this.pictureBoxEbecsa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxEbecsa.Name = "pictureBoxEbecsa";
            this.pictureBoxEbecsa.Size = new System.Drawing.Size(732, 382);
            this.pictureBoxEbecsa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEbecsa.TabIndex = 1;
            this.pictureBoxEbecsa.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1185, 695);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Inicio";
            this.Text = "Seguros EBECSA";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEbecsa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxEbecsa;
        private System.Windows.Forms.Label lblinicio;
        private System.Windows.Forms.PictureBox picBoxInicio;
    }
}