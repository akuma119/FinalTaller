using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class RangoHorarioContinuo : RangoTiempo
    {
        DateTime fechaIni;
        DateTime fechaFin;
        TimeSpan horaIni;
        TimeSpan horaFin;

        public bool estaEn(DateTime fechaYHora)
        {
            DateTime fecha = fechaYHora.Date;
            TimeSpan hora = fechaYHora.TimeOfDay;

            if (this.fechaIni <= fecha  && fecha <= this.fechaFin && 
                this.horaIni  <= hora   && hora  <= this.horaFin )
            { return true; } else { return false; }
        }
    }
}
