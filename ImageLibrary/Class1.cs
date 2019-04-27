using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageLibrary
{
    public class Class1
    {
        public static void main()
        {
            Model model = new Model();
            View view = new View(model);
            Application.Run(view);
        }
    }
}
