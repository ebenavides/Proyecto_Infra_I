﻿using System;
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
        public String estadoProceso = "";
        public String tipoProceso;

        public Proceso(int id, String nombre, String tipo)
        {
            idProceso = id;
            nombreProceso = nombre;
            tipoProceso = tipo;

        }
        public void sendExplicitoBlock(int idDestino, String mensj)
        {
            Program.cola.Add(mensj);
        }
        public void sendExplicitoNoBlock(int idDestino, String mensj)
        {
            Program.cola.Add(mensj);
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

