using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Campaña : Evento
    {
        /*private string nombre;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private DateTime horaInicio;
        private DateTime horaFin;*/
        private int duracion; // segundos por imagen
        private System.Collections.Generic.List<Imagen> listaImagenes;
    }
}