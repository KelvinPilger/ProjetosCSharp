using Menu___Kelvin.Formulários;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu___Kelvin
{
    public class AltForms
    {

        public static bool FormAberto(string nomeForm) { 
            return Application.OpenForms.Cast<Form>().Any(form => form.Name == nomeForm);
        }
        public static void OpenFrmCliente()
        {
            frmEstoque frmEstoque = new frmEstoque();
            frmCliente frmCliente = new frmCliente();
            frmFornecedor frmFornecedor = new frmFornecedor();
            if (!FormAberto("frmEstoque") && !FormAberto("frmFornecedor")) {
                if (!FormAberto("frmCliente")) {
                    frmCliente.Show();
                    frmCliente.Focus();
                }
            }
        }

        public static void OpenFrmEstoque()
        {
            {
                frmCliente frmCliente = new frmCliente();
                frmEstoque frmEstoque = new frmEstoque();
                frmFornecedor frmFornecedor = new frmFornecedor();
                if (!FormAberto("frmCliente") && !FormAberto("frmFornecedor"))
                {
                    if (!FormAberto("frmEstoque"))
                    {
                        frmEstoque.Show();
                        frmEstoque.Focus();
                    }
                }
            }
        }

        public static void OpenFrmFornecedor()
        {
            {
                frmCliente frmCliente = new frmCliente();
                frmEstoque frmEstoque = new frmEstoque();
                frmFornecedor frmFornecedor = new frmFornecedor();
                if (!FormAberto("frmCliente") && !FormAberto("frmEstoque"))
                {
                    if (!FormAberto("frmFornecedor"))
                    {
                        frmFornecedor.Show();
                        frmFornecedor.Focus();
                    }
                }
            }
        }


        public static void OpenFrmExportacaoCliente() {
            frmExportarCliente frm = new frmExportarCliente();
            if (!FormAberto("frmExportarCliente")) {
                frm.Show();
                frm.Focus();
            }
        }

        public static void CloseFrmExportacaoCliente(frmExportarCliente frm) {
            frm.Close();
            frmCliente frmCliente = new frmCliente();
            frmCliente.Focus();
        }

        public static void CloseFrmMenu(frmMenu formMenu)
        {
            formMenu.Close();
        }

        public static void CloseFrmCliente(frmCliente formCliente)
        {
            formCliente.Close();
        }

        public static void CloseFrmEstoque(frmEstoque frmEstoque)
        {
            frmEstoque.Close();
        }

        public static void CloseFrmFornecedor(frmFornecedor frmFornecedor) {
            frmFornecedor.Close();
        }
    }
}
