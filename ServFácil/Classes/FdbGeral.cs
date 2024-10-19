using System;
using System.Linq;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
using ServFacil.Forms;
using FirebirdSql.EntityFrameworkCore.Firebird;
using Microsoft.EntityFrameworkCore;
namespace LavaK.Classes
{
    public class FdbGeral
    {
        public static string PegaDiretorio()
        {
            string dirConfig = @"C:\Projetos\ProjetoLavaRapido\ConfigServ.txt";
            string dirConexao = "";
            try
            {
                if (File.Exists(dirConfig))
                {
                    string[] linhas = File.ReadAllLines(dirConfig);
                    string linhaBD = linhas.FirstOrDefault(linha => linha.Trim().StartsWith("BD=", StringComparison.OrdinalIgnoreCase));

                    if (!string.IsNullOrEmpty(linhaBD))
                    {
                        dirConexao = linhaBD.Substring(3).Trim();
                    }
                }
                else
                {
                    MessageBox.Show(@"O arquivo para inicialização não foi encontrado! O sistema não será aberto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Erro ao tentar ler o arquivo de configuração: {ex.Message}");
            }
            return dirConexao;
        }

        public static string dirBanco = PegaDiretorio();
        private static string portaFirebird = PortaFirebird().Replace("RemoteServicePort = ", "");
        private static string PortaFirebird()
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
                portaOrigem = lines.FirstOrDefault(line => line.Trim().StartsWith("RemoteServicePort = ", StringComparison.OrdinalIgnoreCase));

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

        public static string stringConexao = $@"User=SYSDBA;Password=masterkey;Database={dirBanco};DataSource=localhost;
        Port={portaFirebird};Dialect=3;Charset=UTF8;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;ServerType=0;";

        public static bool AbreConexao()
        {
            bool conexaoAberta = false;

            using (FbConnection conexao = new FbConnection(stringConexao)) {
                try
                {
                    conexao.Open();
                    
                    if(conexao.State == ConnectionState.Open)
                    {
                        conexaoAberta = true;
                    }

                } catch (Exception ex)
                {
                    frmMensagem frmMensagem = new frmMensagem($@"Conexão não assegurada com o banco de dados!
{ex.Message}");
                }
                return conexaoAberta;
            }

        }
    }
}
