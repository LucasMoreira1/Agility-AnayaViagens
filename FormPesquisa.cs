﻿using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;

namespace Programa_STPMJ
{

    public partial class FormPesquisa : Form
    {
        private int row = 0;
        private string id = "";
        public FormPesquisa()
        {
            InitializeComponent();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            loadData("");
        }

        public void btnPesquisar_Click(object sender, EventArgs e)
        {
            loadFiltro();
        }

        public void loadFiltro()
        {
            CRUD.sql = "SELECT * FROM CLIENTES WHERE " + cboxFiltro2.Text.Trim() + " LIKE '%" + txtFiltro2.Text.Trim() + "%' AND " +
              "" + cboxFiltro3.Text.Trim() + " LIKE '%" + txtFiltro3.Text.Trim() + "%';";

            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            if (dt.Rows.Count > 0)
            {
                row = Convert.ToInt32(dt.Rows.Count.ToString());
            }
            else
            {
                row = 0;
            }

            toolStripStatusLabel1.Text = "Número de linha(s): " + row.ToString();

            DataGridView dgv = dataGridView1;

            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DataSource = dt;
            dgv.Columns["Foto"].Visible = false;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void loadData(string keyword)
        {

            CRUD.sql = "SELECT * FROM CLIENTES;";
            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);


            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);
            
            if (dt.Rows.Count > 0)
            {
                row = Convert.ToInt32(dt.Rows.Count.ToString());
            }
            else
            {
                row = 0;
            }

            toolStripStatusLabel1.Text = "Número de linha(s): " + row.ToString();

            DataGridView dgv = dataGridView1;

            dgv.MultiSelect=false;
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DataSource = dt;
            dgv.Columns["Foto"].Visible = false;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = dataGridView1;
            FormCadastro formcadastro = new FormCadastro();


            formcadastro.btnSalvar.Visible = false;
            formcadastro.btnAtualizar.Visible = true;
            formcadastro.Show();
            
            formcadastro.txtNome.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
            formcadastro.txtRG.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            formcadastro.txtCPF.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
            formcadastro.txtDataNascimento.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
            formcadastro.cboxEstadoCivil.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
            formcadastro.txtTelefone.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
            formcadastro.txtEmail.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
            formcadastro.txtCEP.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
            formcadastro.txtLogradouro.Text = Convert.ToString(dgv.CurrentRow.Cells[8].Value);
            formcadastro.txtNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[9].Value);
            formcadastro.txtComplemento.Text = Convert.ToString(dgv.CurrentRow.Cells[10].Value);
            formcadastro.txtBairro.Text = Convert.ToString(dgv.CurrentRow.Cells[11].Value);
            formcadastro.txtCidade.Text = Convert.ToString(dgv.CurrentRow.Cells[12].Value);
            formcadastro.txtEstado.Text = Convert.ToString(dgv.CurrentRow.Cells[13].Value);
            formcadastro.txtObservacao.Text = Convert.ToString(dgv.CurrentRow.Cells[14].Value);
            MemoryStream ms = new MemoryStream((byte[])dgv.CurrentRow.Cells[15].Value);
            formcadastro.imgCamera.Image = Image.FromStream(ms);
            formcadastro.txtDataCadastro.Text = Convert.ToString(dgv.CurrentRow.Cells[16].Value);
            formcadastro.txtCadNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[17].Value);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dgv = dataGridView1;
                this.id = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
                txtRegistroSelecionado.Text = Convert.ToString(dgv.CurrentRow.Cells[17].Value);
                btnAtualizar.Text = "Atualizar (" + this.id + ")";
                btnDeletar.Text = "Deletar (" + this.id + ")";

            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dataGridView1;
            FormCadastro formcadastro = new FormCadastro();
            formcadastro.btnSalvar.Visible = false;
            formcadastro.btnAtualizar.Visible = true;
            formcadastro.Show();

            formcadastro.txtNome.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
            formcadastro.txtRG.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            formcadastro.txtCPF.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
            formcadastro.txtDataNascimento.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
            formcadastro.cboxEstadoCivil.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
            formcadastro.txtTelefone.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
            formcadastro.txtEmail.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
            formcadastro.txtCEP.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
            formcadastro.txtLogradouro.Text = Convert.ToString(dgv.CurrentRow.Cells[8].Value);
            formcadastro.txtNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[9].Value);
            formcadastro.txtComplemento.Text = Convert.ToString(dgv.CurrentRow.Cells[10].Value);
            formcadastro.txtBairro.Text = Convert.ToString(dgv.CurrentRow.Cells[11].Value);
            formcadastro.txtCidade.Text = Convert.ToString(dgv.CurrentRow.Cells[12].Value);
            formcadastro.txtEstado.Text = Convert.ToString(dgv.CurrentRow.Cells[13].Value);
            formcadastro.txtObservacao.Text = Convert.ToString(dgv.CurrentRow.Cells[14].Value);
            MemoryStream ms = new MemoryStream((byte[])dgv.CurrentRow.Cells[15].Value);
            formcadastro.imgCamera.Image = Image.FromStream(ms);
            formcadastro.txtDataCadastro.Text = Convert.ToString(dgv.CurrentRow.Cells[16].Value);
            formcadastro.txtCadNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[17].Value);

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dataGridView1;

            if (dgv.Rows.Count == 0)
            {
                return;
            }
            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Por favor, selecione um item da lista.", "Deletar dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int registroSelecionado = Convert.ToInt32(txtRegistroSelecionado.Text);

            if(MessageBox.Show("Tem certeza que deseja deletar os dados selecionados?","Deletar Dados",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CRUD.sql = "DELETE FROM CLIENTES WHERE CadNumero = " + registroSelecionado + "";
                CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
                CRUD.PerformCRUD(CRUD.cmd);

                MessageBox.Show("Dados deletados com sucesso.", "Deletar dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadData("");
            }
        }
        private void FormPesquisa_Load(object sender, EventArgs e)
        {
            //loadData("");
        }

        public void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnPesquisar_Click(sender,e);
        }
    }
}