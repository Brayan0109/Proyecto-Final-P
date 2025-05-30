using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_Hospital.Logica
{
    public  class CLEmpleados
    {
        public DateTime MtdFechaHoy()
        {
            return DateTime.Now;
        }


        public double MtdSalario(string Tipo)
        {
            if (Tipo == "Director") return 30000;
            else if (Tipo == "Medico") return 20000;
            else if (Tipo == "Enfermero") return 10000;
            else if (Tipo == "Tecnico") return 7000;
            else if (Tipo == "Farmaceutico") return 6000;
            else return 0;
        }
    }
}
