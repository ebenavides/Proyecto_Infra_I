using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto_Infra
{

    public static class Program
    {

        public static List<Proceso> ListaProcesos = new List<Proceso>();

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
                    Console.ReadLine();
                }
            }
        }
    }


