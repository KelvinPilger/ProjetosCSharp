using System;
using System.Data;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using OfficeOpenXml;
using System.IO;
using System.Data.SqlClient;
using DocumentFormat.OpenXml.Bibliography;
using System.Configuration;
using DocumentFormat.OpenXml.Math;
using System.Text;
using Menu___Kelvin.Tabelas;

namespace Menu___Kelvin.Classes
{
    internal class Planilhas
    {
        public static string ExportacaoComData(MaskedTextBox mbInicial, MaskedTextBox mbFinal, RadioButton rb1, RadioButton rb2)
        {
            string dataInicial = mbInicial.Text;
            string dataFinal = mbFinal.Text;
            string select;

            if (rb1.Checked)
            {
                select = $"SELECT * FROM TCLIENTE WHERE ATIVO = 'SIM' AND CAST((DATAHORACADASTRO) AS DATE) BETWEEN '{dataInicial}' AND '{dataFinal}';";
            }
            else if (rb2.Checked)
            {
                select = $"SELECT * FROM TCLIENTE WHERE ATIVO = 'NÃO' AND CAST((DATAHORACADASTRO) AS DATE) BETWEEN '{dataInicial}' AND '{dataFinal}';";
            }
            else
            {
                select = $"SELECT * FROM TCLIENTE WHERE CAST((DATAHORACADASTRO) AS DATE) BETWEEN '{dataInicial}' AND '{dataFinal}';";
            }

            return select;
        }

        public static string ExportacaoSemData(RadioButton rb1, RadioButton rb2)
        {
            string select;

            if (rb1.Checked)
            {
                select = "SELECT * FROM TCLIENTE WHERE ATIVO = 'SIM';";
            }
            else if (rb2.Checked)
            {
                select = "SELECT * FROM TCLIENTE WHERE ATIVO = 'NÃO';";
            }
            else
            {
                select = "SELECT * FROM TCLIENTE;";
            }

            return select;
        }

        public static void ExportarClientes(string select)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage pacotesExcel = new ExcelPackage())
            {
                ExcelWorksheet folha = pacotesExcel.Workbook.Worksheets.Add("Clientes");

                DataTable dtCliente = new DataTable();

                try
                {
                    string conexaoString = DB.ConectarBD();
                    using (FbConnection conexao = new FbConnection(conexaoString))
                    {
                        using (FbDataAdapter dataAdapter = new FbDataAdapter(select, conexao))
                        {
                            dataAdapter.Fill(dtCliente);

                            for (int i = 0; i < dtCliente.Columns.Count; i++)
                            {
                                folha.Cells[1, i + 1].Value = dtCliente.Columns[i].ColumnName;
                            }

                            for (int j = 0; j < dtCliente.Rows.Count; j++)
                            {
                                for (int k = 0; k < dtCliente.Columns.Count; k++)
                                {
                                    folha.Cells[j + 2, k + 1].Value = dtCliente.Rows[j][k];
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                SaveFileDialog selecaoDiretorio = new SaveFileDialog
                {
                    Title = "Selecione o diretório de salvamento: ",
                    AddExtension = true,
                    Filter = "Arquivo do Excel (*.xlsx)|*.xlsx",
                    DefaultExt = "xlsx"
                };

                try
                {
                    if (selecaoDiretorio.ShowDialog() == DialogResult.OK)
                    {
                        string diretorio = selecaoDiretorio.FileName;
                        FileInfo salvar = new FileInfo(diretorio);
                        pacotesExcel.SaveAs(salvar);
                        MessageBox.Show("Arquivo gerado com sucesso!", "Exportação de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Pelos seguintes motivos, seu arquivo poderá não ser salvo:\r\n\r\n-> Diretório incorreto, ou não informado;\r\n-> O Arquivo já se encontra em aberto;\r\n-> A pasta selecionada não possui permissão para gravação.", "Exportação de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public static void ExportarClientesGrid(DataGridView dgCliente)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage pacotesExcel = new ExcelPackage())
            {
                ExcelWorksheet folha = pacotesExcel.Workbook.Worksheets.Add("Clientes");

                // Adiciona os cabeçalhos das colunas
                for (int i = 0; i < dgCliente.Columns.Count; i++)
                {
                    folha.Cells[1, i + 1].Value = dgCliente.Columns[i].HeaderText;
                }

                // Adiciona as linhas e colunas do DataGridView
                for (int j = 0; j < dgCliente.Rows.Count; j++)
                {
                    for (int k = 0; k < dgCliente.Columns.Count; k++)
                    {
                        folha.Cells[j + 2, k + 1].Value = dgCliente.Rows[j].Cells[k].Value;
                    }
                }

                SaveFileDialog selecaoDiretorio = new SaveFileDialog
                {
                    Title = "Selecione o diretório de salvamento: ",
                    AddExtension = true,
                    Filter = "Arquivo do Excel (*.xlsx)|*.xlsx",
                    DefaultExt = "xlsx"
                };

                try
                {
                    if (selecaoDiretorio.ShowDialog() == DialogResult.OK)
                    {
                        string diretorio = selecaoDiretorio.FileName;
                        FileInfo salvar = new FileInfo(diretorio);
                        pacotesExcel.SaveAs(salvar);
                        MessageBox.Show("Arquivo gerado com sucesso!", "Exportação de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Pelos seguintes motivos, seu arquivo poderá não ser salvo:\r\n\r\n-> Diretório incorreto, ou não informado;\r\n-> O Arquivo já se encontra em aberto;\r\n-> A pasta selecionada não possui permissão para gravação.", "Exportação de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static string ProdutosComData(MaskedTextBox mbInicial, MaskedTextBox mbFinal, RadioButton rb1, RadioButton rb2)
        {
            string dataInicial = mbInicial.Text;
            string dataFinal = mbFinal.Text;
            string select;

            if (rb1.Checked)
            {
                select = $"SELECT * FROM TESTOQUE WHERE ATIVO = 'SIM' AND CAST((DATAHORACADASTRO) AS DATE) BETWEEN '{dataInicial}' AND '{dataFinal}';";
            }
            else if (rb2.Checked)
            {
                select = $"SELECT * FROM TESTOQUE WHERE ATIVO = 'NÃO' AND CAST((DATAHORACADASTRO) AS DATE) BETWEEN '{dataInicial}' AND '{dataFinal}';";
            }
            else
            {
                select = $"SELECT * FROM TESTOQUE WHERE CAST((DATAHORACADASTRO) AS DATE) BETWEEN '{dataInicial}' AND '{dataFinal}';";
            }

            return select;
        }

        public static string ProdutosSemData(RadioButton rb1, RadioButton rb2)
        {
            string select;

            if (rb1.Checked)
            {
                select = "SELECT * FROM TESTOQUE WHERE ATIVO = 'SIM';";
            }
            else if (rb2.Checked)
            {
                select = "SELECT * FROM TESTOQUE WHERE ATIVO = 'NÃO';";
            }
            else
            {
                select = "SELECT * FROM TESTOQUE;";
            }

            return select;
        }

        public static void ExportarProdutos(string select)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage pacotesExcel = new ExcelPackage())
            {
                ExcelWorksheet folha = pacotesExcel.Workbook.Worksheets.Add("Estoque");

                DataTable dtEstoque = new DataTable();

                try
                {
                    string conexaoString = DB.ConectarBD();
                    using (FbConnection conexao = new FbConnection(conexaoString))
                    {
                        using (FbDataAdapter dataAdapter = new FbDataAdapter(select, conexao))
                        {
                            dataAdapter.Fill(dtEstoque);

                            for (int i = 0; i < dtEstoque.Columns.Count; i++)
                            {
                                folha.Cells[1, i + 1].Value = dtEstoque.Columns[i].ColumnName;
                            }

                            for (int j = 0; j < dtEstoque.Rows.Count; j++)
                            {
                                for (int k = 0; k < dtEstoque.Columns.Count; k++)
                                {
                                    folha.Cells[j + 2, k + 1].Value = dtEstoque.Rows[j][k];
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                SaveFileDialog selecaoDiretorio = new SaveFileDialog
                {
                    Title = "Selecione o diretório de salvamento: ",
                    AddExtension = true,
                    Filter = "Arquivo do Excel (*.xlsx)|*.xlsx",
                    DefaultExt = "xlsx"
                };

                try
                {
                    if (selecaoDiretorio.ShowDialog() == DialogResult.OK)
                    {
                        string diretorio = selecaoDiretorio.FileName;
                        FileInfo salvar = new FileInfo(diretorio);
                        pacotesExcel.SaveAs(salvar);
                        MessageBox.Show("Arquivo gerado com sucesso!", "Exportação de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Pelos seguintes motivos, seu arquivo poderá não ser salvo:\r\n\r\n-> Diretório incorreto, ou não informado;\r\n-> O Arquivo já se encontra em aberto;\r\n-> A pasta selecionada não possui permissão para gravação.", "Exportação de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }


        public static void ExportarProdutosGrid(DataGridView dgEstoque)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage pacotesExcel = new ExcelPackage())
            {
                ExcelWorksheet folha = pacotesExcel.Workbook.Worksheets.Add("Clientes");
                for (int i = 0; i < dgEstoque.Columns.Count; i++)
                {
                    folha.Cells[1, i + 1].Value = dgEstoque.Columns[i].HeaderText;
                }

                for (int j = 0; j < dgEstoque.Rows.Count; j++)
                {
                    for (int k = 0; k < dgEstoque.Columns.Count; k++)
                    {
                        folha.Cells[j + 2, k + 1].Value = dgEstoque.Rows[j].Cells[k].Value;
                    }
                }

                SaveFileDialog selecaoDiretorio = new SaveFileDialog
                {
                    Title = "Selecione o diretório de salvamento: ",
                    AddExtension = true,
                    Filter = "Arquivo do Excel (*.xlsx)|*.xlsx",
                    DefaultExt = "xlsx"
                };

                try
                {
                    if (selecaoDiretorio.ShowDialog() == DialogResult.OK)
                    {
                        string diretorio = selecaoDiretorio.FileName;
                        FileInfo salvar = new FileInfo(diretorio);
                        pacotesExcel.SaveAs(salvar);
                        MessageBox.Show("Arquivo gerado com sucesso!", "Exportação de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Pelos seguintes motivos, seu arquivo poderá não ser salvo:\r\n\r\n-> Diretório incorreto, ou não informado;\r\n-> O Arquivo já se encontra em aberto;\r\n-> A pasta selecionada não possui permissão para gravação.", "Exportação de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void ExportarFornecedoresGrid(DataGridView dgFornecedor)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage pacotesExcel = new ExcelPackage())
            {
                ExcelWorksheet folha = pacotesExcel.Workbook.Worksheets.Add("Clientes");
                for (int i = 0; i < dgFornecedor.Columns.Count; i++)
                {
                    folha.Cells[1, i + 1].Value = dgFornecedor.Columns[i].HeaderText;
                }

                for (int j = 0; j < dgFornecedor.Rows.Count; j++)
                {
                    for (int k = 0; k < dgFornecedor.Columns.Count; k++)
                    {
                        folha.Cells[j + 2, k + 1].Value = dgFornecedor.Rows[j].Cells[k].Value;
                    }
                }

                SaveFileDialog selecaoDiretorio = new SaveFileDialog
                {
                    Title = "Selecione o diretório de salvamento: ",
                    AddExtension = true,
                    Filter = "Arquivo do Excel (*.xlsx)|*.xlsx",
                    DefaultExt = "xlsx"
                };

                try
                {
                    if (selecaoDiretorio.ShowDialog() == DialogResult.OK)
                    {
                        string diretorio = selecaoDiretorio.FileName;
                        FileInfo salvar = new FileInfo(diretorio);
                        pacotesExcel.SaveAs(salvar);
                        MessageBox.Show("Arquivo gerado com sucesso!", "Exportação de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Pelos seguintes motivos, seu arquivo poderá não ser salvo:\r\n\r\n-> Diretório incorreto, ou não informado;\r\n-> O Arquivo já se encontra em aberto;\r\n-> A pasta selecionada não possui permissão para gravação.", "Exportação de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void ImportarClientes() {
            OpenFileDialog selecaoDiretorio = new OpenFileDialog
            {
                Title = "Selecione o diretório de salvamento: ",
                AddExtension = true,
                Filter = "Arquivo do Excel (*.xlsx)|*.xlsx",
                DefaultExt = "xlsx"
            };

            string diretorio = "";
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                if (selecaoDiretorio.ShowDialog() == DialogResult.OK)
                {
                    diretorio = @selecaoDiretorio.FileName;
                    string stringConexao = DB.ConectarBD();

                    FileInfo fileInfo = new FileInfo(diretorio);
                    using (ExcelPackage excelPackage = new ExcelPackage(fileInfo))
                    {
                        ExcelWorksheet planilhaExcel = excelPackage.Workbook.Worksheets[0];
                        int totalLinhas = planilhaExcel.Dimension.Rows;

                        using (FbConnection conexao = new FbConnection(stringConexao))
                        {
                                Clientes clienteCadastro = new Clientes();
                                clienteCadastro.Cpf = "NULL";
                                clienteCadastro.Cnpj = "NULL";

                                if (planilhaExcel.Cells[i, 3].Value != null || planilhaExcel.Cells[i, 4].Value == null)
                                {
                                    clienteCadastro.Cnpj = "'" + planilhaExcel.Cells[i, 3].Value.ToString().Trim().ToUpper() + "'";
                                    clienteCadastro.Cpf = "NULL";
                                    clienteCadastro.Tipo = "JURÍDICA";
                                }
                                else if (planilhaExcel.Cells[i, 4].Value != null || planilhaExcel.Cells[i, 3].Value == null)
                                {
                                    clienteCadastro.Cpf = "'" + planilhaExcel.Cells[i, 4].Value.ToString().Trim().ToUpper() + "'";
                                    clienteCadastro.Cnpj = "NULL";
                                    clienteCadastro.Tipo = "FÍSICA";
                                }
                                else {
                                    MessageBox.Show("Cliente não pode ter CPF e CNPJ Nulos!");
                                    break;
                                }
                                
                                string cliente = planilhaExcel.Cells[i, 1].Value.ToString().Trim().ToUpper();
                                string fantasia = planilhaExcel.Cells[i, 2].Value?.ToString().Trim().ToUpper() ?? string.Empty;
                                string rg = planilhaExcel.Cells[i, 5].Value?.ToString().Trim().ToUpper() ?? string.Empty;
                                string endereco = planilhaExcel.Cells[i, 6].Value?.ToString().Trim().ToUpper() ?? string.Empty;
                                string complemento = planilhaExcel.Cells[i, 7].Value?.ToString().Trim().ToUpper() ?? string.Empty;
                                string bairro = planilhaExcel.Cells[i, 8].Value?.ToString().Trim().ToUpper() ?? string.Empty;
                                string cep = planilhaExcel.Cells[i, 9].Value?.ToString().Trim().ToUpper() ?? string.Empty;
                                string numero = planilhaExcel.Cells[i, 10].Value?.ToString().Trim().ToUpper() ?? string.Empty;
                                string municipio = planilhaExcel.Cells[i, 11].Value?.ToString().Trim().ToUpper() ?? string.Empty;
                                string uf = planilhaExcel.Cells[i, 12].Value?.ToString().Trim().ToUpper() ?? string.Empty;
                                string telefone = planilhaExcel.Cells[i, 13].Value?.ToString().Trim().ToUpper() ?? string.Empty;
                                string email = planilhaExcel.Cells[i, 14].Value?.ToString().Trim().ToUpper() ?? string.Empty;

                                string insert = $@"INSERT INTO TCLIENTE (CLIENTE, DATAHORACADASTRO, ATIVO, FANTASIA,
                                CNPJ, CPF, RG, ENDERECO, COMPLEMENTO, BAIRRO, CEP, NUMERO, CIDADE, UF, TELEFONE, EMAIL, PAIS, TIPOCLIENTE, CODIGOPAIS) 
                                VALUES ('{cliente}', '{DateTime.Now}', 'SIM', '{fantasia}', {clienteCadastro.Cnpj}, {clienteCadastro.Cpf}, '{rg}', '{endereco}',
                                '{complemento}', '{bairro}', '{cep}', '{numero}', '{municipio}', '{uf}', '{telefone}', '{email}', 'BRASIL', '{clienteCadastro.Tipo}', '1058')";

                                using (FbCommand comando = new FbCommand(insert, conexao))
                                {
                                    comando.ExecuteNonQuery();
                                    conexao.Close();
                                }
                            }
                            MessageBox.Show("Dados Importados com sucesso!", "Importação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else {
                    MessageBox.Show("Diretório não selecionado!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }

            
        }

        public static void ImportarFornecedor()
        {
            OpenFileDialog selecaoDiretorio = new OpenFileDialog
            {
                Title = "Selecione o diretório de salvamento: ",
                AddExtension = true,
                Filter = "Arquivo do Excel (*.xlsx)|*.xlsx",
                DefaultExt = "xlsx"
            };

            string diretorio = "";
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                if (selecaoDiretorio.ShowDialog() == DialogResult.OK)
                {
                    diretorio = @selecaoDiretorio.FileName;
                    string stringConexao = DB.ConectarBD();

                    FileInfo fileInfo = new FileInfo(diretorio);
                    using (ExcelPackage excelPackage = new ExcelPackage(fileInfo))
                    {
                        ExcelWorksheet planilhaExcel = excelPackage.Workbook.Worksheets[0];
                        int totalLinhas = planilhaExcel.Dimension.Rows;

                        using (FbConnection conexao = new FbConnection(stringConexao))
                        {
                            for (int i = 2; i <= totalLinhas; i++)
                            {
                                conexao.Open();
                                Fornecedor fornecedorCadastro = new Fornecedor();
                                fornecedorCadastro.Cpf = "NULL";
                                fornecedorCadastro.Cnpj = "NULL";

                                if (planilhaExcel.Cells[i, 3].Value != null || planilhaExcel.Cells[i, 4].Value == null)
                                {
                                    fornecedorCadastro.Cnpj = "'" + planilhaExcel.Cells[i, 3].Value.ToString().Trim().ToUpper() + "'";
                                    fornecedorCadastro.Cpf = "NULL";
                                    fornecedorCadastro.Ie = "'" + planilhaExcel.Cells[i, 5].Value?.ToString().Trim().ToUpper() + "'";
                                    fornecedorCadastro.Rg = "NULL";
                                }
                                else if (planilhaExcel.Cells[i, 4].Value != null || planilhaExcel.Cells[i, 3].Value == null)
                                {
                                    fornecedorCadastro.Cpf = "'" + planilhaExcel.Cells[i, 4].Value.ToString().Trim().ToUpper() + "'";
                                    fornecedorCadastro.Cnpj = "NULL";
                                    fornecedorCadastro.Rg = "'" + planilhaExcel.Cells[i, 5].Value?.ToString().Trim().ToUpper() + "'";
                                    fornecedorCadastro.Ie = "NULL";
                                }
                                else
                                {
                                    MessageBox.Show("Fornecedor não pode ter CPF e CNPJ Nulos!");
                                    break;
                                }

                                string razaosocial = planilhaExcel.Cells[i, 1].Value.ToString().Trim().ToUpper();
                                string fantasia = planilhaExcel.Cells[i, 2].Value?.ToString().Trim().ToUpper() ?? string.Empty;
                                string endereco = planilhaExcel.Cells[i, 6].Value?.ToString().Trim().ToUpper() ?? string.Empty;
                                string complemento = planilhaExcel.Cells[i, 7].Value?.ToString().Trim().ToUpper() ?? string.Empty;
                                string bairro = planilhaExcel.Cells[i, 8].Value?.ToString().Trim().ToUpper() ?? string.Empty;
                                string cep = planilhaExcel.Cells[i, 9].Value?.ToString().Trim().ToUpper() ?? string.Empty;
                                string numero = planilhaExcel.Cells[i, 10].Value?.ToString().Trim().ToUpper() ?? string.Empty;
                                string municipio = planilhaExcel.Cells[i, 11].Value?.ToString().Trim().ToUpper() ?? string.Empty;
                                string uf = planilhaExcel.Cells[i, 12].Value?.ToString().Trim().ToUpper() ?? string.Empty;
                                string telefone = planilhaExcel.Cells[i, 13].Value?.ToString().Trim().ToUpper() ?? string.Empty;
                                string email = planilhaExcel.Cells[i, 14].Value?.ToString().Trim().ToUpper() ?? string.Empty;

                                string insert = $@"INSERT INTO TFORNECEDOR (RAZAOSOCIAL, DATAHORACADASTRO, ATIVO, NOMEFANTASIA,
                                CNPJ, CPF, RG, ENDERECO, COMPLEMENTO, BAIRRO, CEP, NUMERO, CIDADE, UF, TELEFONE, EMAIL, PAIS, CODIGOPAIS, IE) 
                                VALUES ('{razaosocial}', '{DateTime.Now}', 'SIM', '{fantasia}', {fornecedorCadastro.Cnpj}, {fornecedorCadastro.Cpf}, {fornecedorCadastro.Rg}, '{endereco}',
                                '{complemento}', '{bairro}', '{cep}', '{numero}', '{municipio}', '{uf}', '{telefone}', '{email}', 'BRASIL', '1058', {fornecedorCadastro.Ie})";

                                using (FbCommand comando = new FbCommand(insert, conexao))
                                {
                                    comando.ExecuteNonQuery();
                                    conexao.Close();
                                }
                            }
                            MessageBox.Show("Dados Importados com sucesso!", "Importação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Diretório não selecionado!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
    }
}