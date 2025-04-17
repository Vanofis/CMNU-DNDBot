using System;
using System.Windows.Forms;

namespace DND_Bot_XML_Baker
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StateEditorForm());
        }
    }
}