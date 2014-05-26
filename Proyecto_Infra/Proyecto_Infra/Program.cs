using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace Proyecto_Infra
{

    public static class Program
    {

        //public static List<Proceso> ListaProcesos = new List<Proceso>();
        public static List<Proceso> ListaEmisores = new List<Proceso>();
        public static List<Proceso> ListaReceptores = new List<Proceso>();
        public static List<string> _log = new List<string>();
        public static ArrayList cola = new ArrayList();
        public static string line = "";
        public static String[] command_args;
        

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigWindow configw = new ConfigWindow();
            configw.ShowDialog();
            Console.WriteLine("Configuracion Inicial:\nSend: " + Config.send + "\nReceive: " + Config.receive + "\n\nDireccionamiento: " + Config.direccionamiento + "\n\nMensaje\nTipo: " + Config.content + "\nLargo: " + Config.fmt_length + "\n\nCola\nFIFO: " + Config.fifo.ToString() + "\nPrioridad: " + Config.priority.ToString() + "\nLargo: " + Config.length.ToString());
            MostrarProcesos();
                while (true)
                {
                    line = Console.ReadLine();
                    Reader(line);
                }
            }//Main

        public static void Reader(string command){

            //verifica si es comando send
            if(command.Contains("send")){
                if(Config.direccionamiento=="Explicito"){

                string copy = command;
                command = command.Replace("send(", "");
                command = command.Replace(")", "");
                command_args = command.Split(',');
                
                foreach(string arg in command_args){
                    Console.WriteLine(arg);
                }

                int idemisor = int.Parse(command_args[0]);
                int idreceptor = int.Parse(command_args[1]);
                string mensaje = command_args[2];
                Proceso emisor = ListaEmisores.Find(x => x.idProceso == idemisor);
                emisor._log.Add(copy);
                emisor.Mostrar();
                    }//Send Directo


            }//SEND


        }//Reader

        public static void MostrarProcesos()
        {
            Console.WriteLine("\n\nProcesos Emisores Creados: \n");
            foreach (Proceso emisor in ListaEmisores){Console.WriteLine("Proceso: " + emisor.nombreProceso + "| IDProceso: " + emisor.idProceso + " | Tipo: " + emisor.tipoProceso);}

            Console.WriteLine("\n\nProcesos Receptores Creados: \n");
            foreach (Proceso receptor in ListaReceptores){Console.WriteLine("Proceso: " + receptor.nombreProceso + "| IDProceso: " + receptor.idProceso + " | Tipo: " + receptor.tipoProceso);}
        }//Mostrar Proceso


    }
}//:~


