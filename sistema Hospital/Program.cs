using CapaPresentacion.Presentacion;
using Habitaciones;
using login;
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


            Application.Run(new FrmPacientes());

        }
    }
}
