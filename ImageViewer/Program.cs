using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ImageViewer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ImageLibrary.Model model = new ImageLibrary.Model();
            ImageLibrary.View view = new ImageLibrary.View(model);
            Application.Run(view);
        }
    }
}
