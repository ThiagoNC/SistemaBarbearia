namespace SistemaBarbearia
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pcImagem = new PictureBox();
            lblBemVindo = new Label();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            btnCancelar = new Button();
            pcLogin = new PictureBox();
            pcSenha = new PictureBox();
            lblLogin = new Label();
            lblSenha = new Label();
            lklEsqueciSenha = new LinkLabel();
            pcOlho = new PictureBox();
            panel1 = new Panel();
            lblSistemaGestao = new Label();
            ((System.ComponentModel.ISupportInitialize)pcImagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcOlho).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pcImagem
            // 
            pcImagem.Image = (Image)resources.GetObject("pcImagem.Image");
            pcImagem.Location = new Point(143, 20);
            pcImagem.Name = "pcImagem";
            pcImagem.Size = new Size(140, 140);
            pcImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pcImagem.TabIndex = 0;
            pcImagem.TabStop = false;
            // 
            // lblBemVindo
            // 
            lblBemVindo.AutoSize = true;
            lblBemVindo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBemVindo.Location = new Point(82, 176);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(261, 30);
            lblBemVindo.TabIndex = 1;
            lblBemVindo.Text = "Bem-vindo! Faça seu Login";
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogin.Location = new Point(139, 228);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(250, 29);
            txtLogin.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(139, 263);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(250, 29);
            txtSenha.TabIndex = 5;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.MidnightBlue;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(45, 326);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(238, 45);
            btnEntrar.TabIndex = 7;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightGray;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(289, 326);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 45);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pcLogin
            // 
            pcLogin.Image = (Image)resources.GetObject("pcLogin.Image");
            pcLogin.Location = new Point(45, 228);
            pcLogin.Name = "pcLogin";
            pcLogin.Size = new Size(29, 29);
            pcLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pcLogin.TabIndex = 6;
            pcLogin.TabStop = false;
            // 
            // pcSenha
            // 
            pcSenha.Image = (Image)resources.GetObject("pcSenha.Image");
            pcSenha.Location = new Point(45, 263);
            pcSenha.Name = "pcSenha";
            pcSenha.Size = new Size(29, 29);
            pcSenha.SizeMode = PictureBoxSizeMode.StretchImage;
            pcSenha.TabIndex = 7;
            pcSenha.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(80, 235);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(50, 15);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Usuário:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(80, 270);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha:";
            // 
            // lklEsqueciSenha
            // 
            lklEsqueciSenha.ActiveLinkColor = Color.MediumSlateBlue;
            lklEsqueciSenha.AutoSize = true;
            lklEsqueciSenha.LinkColor = Color.Black;
            lklEsqueciSenha.Location = new Point(271, 295);
            lklEsqueciSenha.Name = "lklEsqueciSenha";
            lklEsqueciSenha.Size = new Size(118, 15);
            lklEsqueciSenha.TabIndex = 6;
            lklEsqueciSenha.TabStop = true;
            lklEsqueciSenha.Text = "Esqueci minha senha";
            lklEsqueciSenha.LinkClicked += lklEsqueciSenha_LinkClicked;
            // 
            // pcOlho
            // 
            pcOlho.BackColor = Color.White;
            pcOlho.Cursor = Cursors.Hand;
            pcOlho.Image = (Image)resources.GetObject("pcOlho.Image");
            pcOlho.Location = new Point(360, 264);
            pcOlho.Name = "pcOlho";
            pcOlho.Size = new Size(28, 26);
            pcOlho.SizeMode = PictureBoxSizeMode.Zoom;
            pcOlho.TabIndex = 11;
            pcOlho.TabStop = false;
            pcOlho.Click += pcOlho_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(lblSistemaGestao);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 386);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 25);
            panel1.TabIndex = 12;
            // 
            // lblSistemaGestao
            // 
            lblSistemaGestao.AutoSize = true;
            lblSistemaGestao.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSistemaGestao.Location = new Point(131, 6);
            lblSistemaGestao.Name = "lblSistemaGestao";
            lblSistemaGestao.Size = new Size(164, 13);
            lblSistemaGestao.TabIndex = 9;
            lblSistemaGestao.Text = "Sistema de Gestão Interna v1.0";
            // 
            // FormLogin
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(434, 411);
            Controls.Add(panel1);
            Controls.Add(pcOlho);
            Controls.Add(lklEsqueciSenha);
            Controls.Add(lblSenha);
            Controls.Add(lblLogin);
            Controls.Add(pcSenha);
            Controls.Add(pcLogin);
            Controls.Add(btnCancelar);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(lblBemVindo);
            Controls.Add(pcImagem);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Sistema de Barbearia";
            ((System.ComponentModel.ISupportInitialize)pcImagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcOlho).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcImagem;
        private Label lblBemVindo;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Button btnEntrar;
        private Button btnCancelar;
        private PictureBox pcLogin;
        private PictureBox pcSenha;
        private Label lblLogin;
        private Label lblSenha;
        private LinkLabel lklEsqueciSenha;
        private PictureBox pcOlho;
        private Panel panel1;
        private Label lblSistemaGestao;
    }
}
