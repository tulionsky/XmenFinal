﻿namespace XmenFinal
{
    partial class Formprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formprincipal));
            this.buttonEmpezar = new System.Windows.Forms.Button();
            this.buttonConexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEmpezar
            // 
            this.buttonEmpezar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonEmpezar.Font = new System.Drawing.Font("Rockwell Extra Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpezar.Location = new System.Drawing.Point(214, 238);
            this.buttonEmpezar.Name = "buttonEmpezar";
            this.buttonEmpezar.Size = new System.Drawing.Size(241, 92);
            this.buttonEmpezar.TabIndex = 0;
            this.buttonEmpezar.Text = "¿Empezamos?";
            this.buttonEmpezar.UseVisualStyleBackColor = false;
            this.buttonEmpezar.Click += new System.EventHandler(this.buttonEmpezar_Click);
            // 
            // buttonConexion
            // 
            this.buttonConexion.Location = new System.Drawing.Point(55, 47);
            this.buttonConexion.Name = "buttonConexion";
            this.buttonConexion.Size = new System.Drawing.Size(144, 78);
            this.buttonConexion.TabIndex = 1;
            this.buttonConexion.Text = "REALIZAR CONEXION CON BD";
            this.buttonConexion.UseVisualStyleBackColor = true;
            this.buttonConexion.Click += new System.EventHandler(this.buttonConexion_Click);
            // 
            // Formprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(829, 464);
            this.Controls.Add(this.buttonConexion);
            this.Controls.Add(this.buttonEmpezar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Formprincipal";
            this.Text = "PAGINA PRINCIPAL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEmpezar;
        private System.Windows.Forms.Button buttonConexion;
    }
}

