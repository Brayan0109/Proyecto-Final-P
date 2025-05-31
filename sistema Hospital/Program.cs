using CapaPresentacion.Presentacion;
using Habitaciones;
using Pacientesamy;
using sistema_Hospital.Pesentacion;
using Sistema_Proyecto;
using SistemaHospital.Presentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_Hospital
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new FrmTratamientos());
=======
            Application.Run(new FrmCitas());
>>>>>>> eab918f868b15a23c56c8dc4596d22425223d3a8
        }
    }
}
