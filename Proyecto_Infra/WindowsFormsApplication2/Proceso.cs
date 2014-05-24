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
        String tipoProceso;

        public Proceso(int id, String nombre, String estado, String tipo)
        {
            idProceso = id;
            nombreProceso = nombre;
            estadoProceso = estado;
            tipoProceso = tipo;

        }
        public void sendExplicito(int idDestino, String mensj)
        {
            cola.add(mensj);
        }
        public void sendImplicito(int idBuzon, String mensj)
        {


        }

        public void sendEstatico(int idGrupo, String mensj)
        {


        }


        public void receiveExplicito(int idEmisor)
        {

        }
        public void receiveImplicito(int idBuzon)
        {

        }
        public void receiveEstatico(int idEmisor)
        {

        }
        





 

    }
}
