using SysEstoque.Models;
using SysEstoque.Telas;
using SysEstoque.Utils;
using System;
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

            Globais.init();

			Globais.DBString = "Server=127.0.0.1;port=3306;database=estoque_aula;uid=root;password=#Root2022";

			//Application.Run(new FormCategoria());
            //Application.Run(new FormNewProduto());
            //Application.Run(new FormEndereco());
            //Application.Run(new FormCRUDFornecedor());
            //Application.Run(new FormCRUDNotaEntrada());
            Application.Run(new FormMain());
            //Application.Run(new FormCRUDNotaEntrada());
            //Application.Run(new FormLogin());
        }
    }
}