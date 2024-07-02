using System.Windows.Forms;
using System;
using System.Drawing;

namespace Menu___Kelvin
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblClientes.Location = new System.Drawing.Point(17, 98);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(106, 21);
            this.lblClientes.TabIndex = 1;
            this.lblClientes.Text = "Clientes - (1)";
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEstoque.Location = new System.Drawing.Point(145, 98);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(106, 21);
            this.lblEstoque.TabIndex = 3;
            this.lblEstoque.Text = "Estoque - (2)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(273, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fornecedores - (3)";
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFornecedor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFornecedor.BackgroundImage = global::Menu___Kelvin.Properties.Resources.ordem_de_compra;
            this.btnFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFornecedor.FlatAppearance.BorderSize = 0;
            this.btnFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedor.Location = new System.Drawing.Point(296, 12);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(87, 89);
            this.btnFornecedor.TabIndex = 4;
            this.btnFornecedor.UseVisualStyleBackColor = false;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEstoque.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEstoque.BackgroundImage = global::Menu___Kelvin.Properties.Resources.estoque_pronto;
            this.btnEstoque.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Location = new System.Drawing.Point(157, 12);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(89, 89);
            this.btnEstoque.TabIndex = 2;
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClientes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClientes.BackgroundImage = global::Menu___Kelvin.Properties.Resources.cliente1;
            this.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnClientes.Location = new System.Drawing.Point(27, 12);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(85, 89);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnFechar.Location = new System.Drawing.Point(1160, 12);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(10, 10);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(1182, 128);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFornecedor);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.btnClientes);
            this.Font = new System.Drawing.Font("Nirmala UI Semilight", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.Opacity = 0.95D;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.Button btnFechar;

        private Color borderColor = Color.LightBlue;
        private int borderWidth = 5;

        public void FormPersonalizado()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderWidth);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Pen pen = new Pen(borderColor, 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
            }
        }
    }
}

