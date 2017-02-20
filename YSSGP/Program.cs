﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YSSGP.Sınıflar;
namespace YSSGP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length==1)
            {
                Application.Run(new Form1(args[0]));
            }
            else
                Application.Run(new Form1());
             
            
            
        }
    }
}
