using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habitaciones
{
    internal class CLHabitaciones
    {


       public double MtdCostoHabitacion( string TipoHabitacion  )
        {

            if (TipoHabitacion == "General") return 300;
            else if (TipoHabitacion == "Maternidad") return 1000;
            else if (TipoHabitacion == "Pediatria") return 500;
            else if (TipoHabitacion == "Aislamiento") return 3000;
            else if (TipoHabitacion == "Observacion") return 100;
            else return 0;
        }





        public DateTime MtdFechaHoy()
        {
            return DateTime.Now;
        }


    }
}
