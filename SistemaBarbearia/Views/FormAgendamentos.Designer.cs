namespace SistemaBarbearia.Views
{
    partial class FormAgendamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgendamentos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnClientes = new Panel();
            pcBarber = new PictureBox();
            lblGestaoAgendamentos = new Label();
            lblCliente = new Label();
            btnNovo = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            dgvAgendamentos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            NomeCliente = new DataGridViewTextBoxColumn();
            NomeServico = new DataGridViewTextBoxColumn();
            PrecoServico = new DataGridViewTextBoxColumn();
            DuracaoServico = new DataGridViewTextBoxColumn();
            NomeBarbeiro = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            DataHora = new DataGridViewTextBoxColumn();
            lblData = new Label();
            dtpData = new DateTimePicker();
            btnAtualizar = new Button();
            txtPesquisar = new TextBox();
            gbAgendamentos = new GroupBox();
            mtbHora = new MaskedTextBox();
            lblBarbeiro = new Label();
            lblServico = new Label();
            cbStatus = new ComboBox();
            cbBarbeiro = new ComboBox();
            cbServico = new ComboBox();
            cbCliente = new ComboBox();
            lblStatus = new Label();
            lblHora = new Label();
            pnClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcBarber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAgendamentos).BeginInit();
            gbAgendamentos.SuspendLayout();
            SuspendLayout();
            // 
            // pnClientes
            // 
            pnClientes.BackColor = Color.MidnightBlue;
            pnClientes.Controls.Add(pcBarber);
            pnClientes.Controls.Add(lblGestaoAgendamentos);
            pnClientes.Dock = DockStyle.Top;
            pnClientes.Location = new Point(0, 0);
            pnClientes.Name = "pnClientes";
            pnClientes.Size = new Size(1008, 150);
            pnClientes.TabIndex = 0;
            // 
            // pcBarber
            // 
            pcBarber.Image = (Image)resources.GetObject("pcBarber.Image");
            pcBarber.Location = new Point(148, 27);
            pcBarber.Name = "pcBarber";
            pcBarber.Size = new Size(100, 100);
            pcBarber.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBarber.TabIndex = 1;
            pcBarber.TabStop = false;
            // 
            // lblGestaoAgendamentos
            // 
            lblGestaoAgendamentos.AutoSize = true;
            lblGestaoAgendamentos.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestaoAgendamentos.ForeColor = Color.White;
            lblGestaoAgendamentos.Location = new Point(254, 45);
            lblGestaoAgendamentos.Name = "lblGestaoAgendamentos";
            lblGestaoAgendamentos.Size = new Size(608, 65);
            lblGestaoAgendamentos.TabIndex = 0;
            lblGestaoAgendamentos.Text = "Gestão de Agendamentos";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(6, 33);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(61, 21);
            lblCliente.TabIndex = 5;
            lblCliente.Text = "Cliente:";
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.Green;
            btnNovo.FlatStyle = FlatStyle.Flat;
            btnNovo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNovo.ForeColor = Color.White;
            btnNovo.Location = new Point(10, 264);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(110, 35);
            btnNovo.TabIndex = 70;
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
            btnSalvar.Location = new Point(126, 264);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(110, 35);
            btnSalvar.TabIndex = 65;
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
            btnExcluir.Location = new Point(242, 264);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 35);
            btnExcluir.TabIndex = 75;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dgvAgendamentos
            // 
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dgvAgendamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAgendamentos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAgendamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAgendamentos.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAgendamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAgendamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAgendamentos.Columns.AddRange(new DataGridViewColumn[] { Id, Data, Hora, NomeCliente, NomeServico, PrecoServico, DuracaoServico, NomeBarbeiro, Status, DataHora });
            dgvAgendamentos.Location = new Point(378, 203);
            dgvAgendamentos.MultiSelect = false;
            dgvAgendamentos.Name = "dgvAgendamentos";
            dgvAgendamentos.ReadOnly = true;
            dgvAgendamentos.Size = new Size(618, 296);
            dgvAgendamentos.TabIndex = 90;
            dgvAgendamentos.CellClick += dgvAgendamentos_CellClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            Id.DefaultCellStyle = dataGridViewCellStyle3;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Data
            // 
            Data.DataPropertyName = "Data";
            Data.HeaderText = "Data";
            Data.Name = "Data";
            Data.ReadOnly = true;
            // 
            // Hora
            // 
            Hora.DataPropertyName = "Hora";
            Hora.HeaderText = "Hora";
            Hora.Name = "Hora";
            Hora.ReadOnly = true;
            // 
            // NomeCliente
            // 
            NomeCliente.DataPropertyName = "NomeCliente";
            NomeCliente.HeaderText = "Cliente";
            NomeCliente.Name = "NomeCliente";
            NomeCliente.ReadOnly = true;
            // 
            // NomeServico
            // 
            NomeServico.DataPropertyName = "NomeServico";
            NomeServico.HeaderText = "Serviço";
            NomeServico.Name = "NomeServico";
            NomeServico.ReadOnly = true;
            // 
            // PrecoServico
            // 
            PrecoServico.DataPropertyName = "PrecoServico";
            PrecoServico.HeaderText = "Preço";
            PrecoServico.Name = "PrecoServico";
            PrecoServico.ReadOnly = true;
            // 
            // DuracaoServico
            // 
            DuracaoServico.DataPropertyName = "DuracaoServico";
            DuracaoServico.HeaderText = "Duração";
            DuracaoServico.Name = "DuracaoServico";
            DuracaoServico.ReadOnly = true;
            // 
            // NomeBarbeiro
            // 
            NomeBarbeiro.DataPropertyName = "NomeBarbeiro";
            NomeBarbeiro.HeaderText = "Barbeiro";
            NomeBarbeiro.Name = "NomeBarbeiro";
            NomeBarbeiro.ReadOnly = true;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // DataHora
            // 
            DataHora.DataPropertyName = "DataHora";
            DataHora.HeaderText = "DataHora";
            DataHora.Name = "DataHora";
            DataHora.ReadOnly = true;
            DataHora.Visible = false;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 12F);
            lblData.Location = new Point(6, 138);
            lblData.Name = "lblData";
            lblData.Size = new Size(45, 21);
            lblData.TabIndex = 35;
            lblData.Text = "Data:";
            // 
            // dtpData
            // 
            dtpData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(164, 134);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(192, 29);
            dtpData.TabIndex = 40;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.Transparent;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Image = (Image)resources.GetObject("btnAtualizar.Image");
            btnAtualizar.Location = new Point(973, 174);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(23, 23);
            btnAtualizar.TabIndex = 85;
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
            txtPesquisar.TabIndex = 80;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // gbAgendamentos
            // 
            gbAgendamentos.Controls.Add(mtbHora);
            gbAgendamentos.Controls.Add(lblBarbeiro);
            gbAgendamentos.Controls.Add(lblServico);
            gbAgendamentos.Controls.Add(cbStatus);
            gbAgendamentos.Controls.Add(cbBarbeiro);
            gbAgendamentos.Controls.Add(cbServico);
            gbAgendamentos.Controls.Add(cbCliente);
            gbAgendamentos.Controls.Add(lblStatus);
            gbAgendamentos.Controls.Add(lblHora);
            gbAgendamentos.Controls.Add(lblCliente);
            gbAgendamentos.Controls.Add(lblData);
            gbAgendamentos.Controls.Add(dtpData);
            gbAgendamentos.Controls.Add(btnExcluir);
            gbAgendamentos.Controls.Add(btnNovo);
            gbAgendamentos.Controls.Add(btnSalvar);
            gbAgendamentos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbAgendamentos.Location = new Point(10, 174);
            gbAgendamentos.Name = "gbAgendamentos";
            gbAgendamentos.Size = new Size(362, 325);
            gbAgendamentos.TabIndex = 1;
            gbAgendamentos.TabStop = false;
            gbAgendamentos.Text = "Informações do Agendamento";
            // 
            // mtbHora
            // 
            mtbHora.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtbHora.Location = new Point(164, 169);
            mtbHora.Mask = "00:00";
            mtbHora.Name = "mtbHora";
            mtbHora.Size = new Size(192, 29);
            mtbHora.TabIndex = 50;
            // 
            // lblBarbeiro
            // 
            lblBarbeiro.AutoSize = true;
            lblBarbeiro.Font = new Font("Segoe UI", 12F);
            lblBarbeiro.Location = new Point(6, 103);
            lblBarbeiro.Name = "lblBarbeiro";
            lblBarbeiro.Size = new Size(72, 21);
            lblBarbeiro.TabIndex = 25;
            lblBarbeiro.Text = "Barbeiro:";
            // 
            // lblServico
            // 
            lblServico.AutoSize = true;
            lblServico.Font = new Font("Segoe UI", 12F);
            lblServico.Location = new Point(6, 68);
            lblServico.Name = "lblServico";
            lblServico.Size = new Size(64, 21);
            lblServico.TabIndex = 15;
            lblServico.Text = "Serviço:";
            // 
            // cbStatus
            // 
            cbStatus.DisplayMember = "0";
            cbStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(164, 204);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(192, 29);
            cbStatus.TabIndex = 60;
            cbStatus.ValueMember = "0";
            // 
            // cbBarbeiro
            // 
            cbBarbeiro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbBarbeiro.FormattingEnabled = true;
            cbBarbeiro.Location = new Point(164, 99);
            cbBarbeiro.Name = "cbBarbeiro";
            cbBarbeiro.Size = new Size(192, 29);
            cbBarbeiro.TabIndex = 30;
            // 
            // cbServico
            // 
            cbServico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbServico.FormattingEnabled = true;
            cbServico.Location = new Point(164, 64);
            cbServico.Name = "cbServico";
            cbServico.Size = new Size(192, 29);
            cbServico.TabIndex = 20;
            // 
            // cbCliente
            // 
            cbCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(164, 29);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(192, 29);
            cbCliente.TabIndex = 10;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F);
            lblStatus.Location = new Point(6, 208);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(55, 21);
            lblStatus.TabIndex = 55;
            lblStatus.Text = "Status:";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 12F);
            lblHora.Location = new Point(6, 173);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(47, 21);
            lblHora.TabIndex = 45;
            lblHora.Text = "Hora:";
            // 
            // FormAgendamentos
            // 
            AcceptButton = btnSalvar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 511);
            Controls.Add(gbAgendamentos);
            Controls.Add(txtPesquisar);
            Controls.Add(btnAtualizar);
            Controls.Add(dgvAgendamentos);
            Controls.Add(pnClientes);
            Name = "FormAgendamentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestão de Barbearia - Agendamentos";
            FormClosing += FormAgendamentos_FormClosing;
            Load += FormAgendamentos_Load;
            KeyDown += FormAgendamentos_KeyDown;
            pnClientes.ResumeLayout(false);
            pnClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcBarber).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAgendamentos).EndInit();
            gbAgendamentos.ResumeLayout(false);
            gbAgendamentos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnClientes;
        private PictureBox pcBarber;
        private Label lblGestaoAgendamentos;
        private Label lblCliente;
        private Label lblTelefone;
        private TextBox txtNome;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnExcluir;
        private DataGridView dgvAgendamentos;
        private Label lblEmail;
        private Label lblData;
        private DateTimePicker dtpData;
        private MaskedTextBox mtbTelefone;
        private Button btnAtualizar;
        private TextBox txtPesquisar;
        private GroupBox gbAgendamentos;
        private Label lblStatus;
        private Label lblHora;
        private ComboBox cbCliente;
        private ComboBox cbBarbeiro;
        private ComboBox cbServico;
        private ComboBox cbStatus;
        private Label lblBarbeiro;
        private Label lblServico;
        private MaskedTextBox mtbHora;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn NomeCliente;
        private DataGridViewTextBoxColumn NomeServico;
        private DataGridViewTextBoxColumn PrecoServico;
        private DataGridViewTextBoxColumn DuracaoServico;
        private DataGridViewTextBoxColumn NomeBarbeiro;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn DataHora;
    }
}