using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Infra
{
    class Config
    {
        //Sincronizacion
        public static string send;
        public static string receive;

        //Direccionamiento
        public static string direccionamiento;

        //Formato
        public static string content;
        public static string fmt_length;

        //Cola
        public static int length;
        public static bool fifo;
        public static bool priority;
    }
}
