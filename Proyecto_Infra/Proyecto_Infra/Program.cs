﻿using System;
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
            while (true)
            {
                Console.WriteLine(Config.send);
                Console.ReadLine();
                }
            }
        }
    }

