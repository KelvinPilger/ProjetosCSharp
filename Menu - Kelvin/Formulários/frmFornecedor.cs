using Menu___Kelvin.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu___Kelvin
{
    public partial class frmFornecedor : Form
    {
        public frmFornecedor()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    if (cbDatas.Checked)
                    {
                        DB.SelecionaFornecedor(dgFornecedor, cbTodosFornecedores);
                    }
                    else
                    {
                        DB.SelecionaFornecedor(dgFornecedor, cbTodosFornecedores, dtpInicial, dtpFinal);
                    }
                    break;
                case Keys.F2:
                    if (cbTodosFornecedores.Checked == false)
                    {
                        cbTodosFornecedores.Checked = true;
                    }
                    else
                    {
                        cbTodosFornecedores.Checked = false;
                    }
                    break;
                case Keys.F3:
                    if (cbDatas.Checked == false)
                    {
                        cbDatas.Checked = true;
                    }
                    else
                    {
                        cbDatas.Checked = false;
                    }
                    break;
                case Keys.F4:
                    AltForms.OpenFrmExportacaoCliente();
                    break;
                case Keys.F5:
                    Planilhas.ImportarFornecedor();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            dtpInicial.Format = DateTimePickerFormat.Short;
            dtpFinal.Format = DateTimePickerFormat.Short;
            DateTime dtPrimeiroDiaMes = new DateTime(DateTime.Now.Year - 1, DateTime.Now.Month, 1);
            dtpInicial.Value = dtPrimeiroDiaMes;
            dtpFinal.Value = DateTime.Now;
            // Predefinição da data inicial/final (Datas, Formato)

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 165);
            // Posição do Formulário Clientes ao Abrir
            cbDatas.Checked = true;

            DB.SelecionaFornecedor(dgFornecedor, cbTodosFornecedores);
            dgFornecedor.Focus();
        }

        private void btnAtualizarFornecedor_Click(object sender, EventArgs e)
        {

                if (cbDatas.Checked)
                {
                    DB.SelecionaFornecedor(dgFornecedor, cbTodosFornecedores);
                    dgFornecedor.Focus();
            }
                else
                {
                    DB.SelecionaFornecedor(dgFornecedor, cbTodosFornecedores, dtpInicial, dtpFinal);
                    dgFornecedor.Focus();
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            Planilhas.ImportarFornecedor();
        }

        private void exportarDadosDaGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planilhas.ExportarFornecedoresGrid(dgFornecedor);
        }
    }
}
