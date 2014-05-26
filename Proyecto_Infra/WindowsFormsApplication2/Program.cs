using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Collections;

namespace WindowsFormsApplication2
{
      class Program
    {
        static ArrayList cola = new ArrayList();
        static List<object> procesosTotal;
        
        public static List<Object> Procesos = new List<Object>();
        static Config var = new Config();    


        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            new System.Threading.Thread(() => { System.Windows.Forms.Application.Run(new ConfigWindow());}).Start();
            
            
            Console.WriteLine(Config.send);
            
            while (true)
            {
                string command = Console.ReadLine();
                    
                    new System.Threading.Thread(() => {System.Windows.Forms.Application.Run(new ProcesoWindow());}).Start();
               }
            
            }
        }
    }

