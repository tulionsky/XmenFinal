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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace XmenFinal
{
    public partial class Forminterfaz : Form
    {
        usuario usr = new usuario();
        ConexionXmen conect = new ConexionXmen();
        List<usuario> todos = new List<usuario>();
        cursor cursor1 = new cursor();

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
            usr.Grupo = comboBoxequipo.Text;
            conect.Insertar(usr);
            MessageBox.Show("Personaje agregado sin clavos");
        }

        private void buttonObtenerTodos_Click(object sender, EventArgs e)
        {
           todos = conect.ObtenerTodosLosUsuarios();
            if (todos.Count > 0)
            {
                cursor1.Total = todos.Count;
                MessageBox.Show("Total de registros: " + cursor1.Total);
            }
            else
            {
                MessageBox.Show("No hay registros");
            }
        }

        private void MostrarMasRegistros()
        {
            if (cursor1.current >= 0 && cursor1.current < cursor1.Total)
            {
                usuario u = todos[cursor1.current];
                textBoxid.Text = u.ID.ToString();
                textBoxnombre.Text = u.Nombre;
                textBoxedad.Text = u.Edad.ToString();
                checkBoxmutante.Checked = u.Mutante;
                textBoxpoder.Text = u.Poder;
                comboBoxmutacion.Text = u.Nivel_Mutacion;
                comboBoxequipo.Text = u.Grupo;

                // incrementar el cursor y validar que no se pase del total de registros
                cursor1.current++;
                if (cursor1.current >= cursor1.Total)
                {
                    cursor1.current = 0;
                    MessageBox.Show("Fin de los registros");
                }
            }
        }


        private void MostrarMenosRegistros()
        {
            if (cursor1.current >= 0 && cursor1.current < cursor1.Total)
            {
                usuario u = todos[cursor1.current];
                textBoxid.Text = u.ID.ToString();
                textBoxnombre.Text = u.Nombre;
                textBoxedad.Text = u.Edad.ToString();
                checkBoxmutante.Checked = u.Mutante;
                textBoxpoder.Text = u.Poder;
                comboBoxmutacion.Text = u.Nivel_Mutacion;
                comboBoxequipo.Text = u.Grupo;

                // decrementar el cursor y validar que no se pase del inicio de los registros
                cursor1.current--;
                if (cursor1.current <= 0)
                {
                    cursor1.current = cursor1.Total - 1;
                    MessageBox.Show("Inicio de los registros");
                }
            }
        }

        private void buttonsiguiente_Click(object sender, EventArgs e)
        {
            MostrarMasRegistros();
        }

        private void buttonanterior_Click(object sender, EventArgs e)
        {
            MostrarMenosRegistros();
        }
    }
}
