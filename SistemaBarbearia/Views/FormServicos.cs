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
    public partial class FormServicos : Form
    {
        public FormServicos()
        {
            InitializeComponent();
        }

        private void AtualizarGrid()
        {
            try
            {
                var service = new ServicoService();

                var listaServicos = service.ListarTodos();

                dgvServicos.DataSource = listaServicos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista de servicos: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormServicos_Load(object sender, EventArgs e)
        {
            AtualizarGrid();

            foreach (DataGridViewColumn coluna in dgvServicos.Columns)
            {
                coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvServicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dgvServicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvServicos.Rows[e.RowIndex];

                string idSelecionado = row.Cells["Id"].Value.ToString();

                txtNome.Text = row.Cells["Nome"].Value.ToString();
                nudPreco.Value = Convert.ToDecimal(row.Cells["Preco"].Value);
                nudDuracaoMinutos.Value = Convert.ToInt32(row.Cells["DuracaoMinutos"].Value);

                this.Tag = idSelecionado;
            }
        }

        private void dgvServicos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvServicos.Columns[e.ColumnIndex].Name == "Preco" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal preco))
                {
                    e.Value = preco.ToString("C2");
                    e.FormattingApplied = true;
                }
            }
        }

        private void Novo()
        {
            txtNome.Clear();
            nudPreco.Value = 0;
            nudDuracaoMinutos.Value = 1;
            this.Tag = null;
            txtNome.Focus();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            var service = new ServicoService();

            dgvServicos.DataSource = service.ListarPorNome(txtPesquisar.Text);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
            MessageBox.Show("Lista atualizada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    MessageBox.Show("O nome do serviço é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var service = new ServicoService();

                if (this.Tag == null || string.IsNullOrEmpty(this.Tag.ToString()))
                {
                    service.Inserir(txtNome.Text, nudPreco.Value, (int)nudDuracaoMinutos.Value);
                    MessageBox.Show("Serviço cadastrado com sucesso!");
                }
                else
                {
                    int id = Convert.ToInt32(this.Tag);
                    service.Atualizar(id, txtNome.Text, nudPreco.Value, (int)nudDuracaoMinutos.Value);
                    MessageBox.Show("Serviço atualizado com sucesso!");
                }

                Novo();

                AtualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (this.Tag == null || string.IsNullOrEmpty(this.Tag.ToString()))
            {
                MessageBox.Show("Por favor, selecione um servico na lista para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja excluir este servico?",
                                                       "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(this.Tag);
                    var service = new ServicoService();
                    service.Deletar(id);

                    MessageBox.Show("Servico excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Novo();

                    AtualizarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormServicos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();

            var form = new FormLogin();
            form.ShowDialog();
        }
    }
}
