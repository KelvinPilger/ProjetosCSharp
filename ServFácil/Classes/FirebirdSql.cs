using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.Windows.Forms;
namespace LavaK.Classes
{
    internal class FirebirdSql
    {
        public string dirConexao = "";
        public static void AbreConexao(string diretorio)
        {
            using (FbConnection conexao = new FbConnection(diretorio)) {
                try
                {
                    conexao.Open();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
