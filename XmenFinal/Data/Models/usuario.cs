using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmenFinal.Data.Models
{
    internal class usuario
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public bool Mutante {  get; set; }
        public string Poder {  get; set; }
        public string Nivel_Mutacion { get; set; }
        public string Grupo { get; set; }

        public usuario(int id, string nombre, int edad, bool mutante, string poder, string nivelMutacion, string grupo)
        {
            ID = id;
            Nombre = nombre;
            Edad = edad;
            Mutante = mutante;
            Poder = poder;
            Nivel_Mutacion = nivelMutacion;
            Grupo = grupo;
        }

        public usuario() { }

    }
}
