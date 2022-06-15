using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System;

namespace ANAYA_VIAGENS
{
    public partial class FormCriarPacote : Form
    {
        public FormCriarPacote()
        {
            InitializeComponent();
            LimparDados();
        }

        private void LimparDados()
        {
            txtCodPacote.Text = "";
            txtDataViagem.Text = "";
            txtDestino.Text = "";
            txtRoteiro.Text = "";
        }

        private void Executar(string MySql, string param)
        {
            CRUD.cmd = new MySqlCommand(MySql, CRUD.con);
            AddParametros(param);
            CRUD.PerformCRUD(CRUD.cmd);
        }

        private void AddParametros(string str)
        {
            CRUD.cmd.Parameters.Clear();

            CRUD.cmd.Parameters.AddWithValue("Destino", txtDestino.Text);
            CRUD.cmd.Parameters.AddWithValue("Data", txtDataViagem.Text);
            CRUD.cmd.Parameters.AddWithValue("Roteiro", txtRoteiro.Text);

        }

        private void btnCriar_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDestino.Text))
            {
                MessageBox.Show("Preencha o nome do destino", "Dados obrigatórios.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CRUD.sql = "INSERT INTO PACOTES (Destino, Data, Roteiro) Values (@Destino, @Data, @Roteiro)";

            Executar(CRUD.sql, "Insert");

            MessageBox.Show("Pacote registrado.", "Cadastro realizado.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparDados();
        }
    }
}
