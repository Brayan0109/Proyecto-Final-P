using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Proyecto
{
    internal class CLmedicamentos
    {
        public double Mtdmedicamento(string Tpomedicamento)
        {
            if (Tpomedicamento == "Jarabe") { return 150; }
            else if (Tpomedicamento == "Suero") { return 25; }
            else if (Tpomedicamento == "Crema") { return 75; }
            else if (Tpomedicamento == "Tableta") { return 25; }
            else if (Tpomedicamento == "Inyeccion") { return 125; }
            return 0;
        }
        public DateTime MtdFechaHoy()
        {
            return DateTime.Now;
        }
    }
}
