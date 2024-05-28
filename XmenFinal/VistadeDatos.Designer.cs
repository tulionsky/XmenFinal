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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonRegresarInterfaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(911, 418);
            this.dataGridView1.TabIndex = 0;
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
            this.Controls.Add(this.dataGridView1);
            this.Name = "VistadeDatos";
            this.Text = "VistadeDatos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRegresarInterfaz;
    }
}