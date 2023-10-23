using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AASOTE
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public static class data
    {
        public static bool helpMessage = false;
        public static string Cod { get; set; }

        public static Form1 f1 = new Form1();
        public static AddForm AF = new AddForm();
        public static ChangeForm CF = new ChangeForm();

        public static string name { get; set; }
        public static string surname { get; set; }

        public static string imgName { get; set; }
    }
}
