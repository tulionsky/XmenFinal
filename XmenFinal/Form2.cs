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
using XmenFinal.Data.Models;

namespace XmenFinal
{
    public partial class Forminterfaz : Form
    {
        usuario usr = new usuario();
        ConexionXmen conect = new ConexionXmen();

        private string[] nivelesMutacion = {
    "Alpha",
    "Beta",
    "Omega"
        };
        private string[] grupos = {
    "X-Men",
    "Hellfire Club",
    "Hermandad de Mutantes",
    "Vengadores"
        };

        public Forminterfaz()
        {
            InitializeComponent();
        }

        private void Forminterfaz_Load(object sender, EventArgs e)
        {
            comboBoxmutacion.Items.AddRange(nivelesMutacion);
            comboBoxequipo.Items.AddRange(grupos);
        }

        private void buttonLeer_Click(object sender, EventArgs e)
        {
            VistadeDatos vistadeDatos = new VistadeDatos();
            vistadeDatos.Show();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            usr.Nombre = textBoxnombre.Text;
            usr.Edad = Convert.ToInt32(textBoxedad.Text);
            usr.Mutante= checkBoxmutante.Checked;
            usr.Poder = textBoxpoder.Text;
            usr.Nivel_Mutacion = comboBoxmutacion.Text;
            conect.Insertar(usr);
            MessageBox.Show("Personaje agregado sin clavos");
        }
    }
}
