namespace Restuaracja
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
            //se sciezke tu zmen:
            GlobalConfig.ApiBaseUrl = "https://localhost:5001/api";
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}