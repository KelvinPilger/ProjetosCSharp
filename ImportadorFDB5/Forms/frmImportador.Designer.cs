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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDestino = new System.Windows.Forms.Button();
            this.btnOrigem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStatusDestino = new System.Windows.Forms.Button();
            this.btnStatusOrigem = new System.Windows.Forms.Button();
            this.lblTabela = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pgbImportar
            // 
            this.pgbImportar.Location = new System.Drawing.Point(78, 203);
            this.pgbImportar.Name = "pgbImportar";
            this.pgbImportar.Size = new System.Drawing.Size(214, 17);
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
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ImportadorFDB5.Properties.Resources.png_transparent_bathroom_aesthetics_person_ak_logo_angle_text_triangle_thumbnail_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(369, -35);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(355, 264);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
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
            this.btnImportar.Location = new System.Drawing.Point(97, 139);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(0);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(172, 29);
            this.btnImportar.TabIndex = 0;
            this.btnImportar.Text = "Importar Dados";
            this.btnImportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ImportadorFDB5.Properties.Resources.alvo;
            this.pictureBox2.Location = new System.Drawing.Point(30, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 22);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnDestino
            // 
            this.btnDestino.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDestino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDestino.FlatAppearance.BorderSize = 0;
            this.btnDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestino.Image = global::ImportadorFDB5.Properties.Resources.pasta;
            this.btnDestino.Location = new System.Drawing.Point(319, 95);
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
            this.btnOrigem.Image = global::ImportadorFDB5.Properties.Resources.pasta;
            this.btnOrigem.Location = new System.Drawing.Point(319, 36);
            this.btnOrigem.Margin = new System.Windows.Forms.Padding(0);
            this.btnOrigem.Name = "btnOrigem";
            this.btnOrigem.Size = new System.Drawing.Size(27, 22);
            this.btnOrigem.TabIndex = 1;
            this.btnOrigem.UseVisualStyleBackColor = true;
            this.btnOrigem.Click += new System.EventHandler(this.btnOrigem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ImportadorFDB5.Properties.Resources.db;
            this.pictureBox1.Location = new System.Drawing.Point(29, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 22);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 185);
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
            this.lblTabela.Location = new System.Drawing.Point(102, 223);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(9, 10);
            this.lblTabela.TabIndex = 16;
            this.lblTabela.Text = "-";
            // 
            // frmImportador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(761, 251);
            this.Controls.Add(this.lblTabela);
            this.Controls.Add(this.btnStatusOrigem);
            this.Controls.Add(this.btnStatusDestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVUm);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblOrigem);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.btnDestino);
            this.Controls.Add(this.btnOrigem);
            this.Controls.Add(this.txtOrigem);
            this.Controls.Add(this.pgbImportar);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar pgbImportar;
        private System.Windows.Forms.Button btnOrigem;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblVUm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDestino;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStatusDestino;
        private System.Windows.Forms.Button btnStatusOrigem;
        public System.Windows.Forms.TextBox txtOrigem;
        public System.Windows.Forms.Label lblTabela;
    }
}

