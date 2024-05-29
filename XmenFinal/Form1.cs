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
    public partial class Formprincipal : Form
    {
        private ConexionXmen Conexion;
        public Formprincipal()
        {
            InitializeComponent();
        }

        private void buttonEmpezar_Click(object sender, EventArgs e)
        {
            Forminterfaz forma2 = new Forminterfaz();
            forma2.Show();
            this.Hide();
            
        }

        private void buttonConexion_Click(object sender, EventArgs e)
        {
            Conexion = new ConexionXmen();
            if (Conexion.ProbarConexion())
            {
                MessageBox.Show("CONEXION EXITOSA");
            }
            else
            {
                MessageBox.Show("CONEXION FALLIDA");
            }
        }
    }
}
