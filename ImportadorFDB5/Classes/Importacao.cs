
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.IO;
using System.Diagnostics.Eventing.Reader;

namespace ImportadorFDB5.Classes
{
    internal class Importacao
    {
        public static string diretorioOrigem;
        public static string diretorioDestino;


        public static string PortaFdbDois()
        {
            string portaOrigem;
            string diretorioFdb = null;
            try
            {
                diretorioFdb = @"C:\Program Files\Firebird\Firebird_2_5\firebird.conf";
                if (!File.Exists(diretorioFdb))
                {
                    diretorioFdb = @"C:\Program Files (x86)\Firebird\Firebird_2_5\firebird.conf";
                }

                string[] lines = File.ReadAllLines(diretorioFdb);
                portaOrigem = lines.FirstOrDefault(line => line.Trim().StartsWith("RemoteServicePort", StringComparison.OrdinalIgnoreCase));

                if (portaOrigem is null)
                {
                    portaOrigem = "3050";
                }
            }
            catch
            {
                portaOrigem = null;
            }

            return portaOrigem;
        }

        public static string PortaFdbCinco()
        {
            string portaDestino = null;
            string diretorioFdb = null;
            try
            {
                diretorioFdb = @"C:\Program Files\Firebird\Firebird_5_0\firebird.conf";
                if (!File.Exists(diretorioFdb))
                {
                    diretorioFdb = @"C:\Program Files (x86)\Firebird\Firebird_5_0\firebird.conf";
                }


                string[] lines = File.ReadAllLines(diretorioFdb);
                portaDestino = lines.FirstOrDefault(line => line.Trim().StartsWith("RemoteServicePort", StringComparison.OrdinalIgnoreCase));

                if (portaDestino is null)
                {
                    portaDestino = "3051";
                }
            }
            catch
            {
                portaDestino = null;
            }
            return portaDestino;
        }

        public static string portaUm = null;
        public static string portaDois = null;
        public static void CatchPorta()
        {
            if (PortaFdbDois() != null)
            {
                Importacao.portaUm = PortaFdbDois().Replace("RemoteServicePort = ", "");
            }
            if (PortaFdbCinco() != null)
            {
                Importacao.portaDois = PortaFdbCinco().Replace("RemoteServicePort = ", "");
            }
        }
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
                    MessageBox.Show("-> O Serviço do Firebird Está Ativo? \n-> O banco de dados selecionado é pertencente a versão 2.5 do Firebird?", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("-> O Serviço do Firebird Está Ativo? \n-> O banco de dados selecionado é pertencente a versão 5.0 do Firebird?", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public static void CreateFaltantes()
        {
            string stringConexao = $@"User=SYSDBA;Password=masterkey;Database={diretorioDestino};DataSource=localhost;Port={portaDois};
                                    Dialect=3;Charset=NONE;Pooling=true;MinPoolSize=0;MaxPoolSize=50;
                                    Packet Size=8192;ServerType=0;";

            using (FbConnection conexaoDest = new FbConnection(stringConexao))
            {
                conexaoDest.Open();

                string[] create = new string[12];

                create[0] = $@"EXECUTE BLOCK AS
                BEGIN
                    IF (NOT EXISTS(SELECT 1 FROM rdb$relations WHERE rdb$relation_name = 'TCONFERENCIAFECHAMENTOCAIXA')) THEN
                    BEGIN
                        EXECUTE STATEMENT '
                            CREATE TABLE TCONFERENCIAFECHAMENTOCAIXA (
                                CONTROLE            INTEGER NOT NULL,
                                CODCENTROCUSTO      INTEGER NOT NULL,
                                CENTROCUSTO         VARCHAR(100) COLLATE PT_BR,
                                CODFUNCIONARIO      INTEGER NOT NULL,
                                FUNCIONARIO         VARCHAR(100) COLLATE PT_BR,
                                ESPECIE             VARCHAR(50) COLLATE PT_BR,
                                VALORRECEBIDO       DECIMAL(15,4),
                                VALORFECHAMENTO     DECIMAL(15,4),
                                VALORDIFERENCA      DECIMAL(15,4),
                                DATAHORAFECHAMENTO  TIMESTAMP NOT NULL
                            );
                        ';
                    END
                END;";

                create[1] = $@"EXECUTE BLOCK AS
                BEGIN
                    IF (NOT EXISTS(SELECT 1 FROM rdb$relations WHERE rdb$relation_name = 'TMENSAGEMPADRAO')) THEN
                    BEGIN
                        EXECUTE STATEMENT '
                            CREATE TABLE TMENSAGEMPADRAO (
                                CONTROLE      INTEGER NOT NULL,
                                ATIVO         CHAR(1) NOT NULL,
                                MODULO        CHAR(2) NOT NULL,
                                TIPOMENSAGEM  CHAR(2) NOT NULL,
                                MENSAGEM      BLOB SUB_TYPE 1 SEGMENT SIZE 80,
                                VARIAVEIS     BLOB SUB_TYPE 1 SEGMENT SIZE 80 NOT NULL
                            );
                        ';
                    END
                END;";

                create[2] = $@"EXECUTE BLOCK AS
                BEGIN
                    IF (NOT EXISTS(SELECT 1 FROM rdb$relations WHERE rdb$relation_name = 'TANTECIPACAOCARTAO')) THEN
                    BEGIN
                        EXECUTE STATEMENT '
                            CREATE TABLE TANTECIPACAOCARTAO (
                                CONTROLE         INTEGER NOT NULL,
                                CODESPECIE       INTEGER NOT NULL,
                                TAXAANTECIPACAO  DECIMAL(5,2) NOT NULL,
                                DIASCREDITO      INTEGER NOT NULL,
                                ESPECIE          VARCHAR(50) COLLATE PT_BR
                            );
                        ';
                    END
                END;";

                create[3] = $@"EXECUTE BLOCK AS
                BEGIN
                    IF (NOT EXISTS(SELECT 1 FROM rdb$relations WHERE rdb$relation_name = 'TCONFIGCASHBACK')) THEN
                    BEGIN
                        EXECUTE STATEMENT '
                            CREATE TABLE TCONFIGCASHBACK (
                                CONTROLE             INTEGER NOT NULL,
                                MODULOSCASHBACK      VARCHAR(30) DEFAULT ''1,2,3,4,5,6,7,8'' COLLATE PT_BR,
                                VALORMINIMOCASHBACK  DECIMAL(15,4) DEFAULT 0.0000,
                                TIPOCASHBACK         CHAR(1) DEFAULT ''0'' COLLATE PT_BR,
                                VALORCASHBACK        DECIMAL(15,4) DEFAULT 0.0000
                            );
                        ';
                    END
                END;";

                create[4] = $@"EXECUTE BLOCK AS
                BEGIN
                    IF (NOT EXISTS(SELECT 1 FROM rdb$relations WHERE rdb$relation_name = 'TOFICINACHECKLIST')) THEN
                    BEGIN
                        EXECUTE STATEMENT '
                            CREATE TABLE TOFICINACHECKLIST (
	                            CONTROLE INTEGER NOT NULL,
	                            CODPRODUTO INTEGER,
	                            PRODUTO VARCHAR(100),
	                            DESCRICAO VARCHAR(30),
	                            UTILIZANAIMPRESSAO CHAR(1),
	                            DATAEHORACADASTRO TIMESTAMP,
	                            CONSTRAINT PK_TOFICINACHECKLIST PRIMARY KEY (CONTROLE)
                            );
                        ';
                    END
                END;";

                create[5] = $@"EXECUTE BLOCK AS
                BEGIN
                    IF (NOT EXISTS(SELECT 1 FROM rdb$relations WHERE rdb$relation_name = 'TOFICINAVEICULO')) THEN
                    BEGIN
                        EXECUTE STATEMENT '
                            CREATE TABLE TOFICINAVEICULO (
	                            CONTROLE INTEGER NOT NULL,
	                            CODPROPRIETARIO INTEGER NOT NULL,
	                            PROPRIETARIO VARCHAR(100),
	                            MARCA VARCHAR(50),
	                            MODELO VARCHAR(100),
	                            ATIVO CHAR(1),
	                            PLACA VARCHAR(8),
	                            CATEGORIA VARCHAR(20),
	                            COR VARCHAR(25),
	                            ANOMODELOFABRICACAO VARCHAR(4),
	                            ANOFABRICACAO INTEGER,
	                            TIPOCOMBUSTIVEL VARCHAR(30),
	                            CHASSI VARCHAR(17),
	                            QUILOMETRAGEM VARCHAR(10),
	                            OBS BLOB SUB_TYPE TEXT,
	                            DATAEHORACADASTRO TIMESTAMP,
	                            POTENCIA VARCHAR(10),
	                            CONSTRAINT PK_TOFICINAVEICULO PRIMARY KEY (CONTROLE)
                            );
                        ';
                    END
                END;";

                create[6] = $@"EXECUTE BLOCK AS
                BEGIN
                    IF (NOT EXISTS(SELECT 1 FROM rdb$relations WHERE rdb$relation_name = 'TSEGURADORA')) THEN
                    BEGIN
                        EXECUTE STATEMENT '
                            CREATE TABLE TSEGURADORA (
	                            CONTROLE INTEGER NOT NULL,
	                            SEGURADORA VARCHAR(100),
	                            RESPONSAVELSEGURO CHAR(1),
	                            CNPJSEGURADORA VARCHAR(14),
	                            NROAPOLICE VARCHAR(20),
	                            NROAVERBACAO VARCHAR(20),
	                            DATAHORACADASTRO TIMESTAMP,
	                            CONSTRAINT PK_TSEGURADORA PRIMARY KEY (CONTROLE)
                            );
                        ';
                    END
                END;";

                create[7] = $@"EXECUTE BLOCK AS
                BEGIN
                    IF (NOT EXISTS(SELECT 1 FROM rdb$relations WHERE rdb$relation_name = 'TOFICINALOCALIZACAOVEICULO')) THEN
                    BEGIN
                        EXECUTE STATEMENT '
                                CREATE TABLE TOFICINALOCALIZACAOVEICULO (
	                            CONTROLE INTEGER NOT NULL,
	                            LOCALIZACAO VARCHAR(50),
	                            DATAHORACADASTRO TIMESTAMP,
	                            CONSTRAINT PK_TOFICINALOCALIZACAOVEICULO PRIMARY KEY (CONTROLE)
                            );
                        ';
                    END
                END;";

                create[8] = $@"EXECUTE BLOCK AS
                BEGIN
                    IF (NOT EXISTS(SELECT 1 FROM rdb$relations WHERE rdb$relation_name = 'THISTORICOOS')) THEN
                    BEGIN
                        EXECUTE STATEMENT '
                                CREATE TABLE THISTORICOOS (
                                CONTROLE INTEGER NOT NULL,
                                CODOPERADOR INTEGER,
                                CODOS INTEGER NOT NULL,
                                SITUACAOANTIGA VARCHAR(100),
                                SITUACAONOVA VARCHAR(100),
                                DATAALTERACAO TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                                CONSTRAINT PK_THISTORICOOS PRIMARY KEY (CONTROLE),
                                CONSTRAINT FK_THISTORICOOS_1 FOREIGN KEY (CODOS) REFERENCES TOS(CONTROLE)
                                );
                             
                        ';
                    END
                END;";

                create[9] = $@"EXECUTE BLOCK AS
                BEGIN
                    IF (NOT EXISTS(SELECT 1 FROM rdb$relations WHERE rdb$relation_name = 'TOSOFICINA')) THEN
                    BEGIN
                        EXECUTE STATEMENT '
                                CREATE TABLE TOSOFICINA (
	                            CONTROLE INTEGER NOT NULL,
	                            CODVEICULOOFICINA INTEGER,
	                            CODOS INTEGER NOT NULL,
	                            PERCTANQUECOMBUSTIVEL INTEGER,
	                            LOCALIZACAOVEICULO VARCHAR(50),
	                            CONSTRAINT PK_TOSOFICINA PRIMARY KEY (CONTROLE),
	                            CONSTRAINT FK_TOSOFICINA_1 FOREIGN KEY (CODOS) REFERENCES TOS(CONTROLE)
                                );
                            
                        ';
                    END
                END;";

                create[10] = $@"EXECUTE BLOCK AS
                BEGIN
                    IF (NOT EXISTS(SELECT 1 FROM rdb$relations WHERE rdb$relation_name = 'TANEXOOS')) THEN
                    BEGIN
                        EXECUTE STATEMENT '
                                CREATE TABLE TANEXOOS (
	                            CONTROLE INTEGER NOT NULL,
	                            CODOS INTEGER,
	                            ANEXOLOCAL VARCHAR(200),
	                            ANEXOFTP VARCHAR(50),
	                            DATAEHORACADASTRO TIMESTAMP,
	                            CONSTRAINT PK_TANEXOOS PRIMARY KEY (CONTROLE),
	                            CONSTRAINT FK_TANEXOOS_1 FOREIGN KEY (CODOS) REFERENCES TOS(CONTROLE)
                                );
                            
                        ';
                    END
                END;";

                create[11] = $@"EXECUTE BLOCK AS
                BEGIN
                    IF (NOT EXISTS(SELECT 1 FROM rdb$relations WHERE rdb$relation_name = 'TOFICINAIMAGEMVEICULO')) THEN
                    BEGIN
                        EXECUTE STATEMENT '
                                CREATE TABLE TOFICINAIMAGEMVEICULO (
	                            CONTROLE INTEGER NOT NULL,
	                            CODVEICULO INTEGER NOT NULL,
	                            IMAGEMLOCAL VARCHAR(200),
	                            IMAGEMFTP VARCHAR(50),
	                            DATAEHORACADASTRO TIMESTAMP,
	                            CONSTRAINT PK_TOFICINAIMAGEMVEICULO PRIMARY KEY (CONTROLE),
	                            CONSTRAINT FK_TOFICINAIMAGEMVEICULO_1 FOREIGN KEY (CODVEICULO) REFERENCES TOFICINAVEICULO(CONTROLE)
                                );
                            
                        ';
                    END
                END;";

                try
                {
                    foreach (string query in create)
                    {
                        using (FbCommand queryCriar = new FbCommand(query, conexaoDest))
                        {
                            queryCriar.ExecuteNonQuery();
                        }
                    }
                }
                catch (FbException ex) when (ex.Message.Contains("SQL error code = -607"))
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static List<string> OrdenarTabelasPorDependencias(List<string> tabelas)
        {
            string stringConexaoOrigem = $@"User=SYSDBA;Password=masterkey;Database={diretorioOrigem};DataSource=localhost;Port={portaUm};
                    Dialect=3;Charset=NONE;Pooling=true;MinPoolSize=0;MaxPoolSize=50;
                    Packet Size=8192;ServerType=0;";

            using (FbConnection conexaoOrigem = new FbConnection(stringConexaoOrigem))
            {
                conexaoOrigem.Open();

                Dictionary<string, List<string>> dependencias = new Dictionary<string, List<string>>();

                foreach (string tabela in tabelas)
                {
                    List<string> tabelasReferenciadas = new List<string>();

                    string consultaReferencias = $@"
                        SELECT DISTINCT rfc.RDB$RELATION_NAME AS REFERENCED_TABLE_NAME
                        FROM RDB$RELATION_CONSTRAINTS rc
                        JOIN RDB$REF_CONSTRAINTS refc ON rc.RDB$CONSTRAINT_NAME = refc.RDB$CONSTRAINT_NAME
                        JOIN RDB$RELATION_CONSTRAINTS rfc ON refc.RDB$CONST_NAME_UQ = rfc.RDB$CONSTRAINT_NAME
                        WHERE rc.RDB$RELATION_NAME = '{tabela}' AND rc.RDB$CONSTRAINT_TYPE = 'FOREIGN KEY'";

                    using (FbCommand comandoReferencias = new FbCommand(consultaReferencias, conexaoOrigem))
                    {
                        using (FbDataReader leitor = comandoReferencias.ExecuteReader())
                        {
                            while (leitor.Read())
                            {
                                string referencedTable = leitor["REFERENCED_TABLE_NAME"].ToString().Trim();
                                if (tabelas.Contains(referencedTable))
                                {
                                    tabelasReferenciadas.Add(referencedTable);
                                }
                            }
                        }
                    }

                    dependencias[tabela] = tabelasReferenciadas;
                }

                List<string> ordenacao = new List<string>();
                HashSet<string> visitado = new HashSet<string>();

                void Visitar(string tabela)
                {
                    if (!visitado.Contains(tabela))
                    {
                        visitado.Add(tabela);

                        if (dependencias.ContainsKey(tabela))
                        {
                            foreach (var referenciada in dependencias[tabela])
                            {
                                if (!visitado.Contains(referenciada))
                                {
                                    Visitar(referenciada);
                                }
                            }
                        }

                        ordenacao.Add(tabela);
                    }
                }

                foreach (var tabela in tabelas)
                {
                    Visitar(tabela);
                }

                return ordenacao;
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

        public static void DropKeys(System.Windows.Forms.Label label)
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

                        using (FbCommand drop = new FbCommand(comandoDrop, conexao))
                        {
                            drop.ExecuteNonQuery();
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
        public static void ImportarTabelas(List<string> tabelas, ProgressBar progresso, System.Windows.Forms.Label lblStatus)
        {
            lblStatus.Enabled = true;

            List<string> tabelasSemFk = new List<string>();
            List<string> tabelasComFk = new List<string>();

            string stringConexaoDestino = $@"User=SYSDBA;Password=masterkey;Database={diretorioDestino};DataSource=localhost;Port={portaDois};
                    Dialect=3;Charset=NONE;Pooling=true;MinPoolSize=0;MaxPoolSize=50;
                    Packet Size=8192;ServerType=0;";
            string stringConexaoOrigem = $@"User=SYSDBA;Password=masterkey;Database={diretorioOrigem};DataSource=localhost;Port={portaUm};
                    Dialect=3;Charset=NONE;Pooling=true;MinPoolSize=0;MaxPoolSize=50;
                    Packet Size=8192;ServerType=0;";

            using (FbConnection conexaoDestino = new FbConnection(stringConexaoDestino))
            using (FbConnection conexaoOrigem = new FbConnection(stringConexaoOrigem))
            {
                conexaoOrigem.Open();
                conexaoDestino.Open();

                List<string> tabelasExportar = PreencherNomeTabelas();

                foreach (string tabela in tabelasExportar)
                {
                    string consultaView = $@"
                        SELECT COUNT(*)
                        FROM RDB$RELATIONS
                        WHERE RDB$RELATION_NAME = '{tabela}' AND RDB$VIEW_BLR IS NOT NULL";

                    using (FbCommand comandoView = new FbCommand(consultaView, conexaoOrigem))
                    {
                        int isView = Convert.ToInt32(comandoView.ExecuteScalar());
                        if (isView > 0)
                        {
                            continue;
                        }
                    }

                    string consultaFk = $@"
                        SELECT COUNT(*)
                        FROM RDB$RELATION_CONSTRAINTS rc
                        WHERE rc.RDB$RELATION_NAME = '{tabela}' AND rc.RDB$CONSTRAINT_TYPE = 'FOREIGN KEY'";

                    using (FbCommand comandoFk = new FbCommand(consultaFk, conexaoOrigem))
                    {
                        int fkCount = Convert.ToInt32(comandoFk.ExecuteScalar());
                        if (fkCount == 0)
                        {
                            tabelasSemFk.Add(tabela);
                        }
                        else
                        {
                            tabelasComFk.Add(tabela);
                        }
                    }
                }

                List<string> tabelasOrdenadasComFk = OrdenarTabelasPorDependencias(tabelasComFk);

                List<string> tabelasOrdenadas = new List<string>();
                tabelasOrdenadas.AddRange(tabelasSemFk);
                tabelasOrdenadas.AddRange(tabelasOrdenadasComFk);

                progresso.Maximum = tabelasOrdenadas.Count;

                foreach (string tabela in tabelasOrdenadas)
                {
                    decimal valor = progresso.Maximum / tabelas.Count() + 1;

                    string select = $@"SELECT * FROM {tabela}";

                    using (FbCommand comandoSelect = new FbCommand(select, conexaoOrigem))
                    {
                        using (FbDataReader leitor = comandoSelect.ExecuteReader())
                        {
                            DataTable schemaTable = leitor.GetSchemaTable();
                            List<string> colunas = new List<string>();
                            List<string> parametros = new List<string>();
                            List<string> primaryKeyColumns = new List<string>();
                            bool temPk = false;

                            foreach (DataRow linha in schemaTable.Rows)
                            {
                                string coluna = linha["ColumnName"].ToString();
                                colunas.Add(coluna);
                                parametros.Add($"@{coluna}");

                                if ((bool)linha["IsKey"])
                                {
                                    temPk = true;
                                    primaryKeyColumns.Add(coluna);
                                }
                            }

                            progresso.Value = Math.Min(progresso.Value + 1, progresso.Maximum);
                            lblStatus.Text = $"Importando tabela: {tabela}";
                            lblStatus.Refresh();
                            Application.DoEvents();

                            foreach (string coluna in colunas)
                            {
                                using (FbCommand checarColuna = new FbCommand($"SELECT COUNT(*) FROM RDB$RELATION_FIELDS WHERE RDB$FIELD_NAME = '{coluna}' AND RDB$RELATION_NAME = '{tabela}'", conexaoDestino))
                                {
                                    object result = checarColuna.ExecuteScalar();

                                    int colunaExiste = result != null && Convert.ToInt32(result) > 0 ? 1 : 0;

                                    if (colunaExiste == 0)
                                    {
                                        string datatype = "";
                                        using (FbCommand tipoDatatype = new FbCommand($"SELECT RDB$FIELD_TYPE FROM RDB$RELATION_FIELDS RF JOIN RDB$FIELDS F ON RF.RDB$FIELD_SOURCE = F.RDB$FIELD_NAME WHERE RF.RDB$FIELD_NAME = '{coluna}' AND RF.RDB$RELATION_NAME = '{tabela}'", conexaoOrigem))
                                        {
                                            object resultado = tipoDatatype.ExecuteScalar();

                                            int tipoCampo = Convert.ToInt32(resultado);
                                            switch (tipoCampo)
                                            {
                                                case 7:
                                                    datatype = "SMALLINT";
                                                    break;
                                                case 8:
                                                    datatype = "INTEGER";
                                                    break;
                                                case 10:
                                                    datatype = "FLOAT";
                                                    break;
                                                case 12:
                                                    datatype = "DATE";
                                                    break;
                                                case 13:
                                                    datatype = "TIME";
                                                    break;
                                                case 14:
                                                case 37:
                                                    datatype = "VARCHAR(50)";
                                                    break;
                                                case 16:
                                                    datatype = "BIGINT";
                                                    break;
                                                case 27:
                                                    datatype = "DOUBLE PRECISION";
                                                    break;
                                                case 35:
                                                    datatype = "TIMESTAMP";
                                                    break;
                                                default:
                                                    datatype = "VARCHAR(50)";
                                                    break;
                                            }
                                        }
                                        try
                                        {
                                            using (FbCommand createColumnCommand = new FbCommand($"ALTER TABLE {tabela} ADD {coluna} {datatype}", conexaoDestino))
                                            {
                                                createColumnCommand.ExecuteNonQuery();
                                            }
                                        }
                                        catch (FbException ex) when (ex.Message.Contains("SQL error code = -607"))
                                        {
                                            Console.WriteLine(ex.Message);
                                        }
                                    }
                                }
                            }

                            int contaRegistros = 0;

                            while (leitor.Read())
                            {
                                string insert;
                                 

                                if (temPk)
                                {
                                    string matchingClause = string.Join(" AND ", primaryKeyColumns.Select(pk => $"{pk} = @{pk}"));
                                    insert = $"UPDATE OR INSERT INTO {tabela} ({string.Join(",", colunas)}) VALUES ({string.Join(",", parametros)}) MATCHING ({string.Join(",", primaryKeyColumns)})";
                                }
                                else
                                {
                                    insert = $"INSERT INTO {tabela} ({string.Join(",", colunas)}) VALUES ({string.Join(",", parametros)})";
                                }

                                try
                                {
                                    using (FbCommand comandoInsert = new FbCommand(insert, conexaoDestino))
                                    {
                                        foreach (string coluna in colunas)
                                        {
                                            comandoInsert.Parameters.AddWithValue($@"{coluna}", leitor[coluna]);
                                        }
                                        comandoInsert.ExecuteNonQuery();
                                        contaRegistros++;
                                    }
                                }
                                catch (FbException ex) when (ex.Message.Contains("violation of PRIMARY or UNIQUE KEY constraint"))
                                {
                                    Logs.AlimentarLog(diretorioDestino, $"Erro ao inserir na tabela {tabela}: {ex.Message}");
                                }
                                catch (FbException ex) when (ex.Message.Contains("violation of FOREIGN KEY constraint"))
                                {
                                    Logs.AlimentarLog(diretorioDestino, $"Erro de chave estrangeira ao inserir na tabela {tabela}: {ex.Message}");
                                }
                                catch (FbException ex) when (ex.Message.Contains("SQL error code = -607"))
                                {
                                    Logs.AlimentarLog(diretorioDestino, $"Tabela inexistente. {ex.Message}");
                                }
                                catch (FbException ex) when (ex.Message.Contains("*** null ***"))
                                {
                                    Logs.AlimentarLog(diretorioDestino, $@"O registro não possui o valor de FK definido na tabela: {tabela}");
                                }
                            }
                            if (contaRegistros > 0)
                            {
                                try
                                {
                                    Logs.AlimentarLog(diretorioDestino, $@"Registros da tabela {tabela} importados com sucesso! Total de Registros: {contaRegistros}");
                                }
                                catch { 
                                }
                            }
                        }
                    }
                }
                lblStatus.Text = "Importação Concluída com Sucesso!";
                lblStatus.Refresh();
                progresso.Value = 0;
                Application.DoEvents();
                MessageBox.Show("Importação Concluída com Sucesso!", "Importação FDB5", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
