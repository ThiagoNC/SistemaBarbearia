namespace SistemaBarbearia.Views
{
    partial class FormBarbeiros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBarbeiros));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnClientes = new Panel();
            pcBarber = new PictureBox();
            lblGestaoBarbeiros = new Label();
            lblNome = new Label();
            lblTelefone = new Label();
            txtNome = new TextBox();
            btnNovo = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            dgvBarbeiros = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            DataNascimento = new DataGridViewTextBoxColumn();
            PercentualComissao = new DataGridViewTextBoxColumn();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblDtNascimento = new Label();
            dtpDtNascimento = new DateTimePicker();
            mtbTelefone = new MaskedTextBox();
            btnAtualizar = new Button();
            txtPesquisar = new TextBox();
            gbBarbeiro = new GroupBox();
            nudPercentualComissao = new NumericUpDown();
            lblPercentualComissao = new Label();
            pnClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcBarber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBarbeiros).BeginInit();
            gbBarbeiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPercentualComissao).BeginInit();
            SuspendLayout();
            // 
            // pnClientes
            // 
            pnClientes.BackColor = Color.MidnightBlue;
            pnClientes.Controls.Add(pcBarber);
            pnClientes.Controls.Add(lblGestaoBarbeiros);
            pnClientes.Dock = DockStyle.Top;
            pnClientes.Location = new Point(0, 0);
            pnClientes.Name = "pnClientes";
            pnClientes.Size = new Size(1008, 150);
            pnClientes.TabIndex = 0;
            // 
            // pcBarber
            // 
            pcBarber.Image = (Image)resources.GetObject("pcBarber.Image");
            pcBarber.Location = new Point(212, 27);
            pcBarber.Name = "pcBarber";
            pcBarber.Size = new Size(100, 100);
            pcBarber.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBarber.TabIndex = 1;
            pcBarber.TabStop = false;
            // 
            // lblGestaoBarbeiros
            // 
            lblGestaoBarbeiros.AutoSize = true;
            lblGestaoBarbeiros.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestaoBarbeiros.ForeColor = Color.White;
            lblGestaoBarbeiros.Location = new Point(318, 45);
            lblGestaoBarbeiros.Name = "lblGestaoBarbeiros";
            lblGestaoBarbeiros.Size = new Size(480, 65);
            lblGestaoBarbeiros.TabIndex = 0;
            lblGestaoBarbeiros.Text = "Gestão de Barbeiros";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(5, 32);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(56, 21);
            lblNome.TabIndex = 10;
            lblNome.Text = "Nome:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 12F);
            lblTelefone.Location = new Point(5, 67);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(70, 21);
            lblTelefone.TabIndex = 20;
            lblTelefone.Text = "Telefone:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F);
            txtNome.Location = new Point(164, 29);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(192, 29);
            txtNome.TabIndex = 15;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.Green;
            btnNovo.FlatStyle = FlatStyle.Flat;
            btnNovo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNovo.ForeColor = Color.White;
            btnNovo.Location = new Point(14, 227);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(110, 35);
            btnNovo.TabIndex = 55;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.MidnightBlue;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(130, 227);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(110, 35);
            btnSalvar.TabIndex = 50;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(192, 0, 0);
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(246, 227);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 35);
            btnExcluir.TabIndex = 60;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dgvBarbeiros
            // 
            dataGridViewCellStyle3.BackColor = Color.Gainsboro;
            dgvBarbeiros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvBarbeiros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBarbeiros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBarbeiros.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvBarbeiros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvBarbeiros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBarbeiros.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Telefone, Email, DataNascimento, PercentualComissao });
            dgvBarbeiros.Location = new Point(378, 203);
            dgvBarbeiros.Name = "dgvBarbeiros";
            dgvBarbeiros.ReadOnly = true;
            dgvBarbeiros.Size = new Size(618, 296);
            dgvBarbeiros.TabIndex = 75;
            dgvBarbeiros.CellClick += dgvBarbeiros_CellClick;
            dgvBarbeiros.CellFormatting += dgvBarbeiros_CellFormatting;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Telefone
            // 
            Telefone.DataPropertyName = "Telefone";
            Telefone.HeaderText = "Telefone";
            Telefone.Name = "Telefone";
            Telefone.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "E-mail";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // DataNascimento
            // 
            DataNascimento.DataPropertyName = "DataNascimento";
            DataNascimento.HeaderText = "Nascimento";
            DataNascimento.Name = "DataNascimento";
            DataNascimento.ReadOnly = true;
            // 
            // PercentualComissao
            // 
            PercentualComissao.DataPropertyName = "PercentualComissao";
            PercentualComissao.HeaderText = "Comissao (%)";
            PercentualComissao.Name = "PercentualComissao";
            PercentualComissao.ReadOnly = true;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(164, 99);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(192, 29);
            txtEmail.TabIndex = 35;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.Location = new Point(5, 102);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 21);
            lblEmail.TabIndex = 30;
            lblEmail.Text = "E-mail:";
            // 
            // lblDtNascimento
            // 
            lblDtNascimento.AutoSize = true;
            lblDtNascimento.Font = new Font("Segoe UI", 12F);
            lblDtNascimento.Location = new Point(5, 140);
            lblDtNascimento.Name = "lblDtNascimento";
            lblDtNascimento.Size = new Size(153, 21);
            lblDtNascimento.TabIndex = 40;
            lblDtNascimento.Text = "Data de Nascimento:";
            // 
            // dtpDtNascimento
            // 
            dtpDtNascimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDtNascimento.Format = DateTimePickerFormat.Short;
            dtpDtNascimento.Location = new Point(164, 134);
            dtpDtNascimento.Name = "dtpDtNascimento";
            dtpDtNascimento.Size = new Size(192, 29);
            dtpDtNascimento.TabIndex = 45;
            // 
            // mtbTelefone
            // 
            mtbTelefone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtbTelefone.Location = new Point(164, 64);
            mtbTelefone.Mask = "(00) 00000-0000";
            mtbTelefone.Name = "mtbTelefone";
            mtbTelefone.Size = new Size(192, 29);
            mtbTelefone.TabIndex = 25;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.Transparent;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Image = (Image)resources.GetObject("btnAtualizar.Image");
            btnAtualizar.Location = new Point(973, 174);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(23, 23);
            btnAtualizar.TabIndex = 70;
            btnAtualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.BackColor = SystemColors.Control;
            txtPesquisar.Location = new Point(817, 174);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar barbeiro...";
            txtPesquisar.Size = new Size(150, 23);
            txtPesquisar.TabIndex = 65;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // gbBarbeiro
            // 
            gbBarbeiro.Controls.Add(nudPercentualComissao);
            gbBarbeiro.Controls.Add(lblPercentualComissao);
            gbBarbeiro.Controls.Add(lblNome);
            gbBarbeiro.Controls.Add(lblTelefone);
            gbBarbeiro.Controls.Add(lblEmail);
            gbBarbeiro.Controls.Add(mtbTelefone);
            gbBarbeiro.Controls.Add(lblDtNascimento);
            gbBarbeiro.Controls.Add(dtpDtNascimento);
            gbBarbeiro.Controls.Add(txtNome);
            gbBarbeiro.Controls.Add(txtEmail);
            gbBarbeiro.Controls.Add(btnExcluir);
            gbBarbeiro.Controls.Add(btnNovo);
            gbBarbeiro.Controls.Add(btnSalvar);
            gbBarbeiro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbBarbeiro.Location = new Point(10, 174);
            gbBarbeiro.Name = "gbBarbeiro";
            gbBarbeiro.Size = new Size(362, 325);
            gbBarbeiro.TabIndex = 5;
            gbBarbeiro.TabStop = false;
            gbBarbeiro.Text = "Informações do Barbeiro";
            // 
            // nudPercentualComissao
            // 
            nudPercentualComissao.DecimalPlaces = 2;
            nudPercentualComissao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudPercentualComissao.Increment = new decimal(new int[] { 50, 0, 0, 131072 });
            nudPercentualComissao.Location = new Point(164, 169);
            nudPercentualComissao.Name = "nudPercentualComissao";
            nudPercentualComissao.Size = new Size(192, 29);
            nudPercentualComissao.TabIndex = 62;
            nudPercentualComissao.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPercentualComissao
            // 
            lblPercentualComissao.AutoSize = true;
            lblPercentualComissao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPercentualComissao.Location = new Point(6, 171);
            lblPercentualComissao.Name = "lblPercentualComissao";
            lblPercentualComissao.Size = new Size(105, 21);
            lblPercentualComissao.TabIndex = 61;
            lblPercentualComissao.Text = "Comissão (%)";
            // 
            // FormBarbeiros
            // 
            AcceptButton = btnSalvar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 511);
            Controls.Add(gbBarbeiro);
            Controls.Add(txtPesquisar);
            Controls.Add(btnAtualizar);
            Controls.Add(dgvBarbeiros);
            Controls.Add(pnClientes);
            Name = "FormBarbeiros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestão de Barbearia - Barbeiros";
            FormClosing += FormBarbeiros_FormClosing;
            Load += FormBarbeiros_Load;
            pnClientes.ResumeLayout(false);
            pnClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcBarber).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBarbeiros).EndInit();
            gbBarbeiro.ResumeLayout(false);
            gbBarbeiro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPercentualComissao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnClientes;
        private PictureBox pcBarber;
        private Label lblGestaoBarbeiros;
        private Label lblNome;
        private Label lblTelefone;
        private TextBox txtNome;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnExcluir;
        private DataGridView dgvBarbeiros;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblDtNascimento;
        private DateTimePicker dtpDtNascimento;
        private MaskedTextBox mtbTelefone;
        private Button btnAtualizar;
        private TextBox txtPesquisar;
        private GroupBox gbBarbeiro;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn DataNascimento;
        private DataGridViewTextBoxColumn PercentualComissao;
        private NumericUpDown nudPercentualComissao;
        private Label lblPercentualComissao;
    }
}