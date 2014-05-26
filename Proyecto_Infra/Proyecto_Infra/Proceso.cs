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
        public String estadoProceso = ""; //block o no block
        public String tipoProceso; //send o receive

        public Proceso(int id, String nombre, String tipo)
        {
            idProceso = id;
            nombreProceso = nombre;
            tipoProceso = tipo;

        }

        public void mandarACola(String mensj)
        {
            //si la cola no esta llena 
            Program.cola.Add(mensj);
            // y retorna recibido
            //si no, retorna no recibido

        }

        public void sendExplicitoBlock(int idDestino, String mensj)
        {
            //se llama a mandaracola, si se obtiene recibido se cambia el estado del proceso a no block
            // si es no recibido se queda blockeado hasta que alla campo en la cola

        }
        public void sendExplicitoNoBlock(int idDestino, String mensj)
        {
            Program.cola.Add(mensj);
            // basta con agregar la cola, ya que al send no le importa si fue recibido o no

        }

        public void sendImplicitoBlock(int idBuzon, String mensj)
        {
            Program.cola.Add(mensj);
        }

        public void sendImplicitoNoBlock(int idBuzon, String mensj)
        {
            Program.cola.Add(mensj);
        }
        public void sendEstatico(int idGrupo, String mensj)
        {
            Program.cola.Add(mensj);
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

