using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace DataBaseStudents
{
    static class Program
    {
        public static KeyProfiles kfeData;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            kfeData = new KeyProfiles();
            Main main = new Main();
            DataBase dataBase = main.DataBase = new DataBase(main.data);
            KeyUsage ks = new KeyUsage();
            Application.Run(ks);
            
            if (ks.IsKeyed)
            {
                Application.Run(main);
            }
            if (DataBase.dataBase != null)
                DataBase.dataBase.Save();
        }
    }
}
