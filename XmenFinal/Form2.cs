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
            DialogResult confirmacion = MessageBox.Show("¿Deseas continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (confirmacion == DialogResult.Yes)
            {
                // Acción para "Sí"
                usr.Nombre = textBoxnombre.Text;
                usr.Edad = Convert.ToInt32(textBoxedad.Text);
                usr.Mutante = checkBoxmutante.Checked;
                usr.Poder = textBoxpoder.Text;
                usr.Nivel_Mutacion = comboBoxmutacion.Text;
                usr.Grupo = comboBoxequipo.Text;
                conect.Insertar(usr);
                MessageBox.Show("Personaje agregado sin clavos");
            }
            else if (confirmacion == DialogResult.No)
            {
                // Acción para "No"
                MessageBox.Show("Has seleccionado 'No'");
            }
        }

        private void buttonObtenerTodos_Click(object sender, EventArgs e)
        {
           todos = conect.ObtenerTodosLosUsuarios();
            if (todos.Count > 0)
            {
                cursor1.Total = todos.Count;
                MessageBox.Show("Total de registros: " + cursor1.Total);
                MostrarEncontrado(todos[cursor1.current]);
            }
            else
            {
                MessageBox.Show("No hay registros");
            }
        }



        private void buttonsiguiente_Click(object sender, EventArgs e)
        {
            if (cursor1.current < cursor1.Total - 1)
            {
                cursor1.current++;
            }
            else
            {
                cursor1.current = 0;
                MessageBox.Show("Fin de los registros, volviendo al inicio.");
            }

            MostrarEncontrado(todos[cursor1.current]);
        }

        private void buttonanterior_Click(object sender, EventArgs e)
        {
            if (cursor1.current > 0)
            {
                cursor1.current--;
            }
            else
            {
                cursor1.current = cursor1.Total - 1;
                MessageBox.Show("Inicio de los registros, volviendo al final.");
            }

            MostrarEncontrado(todos[cursor1.current]);
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            usr.ID = Convert.ToInt32(textBoxid.Text);
            usr.Nombre = textBoxnombre.Text;
            usr.Edad = Convert.ToInt32(textBoxedad.Text);
            usr.Mutante = checkBoxmutante.Checked;
            usr.Poder = textBoxpoder.Text;
            usr.Nivel_Mutacion = comboBoxmutacion.Text;
            usr.Grupo = comboBoxequipo.Text;
            conect.Actualizar(usr);
            MessageBox.Show("Todo bien al actualizar👍");
        }

        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxid.Text))
            {
                MessageBox.Show("Por favor, ingrese un ID para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idABuscar;
            if (!int.TryParse(textBoxid.Text, out idABuscar))
            {
                MessageBox.Show("El ID ingresado no es válido. Por favor, ingrese un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            usuario Buscarmutante = conect.BuscarPorId(idABuscar);

            if (Buscarmutante != null)
            {
                MostrarEncontrado(Buscarmutante);
            }
            else
            {
                MessageBox.Show("No se encontró ningún libro con el ID especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void MostrarEncontrado(usuario usr)
        {
            textBoxid.Text = usr.ID.ToString();
            textBoxnombre.Text = usr.Nombre;
            textBoxedad.Text = usr.Edad.ToString();
            checkBoxmutante.Checked = usr.Mutante;
            textBoxpoder.Text = usr.Poder;
            comboBoxmutacion.SelectedItem = usr.Nivel_Mutacion;
            comboBoxequipo.SelectedItem = usr.Grupo;

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Deseas continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (confirmacion == DialogResult.Yes)
            {
                int id = int.Parse(textBoxid.Text);
                try
                {
                    conect.Eliminar(id);
                    MessageBox.Show("Acabas de eliminar a un personaje.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el libro: " + ex.Message);
                }
            }
            else if (confirmacion == DialogResult.No)
            {
                // Acción para "No"
                MessageBox.Show("Has seleccionado 'No'");
            }
        }
    }
}
