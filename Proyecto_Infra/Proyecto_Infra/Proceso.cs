using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Infra
{
    public class Proceso
    {
        public int idProceso;
        public String nombreProceso;
        public String estadoProceso;
        public String tipoProceso;

        public Proceso(int id, String nombre, String tipo, String estado = null)
        {
            idProceso = id;
            nombreProceso = nombre;
            estadoProceso = estado;
            tipoProceso = tipo;

        }
        public void sendExplicito(int idDestino, String mensj)
        {
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

