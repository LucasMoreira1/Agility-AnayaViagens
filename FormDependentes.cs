using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Programa_STPMJ
{
    public partial class FormDependentes : Form
    {
        private int row = 0;
        private string id = "";
        public FormDependentes()
        {
            InitializeComponent();
        }

        private void FormDependentes_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void CarregarDados()
        {
            CRUD.sql = "SELECT * FROM DEPENDENTES WHERE CadReferencia = " + txtCadReferencia.Text + ";";
            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);


            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            DataGridView dgv = dataGridView1;

            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DataSource = dt;
            dgv.Columns["CadReferencia"].Visible = false;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = dataGridView1;
            FormCadastro formcadastro = new FormCadastro();


            formcadastro.btnSalvar.Visible = false;
            formcadastro.btnAtualizar.Visible = true;
            formcadastro.Show();

            formcadastro.txtCadNumero.Text = txtCadReferencia.Text.Trim();
            formcadastro.txtNomeDependente.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            formcadastro.txtRGDependente.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
            formcadastro.txtOrgEmissorDependente.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
            formcadastro.txtCPFDependente.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
            formcadastro.txtPassaporteDependente.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
            formcadastro.txtCertidaoNascimentoDependente.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
            formcadastro.cboxGrauParentesco.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
            formcadastro.txtDataNascimentoDependente.Text = Convert.ToString(dgv.CurrentRow.Cells[8].Value);
            formcadastro.cboxAutorizacaoDependente.Text = Convert.ToString(dgv.CurrentRow.Cells[9].Value);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
            string registroSelecionado = txtRegistroSelecionado.Text.Trim();


            if (MessageBox.Show("Tem certeza que deseja deletar os dados selecionados?", "Deletar Dados",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CRUD.sql = "DELETE FROM DEPENDENTES WHERE CadReferencia = '" + txtCadReferencia.Text + "' AND NOME = '" + registroSelecionado + "'";
                CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
                CRUD.PerformCRUD(CRUD.cmd);

                MessageBox.Show("Dados deletados com sucesso.", "Deletar dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CarregarDados();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dgv = dataGridView1;
                //this.id = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
                txtRegistroSelecionado.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
                
            }
        }

        private void btnAtualizarLista_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btnEditarDependente_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dataGridView1;
            FormCadastro formcadastro = new FormCadastro();


            formcadastro.btnSalvar.Visible = false;
            formcadastro.btnAtualizar.Visible = true;
            formcadastro.Show();

            formcadastro.txtCadNumero.Text = txtCadReferencia.Text.Trim();
            formcadastro.txtNomeDependente.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            formcadastro.txtRGDependente.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
            formcadastro.txtOrgEmissorDependente.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
            formcadastro.txtCPFDependente.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
            formcadastro.txtPassaporteDependente.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
            formcadastro.txtCertidaoNascimentoDependente.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
            formcadastro.cboxGrauParentesco.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
            formcadastro.txtDataNascimentoDependente.Text = Convert.ToString(dgv.CurrentRow.Cells[8].Value);
            formcadastro.cboxAutorizacaoDependente.Text = Convert.ToString(dgv.CurrentRow.Cells[9].Value);
        }
    }
}
