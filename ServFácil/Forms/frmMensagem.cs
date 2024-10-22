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

namespace ServFacil.Forms
{
    public partial class frmMensagem : Form
    {
        public frmMensagem(string mensagem)
        {
            InitializeComponent();
            lblMensagem.Text = mensagem;
        }

        private void frmMensagem_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMensagem_MouseEnter(object sender, EventArgs e)
        {
            Cores.passouMouse = false;
            Cores.MudarCor(btnMensagem);
        }

        private void btnMensagem_MouseLeave(object sender, EventArgs e)
        {
            Cores.passouMouse = true;
            Cores.MudarCor(btnMensagem);
        }

        private void btnDir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lblMensagem_Click(object sender, EventArgs e)
        {

        }
    }
}
