﻿using System;
using System.Windows.Forms;

namespace Sinema_Uygulaması
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new üye_paneli());
        }
    }
}
