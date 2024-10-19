using LavaK.Classes;
using LavaK.Forms;
using ServFacil.Classes;
using ServFacil.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LavaK
{
    public partial class frmMenu : Form
    { 
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            FdbGeral.PegaDiretorio();
        }


        private void btnCliente_MouseLeave(object sender, EventArgs e)
        {
            Cores.passouMouse = true;
            Cores.MudarCor(btnCliente);
        }

        private void btnCliente_MouseEnter(object sender, EventArgs e)
        {
            Cores.passouMouse = false;
            Cores.MudarCor(btnCliente);
        }

        private void btnVeiculo_MouseLeave(object sender, EventArgs e)
        {
            Cores.passouMouse = true;
            Cores.MudarCor(btnVeiculo);
        }

        private void btnVeiculo_MouseEnter(object sender, EventArgs e)
        {
            Cores.passouMouse = false;
            Cores.MudarCor(btnVeiculo);
        }

        private void btnFornecedor_MouseLeave(object sender, EventArgs e)
        {
            Cores.passouMouse = true;
            Cores.MudarCor(btnFornecedor);
        }

        private void btnFornecedor_MouseEnter(object sender, EventArgs e)
        {
            Cores.passouMouse = false;
            Cores.MudarCor(btnFornecedor);
        }

        private void btnFinanceiro_MouseLeave(object sender, EventArgs e)
        {
            Cores.passouMouse = true;
            Cores.MudarCor(btnFinanceiro);
        }

        private void btnFinanceiro_MouseEnter(object sender, EventArgs e)
        {
            Cores.passouMouse = false;
            Cores.MudarCor(btnFinanceiro);
        }

        private void btnUsuario_MouseLeave(object sender, EventArgs e)
        {
            Cores.passouMouse = true;
            Cores.MudarCor(btnUsuario);
        }

        private void btnUsuario_MouseEnter(object sender, EventArgs e)
        {
            Cores.passouMouse = false;
            Cores.MudarCor(btnUsuario);
        }

        private void btnEstoque_MouseLeave(object sender, EventArgs e)
        {
            Cores.passouMouse = true;
            Cores.MudarCor(btnEstoque);
        }

        private void btnEstoque_MouseEnter(object sender, EventArgs e)
        {
            Cores.passouMouse = false;
            Cores.MudarCor(btnEstoque);
        }

        private void btnEspecie_MouseLeave(object sender, EventArgs e)
        {
            Cores.passouMouse = true;
            Cores.MudarCor(btnEspecie);
        }

        private void btnEspecie_MouseEnter(object sender, EventArgs e)
        {
            Cores.passouMouse = false;
            Cores.MudarCor(btnEspecie);
        }

        private void btnServico_MouseLeave(object sender, EventArgs e)
        {
            Cores.passouMouse = true;
            Cores.MudarCor(btnServico);
        }

        private void btnServico_MouseEnter(object sender, EventArgs e)
        {
            Cores.passouMouse = false;
            Cores.MudarCor(btnServico);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            frmConfiguracao frmConfig = new frmConfiguracao();
            frmConfig.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente();
            frmCliente.ShowDialog();
        }
    }
}
