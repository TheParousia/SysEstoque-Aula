using SysEstoque.Models;
using SysVendas;

namespace SysEstoque
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(){
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormCategoria());
            //Application.Run(new FormAddProduto());
            //Application.Run(new FormCRUDNotaEntrada());
            //Application.Run(new FormCategoria());
            //Application.Run(new FormMain());
            //Application.Run(new FormLogin());
        }
    }
}