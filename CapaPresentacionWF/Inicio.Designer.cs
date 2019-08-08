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
            this.pictureBoxEbecsa = new System.Windows.Forms.PictureBox();
            this.picBoxInicio = new System.Windows.Forms.PictureBox();
            this.lblinicio = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEbecsa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lblinicio);
            this.panel1.Controls.Add(this.picBoxInicio);
            this.panel1.Controls.Add(this.pictureBoxEbecsa);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 440);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxEbecsa
            // 
            this.pictureBoxEbecsa.Image = global::CapaPresentacionWF.Properties.Resources.Ebecsa1;
            this.pictureBoxEbecsa.Location = new System.Drawing.Point(138, 76);
            this.pictureBoxEbecsa.Name = "pictureBoxEbecsa";
            this.pictureBoxEbecsa.Size = new System.Drawing.Size(488, 248);
            this.pictureBoxEbecsa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEbecsa.TabIndex = 1;
            this.pictureBoxEbecsa.TabStop = false;
            // 
            // picBoxInicio
            // 
            this.picBoxInicio.Image = ((System.Drawing.Image)(resources.GetObject("picBoxInicio.Image")));
            this.picBoxInicio.Location = new System.Drawing.Point(691, 392);
            this.picBoxInicio.Name = "picBoxInicio";
            this.picBoxInicio.Size = new System.Drawing.Size(32, 32);
            this.picBoxInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxInicio.TabIndex = 3;
            this.picBoxInicio.TabStop = false;
            // 
            // lblinicio
            // 
            this.lblinicio.AutoSize = true;
            this.lblinicio.BackColor = System.Drawing.Color.FloralWhite;
            this.lblinicio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblinicio.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinicio.Location = new System.Drawing.Point(549, 392);
            this.lblinicio.Name = "lblinicio";
            this.lblinicio.Size = new System.Drawing.Size(136, 19);
            this.lblinicio.TabIndex = 4;
            this.lblinicio.Text = "Iniciar cotización";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 452);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.Text = "Seguros EBECSA";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEbecsa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxEbecsa;
        private System.Windows.Forms.Label lblinicio;
        private System.Windows.Forms.PictureBox picBoxInicio;
    }
}