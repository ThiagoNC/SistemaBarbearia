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
    public partial class FormAgendamentos : Form
    {
        public FormAgendamentos()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void FormAgendamentos_Load(object sender, EventArgs e)
        {
            CarregarComboBoxes();

            AtualizarGrid();

            ConfigurarGrid();
        }

        private void CarregarComboBoxes()
        {
            try
            {
                cbCliente.DataSource = new ClienteService().ListarTodos().OrderBy(c => c.Nome).ToList();
                cbCliente.DisplayMember = "Nome";
                cbCliente.ValueMember = "Id";
                cbCliente.SelectedIndex = -1;

                cbServico.DataSource = new ServicoService().ListarTodos().OrderBy(s => s.Nome).ToList();
                cbServico.DisplayMember = "Nome";
                cbServico.ValueMember = "Id";
                cbServico.SelectedIndex = -1;

                cbBarbeiro.DataSource = new BarbeiroService().ListarTodos().OrderBy(b => b.Nome).ToList();
                cbBarbeiro.DisplayMember = "Nome";
                cbBarbeiro.ValueMember = "Id";
                cbBarbeiro.SelectedIndex = -1;

                cbStatus.Items.Clear();
                cbStatus.Items.AddRange(new string[] { "Pendente", "Concluído", "Cancelado" });
                cbStatus.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados das listas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarGrid()
        {
            try
            {
                var service = new AgendamentoService();
                dgvAgendamentos.DataSource = service.ListarTodos().OrderByDescending(a => a.DataHora).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista de agendamentos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarGrid()
        {
            dgvAgendamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            foreach (DataGridViewColumn coluna in dgvAgendamentos.Columns)
            {
                coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvAgendamentos.Columns["Data"].DataPropertyName = "DataHora";
            dgvAgendamentos.Columns["Data"].DefaultCellStyle.Format = "dd/MM/yyyy";

            dgvAgendamentos.Columns["Hora"].DataPropertyName = "DataHora";
            dgvAgendamentos.Columns["Hora"].DefaultCellStyle.Format = "HH:mm";

            if (dgvAgendamentos.Columns["ClienteId"] != null) dgvAgendamentos.Columns["ClienteId"].Visible = false;
            if (dgvAgendamentos.Columns["ServicoId"] != null) dgvAgendamentos.Columns["ServicoId"].Visible = false;
            if (dgvAgendamentos.Columns["BarbeiroId"] != null) dgvAgendamentos.Columns["BarbeiroId"].Visible = false;

            //if (dgvAgendamentos.Columns["DataHora"] != null) dgvAgendamentos.Columns["DataHora"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
        }

        private void Novo()
        {
            cbCliente.SelectedIndex = -1;
            cbServico.SelectedIndex = -1;
            cbBarbeiro.SelectedIndex = -1;
            dtpData.Value = DateTime.Now;
            mtbHora.Clear();
            cbStatus.SelectedIndex = 0;
            this.Tag = null;
            cbCliente.Focus();
        }

        private void dgvAgendamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAgendamentos.Rows[e.RowIndex];

                string idSelecionado = row.Cells["Id"].Value.ToString();

                cbCliente.SelectedValue = row.Cells["ClienteId"].Value;
                cbServico.SelectedValue = row.Cells["ServicoId"].Value;
                cbBarbeiro.SelectedValue = row.Cells["BarbeiroId"].Value;

                DateTime dataHora = Convert.ToDateTime(row.Cells["DataHora"].Value);
                dtpData.Value = dataHora.Date;
                mtbHora.Text = dataHora.ToString("HH:mm");

                cbStatus.SelectedItem = row.Cells["Status"].Value.ToString();

                this.Tag = idSelecionado;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbCliente.SelectedValue == null) { MessageBox.Show("Selecione um Cliente!"); return; }
                if (cbServico.SelectedValue == null) { MessageBox.Show("Selecione um Serviço!"); return; }
                if (cbBarbeiro.SelectedValue == null) { MessageBox.Show("Selecione um Barbeiro!"); return; }

                var service = new AgendamentoService();

                DateTime dataSelecionada = dtpData.Value.Date;
                TimeSpan horaSelecionada;
                if (!TimeSpan.TryParse(mtbHora.Text, out horaSelecionada))
                {
                    MessageBox.Show("Por favor, digite uma hora válida no formato HH:mm.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime dataHoraFinal = dataSelecionada.Add(horaSelecionada);

                var agendamento = new Agendamento
                {
                    ClienteId = Convert.ToInt32(cbCliente.SelectedValue),
                    ServicoId = Convert.ToInt32(cbServico.SelectedValue),
                    BarbeiroId = Convert.ToInt32(cbBarbeiro.SelectedValue),
                    DataHora = dataHoraFinal,
                    Status = cbStatus.SelectedItem?.ToString() ?? "Pendente"
                };

                if (this.Tag == null || string.IsNullOrEmpty(this.Tag.ToString()))
                {
                    service.Inserir(agendamento);
                    MessageBox.Show("Agendamento cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    agendamento.Id = Convert.ToInt32(this.Tag);
                    service.Atualizar(agendamento);
                    MessageBox.Show("Agendamento atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Novo();
                AtualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (this.Tag == null || string.IsNullOrEmpty(this.Tag.ToString()))
            {
                MessageBox.Show("Por favor, selecione um agendamento na lista para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja excluir este agendamento?",
                                                       "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(this.Tag);
                    var service = new AgendamentoService();
                    service.Deletar(id);

                    MessageBox.Show("Agendamento excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Novo();
                    AtualizarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            var service = new AgendamentoService();
            dgvAgendamentos.DataSource = service.ListarPorNome(txtPesquisar.Text);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
            MessageBox.Show("Lista atualizada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormAgendamentos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            var form = new FormPrincipal();
            form.ShowDialog();
        }

        private void FormAgendamentos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
