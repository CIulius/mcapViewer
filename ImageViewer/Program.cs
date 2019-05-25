/**************************************************************************
 *                                                                        *
 *  File:        Program.cs                                               *
 *  E-mail:      brinzapaul@gmail.com                                     *
 *  Description: Entry point for the application                          *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

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
