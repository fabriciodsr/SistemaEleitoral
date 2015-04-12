using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEleitoral
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new frmLogin());

            frmLogin login = new frmLogin();

            // Mostra o formulário para o usuário, e obtém o resultado

            DialogResult resultado = login.ShowDialog();

            // Usuário finalizou clicando no botão OK?

            if (resultado == DialogResult.OK)
            {
                Application.Run(new frmPrincipal());
                login.Close();
            }
            else
            {
                login.Close();
            }

        }
    }
}
