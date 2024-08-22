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
using System.Reflection.Emit;

namespace ImportadorFDB5.Classes
{
    internal class Importacao
    {
        public static string diretorioOrigem;
        public static string diretorioDestino;


        public static string PortaFdbDois()
        {
            string diretorioFdb = @"C:\Program Files\Firebird\Firebird_2_5\firebird.conf";
            if (!File.Exists(diretorioFdb))
            {
                diretorioFdb = @"C:\Program Files (x86)\Firebird\Firebird_2_5\firebird.conf";
            }

            string[] lines = File.ReadAllLines(diretorioFdb);
            string portaOrigem = lines.FirstOrDefault(line => line.Trim().StartsWith("RemoteServicePort", StringComparison.OrdinalIgnoreCase));

            if (portaOrigem is null)
            {
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
                    btnStatus.BackColor = System.Drawing.Color.Red;
                    destino.Text = "Selecione o banco de origem.";
                    MessageBox.Show(@"-> O Serviço do Firebird Está Ativo?\n-> O banco de dados selecionado é pertencente a V5.0 do\n     
                                    Firebird?", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public static List<string> PreencherNomeTabelas()
        {
            string stringConexao = $@"User=SYSDBA;Password=masterkey;Database={diretorioOrigem};DataSource=localhost;Port={portaUm};
                                    Dialect=3;Charset=NONE;Pooling=true;MinPoolSize=0;MaxPoolSize=50;
                                    Packet Size=8192;ServerType=0;";
            FbConnection conexao = new FbConnection(stringConexao);
            List<string> nomeTabela = new List<string>();

            conexao.Open();
            string select = "SELECT RDB$RELATION_NAME FROM RDB$RELATIONS WHERE RDB$SYSTEM_FLAG = '0'";
            using (FbCommand comando = new FbCommand(select, conexao))
            {
                using (FbDataReader leitor = comando.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        nomeTabela.Add(leitor.GetString(0).Trim());
                    }
                }
                return nomeTabela;
            }
        }

        public static void DropKeys(System.Windows.Forms.Label lbl)
        {
            string stringConexaoDestino = $@"User=SYSDBA;Password=masterkey;Database={diretorioDestino};DataSource=localhost;Port={portaDois};
                                    Dialect=3;Charset=NONE;Pooling=true;MinPoolSize=0;MaxPoolSize=50;
                                    Packet Size=8192;ServerType=0;";

            FbConnection conexao = new FbConnection(stringConexaoDestino);

            string consultaTrigger = @"
            SELECT RDB$TRIGGER_NAME FROM RDB$TRIGGERS WHERE RDB$FLAGS = 1;
            ";

            string consultaForeignKeys = @"
            SELECT 
                RDB$CONSTRAINT_NAME, 
                RDB$RELATION_NAME 
            FROM 
                RDB$RELATION_CONSTRAINTS 
            WHERE 
                RDB$CONSTRAINT_TYPE = 'FOREIGN KEY'";

            string consultaUniqueKeys = @"
            SELECT 
                RDB$CONSTRAINT_NAME, 
                RDB$RELATION_NAME 
            FROM 
                RDB$RELATION_CONSTRAINTS 
            WHERE RDB$CONSTRAINT_NAME LIKE '%UNQ%'";

            conexao.Open();

            using (FbCommand comandoTrigger = new FbCommand(consultaTrigger, conexao))
            {
                using (FbDataReader leitor = comandoTrigger.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        string nomeTrigger = leitor["RDB$TRIGGER_NAME"].ToString();
                        string comandoInactive = $@"ALTER TRIGGER {nomeTrigger} INACTIVE";
                        using (FbCommand comandoInativar = new FbCommand(comandoInactive, conexao))
                        {
                            comandoInativar.ExecuteNonQuery();
                        }
                    }
                }
            }

            using (FbCommand comandoFk = new FbCommand(consultaForeignKeys, conexao))
            {
                using (FbDataReader leitor = comandoFk.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        string nomeConstraint = leitor["RDB$CONSTRAINT_NAME"].ToString();
                        string nomeTabela = leitor["RDB$RELATION_NAME"].ToString();

                        string comandoDrop = $@"ALTER TABLE {nomeTabela} DROP CONSTRAINT {nomeConstraint}";
                        string pkDefere = "SET CONSTRAINTS ALL DEFERRED;";

                        using (FbCommand drop = new FbCommand(comandoDrop, conexao))
                        {
                            drop.ExecuteNonQuery();
                        }
                        using (FbCommand defere = new FbCommand(pkDefere, conexao))
                        {
                            defere.ExecuteNonQuery();
                        }
                    }
                }
            }

            using (FbCommand comandoUnq = new FbCommand(consultaUniqueKeys, conexao))
            {
                using (FbDataReader leitor = comandoUnq.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        string nomeUnique = leitor["RDB$CONSTRAINT_NAME"].ToString();
                        string nomeTabela = leitor["RDB$RELATION_NAME"].ToString();

                        string comandoDrop = $@"ALTER TABLE {nomeTabela} DROP CONSTRAINT {nomeUnique}";

                        using (FbCommand drop = new FbCommand(comandoDrop, conexao))
                        {
                            drop.ExecuteNonQuery();
                        }
                    }
                }
            }

        }
        public static void ExportarDados(List<string> tabelas, ProgressBar progresso, System.Windows.Forms.Label lbl)
        {
            progresso.Maximum = tabelas.Count();

            string stringConexaoDestino = $@"User=SYSDBA;Password=masterkey;Database={diretorioDestino};DataSource=localhost;Port={portaDois};
                                    Dialect=3;Charset=NONE;Pooling=true;MinPoolSize=0;MaxPoolSize=50;
                                    Packet Size=8192;ServerType=0;";
            string stringConexaoOrigem = $@"User=SYSDBA;Password=masterkey;Database={diretorioOrigem};DataSource=localhost;Port={portaUm};
                                    Dialect=3;Charset=NONE;Pooling=true;MinPoolSize=0;MaxPoolSize=50;
                                    Packet Size=8192;ServerType=0;";

            bool temPk = false;

            FbConnection conexaoDestino = new FbConnection(stringConexaoDestino);
            FbConnection conexaoOrigem = new FbConnection(stringConexaoOrigem);

            List<string> tabelasExportar = PreencherNomeTabelas();
            bool validar = false;
            conexaoOrigem.Open();
            conexaoDestino.Open();

            foreach (string tabela in tabelasExportar)
            {
                string select = $@"SELECT * FROM {tabela}";

                using (FbCommand comandoSelect = new FbCommand(select, conexaoOrigem))
                {
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

                            string pKey = linha["ColumnName"].ToString();
                            temPk = (bool)linha["IsKey"];
                        }





                        progresso.Value += 1;

                        if (validar == false)
                        {
                            /* string sqlCheckView = $"SELECT RDB$VIEW_SOURCE FROM RDB$RELATIONS WHERE RDB$RELATION_NAME = '{tabela.ToUpper()}'";
                            bool isView = false;

                            using (FbCommand cmdCheckView = new FbCommand(sqlCheckView, conexaoOrigem))
                            {
                                object result = cmdCheckView.ExecuteScalar();
                                if (result != DBNull.Value && result != null)
                                {
                                    isView = true;
                                }
                            }

                            if (isView)
                            {
                                MessageBox.Show($"A tabela {tabela} é uma visão baseada em mais de uma tabela. O comando UPDATE OR INSERT será ignorado.");
                            } */

                            if (tabela != "TCSTCFOP" && tabela != "TALIQUOTAFCP" && tabela != "TCONFIGESTACAO" && tabela != "TCREDITOCLIENTE" && tabela != "THISTORICOCREDITOCLIENTE" && tabela != "TECF" && tabela != "TPARCELAMENTO" && tabela != "TSCRIPT" && tabela != "TSEQUENCIANFE" && tabela != "TXML" && tabela != "TAUTORIZACAOXML")
                            {
                                while (leitor.Read())
                                {
                                    lbl.Text = $@"Importando Tabela: {tabela}";
                                    lbl.Visible = true;
                                    lbl.ForeColor = System.Drawing.Color.Black;
                                    lbl.BringToFront();
                                    lbl.Location = new System.Drawing.Point(102, 223);

                                    string insert = $"UPDATE OR INSERT INTO {tabela} ({string.Join(",", colunas)}) VALUES ({string.Join(",", parametros)})";
                                    using (FbCommand comandoInsert = new FbCommand(insert, conexaoDestino))
                                    {
                                        foreach (string coluna in colunas)
                                        {
                                            comandoInsert.Parameters.AddWithValue($@"{coluna}", leitor[coluna]);
                                        }
                                        comandoInsert.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            MessageBox.Show("Importação Concluída com Sucesso!");
        }
    }
}
