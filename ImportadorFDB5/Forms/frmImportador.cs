using ImportadorFDB5.Classes;
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

namespace ImportadorFDB5
{
    public partial class frmImportador : Form
    {
        [DllImport("DwmApi")]


        private static extern int DwmSetWindowAttribute(IntPtr hwn, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
            {
                DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
            }
        }
        public frmImportador()
        {
            InitializeComponent();
            SetColor();
        }


        private void SetColor()
        {
            this.BackColor = ControladorMod.corFundo;
            this.ForeColor = ControladorMod.corFonte;
            btnTrocarMod.Image = ControladorMod.imgMod;
            btnOrigem.Image = ControladorMod.pastaMod;
            btnDestino.Image = ControladorMod.pastaMod;
            pcbAlvo.Image = ControladorMod.alvoMod;
            pcbBanco.Image = ControladorMod.bdMod;
            btnImportar.Image = ControladorMod.intercambioMod;
        }

        private void btnOrigem_Click(object sender, EventArgs e)
        {
            OpenFileDialog origem = new OpenFileDialog();
            origem.RestoreDirectory = true;
            origem.Title = "Seleção BD";
            origem.AddExtension = false;
            origem.Filter = "Arquivos FDB (*.fdb)|*.fdb";
            origem.FilterIndex = 1;
            origem.Title = "Selecione um Banco de Dados";
            txtOrigem.Text = origem.FileName;


            if (origem.ShowDialog() == DialogResult.OK)
            {
                txtOrigem.Text = origem.FileName;
                Importacao.diretorioOrigem = txtOrigem.Text;

                Importacao.ConexaoOrigem(txtOrigem, btnStatusOrigem);
            }
            else
            {
                txtOrigem.Text = "Selecione o banco de destino.";
            }

        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            OpenFileDialog destino = new OpenFileDialog();
            destino.RestoreDirectory = true;
            destino.Title = "Seleção BD";
            destino.AddExtension = false;
            destino.Filter = "Arquivos FDB (*.fdb)|*.fdb";
            destino.FilterIndex = 1;
            destino.Title = "Selecione um Banco de Dados";
            txtDestino.Text = destino.FileName;

            if (destino.ShowDialog() == DialogResult.OK)
            {
                txtDestino.Text = destino.FileName;
                Importacao.diretorioDestino = txtDestino.Text;
                Importacao.ConexaoDestino(txtDestino, btnStatusDestino);
            }
            else
            {
                txtDestino.Text = "Selecione o banco de destino.";
                btnStatusDestino.BackColor = Color.Red;
            }
        }

        private void frmImportador_Load(object sender, EventArgs e)
        {
            lblStatus.Visible = false;
        }
        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (btnStatusDestino.BackColor != Color.Red && btnStatusOrigem.BackColor != Color.Red) {
                btnImportar.Enabled = false;
                Importacao.CreateFaltantes();
                Importacao.DropKeys(lblStatus);
                Importacao.ExportarDados(Importacao.PreencherNomeTabelas(), pgbImportar, lblStatus);
                btnImportar.Enabled = true;
            }
        }

        private void btnTrocarMod_Click(object sender, EventArgs e)
        {
            ControladorMod.TrocarMod();
            SetColor();
        }
    }
}
