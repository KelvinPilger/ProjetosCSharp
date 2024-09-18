using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportadorFDB5.Classes
{
    internal class Logs
    {
        
        public static void AlimentarLog(string diretorio, string exception) {
            string diretorioSemBd = Path.GetFileName(diretorio);
            string logDiretorio = Path.Combine(diretorio.Replace(diretorioSemBd, ""), "lImportadorAK.txt");

            if (!File.Exists(logDiretorio))
            {
                using (StreamWriter sw = File.CreateText(logDiretorio))
                {
                    sw.WriteLine("Log iniciado em: " + DateTime.Now + $" -- {logDiretorio}");
                    sw.WriteLine("---------------------------------------------------------");
                }
            }

            using (StreamWriter escrita = new StreamWriter(logDiretorio, true))
            {
                escrita.WriteLine($"{DateTime.Now}: {exception}");
            }
        }
    }
}
