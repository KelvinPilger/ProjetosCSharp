using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using FirebirdSql.Data.Client;
using FirebirdSql.Data.FirebirdClient;
using System.IO;
using static System.Windows.Forms.LinkLabel;

namespace ImportadorFDB5.Classes
{
    internal class Importacao
    {
        public static string diretorioOrigem;
        public static string diretorioDestino;
        

        public static string PortaFdbDois() {
            string diretorioFdb = @"C:\Program Files\Firebird\Firebird_2_5\firebird.conf";
            if (!File.Exists(diretorioFdb)) {
                diretorioFdb = @"C:\Program Files (x86)\Firebird\Firebird_2_5\firebird.conf";
            }

            string[] lines = File.ReadAllLines(diretorioFdb);
            string portaOrigem = lines.FirstOrDefault(line => line.Trim().StartsWith("RemoteServicePort", StringComparison.OrdinalIgnoreCase));
            
            if (portaOrigem is null) {
                portaOrigem = "3050";
            }

            return portaOrigem;
        }

        public static string PortaFdbCinco()
        {
            string diretorioFdb = @"C:\Program Files\Firebird\Firebird_5_0\firebird.conf";
            if (!File.Exists(diretorioFdb))
            {
                diretorioFdb = @"C:\Program Files (x86)\Firebird\Firebird_5_0\firebird.conf";
            }

            string[] lines = File.ReadAllLines(diretorioFdb);
            string portaOrigem = lines.FirstOrDefault(line => line.Trim().StartsWith("RemoteServicePort", StringComparison.OrdinalIgnoreCase));

            if (portaOrigem is null)
            {
                portaOrigem = "3051";
            }

            return portaOrigem;
        }

        public static string portaUm = PortaFdbDois().Replace("RemoteServicePort = ", "");
        public static string portaDois = PortaFdbCinco().Replace("RemoteServicePort = ", "");


        public static void ConexaoOrigem(TextBox origem, Button btnStatus)
        {
            string stringConexao = $@"User=SYSDBA;Password=masterkey;Database={diretorioOrigem};DataSource=localhost;Port={portaUm};
                                    Dialect=3;Charset=NONE;Pooling=true;MinPoolSize=0;MaxPoolSize=50;
                                    Packet Size=8192;ServerType=0;";
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
                    btnStatus.BackColor = System.Drawing.Color.Red;
                    origem.Text = "Selecione o banco de origem.";
                    MessageBox.Show(@"-> O Serviço do Firebird Está Ativo?\n-> O banco de dados selecionado é pertencente a V2.5 do\n     
                                    Firebird?", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public static void ConexaoDestino(TextBox destino, Button btnStatus)
        {
            string stringConexao = $@"User=SYSDBA;Password=masterkey;Database={diretorioDestino};DataSource=localhost;Port={portaDois};
        '                           Dialect=3;Charset=NONE;Pooling=true;MinPoolSize=0;MaxPoolSize=50;
                                    Packet Size=8192;\r\nServerType=0;";
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
                catch
                { 
                    btnStatus.BackColor= System.Drawing.Color.Red;
                    destino.Text = "Selecione o banco de origem.";
                    MessageBox.Show(@"-> O Serviço do Firebird Está Ativo?\n-> O banco de dados selecionado é pertencente a V5.0 do\n     
                                    Firebird?", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public static List<string> PreencherNomeTabelas() {
            string stringConexao = $@"User=SYSDBA;Password=masterkey;Database={diretorioOrigem};DataSource=localhost;Port={portaUm};
                                    Dialect=3;Charset=NONE;Pooling=true;MinPoolSize=0;MaxPoolSize=50;
                                    Packet Size=8192;ServerType=0;";
            FbConnection conexao = new FbConnection(stringConexao);
            List<string> nomeTabela = new List<string>();

            conexao.Open();
            string select = "SELECT RDB$RELATION_NAME FROM RDB$RELATIONS WHERE RDB$SYSTEM_FLAG = '0'";
            using (FbCommand comando = new FbCommand(select, conexao)) { 
                using(FbDataReader leitor = comando.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        nomeTabela.Add(leitor.GetString(0).Trim());
                    }
                }
                return nomeTabela;
            }
        }

        public static void ExportarDados(List<string> tabelas, ProgressBar progresso) {
            string stringConexaoDestino = $@"User=SYSDBA;Password=masterkey;Database={diretorioDestino};DataSource=localhost;Port={portaDois};
                                    Dialect=3;Charset=NONE;Pooling=true;MinPoolSize=0;MaxPoolSize=50;
                                    Packet Size=8192;ServerType=0;";
            string stringConexaoOrigem = $@"User=SYSDBA;Password=masterkey;Database={diretorioOrigem};DataSource=localhost;Port={portaUm};
                                    Dialect=3;Charset=NONE;Pooling=true;MinPoolSize=0;MaxPoolSize=50;
                                    Packet Size=8192;ServerType=0;";

            FbConnection conexaoDestino = new FbConnection(stringConexaoDestino);
            FbConnection conexaoOrigem = new FbConnection(stringConexaoOrigem);

            List<string> tabelasExportar = PreencherNomeTabelas();
            bool validar = false;
            conexaoOrigem.Open();
            conexaoDestino.Open();

            decimal valor = progresso.Maximum / tabelasExportar.Count;

            foreach (string tabela in tabelasExportar)
            {
                string select = $@"SELECT * FROM {tabela}";

                using (FbCommand comandoSelect = new FbCommand(select, conexaoOrigem)) {
                    using (FbDataReader leitor = comandoSelect.ExecuteReader())
                    {
                        DataTable schemaTable = leitor.GetSchemaTable();
                        List<string> colunas = new List<string>();
                        List<string> parametros = new List<string>();
                        foreach (DataRow linha in schemaTable.Rows)
                        {
                            string coluna = linha["ColumnName"].ToString();
                            colunas.Add(coluna);
                            parametros.Add($"@{coluna}");
                        }

                        

                        using(FbCommand comandoDestino = new FbCommand(select, conexaoDestino)) {
                            using (FbDataReader leitorDestino = comandoDestino.ExecuteReader())
                            {
                                if(leitorDestino.Read())
                                {
                                    validar = true;
                                }

                                /* DataTable schemaTableDestino = leitorDestino.GetSchemaTable();
                                List<string> colunasDestino = new List<string>();
                                List<string> parametroDestino = new List<string>();
                                foreach (DataRow linhaDestino in schemaTableDestino.Rows) 
                                {
                                    string colunaDestino = linhaDestino["ColumnName"].ToString();
                                    colunasDestino.Add(colunaDestino);
                                    parametros.Add($"@{colunaDestino}");
                                } */
                            }
                        }

                        if (validar == false)
                        {
                            string insert = $"INSERT INTO {tabela} ({string.Join(",", colunas)}) VALUES ({string.Join(",", parametros)})";
                            while (leitor.Read())
                            {
                                using (FbCommand comandoInsert = new FbCommand(insert, conexaoDestino))
                                {
                                    foreach (string coluna in colunas)
                                    {
                                        comandoInsert.Parameters.AddWithValue($@"{coluna}", coluna);
                                    }
                                    comandoInsert.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
