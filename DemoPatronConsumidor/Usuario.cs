using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPatronConsumidor
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Usuario(int id, string nombre, string correo)
        {
            Id = id;
            Nombre = nombre;
            CorreoElectronico = correo;
            FechaCreacion = DateTime.Now;
        }
        public override string ToString()
        {
            return $"Id:{Id}, Correo: {CorreoElectronico}, Fecha: {FechaCreacion}";
        }
    }
}