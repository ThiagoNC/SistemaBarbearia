using SistemaBarbearia.Models;
using SistemaBarbearia.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaBarbearia.Views
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal(string nomeUsuario)
        {
            InitializeComponent();

            lblUsuario.Text = $"Bem-vindo, {nomeUsuario}!";
        }

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            AtualizarGrid();
        }

        private void ConfigurarGrid()
        {
            dgvProximosAgendamentos.AutoGenerateColumns = false;
            dgvProximosAgendamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProximosAgendamentos.MultiSelect = false;
            dgvProximosAgendamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProximosAgendamentos.ReadOnly = true; // Impede que o usuário edite o painel

            if (dgvProximosAgendamentos.Columns["Hora"] != null)
            {
                dgvProximosAgendamentos.Columns["Hora"].DataPropertyName = "DataHora";
                dgvProximosAgendamentos.Columns["Hora"].DefaultCellStyle.Format = "HH:mm";
            }

            if (dgvProximosAgendamentos.Columns["Cliente"] != null)
                dgvProximosAgendamentos.Columns["Cliente"].DataPropertyName = "NomeCliente";

            if (dgvProximosAgendamentos.Columns["Serviço"] != null)
                dgvProximosAgendamentos.Columns["Serviço"].DataPropertyName = "NomeServico";

            if (dgvProximosAgendamentos.Columns["Barbeiro"] != null)
                dgvProximosAgendamentos.Columns["Barbeiro"].DataPropertyName = "NomeBarbeiro";

            if (dgvProximosAgendamentos.Columns["Preço"] != null)
            {
                dgvProximosAgendamentos.Columns["Preço"].DataPropertyName = "PrecoServico";
                dgvProximosAgendamentos.Columns["Preço"].DefaultCellStyle.Format = "C2";
            }

            if (dgvProximosAgendamentos.Columns["Duração"] != null)
            {
                dgvProximosAgendamentos.Columns["Duração"].DataPropertyName = "DuracaoServico";
                dgvProximosAgendamentos.Columns["Duração"].DefaultCellStyle.Format = "0' min'";
            }

            foreach (DataGridViewColumn coluna in dgvProximosAgendamentos.Columns)
            {
                coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void AtualizarGrid()
        {
            try
            {
                var service = new AgendamentoService();
                dgvProximosAgendamentos.DataSource = service.ListarAgendamentosDeHoje();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os agendamentos de hoje: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form = new FormClientes();
            form.ShowDialog();
            AtualizarGrid();
        }

        private void btnBarbeiros_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form = new FormBarbeiros();
            form.ShowDialog();
            AtualizarGrid();
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form = new FormServicos();
            form.ShowDialog();
            AtualizarGrid();
        }

        private void btnAgendamentos_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form = new FormAgendamentos();
            form.ShowDialog();
            AtualizarGrid();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult confirmacao = MessageBox.Show("Deseja realmente sair do sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacao == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
