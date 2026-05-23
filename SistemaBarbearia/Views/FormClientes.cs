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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void AtualizarGrid()
        {
            try
            {
                var service = new ClienteService();

                var listaClientes = service.ListarTodos();

                dgvClientes.DataSource = listaClientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista de clientes: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            AtualizarGrid();

            foreach (DataGridViewColumn coluna in dgvClientes.Columns)
            {
                coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Columns["DataNascimento"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];

                string idSelecionado = row.Cells["Id"].Value.ToString();

                txtNome.Text = row.Cells["Nome"].Value.ToString();
                mtbTelefone.Text = row.Cells["Telefone"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                dtpDtNascimento.Value = Convert.ToDateTime(row.Cells["DataNascimento"].Value);

                this.Tag = idSelecionado;
            }
        }

        private void dgvClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvClientes.Columns[e.ColumnIndex].Name == "Telefone" && e.Value != null)
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
            this.Tag = null;
            txtNome.Focus();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            var service = new ClienteService();

            dgvClientes.DataSource = service.ListarPorNome(txtPesquisar.Text);
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

                var service = new ClienteService();

                if (this.Tag == null || string.IsNullOrEmpty(this.Tag.ToString()))
                {
                    service.Inserir(txtNome.Text, mtbTelefone.Text, txtEmail.Text, dtpDtNascimento.Value);
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int id = Convert.ToInt32(this.Tag);
                    service.Atualizar(id, txtNome.Text, mtbTelefone.Text, txtEmail.Text, dtpDtNascimento.Value);
                    MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Por favor, selecione um cliente na lista para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja excluir este cliente?",
                                                       "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(this.Tag);
                    ClienteService service = new ClienteService();
                    service.Deletar(id);

                    MessageBox.Show("Cliente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Novo();

                    AtualizarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();

            var form = new FormLogin();
            form.ShowDialog();
        }
    }
}
