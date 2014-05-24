using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class Config
    {
        //Sincronizacion
        public static string send;
        public static string receive;

        //Direccionamiento
        public static string dir_explicit;
        public static string dir_implicit;
        public static string dir_static;
        public static string dynamic;

        //Formato
        public static string content;
        public static string fmt_length;

        //Cola
        public static string length;
        public static bool fifo;
        public static bool priority;
    }
}
