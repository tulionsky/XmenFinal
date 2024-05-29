namespace XmenFinal
{
    partial class VistadeDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistadeDatos));
            this.dataGridViewXmen = new System.Windows.Forms.DataGridView();
            this.buttonRegresarInterfaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXmen)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewXmen
            // 
            this.dataGridViewXmen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXmen.Location = new System.Drawing.Point(12, 47);
            this.dataGridViewXmen.Name = "dataGridViewXmen";
            this.dataGridViewXmen.RowHeadersWidth = 51;
            this.dataGridViewXmen.RowTemplate.Height = 24;
            this.dataGridViewXmen.Size = new System.Drawing.Size(911, 418);
            this.dataGridViewXmen.TabIndex = 0;
            // 
            // buttonRegresarInterfaz
            // 
            this.buttonRegresarInterfaz.Location = new System.Drawing.Point(34, 484);
            this.buttonRegresarInterfaz.Name = "buttonRegresarInterfaz";
            this.buttonRegresarInterfaz.Size = new System.Drawing.Size(211, 63);
            this.buttonRegresarInterfaz.TabIndex = 1;
            this.buttonRegresarInterfaz.Text = "REGRESAR";
            this.buttonRegresarInterfaz.UseVisualStyleBackColor = true;
            this.buttonRegresarInterfaz.Click += new System.EventHandler(this.buttonRegresarInterfaz_Click);
            // 
            // VistadeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 559);
            this.Controls.Add(this.buttonRegresarInterfaz);
            this.Controls.Add(this.dataGridViewXmen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VistadeDatos";
            this.Text = "VistadeDatos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXmen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewXmen;
        private System.Windows.Forms.Button buttonRegresarInterfaz;
    }
}