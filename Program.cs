using FinancialManagementSystem;

namespace FinancialManagementSystem
{
    internal static class Program
    {
        public static Database database = Database.GetInstance("3.86.116.245", "3306", "vitaly", "vitalysukhinin", "bank_app");
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginPage());
        }
    }
}