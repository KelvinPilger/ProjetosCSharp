using LavaK;
using ServFacil.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ServFacil.Forms
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                var listaClientesFornecedores = context.CLIENTE_FORNECEDOR.
                    ToList();

                dgvClienteFornecedor.DataSource = listaClientesFornecedores;
            }
        }

        private void btnIncluir_MouseLeave(object sender, EventArgs e)
        {
            Cores.passouMouse = true;
            Cores.MudarCor(btnIncluir);
        }

        private void btnIncluir_MouseEnter(object sender, EventArgs e)
        {
            Cores.passouMouse = false;
            Cores.MudarCor(btnIncluir);
        }

        private void btnAlterar_MouseLeave(object sender, EventArgs e)
        {
            Cores.passouMouse = true;
            Cores.MudarCor(btnAlterar);
        }

        private void btnAlterar_MouseEnter(object sender, EventArgs e)
        {
            Cores.passouMouse = false;
            Cores.MudarCor(btnAlterar);
        }

        private void btnGravar_MouseLeave(object sender, EventArgs e)
        {
            Cores.passouMouse = true;
            Cores.MudarCor(btnGravar);
        }

        private void btnGravar_MouseEnter(object sender, EventArgs e)
        {
            Cores.passouMouse = false;
            Cores.MudarCor(btnGravar);
        }

        private void btnExcluir_MouseLeave(object sender, EventArgs e)
        {
            Cores.passouMouse = true;
            Cores.MudarCor(btnExcluir);
        }

        private void btnExcluir_MouseEnter(object sender, EventArgs e)
        {
            Cores.passouMouse = false;
            Cores.MudarCor(btnExcluir);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            frmCadastroCliente frmCCliente = new frmCadastroCliente();
            frmCCliente.ShowDialog();
            frmCliente frmCliente = new frmCliente();
            frmCliente.Dispose();
        }
    }
}
