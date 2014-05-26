using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Infra
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigWindow configw = new ConfigWindow();
            configw.ShowDialog();
            Console.WriteLine("Configuracion Inicial:\nSend: "+Config.send+"\nReceive: "+Config.receive+"\n\nDireccionamiento: "+Config.direccionamiento+"\n\nMensaje\nTipo: "+Config.content+"\nLargo: "+Config.fmt_length+"\n\nCola\nFIFO: "+Config.fifo.ToString()+"\nPrioridad: "+Config.priority.ToString()+"\nLargo: "+Config.length.ToString());
            while (true)
            {
                Console.ReadLine();
                }
            }
        }
    }

