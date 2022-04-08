using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTablero.Negocio.Entidades
{
    public class TareaEspecial : Tarea
    {
        private double _porcentajeFinalizacion;
        private int _dificultad;
        private int _prioridad;

        public double PorcentajeFinalizacion { get => _porcentajeFinalizacion; }
        public int Dificultad { get => _dificultad;  }
        public int Prioridad { get => _prioridad;}

        public TareaEspecial(int codigo, string descripcion, string estado, double porcentajeFinalizacion, int dificultad, int prioridad) : base(codigo, descripcion, estado)
        {
            _porcentajeFinalizacion = porcentajeFinalizacion;
            _dificultad = dificultad;
            _prioridad = prioridad;
        }
    }
}
