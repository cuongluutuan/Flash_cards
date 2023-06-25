using Flash_cards.Forms;
using Flash_cards.Forms.MainForm;
using Services.Utils;

namespace Flash_cards
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            MessageBoxManager.OK = "Agree";
            MessageBoxManager.Cancel = "Cancel";
            Application.Run(new MainForm());
        }
    }
}