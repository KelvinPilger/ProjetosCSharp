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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.D1:
                    AltForms.OpenFrmCliente();    
                    break;
                case Keys.D2:
                    AltForms.OpenFrmEstoque();
                    break;
                case Keys .D3:
                    AltForms.OpenFrmFornecedor();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 50000, 2);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AltForms.OpenFrmCliente();      
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            AltForms.CloseFrmMenu(this);
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            AltForms.OpenFrmEstoque();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            AltForms.OpenFrmFornecedor();
        }
    }
}
