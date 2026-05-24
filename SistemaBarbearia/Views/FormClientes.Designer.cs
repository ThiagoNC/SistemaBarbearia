namespace SistemaBarbearia.Views
{
    partial class FormClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnClientes = new Panel();
            pcBarber = new PictureBox();
            lblGestaoClientes = new Label();
            lblNome = new Label();
            lblTelefone = new Label();
            txtNome = new TextBox();
            btnNovo = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            dgvClientes = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            DataNascimento = new DataGridViewTextBoxColumn();
            DataCadastro = new DataGridViewTextBoxColumn();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblDtNascimento = new Label();
            dtpDtNascimento = new DateTimePicker();
            mtbTelefone = new MaskedTextBox();
            btnAtualizar = new Button();
            txtPesquisar = new TextBox();
            gbCliente = new GroupBox();
            pnClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcBarber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            gbCliente.SuspendLayout();
            SuspendLayout();
            // 
            // pnClientes
            // 
            pnClientes.BackColor = Color.MidnightBlue;
            pnClientes.Controls.Add(pcBarber);
            pnClientes.Controls.Add(lblGestaoClientes);
            pnClientes.Dock = DockStyle.Top;
            pnClientes.Location = new Point(0, 0);
            pnClientes.Name = "pnClientes";
            pnClientes.Size = new Size(1008, 150);
            pnClientes.TabIndex = 0;
            // 
            // pcBarber
            // 
            pcBarber.Image = (Image)resources.GetObject("pcBarber.Image");
            pcBarber.Location = new Point(197, 27);
            pcBarber.Name = "pcBarber";
            pcBarber.Size = new Size(100, 100);
            pcBarber.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBarber.TabIndex = 1;
            pcBarber.TabStop = false;
            // 
            // lblGestaoClientes
            // 
            lblGestaoClientes.AutoSize = true;
            lblGestaoClientes.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestaoClientes.ForeColor = Color.White;
            lblGestaoClientes.Location = new Point(303, 45);
            lblGestaoClientes.Name = "lblGestaoClientes";
            lblGestaoClientes.Size = new Size(512, 65);
            lblGestaoClientes.TabIndex = 0;
            lblGestaoClientes.Text = "GESTÃO DE CLIENTES";
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
            btnNovo.Location = new Point(10, 195);
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
            btnSalvar.Location = new Point(126, 195);
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
            btnExcluir.Location = new Point(242, 195);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 35);
            btnExcluir.TabIndex = 60;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dgvClientes
            // 
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Telefone, Email, DataNascimento, DataCadastro });
            dgvClientes.Location = new Point(378, 203);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.Size = new Size(618, 296);
            dgvClientes.TabIndex = 75;
            dgvClientes.CellClick += dgvClientes_CellClick;
            dgvClientes.CellFormatting += dgvClientes_CellFormatting;
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
            // DataCadastro
            // 
            DataCadastro.DataPropertyName = "DataCadastro";
            DataCadastro.HeaderText = "Cadastro";
            DataCadastro.Name = "DataCadastro";
            DataCadastro.ReadOnly = true;
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
            txtPesquisar.PlaceholderText = "Pesquisar cliente...";
            txtPesquisar.Size = new Size(150, 23);
            txtPesquisar.TabIndex = 65;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // gbCliente
            // 
            gbCliente.Controls.Add(lblNome);
            gbCliente.Controls.Add(lblTelefone);
            gbCliente.Controls.Add(lblEmail);
            gbCliente.Controls.Add(mtbTelefone);
            gbCliente.Controls.Add(lblDtNascimento);
            gbCliente.Controls.Add(dtpDtNascimento);
            gbCliente.Controls.Add(txtNome);
            gbCliente.Controls.Add(txtEmail);
            gbCliente.Controls.Add(btnExcluir);
            gbCliente.Controls.Add(btnNovo);
            gbCliente.Controls.Add(btnSalvar);
            gbCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbCliente.Location = new Point(10, 174);
            gbCliente.Name = "gbCliente";
            gbCliente.Size = new Size(362, 325);
            gbCliente.TabIndex = 5;
            gbCliente.TabStop = false;
            gbCliente.Text = "Informações do Cliente";
            // 
            // FormClientes
            // 
            AcceptButton = btnSalvar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 511);
            Controls.Add(gbCliente);
            Controls.Add(txtPesquisar);
            Controls.Add(btnAtualizar);
            Controls.Add(dgvClientes);
            Controls.Add(pnClientes);
            Name = "FormClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestão de Barbearia - Clientes";
            FormClosing += FormClientes_FormClosing;
            Load += FormClientes_Load;
            KeyDown += FormClientes_KeyDown;
            pnClientes.ResumeLayout(false);
            pnClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcBarber).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            gbCliente.ResumeLayout(false);
            gbCliente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnClientes;
        private PictureBox pcBarber;
        private Label lblGestaoClientes;
        private Label lblNome;
        private Label lblTelefone;
        private TextBox txtNome;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnExcluir;
        private DataGridView dgvClientes;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblDtNascimento;
        private DateTimePicker dtpDtNascimento;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn DataNascimento;
        private DataGridViewTextBoxColumn DataCadastro;
        private MaskedTextBox mtbTelefone;
        private Button btnAtualizar;
        private TextBox txtPesquisar;
        private GroupBox gbCliente;
    }
}