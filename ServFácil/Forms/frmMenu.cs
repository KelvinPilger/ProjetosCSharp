using LavaK.Forms;
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
        private bool passouMouse;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
        }

        private void MudarCor(Button btn)
        {
            if (!passouMouse)
            {
                btn.BackColor = Color.FromArgb(255, 251, 254);
                btn.ForeColor = Color.Black;
            }
            else
            {
                btn.BackColor = Color.Black;
                btn.ForeColor = Color.FromArgb(255, 251, 254);
            }
           
        }

        private void btnCliente_MouseLeave(object sender, EventArgs e)
        {
            passouMouse = true;
            MudarCor(btnCliente);
        }

        private void btnCliente_MouseEnter(object sender, EventArgs e)
        {
            passouMouse = false;
            MudarCor(btnCliente);
        }

        private void btnVeiculo_MouseLeave(object sender, EventArgs e)
        {
            passouMouse = true;
            MudarCor(w);
        }

        private void btnVeiculo_MouseEnter(object sender, EventArgs e)
        {
            passouMouse = false;
            MudarCor(w);
        }

        private void btnFornecedor_MouseLeave(object sender, EventArgs e)
        {
            passouMouse = true;
            MudarCor(btnFornecedor);
        }

        private void btnFornecedor_MouseEnter(object sender, EventArgs e)
        {
            passouMouse = false;
            MudarCor(btnFornecedor);
        }

        private void btnFinanceiro_MouseLeave(object sender, EventArgs e)
        {
            passouMouse = true;
            MudarCor(btnFinanceiro);
        }

        private void btnFinanceiro_MouseEnter(object sender, EventArgs e)
        {
            passouMouse = false;
            MudarCor(btnFinanceiro);
        }

        private void btnUsuario_MouseLeave(object sender, EventArgs e)
        {
            passouMouse = true;
            MudarCor(btnUsuario);
        }

        private void btnUsuario_MouseEnter(object sender, EventArgs e)
        {
            passouMouse = false;
            MudarCor(btnUsuario);
        }

        private void btnEstoque_MouseLeave(object sender, EventArgs e)
        {
            passouMouse = true;
            MudarCor(btnEstoque);
        }

        private void btnEstoque_MouseEnter(object sender, EventArgs e)
        {
            passouMouse = false;
            MudarCor(btnEstoque);
        }

        private void btnEspecie_MouseLeave(object sender, EventArgs e)
        {
            passouMouse = true;
            MudarCor(btnEspecie);
        }

        private void btnEspecie_MouseEnter(object sender, EventArgs e)
        {
            passouMouse = false;
            MudarCor(btnEspecie);
        }

        private void btnServico_MouseLeave(object sender, EventArgs e)
        {
            passouMouse = true;
            MudarCor(btnServico);
        }

        private void btnServico_MouseEnter(object sender, EventArgs e)
        {
            passouMouse = false;
            MudarCor(btnServico);
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
