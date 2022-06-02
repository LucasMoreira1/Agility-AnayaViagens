using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Programa_STPMJ
{
    public partial class FormDependentes : Form
    {
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
            
            int registroSelecionado = Convert.ToInt32(txtRegistroSelecionado.Text);

            if (MessageBox.Show("Tem certeza que deseja deletar os dados selecionados?", "Deletar Dados",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CRUD.sql = "DELETE FROM DEPENDENTES WHERE CadNumero = " + registroSelecionado + "";
                CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
                CRUD.PerformCRUD(CRUD.cmd);

                MessageBox.Show("Dados deletados com sucesso.", "Deletar dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
        }
    }
}
