namespace ServFacil.Forms
{
    partial class frmMensagem
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
            this.lblMensagem = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMensagem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMensagem.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMensagem.Location = new System.Drawing.Point(12, 16);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(268, 111);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensagem.UseCompatibleTextRendering = true;
            this.lblMensagem.Click += new System.EventHandler(this.lblMensagem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 13);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnMensagem
            // 
            this.btnMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnMensagem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMensagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMensagem.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMensagem.Location = new System.Drawing.Point(108, 140);
            this.btnMensagem.Name = "btnMensagem";
            this.btnMensagem.Size = new System.Drawing.Size(75, 23);
            this.btnMensagem.TabIndex = 2;
            this.btnMensagem.Text = "OK";
            this.btnMensagem.UseVisualStyleBackColor = false;
            this.btnMensagem.Click += new System.EventHandler(this.btnDir_Click);
            this.btnMensagem.MouseEnter += new System.EventHandler(this.btnMensagem_MouseEnter);
            this.btnMensagem.MouseLeave += new System.EventHandler(this.btnMensagem_MouseLeave);
            // 
            // frmMensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(292, 176);
            this.ControlBox = false;
            this.Controls.Add(this.btnMensagem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMensagem);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMensagem";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMensagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMensagem;
    }
}