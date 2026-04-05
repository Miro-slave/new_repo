using ProductionUI.models;
using ProductionUI.presrnters;
using ProductionUI.views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionUI
{
    public static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IModel model = new Model();
            Form1 view = new Form1();
            IPresenter presenter = new Presenter(model, view);

            presenter.Start();

            Application.Run(view);
        }
    }
}
