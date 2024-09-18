namespace ImportadorFDB5
{
    partial class frmImportador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportador));
            this.pgbImportar = new System.Windows.Forms.ProgressBar();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblVUm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStatusDestino = new System.Windows.Forms.Button();
            this.btnStatusOrigem = new System.Windows.Forms.Button();
            this.lblTabela = new System.Windows.Forms.Label();
            this.lblImportacao = new System.Windows.Forms.Label();
            this.btnFUm = new System.Windows.Forms.Label();
            this.btnFDois = new System.Windows.Forms.Label();
            this.btnFTres = new System.Windows.Forms.Label();
            this.lblFQuatro = new System.Windows.Forms.Label();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.btnTrocarMod = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.pcbAlvo = new System.Windows.Forms.PictureBox();
            this.btnDestino = new System.Windows.Forms.Button();
            this.btnOrigem = new System.Windows.Forms.Button();
            this.pcbBanco = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAlvo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBanco)).BeginInit();
            this.SuspendLayout();
            // 
            // pgbImportar
            // 
            this.pgbImportar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pgbImportar.Location = new System.Drawing.Point(60, 206);
            this.pgbImportar.Name = "pgbImportar";
            this.pgbImportar.Size = new System.Drawing.Size(259, 17);
            this.pgbImportar.TabIndex = 1;
            // 
            // txtOrigem
            // 
            this.txtOrigem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOrigem.Enabled = false;
            this.txtOrigem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtOrigem.Location = new System.Drawing.Point(60, 38);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(259, 20);
            this.txtOrigem.TabIndex = 2;
            this.txtOrigem.Text = "Selecione o banco de origem.";
            this.txtOrigem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDestino
            // 
            this.txtDestino.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDestino.Enabled = false;
            this.txtDestino.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDestino.Location = new System.Drawing.Point(60, 97);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(259, 20);
            this.txtDestino.TabIndex = 4;
            this.txtDestino.Text = "Selecione o banco de destino.";
            this.txtDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigem.Location = new System.Drawing.Point(64, 17);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(176, 18);
            this.lblOrigem.TabIndex = 6;
            this.lblOrigem.Text = "Database de Origem";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(63, 76);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(178, 18);
            this.lblDestino.TabIndex = 7;
            this.lblDestino.Text = "Database de Destino";
            // 
            // lblVUm
            // 
            this.lblVUm.AutoSize = true;
            this.lblVUm.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVUm.Location = new System.Drawing.Point(271, 25);
            this.lblVUm.Name = "lblVUm";
            this.lblVUm.Size = new System.Drawing.Size(31, 10);
            this.lblVUm.TabIndex = 8;
            this.lblVUm.Text = "FB2.5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 10);
            this.label1.TabIndex = 9;
            this.label1.Text = "FB5.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "Progresso";
            // 
            // btnStatusDestino
            // 
            this.btnStatusDestino.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStatusDestino.BackColor = System.Drawing.Color.Red;
            this.btnStatusDestino.Enabled = false;
            this.btnStatusDestino.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStatusDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatusDestino.Location = new System.Drawing.Point(304, 81);
            this.btnStatusDestino.Name = "btnStatusDestino";
            this.btnStatusDestino.Size = new System.Drawing.Size(12, 12);
            this.btnStatusDestino.TabIndex = 14;
            this.btnStatusDestino.UseVisualStyleBackColor = false;
            // 
            // btnStatusOrigem
            // 
            this.btnStatusOrigem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStatusOrigem.BackColor = System.Drawing.Color.Red;
            this.btnStatusOrigem.Enabled = false;
            this.btnStatusOrigem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStatusOrigem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatusOrigem.Location = new System.Drawing.Point(304, 24);
            this.btnStatusOrigem.Name = "btnStatusOrigem";
            this.btnStatusOrigem.Size = new System.Drawing.Size(12, 12);
            this.btnStatusOrigem.TabIndex = 15;
            this.btnStatusOrigem.UseVisualStyleBackColor = false;
            // 
            // lblTabela
            // 
            this.lblTabela.AutoSize = true;
            this.lblTabela.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabela.Location = new System.Drawing.Point(101, 229);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(0, 10);
            this.lblTabela.TabIndex = 16;
            // 
            // lblImportacao
            // 
            this.lblImportacao.AutoSize = true;
            this.lblImportacao.Enabled = false;
            this.lblImportacao.Font = new System.Drawing.Font("Verdana", 5.5F, System.Drawing.FontStyle.Bold);
            this.lblImportacao.Location = new System.Drawing.Point(62, 228);
            this.lblImportacao.Name = "lblImportacao";
            this.lblImportacao.Size = new System.Drawing.Size(0, 10);
            this.lblImportacao.TabIndex = 19;
            // 
            // btnFUm
            // 
            this.btnFUm.AutoSize = true;
            this.btnFUm.Font = new System.Drawing.Font("Verdana", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFUm.Location = new System.Drawing.Point(332, 37);
            this.btnFUm.Name = "btnFUm";
            this.btnFUm.Size = new System.Drawing.Size(14, 8);
            this.btnFUm.TabIndex = 20;
            this.btnFUm.Text = "F1";
            // 
            // btnFDois
            // 
            this.btnFDois.AutoSize = true;
            this.btnFDois.Font = new System.Drawing.Font("Verdana", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFDois.Location = new System.Drawing.Point(332, 95);
            this.btnFDois.Name = "btnFDois";
            this.btnFDois.Size = new System.Drawing.Size(14, 8);
            this.btnFDois.TabIndex = 21;
            this.btnFDois.Text = "F2";
            // 
            // btnFTres
            // 
            this.btnFTres.AutoSize = true;
            this.btnFTres.Font = new System.Drawing.Font("Verdana", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFTres.Location = new System.Drawing.Point(261, 135);
            this.btnFTres.Name = "btnFTres";
            this.btnFTres.Size = new System.Drawing.Size(14, 8);
            this.btnFTres.TabIndex = 22;
            this.btnFTres.Text = "F3";
            // 
            // lblFQuatro
            // 
            this.lblFQuatro.AutoSize = true;
            this.lblFQuatro.Font = new System.Drawing.Font("Verdana", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFQuatro.Location = new System.Drawing.Point(710, 210);
            this.lblFQuatro.Name = "lblFQuatro";
            this.lblFQuatro.Size = new System.Drawing.Size(14, 8);
            this.lblFQuatro.TabIndex = 23;
            this.lblFQuatro.Text = "F4";
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = global::ImportadorFDB5.Properties.Resources.lglModClaro;
            this.pcbLogo.Location = new System.Drawing.Point(351, 12);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(323, 229);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 24;
            this.pcbLogo.TabStop = false;
            // 
            // btnTrocarMod
            // 
            this.btnTrocarMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrocarMod.FlatAppearance.BorderSize = 0;
            this.btnTrocarMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrocarMod.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrocarMod.Image = global::ImportadorFDB5.Properties.Resources.ModLigth;
            this.btnTrocarMod.Location = new System.Drawing.Point(681, 206);
            this.btnTrocarMod.Name = "btnTrocarMod";
            this.btnTrocarMod.Size = new System.Drawing.Size(47, 35);
            this.btnTrocarMod.TabIndex = 18;
            this.btnTrocarMod.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTrocarMod.UseVisualStyleBackColor = true;
            this.btnTrocarMod.Click += new System.EventHandler(this.btnTrocarMod_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportar.FlatAppearance.BorderSize = 0;
            this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.Image = global::ImportadorFDB5.Properties.Resources.intercambio;
            this.btnImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportar.Location = new System.Drawing.Point(93, 135);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(0);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(172, 29);
            this.btnImportar.TabIndex = 0;
            this.btnImportar.Text = "Importar Dados";
            this.btnImportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // pcbAlvo
            // 
            this.pcbAlvo.Image = global::ImportadorFDB5.Properties.Resources.AlvoLigth1;
            this.pcbAlvo.Location = new System.Drawing.Point(30, 95);
            this.pcbAlvo.Name = "pcbAlvo";
            this.pcbAlvo.Size = new System.Drawing.Size(25, 24);
            this.pcbAlvo.TabIndex = 5;
            this.pcbAlvo.TabStop = false;
            // 
            // btnDestino
            // 
            this.btnDestino.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDestino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDestino.FlatAppearance.BorderSize = 0;
            this.btnDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestino.Image = global::ImportadorFDB5.Properties.Resources.PastaLigth1;
            this.btnDestino.Location = new System.Drawing.Point(319, 97);
            this.btnDestino.Margin = new System.Windows.Forms.Padding(0);
            this.btnDestino.Name = "btnDestino";
            this.btnDestino.Size = new System.Drawing.Size(27, 22);
            this.btnDestino.TabIndex = 2;
            this.btnDestino.UseVisualStyleBackColor = true;
            this.btnDestino.Click += new System.EventHandler(this.btnDestino_Click);
            // 
            // btnOrigem
            // 
            this.btnOrigem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOrigem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrigem.FlatAppearance.BorderSize = 0;
            this.btnOrigem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrigem.Image = global::ImportadorFDB5.Properties.Resources.PastaLigth1;
            this.btnOrigem.Location = new System.Drawing.Point(319, 39);
            this.btnOrigem.Margin = new System.Windows.Forms.Padding(0);
            this.btnOrigem.Name = "btnOrigem";
            this.btnOrigem.Size = new System.Drawing.Size(27, 22);
            this.btnOrigem.TabIndex = 1;
            this.btnOrigem.UseVisualStyleBackColor = true;
            this.btnOrigem.Click += new System.EventHandler(this.btnOrigem_Click);
            // 
            // pcbBanco
            // 
            this.pcbBanco.Image = global::ImportadorFDB5.Properties.Resources.base_de_dadosLigth;
            this.pcbBanco.Location = new System.Drawing.Point(29, 37);
            this.pcbBanco.Name = "pcbBanco";
            this.pcbBanco.Size = new System.Drawing.Size(25, 22);
            this.pcbBanco.TabIndex = 0;
            this.pcbBanco.TabStop = false;
            // 
            // frmImportador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 253);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.lblFQuatro);
            this.Controls.Add(this.btnFTres);
            this.Controls.Add(this.btnFDois);
            this.Controls.Add(this.btnFUm);
            this.Controls.Add(this.lblImportacao);
            this.Controls.Add(this.btnTrocarMod);
            this.Controls.Add(this.lblTabela);
            this.Controls.Add(this.btnStatusOrigem);
            this.Controls.Add(this.btnStatusDestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVUm);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblOrigem);
            this.Controls.Add(this.pcbAlvo);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.btnDestino);
            this.Controls.Add(this.btnOrigem);
            this.Controls.Add(this.txtOrigem);
            this.Controls.Add(this.pgbImportar);
            this.Controls.Add(this.pcbBanco);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImportador";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "< Importador FBD >";
            this.Load += new System.EventHandler(this.frmImportador_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnFechar);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAlvo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBanco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar pgbImportar;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.Label lblVUm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStatusDestino;
        private System.Windows.Forms.Button btnStatusOrigem;
        public System.Windows.Forms.TextBox txtOrigem;
        public System.Windows.Forms.Label lblTabela;
        public System.Windows.Forms.PictureBox pcbBanco;
        public System.Windows.Forms.PictureBox pcbAlvo;
        public System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblImportacao;
        private System.Windows.Forms.Label btnFUm;
        private System.Windows.Forms.Label btnFDois;
        private System.Windows.Forms.Label btnFTres;
        public System.Windows.Forms.Button btnOrigem;
        public System.Windows.Forms.Button btnDestino;
        public System.Windows.Forms.Button btnTrocarMod;
        private System.Windows.Forms.Label lblFQuatro;
        public System.Windows.Forms.PictureBox pcbLogo;
    }
}

