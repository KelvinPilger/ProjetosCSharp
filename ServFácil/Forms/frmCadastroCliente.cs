using ServFacil.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ServFacil.Forms
{
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
            mtbCpf.Mask = "000.000.000-00";
            mtbCnpj.Mask = "00.000.000/0000-00";
        }
        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            cbxTipo.SelectedIndex = 0;
            cbxSexo.SelectedIndex = 0;
            ComponenteLeave(this, e);

            tbxBairro.MaxLength = 100;
            tbxCidade.MaxLength = 100;
            tbxPais.MaxLength = 100;
            tbxRua.MaxLength = 100;
            tbxEmail.MaxLength = 75;
            tbxEmailDois.MaxLength = 75;
            tbxSite.MaxLength = 75;
            tbxNumero.MaxLength = 10;

        }

        private void ComponenteLeave(object sender, EventArgs e) {
            if (cbxTipo.SelectedIndex == 0)
            {
                mtbCpf.Enabled = true;
                mtbCnpj.Enabled = false;
                mtbIe.Enabled = false;
            }
            else
            {
                mtbCpf.Enabled = false;
                mtbCnpj.Enabled = true;
                mtbIe.Enabled = true;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxNome.Text))
            {
                if (mtbCpf.MaskFull || mtbCnpj.MaskFull)
                {
                    if (mtbCelular.MaskFull)
                    {
                        char sexo;
                        string Cnpj = null, Cpf = null, Ie = null;

                        if (mtbCnpj.MaskFull && !mtbCpf.MaskFull)
                        {
                            Cnpj = mtbCnpj.Text;
                            Ie = mtbIe.MaskFull ? mtbIe.Text : null;
                        }
                        else if (mtbCpf.MaskFull && !mtbCnpj.MaskFull)
                        {
                            Cpf = mtbCpf.Text;
                        }

                    sexo = cbxSexo.SelectedIndex == 0 ? 'M' : 'F';

                        try
                        {
                            using (var cliente = new MyDbContext())
                            {
                                var novoCliente = new Cliente_Fornecedor
                                {
                                    NOME = tbxNome.Text.ToUpper(),
                                    SEXO = sexo,
                                    CLI_FORN = 'C',
                                    PAIS = tbxPais.Text.ToUpper(),
                                    UF = cbxUf.Text.ToUpper(),
                                    CIDADE = tbxCidade.Text.ToUpper(),
                                    BAIRRO = tbxBairro.Text.ToUpper(),
                                    RUA = tbxRua.Text.ToUpper(),
                                    CEP = mtbCep.Text.ToUpper(),
                                    CELULAR = mtbCelular.Text.ToUpper(),
                                    DT_NASCIMENTO = DateTime.Today,
                                    DT_HR_CADASTRO = DateTime.Now,
                                    TELEFONE = mtbTelefone.Text.ToUpper(),
                                    EMAIL = tbxEmail.Text,
                                    EMAIL_DOIS = tbxEmailDois.Text,
                                    SITE = tbxSite.Text
                                };


                                if (mtbCpf.MaskFull)
                                {
                                    novoCliente.CAD_NACIONAL = 'F';
                                    novoCliente.CPF = Cpf.ToUpper();
                                }
                                else if (mtbCnpj.MaskFull)
                                {
                                    novoCliente.CAD_NACIONAL = 'J';
                                    novoCliente.CNPJ = Cnpj.ToUpper();

                                    if (mtbIe.MaskFull)
                                    {
                                        novoCliente.IE = Ie.ToUpper();
                                    }
                                }

                                cliente.Add(novoCliente);
                                cliente.SaveChanges();

                                MessageBox.Show("Registro inserido com sucesso!");
                            }
                        }
                        catch (Exception ex)
                        {
                            var innerException = ex.InnerException != null ? ex.InnerException.Message : "Nenhuma exceção interna";

                            MessageBox.Show($"Erro ao salvar no banco de dados: {ex.Message}\nInner Exception: {innerException}\n{ex.StackTrace}");
                        }
                    }
                    else {
                        frmMensagem msg = new frmMensagem("Celular não preenchido!");
                        msg.ShowDialog();
                    }
                }

                else
                {
                    frmMensagem msg = new frmMensagem("CPF/CNPJ não preenchido!");
                    msg.ShowDialog();
                }
            }
            else
            {
                frmMensagem msg = new frmMensagem("Nome não preenchido!");
                msg.ShowDialog();
            }
        }
    }
}
