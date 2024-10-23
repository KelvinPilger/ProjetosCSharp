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
        public static string origem = "Incluir";
        public frmCadastroCliente()
        {
            InitializeComponent();
            mtbCpf.Mask = "000.000.000-00";
            mtbCnpj.Mask = "00.000.000/0000-00";
        }
        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
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

            if (frmCliente.id != 0)
            {

                using (var context = new MyDbContext())
                {
                    var cliente = context.CLIENTE_FORNECEDOR.FirstOrDefault(c => c.ID == frmCliente.id);

                    if (cliente.SEXO == 'M')
                    {
                        cbxSexo.SelectedIndex = 0;
                    }
                    else
                    {
                        cbxSexo.SelectedIndex = 1;
                    }

                    if (cliente.CAD_NACIONAL == 'F')
                    {
                        cbxTipo.SelectedIndex = 0;
                        cbxTipo.Enabled = false;
                        mtbIe.Enabled = false;
                        mtbCnpj.Enabled = false;
                    }
                    else
                    {
                        cbxTipo.SelectedIndex = 1;
                        cbxTipo.Enabled = false;
                        mtbCpf.Enabled = false;
                    }

                    if (cliente != null)
                    {
                        lblInfo.Text = "ID: " + frmCliente.id +
                    "\n\nData e Hora do Cadastro:\n" + 
                    cliente.DT_HR_CADASTRO;
                        tbxNome.Text = cliente.NOME;
                        mtbCpf.Text = cliente.CPF;
                        mtbCnpj.Text = cliente.CNPJ;
                        mtbIe.Text = cliente.IE;
                        mtbCelular.Text = cliente.CELULAR;
                        mtbTelefone.Text = cliente.TELEFONE;
                        tbxEmail.Text = cliente.EMAIL;
                        tbxEmailDois.Text = cliente.EMAIL_DOIS;
                        tbxSite.Text = cliente.SITE;
                        tbxBairro.Text = cliente.BAIRRO;
                        mtbCep.Text = cliente.CEP;
                        tbxCidade.Text = cliente.CIDADE;
                        tbxRua.Text = cliente.RUA;
                        tbxPais.Text = cliente.PAIS;
                        tbxNumero.Text = cliente.NUMERO;
                        cbxUf.Text = cliente.UF;
                    }
                }
            }
            else { 
                lblInfo.Text = string.Empty;
            }
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
            if (frmCliente.id == 0 && frmCadastroCliente.origem == "Incluir")
            {
                if (!string.IsNullOrEmpty(tbxNome.Text))
                {
                    if (mtbCpf.MaskFull || mtbCnpj.MaskFull)
                    {
                        if (mtbCelular.MaskFull)
                        {
                            if (mtbCep.MaskFull)
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
                                            SITE = tbxSite.Text,
                                            NUMERO = tbxNumero.Text.ToUpper()
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
                                    }
                                }
                                catch (Exception ex)
                                {
                                    var innerException = ex.InnerException != null ? ex.InnerException.Message : "Nenhuma exceção interna";

                                    MessageBox.Show($"Erro ao salvar no banco de dados: {ex.Message}\nInner Exception: {innerException}\n{ex.StackTrace}");
                                }
                            }
                            else
                            {
                                frmMensagem msg = new frmMensagem("CEP não informado!");
                                msg.ShowDialog();
                            }
                        }
                        else
                        {
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

            else if (frmCliente.id != 0 && frmCadastroCliente.origem == "Alterar") {
                if (!string.IsNullOrEmpty(tbxNome.Text))
                {
                    if (mtbCpf.MaskFull || mtbCnpj.MaskFull)
                    {
                        if (mtbCelular.MaskFull)
                        {
                            if (mtbCep.MaskFull)
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
                                        var ac = cliente.CLIENTE_FORNECEDOR.FirstOrDefault(cf => cf.ID == frmCliente.id);

                                            ac.NOME = tbxNome.Text.ToUpper();
                                            ac.SEXO = sexo;
                                            ac.CLI_FORN = 'C';
                                            ac.PAIS = tbxPais.Text.ToUpper();
                                            ac.UF = cbxUf.Text.ToUpper();
                                            ac.CIDADE = tbxCidade.Text.ToUpper();
                                            ac.BAIRRO = tbxBairro.Text.ToUpper();
                                            ac.RUA = tbxRua.Text.ToUpper();
                                            ac.CEP = mtbCep.Text.ToUpper();
                                            ac.CELULAR = mtbCelular.Text.ToUpper();
                                            ac.CEP = mtbCep.Text.ToUpper();
                                            ac.DT_NASCIMENTO = DateTime.Today;
                                            ac.DT_HR_CADASTRO = DateTime.Now;
                                            ac.TELEFONE = mtbTelefone.Text.ToUpper();
                                            ac.EMAIL = tbxEmail.Text;
                                            ac.EMAIL_DOIS = tbxEmailDois.Text;
                                            ac.SITE = tbxSite.Text;

                                            if (mtbCpf.MaskFull)
                                            {
                                                ac.CAD_NACIONAL = 'F';
                                                ac.CPF = Cpf.ToUpper();
                                            }
                                            else if (mtbCnpj.MaskFull)
                                            {
                                                ac.CAD_NACIONAL = 'J';
                                                ac.CNPJ = Cnpj.ToUpper();

                                                if (mtbIe.MaskFull)
                                                {
                                                    ac.IE = Ie.ToUpper();
                                                }
                                            }

                                            cliente.SaveChanges();

                                        frmCliente.id = 0;

                                        foreach (Control control in this.Controls)
                                        {
                                            if (control is TextBox tbx)
                                            {

                                                tbx.Text = "";
                                            }
                                        }
                                    };
                                }
                                catch (Exception ex)
                                {
                                    var innerException = ex.InnerException != null ? ex.InnerException.Message : "Nenhuma exceção interna";

                                    MessageBox.Show($"Erro ao salvar no banco de dados: {ex.Message}\nInner Exception: {innerException}\n{ex.StackTrace}");
                                }
                            }
                            else
                            {
                                frmMensagem msg = new frmMensagem("CEP não informado!");
                                msg.ShowDialog();
                            }
                        }
                        else
                        {
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
                    frmMensagem msg = new frmMensagem("Nome do cliente não preenchido!");
                    msg.ShowDialog();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
