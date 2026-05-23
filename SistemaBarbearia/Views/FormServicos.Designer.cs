namespace SistemaBarbearia.Views
{
    partial class FormServicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServicos));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnClientes = new Panel();
            pcBarber = new PictureBox();
            lblGestaoServico = new Label();
            lblNome = new Label();
            lblPreco = new Label();
            txtNome = new TextBox();
            btnNovo = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            dgvServicos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Preco = new DataGridViewTextBoxColumn();
            DuracaoMinutos = new DataGridViewTextBoxColumn();
            lblDuracaoMinutos = new Label();
            btnAtualizar = new Button();
            txtPesquisar = new TextBox();
            gbServico = new GroupBox();
            nudDuracaoMinutos = new NumericUpDown();
            nudPreco = new NumericUpDown();
            pnClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcBarber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServicos).BeginInit();
            gbServico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDuracaoMinutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPreco).BeginInit();
            SuspendLayout();
            // 
            // pnClientes
            // 
            pnClientes.BackColor = Color.MidnightBlue;
            pnClientes.Controls.Add(pcBarber);
            pnClientes.Controls.Add(lblGestaoServico);
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
            // lblGestaoServico
            // 
            lblGestaoServico.AutoSize = true;
            lblGestaoServico.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestaoServico.ForeColor = Color.White;
            lblGestaoServico.Location = new Point(318, 45);
            lblGestaoServico.Name = "lblGestaoServico";
            lblGestaoServico.Size = new Size(452, 65);
            lblGestaoServico.TabIndex = 0;
            lblGestaoServico.Text = "Gestão de Serviços";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(6, 32);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(133, 21);
            lblNome.TabIndex = 10;
            lblNome.Text = "Nome do Serviço:";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI", 12F);
            lblPreco.Location = new Point(6, 66);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(85, 21);
            lblPreco.TabIndex = 20;
            lblPreco.Text = "Preço (R$):";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            btnNovo.Location = new Point(10, 156);
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
            btnSalvar.Location = new Point(126, 156);
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
            btnExcluir.Location = new Point(242, 156);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 35);
            btnExcluir.TabIndex = 60;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dgvServicos
            // 
            dataGridViewCellStyle5.BackColor = Color.Gainsboro;
            dgvServicos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvServicos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvServicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServicos.BackgroundColor = Color.White;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvServicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvServicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicos.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Preco, DuracaoMinutos });
            dgvServicos.Location = new Point(378, 203);
            dgvServicos.Name = "dgvServicos";
            dgvServicos.ReadOnly = true;
            dgvServicos.Size = new Size(618, 296);
            dgvServicos.TabIndex = 75;
            dgvServicos.CellClick += dgvServicos_CellClick;
            dgvServicos.CellFormatting += dgvServicos_CellFormatting;
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
            // Preco
            // 
            Preco.DataPropertyName = "Preco";
            Preco.HeaderText = "Preço (R$)";
            Preco.Name = "Preco";
            Preco.ReadOnly = true;
            // 
            // DuracaoMinutos
            // 
            DuracaoMinutos.DataPropertyName = "DuracaoMinutos";
            DuracaoMinutos.HeaderText = "Duração (Minutos)";
            DuracaoMinutos.Name = "DuracaoMinutos";
            DuracaoMinutos.ReadOnly = true;
            // 
            // lblDuracaoMinutos
            // 
            lblDuracaoMinutos.AutoSize = true;
            lblDuracaoMinutos.Font = new Font("Segoe UI", 12F);
            lblDuracaoMinutos.Location = new Point(6, 101);
            lblDuracaoMinutos.Name = "lblDuracaoMinutos";
            lblDuracaoMinutos.Size = new Size(142, 21);
            lblDuracaoMinutos.TabIndex = 40;
            lblDuracaoMinutos.Text = "Duração (Minutos):";
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
            txtPesquisar.PlaceholderText = "Pesquisar serviço...";
            txtPesquisar.Size = new Size(150, 23);
            txtPesquisar.TabIndex = 65;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // gbServico
            // 
            gbServico.Controls.Add(nudDuracaoMinutos);
            gbServico.Controls.Add(nudPreco);
            gbServico.Controls.Add(lblNome);
            gbServico.Controls.Add(lblPreco);
            gbServico.Controls.Add(lblDuracaoMinutos);
            gbServico.Controls.Add(txtNome);
            gbServico.Controls.Add(btnExcluir);
            gbServico.Controls.Add(btnNovo);
            gbServico.Controls.Add(btnSalvar);
            gbServico.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbServico.Location = new Point(10, 174);
            gbServico.Name = "gbServico";
            gbServico.Size = new Size(362, 325);
            gbServico.TabIndex = 5;
            gbServico.TabStop = false;
            gbServico.Text = "Informações do Serviço";
            // 
            // nudDuracaoMinutos
            // 
            nudDuracaoMinutos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudDuracaoMinutos.Location = new Point(164, 99);
            nudDuracaoMinutos.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nudDuracaoMinutos.Name = "nudDuracaoMinutos";
            nudDuracaoMinutos.Size = new Size(192, 29);
            nudDuracaoMinutos.TabIndex = 45;
            nudDuracaoMinutos.TextAlign = HorizontalAlignment.Center;
            // 
            // nudPreco
            // 
            nudPreco.DecimalPlaces = 2;
            nudPreco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudPreco.Increment = new decimal(new int[] { 50, 0, 0, 131072 });
            nudPreco.Location = new Point(164, 64);
            nudPreco.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudPreco.Name = "nudPreco";
            nudPreco.Size = new Size(192, 29);
            nudPreco.TabIndex = 25;
            nudPreco.TextAlign = HorizontalAlignment.Center;
            // 
            // FormServicos
            // 
            AcceptButton = btnSalvar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 511);
            Controls.Add(gbServico);
            Controls.Add(txtPesquisar);
            Controls.Add(btnAtualizar);
            Controls.Add(dgvServicos);
            Controls.Add(pnClientes);
            Name = "FormServicos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestão de Barbearia - Serviços";
            FormClosing += FormServicos_FormClosing;
            Load += FormServicos_Load;
            pnClientes.ResumeLayout(false);
            pnClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcBarber).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServicos).EndInit();
            gbServico.ResumeLayout(false);
            gbServico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDuracaoMinutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPreco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnClientes;
        private PictureBox pcBarber;
        private Label lblGestaoServico;
        private Label lblNome;
        private Label lblPreco;
        private TextBox txtNome;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnExcluir;
        private DataGridView dgvServicos;
        private Label lblDuracaoMinutos;
        private Button btnAtualizar;
        private TextBox txtPesquisar;
        private GroupBox gbServico;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Preco;
        private DataGridViewTextBoxColumn DuracaoMinutos;
        private NumericUpDown nudPreco;
        private NumericUpDown nudDuracaoMinutos;
    }
}