using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XmenFinal.Data.DataAcces;

namespace XmenFinal
{
    public partial class VistadeDatos : Form
    {
        private ConexionXmen conexion;

        public VistadeDatos()
        {
            conexion = new ConexionXmen();

            InitializeComponent();
            dataGridViewXmen.DataSource = conexion.LeerPersonajes();
        }

        private void buttonRegresarInterfaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
