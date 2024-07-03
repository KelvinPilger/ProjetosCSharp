namespace Menu___Kelvin
{
    partial class frmFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFornecedor));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.gbDatas = new System.Windows.Forms.GroupBox();
            this.cbDatas = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.lblAtt = new System.Windows.Forms.Label();
            this.btnAtualizarFornecedor = new System.Windows.Forms.Button();
            this.cbTodosFornecedores = new System.Windows.Forms.CheckBox();
            this.dgFornecedor = new System.Windows.Forms.DataGridView();
            this.cmFornecedor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarDadosDaGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbDatas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFornecedor)).BeginInit();
            this.cmFornecedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Listagem de Fornecedores";
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
            this.groupBox1.TabIndex = 20;
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
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
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
            this.gbDatas.TabIndex = 19;
            this.gbDatas.TabStop = false;
            this.gbDatas.Text = "Filtro de Datas";
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
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinal.Location = new System.Drawing.Point(85, 55);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(85, 20);
            this.dtpFinal.TabIndex = 6;
            // 
            // dtpInicial
            // 
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicial.Location = new System.Drawing.Point(85, 24);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(85, 20);
            this.dtpInicial.TabIndex = 5;
            // 
            // lblAtt
            // 
            this.lblAtt.AutoSize = true;
            this.lblAtt.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAtt.Location = new System.Drawing.Point(936, 423);
            this.lblAtt.Name = "lblAtt";
            this.lblAtt.Size = new System.Drawing.Size(107, 15);
            this.lblAtt.TabIndex = 18;
            this.lblAtt.Text = "Atualizar Grid - F1";
            // 
            // btnAtualizarFornecedor
            // 
            this.btnAtualizarFornecedor.BackgroundImage = global::Menu___Kelvin.Properties.Resources.atualizar__1_;
            this.btnAtualizarFornecedor.FlatAppearance.BorderSize = 0;
            this.btnAtualizarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarFornecedor.Location = new System.Drawing.Point(912, 419);
            this.btnAtualizarFornecedor.Name = "btnAtualizarFornecedor";
            this.btnAtualizarFornecedor.Size = new System.Drawing.Size(21, 23);
            this.btnAtualizarFornecedor.TabIndex = 17;
            this.btnAtualizarFornecedor.UseVisualStyleBackColor = true;
            this.btnAtualizarFornecedor.Click += new System.EventHandler(this.btnAtualizarFornecedor_Click);
            // 
            // cbTodosFornecedores
            // 
            this.cbTodosFornecedores.AutoSize = true;
            this.cbTodosFornecedores.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTodosFornecedores.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbTodosFornecedores.Location = new System.Drawing.Point(925, 139);
            this.cbTodosFornecedores.Name = "cbTodosFornecedores";
            this.cbTodosFornecedores.Size = new System.Drawing.Size(176, 19);
            this.cbTodosFornecedores.TabIndex = 16;
            this.cbTodosFornecedores.Text = "Todos os Fornecedores (F2)";
            this.cbTodosFornecedores.UseVisualStyleBackColor = true;
            // 
            // dgFornecedor
            // 
            this.dgFornecedor.AccessibleName = "";
            this.dgFornecedor.AllowUserToAddRows = false;
            this.dgFornecedor.AllowUserToDeleteRows = false;
            this.dgFornecedor.AllowUserToOrderColumns = true;
            this.dgFornecedor.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFornecedor.ContextMenuStrip = this.cmFornecedor;
            this.dgFornecedor.Location = new System.Drawing.Point(12, 32);
            this.dgFornecedor.Name = "dgFornecedor";
            this.dgFornecedor.ReadOnly = true;
            this.dgFornecedor.Size = new System.Drawing.Size(892, 411);
            this.dgFornecedor.TabIndex = 15;
            // 
            // cmFornecedor
            // 
            this.cmFornecedor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarDadosDaGridToolStripMenuItem});
            this.cmFornecedor.Name = "cmFornecedor";
            this.cmFornecedor.Size = new System.Drawing.Size(196, 26);
            // 
            // exportarDadosDaGridToolStripMenuItem
            // 
            this.exportarDadosDaGridToolStripMenuItem.Name = "exportarDadosDaGridToolStripMenuItem";
            this.exportarDadosDaGridToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.exportarDadosDaGridToolStripMenuItem.Text = "Exportar Dados da Grid";
            this.exportarDadosDaGridToolStripMenuItem.Click += new System.EventHandler(this.exportarDadosDaGridToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(712, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "* Botão direito na grid para Exportação.";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(1162, 9);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(10, 10);
            this.btnFechar.TabIndex = 24;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(1184, 453);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDatas);
            this.Controls.Add(this.lblAtt);
            this.Controls.Add(this.btnAtualizarFornecedor);
            this.Controls.Add(this.cbTodosFornecedores);
            this.Controls.Add(this.dgFornecedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFornecedor";
            this.Opacity = 0.95D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmFornecedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDatas.ResumeLayout(false);
            this.gbDatas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFornecedor)).EndInit();
            this.cmFornecedor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.GroupBox gbDatas;
        private System.Windows.Forms.CheckBox cbDatas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.Label lblAtt;
        private System.Windows.Forms.Button btnAtualizarFornecedor;
        private System.Windows.Forms.CheckBox cbTodosFornecedores;
        private System.Windows.Forms.DataGridView dgFornecedor;
        private System.Windows.Forms.ContextMenuStrip cmFornecedor;
        private System.Windows.Forms.ToolStripMenuItem exportarDadosDaGridToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFechar;
    }
}