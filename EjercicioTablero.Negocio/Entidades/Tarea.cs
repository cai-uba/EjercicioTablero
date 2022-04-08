using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTablero.Negocio.Entidades
{
    public abstract class Tarea
    {
        protected int _codigo;
        protected string _descripcion;
        protected string _estado;
        protected DateTime _fechaAlta;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }

        protected Tarea(int codigo, string descripcion, string estado)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Estado = estado;
            FechaAlta = DateTime.Now;
        }

        protected bool IsFinalizada()
        {
            return (Estado == "Finalizada");
        }
    }
}
