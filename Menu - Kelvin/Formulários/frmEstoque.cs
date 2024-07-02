using Menu___Kelvin.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu___Kelvin
{
    public partial class frmEstoque : Form
    {
        public frmEstoque()
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
                        DB.SelecionaProduto(dgEstoque, cbTodosClientes);
                    }
                    else
                    {
                        DB.SelecionaProduto(dgEstoque, cbTodosClientes, dtpInicial, dtpFinal);
                    }
                    break;
                case Keys.F2:
                    if (cbTodosClientes.Checked == false)
                    {
                        cbTodosClientes.Checked = true;
                    }
                    else
                    {
                        cbTodosClientes.Checked = false;
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
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void frmEstoque_Load(object sender, EventArgs e)
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
                DB.SelecionaProduto(dgEstoque, cbTodosClientes);
                dgEstoque.Focus();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            AltForms.OpenFrmExportacaoCliente();
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planilhas.ExportarClientesGrid(dgEstoque);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            AltForms.CloseFrmEstoque(this);
        }

        private void btnAtualizarCliente_Click(object sender, EventArgs e)
        { 
            if (cbDatas.Checked)
            {
                DB.SelecionaProduto(dgEstoque, cbTodosClientes);
                dgEstoque.Focus();
            }
            else
            {
                DB.SelecionaProduto(dgEstoque, cbTodosClientes, dtpInicial, dtpFinal);
                dgEstoque.Focus();
            }
        }
    }
}
