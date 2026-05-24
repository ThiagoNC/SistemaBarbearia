namespace SistemaBarbearia.Views
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnClientes = new Panel();
            lblPainelPrincipal = new Label();
            pcBarber = new PictureBox();
            lblUsuario = new Label();
            dgvProximosAgendamentos = new DataGridView();
            Hora = new DataGridViewTextBoxColumn();
            NomeCliente = new DataGridViewTextBoxColumn();
            NomeServico = new DataGridViewTextBoxColumn();
            NomeBarbeiro = new DataGridViewTextBoxColumn();
            PrecoServico = new DataGridViewTextBoxColumn();
            DuracaoServico = new DataGridViewTextBoxColumn();
            gbMenu = new GroupBox();
            btnSair = new Button();
            btnAgendamentos = new Button();
            btnServicos = new Button();
            btnBarbeiros = new Button();
            btnClientes = new Button();
            gbProxAgendamentos = new GroupBox();
            pnCinza = new Panel();
            pnClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcBarber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProximosAgendamentos).BeginInit();
            gbMenu.SuspendLayout();
            gbProxAgendamentos.SuspendLayout();
            SuspendLayout();
            // 
            // pnClientes
            // 
            pnClientes.BackColor = Color.MidnightBlue;
            pnClientes.Controls.Add(lblPainelPrincipal);
            pnClientes.Controls.Add(pcBarber);
            pnClientes.Controls.Add(lblUsuario);
            pnClientes.Dock = DockStyle.Top;
            pnClientes.Location = new Point(0, 0);
            pnClientes.Name = "pnClientes";
            pnClientes.Size = new Size(1008, 150);
            pnClientes.TabIndex = 0;
            // 
            // lblPainelPrincipal
            // 
            lblPainelPrincipal.AutoSize = true;
            lblPainelPrincipal.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPainelPrincipal.ForeColor = Color.White;
            lblPainelPrincipal.Location = new Point(318, 27);
            lblPainelPrincipal.Name = "lblPainelPrincipal";
            lblPainelPrincipal.Size = new Size(448, 65);
            lblPainelPrincipal.TabIndex = 0;
            lblPainelPrincipal.Text = "PAINEL PRINCIPAL";
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
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(327, 92);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(94, 21);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Bem-vindo";
            // 
            // dgvProximosAgendamentos
            // 
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dgvProximosAgendamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProximosAgendamentos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProximosAgendamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProximosAgendamentos.BackgroundColor = Color.White;
            dgvProximosAgendamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProximosAgendamentos.Columns.AddRange(new DataGridViewColumn[] { Hora, NomeCliente, NomeServico, NomeBarbeiro, PrecoServico, DuracaoServico });
            dgvProximosAgendamentos.Location = new Point(6, 23);
            dgvProximosAgendamentos.MultiSelect = false;
            dgvProximosAgendamentos.Name = "dgvProximosAgendamentos";
            dgvProximosAgendamentos.ReadOnly = true;
            dgvProximosAgendamentos.Size = new Size(606, 296);
            dgvProximosAgendamentos.TabIndex = 50;
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
            // NomeBarbeiro
            // 
            NomeBarbeiro.DataPropertyName = "NomeBarbeiro";
            NomeBarbeiro.HeaderText = "Barbeiro";
            NomeBarbeiro.Name = "NomeBarbeiro";
            NomeBarbeiro.ReadOnly = true;
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
            // gbMenu
            // 
            gbMenu.BackColor = Color.White;
            gbMenu.Controls.Add(btnSair);
            gbMenu.Controls.Add(btnAgendamentos);
            gbMenu.Controls.Add(btnServicos);
            gbMenu.Controls.Add(btnBarbeiros);
            gbMenu.Controls.Add(btnClientes);
            gbMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbMenu.Location = new Point(10, 174);
            gbMenu.Name = "gbMenu";
            gbMenu.Size = new Size(362, 325);
            gbMenu.TabIndex = 15;
            gbMenu.TabStop = false;
            // 
            // btnSair
            // 
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.ForeColor = Color.Red;
            btnSair.Image = (Image)resources.GetObject("btnSair.Image");
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(6, 270);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(350, 49);
            btnSair.TabIndex = 40;
            btnSair.Text = "SAIR DO SISTEMA";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnAgendamentos
            // 
            btnAgendamentos.FlatStyle = FlatStyle.Flat;
            btnAgendamentos.Image = (Image)resources.GetObject("btnAgendamentos.Image");
            btnAgendamentos.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgendamentos.Location = new Point(6, 188);
            btnAgendamentos.Name = "btnAgendamentos";
            btnAgendamentos.Size = new Size(350, 49);
            btnAgendamentos.TabIndex = 35;
            btnAgendamentos.Text = "AGENDAMENTOS";
            btnAgendamentos.UseVisualStyleBackColor = true;
            btnAgendamentos.Click += btnAgendamentos_Click;
            // 
            // btnServicos
            // 
            btnServicos.FlatStyle = FlatStyle.Flat;
            btnServicos.Image = (Image)resources.GetObject("btnServicos.Image");
            btnServicos.ImageAlign = ContentAlignment.MiddleLeft;
            btnServicos.Location = new Point(6, 133);
            btnServicos.Name = "btnServicos";
            btnServicos.Size = new Size(350, 49);
            btnServicos.TabIndex = 30;
            btnServicos.Text = "SERVIÇOS";
            btnServicos.UseVisualStyleBackColor = true;
            btnServicos.Click += btnServicos_Click;
            // 
            // btnBarbeiros
            // 
            btnBarbeiros.FlatStyle = FlatStyle.Flat;
            btnBarbeiros.Image = (Image)resources.GetObject("btnBarbeiros.Image");
            btnBarbeiros.ImageAlign = ContentAlignment.MiddleLeft;
            btnBarbeiros.Location = new Point(6, 78);
            btnBarbeiros.Name = "btnBarbeiros";
            btnBarbeiros.Size = new Size(350, 49);
            btnBarbeiros.TabIndex = 25;
            btnBarbeiros.Text = "BARBEIROS";
            btnBarbeiros.UseVisualStyleBackColor = true;
            btnBarbeiros.Click += btnBarbeiros_Click;
            // 
            // btnClientes
            // 
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(6, 23);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(350, 49);
            btnClientes.TabIndex = 20;
            btnClientes.Text = "CLIENTES";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // gbProxAgendamentos
            // 
            gbProxAgendamentos.Controls.Add(dgvProximosAgendamentos);
            gbProxAgendamentos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbProxAgendamentos.Location = new Point(378, 174);
            gbProxAgendamentos.Name = "gbProxAgendamentos";
            gbProxAgendamentos.Size = new Size(618, 325);
            gbProxAgendamentos.TabIndex = 45;
            gbProxAgendamentos.TabStop = false;
            gbProxAgendamentos.Text = "Próximos Agendamentos";
            // 
            // pnCinza
            // 
            pnCinza.Location = new Point(10, 174);
            pnCinza.Name = "pnCinza";
            pnCinza.Size = new Size(362, 11);
            pnCinza.TabIndex = 10;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSair;
            ClientSize = new Size(1008, 511);
            Controls.Add(pnCinza);
            Controls.Add(gbProxAgendamentos);
            Controls.Add(gbMenu);
            Controls.Add(pnClientes);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestão de Barbearia - Painel Principal";
            FormClosing += FormPrincipal_FormClosing;
            Load += FormPrincipal_Load;
            pnClientes.ResumeLayout(false);
            pnClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcBarber).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProximosAgendamentos).EndInit();
            gbMenu.ResumeLayout(false);
            gbProxAgendamentos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnClientes;
        private PictureBox pcBarber;
        private Label lblUsuario;
        private DataGridView dgvProximosAgendamentos;
        private GroupBox gbMenu;
        private Label lblPainelPrincipal;
        private GroupBox gbProxAgendamentos;
        private Button btnAgendamentos;
        private Button btnServicos;
        private Button btnBarbeiros;
        private Button btnClientes;
        private Button btnSair;
        private Panel pnCinza;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn NomeCliente;
        private DataGridViewTextBoxColumn NomeServico;
        private DataGridViewTextBoxColumn NomeBarbeiro;
        private DataGridViewTextBoxColumn PrecoServico;
        private DataGridViewTextBoxColumn DuracaoServico;
    }
}