﻿namespace DEDFicha
{
    partial class Pericias
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
            this.lbltextopericias = new System.Windows.Forms.Label();
            this.botaoconfirma = new System.Windows.Forms.Button();
            this.opcaoum = new System.Windows.Forms.CheckBox();
            this.opcaodois = new System.Windows.Forms.CheckBox();
            this.opcaotres = new System.Windows.Forms.CheckBox();
            this.lblopcaoum = new System.Windows.Forms.Label();
            this.lblopcaodois = new System.Windows.Forms.Label();
            this.lblopcaotres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltextopericias
            // 
            this.lbltextopericias.AutoSize = true;
            this.lbltextopericias.Location = new System.Drawing.Point(36, 33);
            this.lbltextopericias.Name = "lbltextopericias";
            this.lbltextopericias.Size = new System.Drawing.Size(0, 13);
            this.lbltextopericias.TabIndex = 0;
            // 
            // botaoconfirma
            // 
            this.botaoconfirma.Location = new System.Drawing.Point(363, 415);
            this.botaoconfirma.Name = "botaoconfirma";
            this.botaoconfirma.Size = new System.Drawing.Size(75, 23);
            this.botaoconfirma.TabIndex = 1;
            this.botaoconfirma.Text = "Ok";
            this.botaoconfirma.UseVisualStyleBackColor = true;
            this.botaoconfirma.Click += new System.EventHandler(this.Botaoconfirma_Click);
            // 
            // opcaoum
            // 
            this.opcaoum.AutoSize = true;
            this.opcaoum.Location = new System.Drawing.Point(39, 218);
            this.opcaoum.Name = "opcaoum";
            this.opcaoum.Size = new System.Drawing.Size(15, 14);
            this.opcaoum.TabIndex = 3;
            this.opcaoum.UseVisualStyleBackColor = true;
            this.opcaoum.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // opcaodois
            // 
            this.opcaodois.AutoSize = true;
            this.opcaodois.Location = new System.Drawing.Point(39, 267);
            this.opcaodois.Name = "opcaodois";
            this.opcaodois.Size = new System.Drawing.Size(15, 14);
            this.opcaodois.TabIndex = 4;
            this.opcaodois.UseVisualStyleBackColor = true;
            // 
            // opcaotres
            // 
            this.opcaotres.AutoSize = true;
            this.opcaotres.Location = new System.Drawing.Point(39, 321);
            this.opcaotres.Name = "opcaotres";
            this.opcaotres.Size = new System.Drawing.Size(15, 14);
            this.opcaotres.TabIndex = 5;
            this.opcaotres.UseVisualStyleBackColor = true;
            // 
            // lblopcaoum
            // 
            this.lblopcaoum.AutoSize = true;
            this.lblopcaoum.Location = new System.Drawing.Point(60, 219);
            this.lblopcaoum.Name = "lblopcaoum";
            this.lblopcaoum.Size = new System.Drawing.Size(0, 13);
            this.lblopcaoum.TabIndex = 6;
            // 
            // lblopcaodois
            // 
            this.lblopcaodois.AutoSize = true;
            this.lblopcaodois.Location = new System.Drawing.Point(61, 267);
            this.lblopcaodois.Name = "lblopcaodois";
            this.lblopcaodois.Size = new System.Drawing.Size(0, 13);
            this.lblopcaodois.TabIndex = 7;
            // 
            // lblopcaotres
            // 
            this.lblopcaotres.AutoSize = true;
            this.lblopcaotres.Location = new System.Drawing.Point(61, 321);
            this.lblopcaotres.Name = "lblopcaotres";
            this.lblopcaotres.Size = new System.Drawing.Size(0, 13);
            this.lblopcaotres.TabIndex = 8;
            // 
            // Pericias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblopcaotres);
            this.Controls.Add(this.lblopcaodois);
            this.Controls.Add(this.lblopcaoum);
            this.Controls.Add(this.opcaotres);
            this.Controls.Add(this.opcaodois);
            this.Controls.Add(this.opcaoum);
            this.Controls.Add(this.botaoconfirma);
            this.Controls.Add(this.lbltextopericias);
            this.Name = "Pericias";
            this.Text = "Pericias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltextopericias;
        private System.Windows.Forms.Button botaoconfirma;
        private System.Windows.Forms.CheckBox opcaoum;
        private System.Windows.Forms.CheckBox opcaodois;
        private System.Windows.Forms.CheckBox opcaotres;
        private System.Windows.Forms.Label lblopcaoum;
        private System.Windows.Forms.Label lblopcaodois;
        private System.Windows.Forms.Label lblopcaotres;
    }
}