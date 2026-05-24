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
    public partial class FormBarbeiros : Form
    {
        public FormBarbeiros()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void AtualizarGrid()
        {
            try
            {
                var service = new BarbeiroService();

                var listaBarbeiros = service.ListarTodos().OrderBy(b => b.Nome).ToList();

                dgvBarbeiros.DataSource = listaBarbeiros;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista de barbeiros: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormBarbeiros_Load(object sender, EventArgs e)
        {
            AtualizarGrid();

            foreach (DataGridViewColumn coluna in dgvBarbeiros.Columns)
            {
                coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvBarbeiros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBarbeiros.Columns["DataNascimento"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void dgvBarbeiros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBarbeiros.Rows[e.RowIndex];

                string idSelecionado = row.Cells["Id"].Value.ToString();

                txtNome.Text = row.Cells["Nome"].Value.ToString();
                mtbTelefone.Text = row.Cells["Telefone"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                dtpDtNascimento.Value = Convert.ToDateTime(row.Cells["DataNascimento"].Value);
                nudPercentualComissao.Value = Convert.ToDecimal(row.Cells["PercentualComissao"].Value);

                this.Tag = idSelecionado;
            }
        }

        private void dgvBarbeiros_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvBarbeiros.Columns[e.ColumnIndex].Name == "Telefone" && e.Value != null)
            {
                string tel = e.Value.ToString();

                if (tel.Length == 11)
                {
                    e.Value = string.Format("({0}) {1}-{2}",
                        tel.Substring(0, 2),
                        tel.Substring(2, 5),
                        tel.Substring(7, 4));
                    e.FormattingApplied = true;
                }
            }
        }

        private void Novo()
        {
            txtNome.Clear();
            mtbTelefone.Clear();
            txtEmail.Clear();
            dtpDtNascimento.Value = DateTime.Now;
            nudPercentualComissao.Value = 0;
            this.Tag = null;
            txtNome.Focus();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            var service = new BarbeiroService();

            dgvBarbeiros.DataSource = service.ListarPorNome(txtPesquisar.Text).OrderBy(b => b.Nome).ToList();
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
                    MessageBox.Show("O nome é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var service = new BarbeiroService();

                if (this.Tag == null || string.IsNullOrEmpty(this.Tag.ToString()))
                {
                    service.Inserir(new Barbeiro { Nome = txtNome.Text, Telefone = mtbTelefone.Text, Email = txtEmail.Text, DataNascimento = dtpDtNascimento.Value, PercentualComissao = nudPercentualComissao.Value });
                    MessageBox.Show("Barbeiro cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int id = Convert.ToInt32(this.Tag);
                    service.Atualizar(new Barbeiro { Id = id, Nome = txtNome.Text, Telefone = mtbTelefone.Text, Email = txtEmail.Text, DataNascimento = dtpDtNascimento.Value, PercentualComissao = nudPercentualComissao.Value });
                    MessageBox.Show("Barbeiro atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Por favor, selecione um barbeiro na lista para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja excluir este barbeiro?",
                                                       "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(this.Tag);
                    BarbeiroService service = new BarbeiroService();
                    service.Deletar(id);

                    MessageBox.Show("Barbeiro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Novo();

                    AtualizarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormBarbeiros_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();

            var form = new FormPrincipal();
            form.ShowDialog();
        }

        private void FormBarbeiros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
