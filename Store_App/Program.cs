﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_App
{
    static class Program
    {
        public static IntroForm introForm { get; set; }
        public static StartForm startForm { get; set; }
        public static SelectForm selectForm { get; set; }
        public static ProductInfoForm producInfoForm { get; set; }
        public static OrderForm orderForm { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            introForm = new IntroForm();
            startForm = new StartForm();
            selectForm = new SelectForm();
            producInfoForm = new ProductInfoForm();
            orderForm = new OrderForm();

            Application.Run(introForm);
           
        }
    }
}
