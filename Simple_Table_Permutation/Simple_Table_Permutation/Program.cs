using System;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace Simple_Table_Permutation
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!File.Exists("MyDB.db"))
            {
                Database DB = new Database("Data Source=MyDB.db; Version=3");
                DB.InitializeDatabase();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Authorization());
        }
    }
}
