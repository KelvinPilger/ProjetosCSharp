using ImportadorFDB5.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportadorFDB5
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
          
            ControladorMod.TrocarMod();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             // Application.Run(new frmImportador());
            frmImportador frmImportador = new frmImportador();
            ConfigureKeyBindings(frmImportador);
            Application.Run(frmImportador);

        }
        static void ConfigureKeyBindings(frmImportador frmImportador)
        {
            frmImportador.KeyPreview = true;

            frmImportador.KeyDown += (sender, e) =>
            {
                switch (e.KeyCode)
                {
                    case Keys.F1:
                        frmImportador.btnOrigem.PerformClick();
                        break;
                    case Keys.F2:
                        frmImportador.btnDestino.PerformClick();
                        break;
                    case Keys.F3:
                        frmImportador.btnImportar.PerformClick();
                        break;
                    case Keys.F4:
                        frmImportador.btnTrocarMod.PerformClick();
                        break;
                    case Keys.Escape:
                        frmImportador.Close();
                        break;
                }
            };
        }
    }
}
