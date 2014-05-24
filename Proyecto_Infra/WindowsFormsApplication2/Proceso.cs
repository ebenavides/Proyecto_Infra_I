using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class Proceso
    {

        int idProceso;
        String nombreProceso;
        String estadoProceso;

        public Proceso(int id, String nombre, String estado)
        {
            idProceso = id;
            nombreProceso = nombre;
            estadoProceso = estado;

        }
        public void send(int idEmisor, int idDestino, String mensj)
        {

        }
        public void receive(int idEmisor)
        {

        }
        





 

    }
}
