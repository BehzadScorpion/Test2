using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test2.Views;

namespace Comp123_SectionC_Test2
{
    public static class Program
    {
        //Temporary
        public static MasterForm masterform;
        public static CharacterGenerationForm characterform;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            masterform = new MasterForm();
            characterform = new CharacterGenerationForm();
            Application.Run(characterform);
        }
    }
}
