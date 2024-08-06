using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.Client;
using FirebirdSql.Data.FirebirdClient;

namespace ImportadorFDB5.Classes
{
    internal class Importacao
    {
        public static void ConexaoOrigem(TextBox dir, Button btnStatus) {
            string diretorio = dir.Text;
            string stringConexao = $@"User=SYSDBA;Password=masterkey;Database={diretorio};DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;\r\nServerType=0;";
            

            using (FbConnection conexao = new FbConnection(stringConexao))
            {
                try
                {
                    conexao.Open();
                    if (conexao.State == ConnectionState.Open)
                    {
                        btnStatus.BackColor = System.Drawing.Color.Green;
                    }
                }
                catch
                {
                    MessageBox.Show("Conexão com o banco de dados falhoum, revise o caminho!");
                }
            }
        }
        public static void Importar() { 
                  
        }
    }
}
