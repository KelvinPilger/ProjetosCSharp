namespace Menu___Kelvin
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    partial class frmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.dgCliente = new System.Windows.Forms.DataGridView();
            this.cmGridCliente = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarDadosDaGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbTodosClientes = new System.Windows.Forms.CheckBox();
            this.lblAtt = new System.Windows.Forms.Label();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDatas = new System.Windows.Forms.CheckBox();
            this.gbDatas = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtualizarCliente = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).BeginInit();
            this.cmGridCliente.SuspendLayout();
            this.gbDatas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgCliente
            // 
            this.dgCliente.AccessibleName = "";
            this.dgCliente.AllowUserToAddRows = false;
            this.dgCliente.AllowUserToDeleteRows = false;
            this.dgCliente.AllowUserToOrderColumns = true;
            this.dgCliente.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCliente.ContextMenuStrip = this.cmGridCliente;
            this.dgCliente.Location = new System.Drawing.Point(12, 32);
            this.dgCliente.Name = "dgCliente";
            this.dgCliente.ReadOnly = true;
            this.dgCliente.Size = new System.Drawing.Size(892, 411);
            this.dgCliente.TabIndex = 0;
            // 
            // cmGridCliente
            // 
            this.cmGridCliente.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarDadosDaGridToolStripMenuItem});
            this.cmGridCliente.Name = "cmGridCliente";
            this.cmGridCliente.ShowImageMargin = false;
            this.cmGridCliente.Size = new System.Drawing.Size(171, 26);
            // 
            // exportarDadosDaGridToolStripMenuItem
            // 
            this.exportarDadosDaGridToolStripMenuItem.Name = "exportarDadosDaGridToolStripMenuItem";
            this.exportarDadosDaGridToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exportarDadosDaGridToolStripMenuItem.Text = "Exportar Dados da Grid";
            this.exportarDadosDaGridToolStripMenuItem.Click += new System.EventHandler(this.exportarDadosDaGridToolStripMenuItem_Click);
            // 
            // cbTodosClientes
            // 
            this.cbTodosClientes.AutoSize = true;
            this.cbTodosClientes.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTodosClientes.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbTodosClientes.Location = new System.Drawing.Point(925, 139);
            this.cbTodosClientes.Name = "cbTodosClientes";
            this.cbTodosClientes.Size = new System.Drawing.Size(144, 19);
            this.cbTodosClientes.TabIndex = 2;
            this.cbTodosClientes.Text = "Todos os Clientes (F2)";
            this.cbTodosClientes.UseVisualStyleBackColor = true;
            // 
            // lblAtt
            // 
            this.lblAtt.AutoSize = true;
            this.lblAtt.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAtt.Location = new System.Drawing.Point(936, 423);
            this.lblAtt.Name = "lblAtt";
            this.lblAtt.Size = new System.Drawing.Size(107, 15);
            this.lblAtt.TabIndex = 4;
            this.lblAtt.Text = "Atualizar Grid - F1";
            // 
            // dtpInicial
            // 
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicial.Location = new System.Drawing.Point(85, 24);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(85, 20);
            this.dtpInicial.TabIndex = 5;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinal.Location = new System.Drawing.Point(85, 55);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(85, 20);
            this.dtpFinal.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data Inicial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data Final:";
            // 
            // cbDatas
            // 
            this.cbDatas.AutoSize = true;
            this.cbDatas.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDatas.Location = new System.Drawing.Point(12, 81);
            this.cbDatas.Name = "cbDatas";
            this.cbDatas.Size = new System.Drawing.Size(158, 19);
            this.cbDatas.TabIndex = 9;
            this.cbDatas.Text = "Sem Filtro de Datas (F3)";
            this.cbDatas.UseVisualStyleBackColor = true;
            // 
            // gbDatas
            // 
            this.gbDatas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbDatas.Controls.Add(this.cbDatas);
            this.gbDatas.Controls.Add(this.label3);
            this.gbDatas.Controls.Add(this.label2);
            this.gbDatas.Controls.Add(this.dtpFinal);
            this.gbDatas.Controls.Add(this.dtpInicial);
            this.gbDatas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDatas.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbDatas.Location = new System.Drawing.Point(913, 26);
            this.gbDatas.Name = "gbDatas";
            this.gbDatas.Size = new System.Drawing.Size(194, 107);
            this.gbDatas.TabIndex = 11;
            this.gbDatas.TabStop = false;
            this.gbDatas.Text = "Filtro de Datas";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnImportar);
            this.groupBox1.Controls.Add(this.btnExportar);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(913, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 149);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Planilhas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Importar Planilha - F5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Exportar Planilha - F4";
            // 
            // btnImportar
            // 
            this.btnImportar.BackgroundImage = global::Menu___Kelvin.Properties.Resources.importar;
            this.btnImportar.FlatAppearance.BorderSize = 0;
            this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportar.Location = new System.Drawing.Point(12, 89);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(0);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(35, 35);
            this.btnImportar.TabIndex = 1;
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackgroundImage = global::Menu___Kelvin.Properties.Resources.tabela_de_edicao___Copia;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Location = new System.Drawing.Point(13, 33);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(0);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(34, 34);
            this.btnExportar.TabIndex = 0;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(1162, 7);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(10, 10);
            this.btnFechar.TabIndex = 13;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Listagem de Clientes";
            // 
            // btnAtualizarCliente
            // 
            this.btnAtualizarCliente.BackgroundImage = global::Menu___Kelvin.Properties.Resources.atualizar__1_;
            this.btnAtualizarCliente.FlatAppearance.BorderSize = 0;
            this.btnAtualizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarCliente.Location = new System.Drawing.Point(912, 419);
            this.btnAtualizarCliente.Name = "btnAtualizarCliente";
            this.btnAtualizarCliente.Size = new System.Drawing.Size(21, 23);
            this.btnAtualizarCliente.TabIndex = 3;
            this.btnAtualizarCliente.UseVisualStyleBackColor = true;
            this.btnAtualizarCliente.Click += new System.EventHandler(this.btnAtualizarCliente_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(712, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "* Botão direito na grid para Exportação.";
            // 
            // frmCliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(1184, 453);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDatas);
            this.Controls.Add(this.lblAtt);
            this.Controls.Add(this.btnAtualizarCliente);
            this.Controls.Add(this.cbTodosClientes);
            this.Controls.Add(this.dgCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 300);
            this.MaximizeBox = false;
            this.Name = "frmCliente";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).EndInit();
            this.cmGridCliente.ResumeLayout(false);
            this.gbDatas.ResumeLayout(false);
            this.gbDatas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCliente;
        private System.Windows.Forms.CheckBox cbTodosClientes;
        private System.Windows.Forms.Button btnAtualizarCliente;
        private System.Windows.Forms.Label lblAtt;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbDatas;
        private System.Windows.Forms.GroupBox gbDatas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ContextMenuStrip cmGridCliente;
        private System.Windows.Forms.ToolStripMenuItem exportarDadosDaGridToolStripMenuItem;
        private System.Windows.Forms.Label label1;

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

        private Label label6;
    }
}