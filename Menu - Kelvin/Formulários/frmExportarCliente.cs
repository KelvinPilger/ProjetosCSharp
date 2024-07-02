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

namespace Menu___Kelvin.Formulários
{
    public partial class frmExportarCliente : Form
    {
        public frmExportarCliente()
        {
            InitializeComponent();
        }

        private void frmExportarCliente_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(450, 250);
            cbDatas.Checked = true;
            rbTodos.Checked = true;
            DateTime dtPrimeiroDiaMes = new DateTime(DateTime.Now.Year - 1, DateTime.Now.Month, 1);
            mtbInicial.Text = dtPrimeiroDiaMes.ToShortDateString();
            mtbFinal.Text = DateTime.Now.ToShortDateString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AltForms.CloseFrmExportacaoCliente(this);
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (!AltForms.FormAberto("frmCliente")) {
                string select;
                if (cbDatas.Checked == false)
                {
                    select = Planilhas.ExportacaoComData(mtbInicial, mtbFinal, rbAtivo, rbInativo);
                    Planilhas.ExportarClientes(select);
                }
                else
                {
                    select = Planilhas.ExportacaoSemData(rbAtivo, rbInativo);
                    Planilhas.ExportarClientes(select);
                }
                this.Dispose();
                this.Close();
            } else if (!AltForms.FormAberto("frmEstoque")) {
                string select;
                if (cbDatas.Checked == false)
                {
                    select = Planilhas.ExportacaoComData(mtbInicial, mtbFinal, rbAtivo, rbInativo);
                    Planilhas.ExportarClientes(select);
                }
                else
                {
                    select = Planilhas.ExportacaoSemData(rbAtivo, rbInativo);
                    Planilhas.ExportarClientes(select);
                }
                this.Dispose();
                this.Close();
            }
            
        }
    }
}
