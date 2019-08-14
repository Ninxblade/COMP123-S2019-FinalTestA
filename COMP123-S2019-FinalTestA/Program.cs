using COMP123_S2019_FinalTestA.Objects;
using COMP123_S2019_FinalTestA.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * 
 * STUDNET NAME: Jason Li
 * STUDENT ID: 301012468
 * DESCRIPTION : This is the Main program
 */
namespace COMP123_S2019_FinalTestA
{
    static class Program
    {
        //this temp
        //public static MasterForm masterForm;
        public static HeroGenerator heroGenerator;
        
        public static Power power;
        public static Hero character;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            heroGenerator = new HeroGenerator();
            character = new Hero();
            power = new Power();
            
            Application.Run(heroGenerator);
        }
    }
}
