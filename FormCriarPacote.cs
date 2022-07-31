using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.IO;

namespace ANAYA_VIAGENS
{
    public partial class FormCriarPacote : Form
    {
        public string localizacaoFoto;
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

            MemoryStream ms = new MemoryStream();
            if (imgPacote.Image == null)
            {
                imgPacote.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            else
            {
                imgPacote.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            }


            byte[] img = ms.GetBuffer();



            CRUD.cmd.Parameters.AddWithValue("Destino", txtDestino.Text);
            CRUD.cmd.Parameters.AddWithValue("Data", txtDataViagem.Text);
            CRUD.cmd.Parameters.AddWithValue("Roteiro", txtRoteiro.Text);
            CRUD.cmd.Parameters.AddWithValue("Foto", img);

        }

        private void btnCriar_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDestino.Text))
            {
                MessageBox.Show("Preencha o nome do destino", "Dados obrigatórios.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CRUD.sql = "INSERT INTO PACOTES (Destino, Data, Roteiro, Foto) Values (@Destino, @Data, @Roteiro, @Foto)";

            Executar(CRUD.sql, "Insert");

            MessageBox.Show("Pacote registrado.", "Cadastro realizado.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparDados();
        }

        private void btnImportarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Escolha a foto(*.jpeg;*.jpg;*.png;*.gif) |*.jpeg;*.jpg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                localizacaoFoto = ofd.FileName.ToString();
                imgPacote.ImageLocation = localizacaoFoto;
            }
        }
    }
}
