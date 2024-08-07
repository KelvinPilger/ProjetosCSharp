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
        public static string dire;

        public static void ConexaoOrigem(TextBox origem, Button btnStatus)
        {
            string stringConexao = $@"User=SYSDBA;Password=masterkey;Database={dire};DataSource=localhost;Port=3051;Dialect=3;Charset=NONE;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;\r\nServerType=0;";
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
                catch (Exception ex)
                {
                    btnStatus.BackColor = System.Drawing.Color.Red;
                    origem.Text = "Selecione o banco de origem.";
                    MessageBox.Show("-> O Serviço do Firebird Está Ativo?\n-> O banco de dados selecionado é pertencente a V2.5 do\n     Firebird?", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public static void ConexaoDestino(TextBox destino, Button btnStatus)
        {
            string stringConexao = $@"User=SYSDBA;Password=masterkey;Database={dire};DataSource=localhost;Port=3052;Dialect=3;Charset=NONE;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;\r\nServerType=0;";
            using (FbConnection conexaoDest = new FbConnection(stringConexao))
            {
                try
                {
                    conexaoDest.Open();
                    if (conexaoDest.State == ConnectionState.Open)
                    {
                        btnStatus.BackColor = System.Drawing.Color.Green;
                    }
                }
                catch (Exception ex)
                {
                    btnStatus.BackColor= System.Drawing.Color.Red;
                    destino.Text = "Selecione o banco de origem.";
                    MessageBox.Show("-> O Serviço do Firebird Está Ativo?\n-> O banco de dados selecionado é pertencente a V5.0 do\n     Firebird?", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public List<string> PreencherTabelas(TextBox dir)
        {
            string diretorio = dir.Text;
            string stringConexao = $@"User=SYSDBA;Password=masterkey;Database={diretorio};DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;\r\nServerType=0;";

            using (FbConnection conexaoDest = new FbConnection(stringConexao))
            {
                List<string> nomeTabelas = new List<string>();
                string select = "SELECT RDB$RELATION_NAME FROM RDB$RELATIONS WHERE RDB$SYSTEM_FLAG = '0'";

                FbCommand comando = new FbCommand(select, conexaoDest);
                conexaoDest.Open();
                FbDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    nomeTabelas.Add(reader["RDB$RELATION_NAME"].ToString().Trim());
                }

                conexaoDest.Close();
                return nomeTabelas;
            }
        }
    }
}
