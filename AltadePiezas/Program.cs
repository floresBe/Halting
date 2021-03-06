﻿using BDMuestras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AltadePiezas
{
    static class Program
    {
        public static int usuario;
        public static int sesion;
        public static int pkC, noC;
        public static string fechaAlta;
        public static string fechaHorneo = null;
        public static List<string> serie = null;
        public static int aprobado = 0;
        public static int defecto = 1;
        public static int rebraze = 0;
        public static int lote = 0;
        public static int pruebaOdefecto = 0;

        public static IniciarSesion ventanaInicio;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ventanaInicio = new IniciarSesion();
            Application.Run(ventanaInicio);
        }
    }
}
