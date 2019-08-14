using COMP123_S2019_FinalTestB.Objects;
using COMP123_S2019_FinalTestB.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Student Name: Sean Kwak
 * Student ID: 300614352
 * Description : This is the driver class for the application
 */
namespace COMP123_S2019_FinalTestB
{
    
    static class Program
    {
        public static Character characters;
        public static Item items;
        public static CharacterGeneratorForm characterForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            items = new Item();
            characters= new Character();
            characterForm = new CharacterGeneratorForm();
            Application.Run(characterForm);
        }
        
    }
}
