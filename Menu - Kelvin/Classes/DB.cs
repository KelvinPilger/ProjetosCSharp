using FirebirdSql.Data.FirebirdClient;
using System;
using System.Data;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu___Kelvin
{
    public class DB
    {
        public static string ConectarBD()
        {
            string conexaoString = "User=SYSDBA;Password=masterkey;Database=localhost:c:\\sgbr\\master\\BD\\BASESGMASTER populada.FDB;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;";
            return conexaoString;
        }

        private static void NomenclaturaDataTable(DataTable dt)
        {
            
        }

        public static void SelecionaCliente(DataGridView dataGridView, CheckBox checkBox, DateTimePicker dtpInicial, DateTimePicker dtpFinal)
        {
            string dataInicial = dtpInicial.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string dataFinal = dtpFinal.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            string select = checkBox.Checked
                ? $"SELECT * FROM TCLIENTE WHERE CAST((DATAHORACADASTRO) AS DATE) BETWEEN '{dataInicial}' AND '{dataFinal}' ORDER BY CONTROLE ASC"
                : $"SELECT FIRST 100 * FROM TCLIENTE WHERE CAST((DATAHORACADASTRO) AS DATE) BETWEEN '{dataInicial}' AND '{dataFinal}' ORDER BY CONTROLE ASC";

            try
            {
                string conexaoString = ConectarBD();
                using (FbConnection conexao = new FbConnection(conexaoString))
                {
                    using (FbDataAdapter dataAdapter = new FbDataAdapter(select, conexao))
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            dataAdapter.Fill(dataTable);
                            DB.NomenclaturaDataTable(dataTable);
                            dataGridView.DataSource = dataTable;
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void SelecionaCliente(DataGridView dataGridView, CheckBox checkBox)
        {
            string select = checkBox.Checked
                ? "SELECT * FROM TCLIENTE ORDER BY CONTROLE ASC"
                : "SELECT FIRST 100 * FROM TCLIENTE ORDER BY CONTROLE ASC";

            try
            {
                string conexaoString = ConectarBD();
                using (FbConnection conexao = new FbConnection(conexaoString))
                {
                    using (FbDataAdapter dataAdapter = new FbDataAdapter(select, conexao))
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            dataAdapter.Fill(dataTable);
                            DB.NomenclaturaDataTable(dataTable);
                            dataGridView.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void SelecionaProduto(DataGridView dataGridView, CheckBox checkBox, DateTimePicker dtpInicial, DateTimePicker dtpFinal)
        {
            string dataInicial = dtpInicial.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string dataFinal = dtpFinal.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            string select = checkBox.Checked
                ? $"SELECT * FROM TESTOQUE WHERE CAST((DATAHORACADASTRO) AS DATE) BETWEEN '{dataInicial}' AND '{dataFinal}' ORDER BY CONTROLE ASC"
                : $"SELECT FIRST 100 * FROM TESTOQUE WHERE CAST((DATAHORACADASTRO) AS DATE) BETWEEN '{dataInicial}' AND '{dataFinal}' ORDER BY CONTROLE ASC";
            {
                try
                {
                    string conexaoString = ConectarBD();
                    using (FbConnection conexao = new FbConnection(conexaoString))
                    {
                        using (FbDataAdapter dataAdapter = new FbDataAdapter(select, conexao))
                        {
                            using (DataTable dataTable = new DataTable())
                            {
                                dataAdapter.Fill(dataTable);
                                DB.NomenclaturaDataTable(dataTable);
                                dataGridView.DataSource = dataTable;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }


        public static void SelecionaProduto(DataGridView dataGridView, CheckBox checkBox)
        {
                string select = checkBox.Checked
                    ? "SELECT * FROM TESTOQUE ORDER BY CONTROLE ASC"
                    : "SELECT FIRST 100 * FROM TESTOQUE ORDER BY CONTROLE ASC";
                try
                {
                    string conexaoString = ConectarBD();

                    using (FbConnection conexao = new FbConnection(conexaoString))
                    {
                        using (FbDataAdapter dataAdapter = new FbDataAdapter(select, conexao))
                        {
                            using (DataTable dataTable = new DataTable())
                            {
                                dataAdapter.Fill(dataTable);
                                DB.NomenclaturaDataTable(dataTable);
                                dataGridView.DataSource = dataTable;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        public static void SelecionaFornecedor(DataGridView dataGridView, CheckBox checkBox)
        {
            string select = checkBox.Checked
                ? "SELECT * FROM TFORNECEDOR ORDER BY CONTROLE ASC"
                : "SELECT FIRST 100 * FROM TFORNECEDOR ORDER BY CONTROLE ASC";

            try
            {
                string conexaoString = ConectarBD();
                using (FbConnection conexao = new FbConnection(conexaoString))
                {
                    using (FbDataAdapter dataAdapter = new FbDataAdapter(select, conexao))
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            dataAdapter.Fill(dataTable);
                            DB.NomenclaturaDataTable(dataTable);
                            dataGridView.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void SelecionaFornecedor(DataGridView dataGridView, CheckBox checkBox, DateTimePicker dtpInicial, DateTimePicker dtpFinal)
        {
            string dataInicial = dtpInicial.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string dataFinal = dtpFinal.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            string select = checkBox.Checked
                ? $"SELECT * FROM TFORNECEDOR WHERE CAST((DATAHORACADASTRO) AS DATE) BETWEEN '{dataInicial}' AND '{dataFinal}' ORDER BY CONTROLE ASC"
                : $"SELECT FIRST 100 * FROM TFORNECEDOR WHERE CAST((DATAHORACADASTRO) AS DATE) BETWEEN '{dataInicial}' AND '{dataFinal}' ORDER BY CONTROLE ASC";

            try
            {
                string conexaoString = ConectarBD();
                using (FbConnection conexao = new FbConnection(conexaoString))
                {
                    using (FbDataAdapter dataAdapter = new FbDataAdapter(select, conexao))
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            dataAdapter.Fill(dataTable);
                            DB.NomenclaturaDataTable(dataTable);
                            dataGridView.DataSource = dataTable;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}