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

        public static List<Proceso> ListaProcesos = new List<Proceso>();
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
            Console.WriteLine("\n\nProcesos Creados: \n");
            foreach (Proceso proceso in ListaProcesos)
            {
                Console.WriteLine("Proceso: " + proceso.nombreProceso + "| IDProceso: " + proceso.idProceso + " | Tipo: " + proceso.tipoProceso);

            }
                while (true)
                {
                    line = Console.ReadLine();
                    Reader(line);
                }
            }//Main

        public static void Reader(string command){



            //verifica si es comando send
            if(command.Contains("send")){
                command = command.Replace("send(", "");
                command = command.Replace(")", "");
                command_args = command.Split(',');
                foreach(string arg in command_args){
                    Console.WriteLine(arg);
                }
                int idemisor = int.Parse(command_args[0]);
                int idreceptor = int.Parse(command_args[1]);
                string mensaje = command_args[2];



                
            }


        }//Reader


    }
}


