﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсач.Models;
using Курсач.Views;
using Курсач.Presenters;
using Курсач._Repository;
using System.Configuration;

namespace Курсач
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string sqliteConnectionString = ConfigurationManager.ConnectionStrings["SqliteConnectionString"].ConnectionString;
            IMainView view = new MainView();
           
            new MainPresenter(view, sqliteConnectionString);


            Application.Run((Form)view);
        }
    }
}
