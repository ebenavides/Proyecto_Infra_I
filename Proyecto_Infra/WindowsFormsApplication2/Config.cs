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
        public static string send = "default";
        public string receive;

        //Direccionamiento
        public string dir_explicit;
        public string dir_implicit;
        public string dir_static;
        public string dynamic;

        //Formato
        public string content;
        public string fmt_length;

        //Cola
        public string length;
        public bool fifo;
        public bool priority;
    }
}
