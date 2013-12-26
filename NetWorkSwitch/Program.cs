using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace NetWorkSwitch
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

        
#if BATCHMODEFREE
                Application.Run(new Form1("Free"));
            return;
#endif

#if BATCHMODENUMERICABLE
            Application.Run(new Form1("Bouygues Telecom"));
                
                return;
#endif


            Application.Run(new Form1());
            
            
        }
    }
}
