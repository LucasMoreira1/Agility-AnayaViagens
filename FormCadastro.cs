using System;
using System.Data;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.IO;

namespace Programa_STPMJ
{
    public partial class FormCadastro : Form
    {
        
        public Boolean CameraOn = false;
        public string localizacaoFoto;
        public FormCadastro()
        {
            InitializeComponent();
            ResetMe();

        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        private void ResetMe()
        {
            
            txtNome.Text = "";
            txtRG.Text = "";
            txtCPF.Text = "";
            txtDataNascimento.Text = "";
            cboxEstadoCivil.SelectedIndex = 0;
            cboxDocumento.SelectedIndex = 0;
            cboxDocumentoDependente.SelectedIndex = 0;
            txtTelefone.Text = "";
            txtEmail.Text = "";
            txtCEP.Text = "";
            txtLogradouro.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtObservacao.Text = "";
            imgCamera.Image = null;

            txtNomeDependente.Text = "";
            txtDataNascimentoDependente.Text = "";
            cboxGrauParentesco.Text = "";
            txtRGDependente.Text = "";
            txtCPFDependente.Text = "";
        }

        private void Executar(string mySQL, string param)
        {
            CRUD.cmd = new MySqlCommand(mySQL,CRUD.con);
            AddParametros(param);
            CRUD.PerformCRUD(CRUD.cmd);
        }

        private void AddParametros(string str)
        {
            CRUD.cmd.Parameters.Clear();


            MemoryStream ms = new MemoryStream();
            if (imgCamera.Image == null)
            {
                imgCamera.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            else
            {
                imgCamera.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            
            
            byte[] img = ms.GetBuffer();

           
            CRUD.cmd.Parameters.AddWithValue("nome", txtNome.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("rg", txtRG.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("cpf", txtCPF.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("data_nascimento", txtDataNascimento.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("estado_civil", cboxEstadoCivil.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("data_cadastro", txtDataCadastro.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("telefone", txtTelefone.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("email", txtEmail.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("cep", txtCEP.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("logradouro", txtLogradouro.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("numero", txtNumero.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("complemento", txtComplemento.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("bairro", txtBairro.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("cidade", txtCidade.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("estado", txtEstado.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("observacao", txtObservacao.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("foto", img);
            CRUD.cmd.Parameters.AddWithValue("Cad_numero", txtCadNumero.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("nomeDependente", txtNomeDependente.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("DataNascimentoDependente", txtDataNascimentoDependente.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("GrauParentesco", cboxGrauParentesco.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("RGDependente", txtRGDependente.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("CPFDependente", txtCPFDependente.Text.Trim());

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text.Trim()))
            {
                MessageBox.Show("Por favor insira o Nome completo", "Dados Obrigatórios",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            

            CRUD.sql = "INSERT INTO CLIENTES(nome,rg,cpf,datanascimento,estadocivil," +
                "telefone,email,cep,logradouro,numero,complemento,bairro,cidade,estado," +
                "observacao,foto,datacadastro)" +
                "Values(@nome,@rg,@cpf,@data_nascimento,@estado_civil," +
                "@telefone,@email,@cep,@logradouro,@numero,@complemento,@bairro,@cidade,@estado," +
                "@observacao,@foto,@data_cadastro);";


            Executar(CRUD.sql, "Insert");

            MessageBox.Show("Cliente registrado.", "Cadastro",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //loadData("");
            ResetMe();
        }

        private void btnBuscarCEP_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep",txtCEP.Text);

                ds.ReadXml(xml);

                txtLogradouro.Text = ds.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = ds.Tables[0].Rows[0]["cidade"].ToString();
                txtEstado.Text = ds.Tables[0].Rows[0]["uf"].ToString();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao buscar CEP");
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ResetMe();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtNome.Text.Trim()))
            {
                MessageBox.Show("Por favor insira o Nome completo", "Dados Obrigatórios",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CRUD.sql = "UPDATE CLIENTES SET nome = @nome, rg = @rg, cpf = @cpf, " +
                "datanascimento = @data_nascimento, estadocivil = @estado_civil," +
                "telefone = @telefone, email = @email, cep = @cep, " +
                "logradouro = @logradouro, numero = @numero, complemento = @complemento, bairro = @bairro," +
                "cidade = @cidade, estado = @estado, " +
                "observacao = @observacao, datacadastro = @data_cadastro, foto = @foto WHERE CadNumero = @cad_numero";


            Executar(CRUD.sql, "Update");

            MessageBox.Show("Dados atualizados.", "Cadastro",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResetMe();
            this.Close();
            
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            txtDataCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");
            
            //Camera
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboxCamera.Items.Add(filterInfo.Name);
            if (cboxCamera.Items.Count >= 1) 
            {
                cboxCamera.SelectedIndex = 0;
            }
            //cboxCamera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }

        private void btnIniciarCamera_Click(object sender, EventArgs e)
        {
            if (!CameraOn)
            {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboxCamera.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += new NewFrameEventHandler(VideoCaptureDevice_NewFrame);
                CameraOn = true;
                videoCaptureDevice.Start();
            }
        }
        public void EncerrarCamera()
        {
            if (CameraOn)
            {
                //  FinalVideo.Stop();     // <-removed
                videoCaptureDevice.SignalToStop();
                // FinalVideo.WaitForStop();  // <- removed this to my suprice isn't needed, in fact my closing started to work only after marking this one out
                CameraOn = false;
                videoCaptureDevice.NewFrame -= new NewFrameEventHandler(VideoCaptureDevice_NewFrame); // <- decouple the newFrame event.
                videoCaptureDevice = null;
                imgCamera.Image = null;
            }
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            imgCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void FormCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            EncerrarCamera();
        }

        private void btnTirarFoto_Click(object sender, EventArgs e)
        {

            if (CameraOn)
            {
                //  FinalVideo.Stop();     // <-removed
                videoCaptureDevice.SignalToStop();
                // FinalVideo.WaitForStop();  // <- removed this to my suprice isn't needed, in fact my closing started to work only after marking this one out
                CameraOn = false;
                videoCaptureDevice.NewFrame -= new NewFrameEventHandler(VideoCaptureDevice_NewFrame); // <- decouple the newFrame event.
                videoCaptureDevice = null;
            }

        }

        public void btnEncerrarCamera_Click(object sender, EventArgs e)
        {
            imgCamera.Image = null;
        }

        private void btnImportarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Escolha a foto(*.jpeg;*.png;*.gif) |*.jpeg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                localizacaoFoto = ofd.FileName.ToString();
                imgCamera.ImageLocation = localizacaoFoto;
            }
        }

        private void btnImagemEmBranco_Click(object sender, EventArgs e)
        {


            CRUD.sql = "UPDATE CLIENTES SET foto = @foto";


            Executar(CRUD.sql, "Update");

            MessageBox.Show("Dados atualizados.", "Cadastro",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            FormPesquisa formpesquisa = new FormPesquisa();
            formpesquisa.btnPesquisar_Click(sender, e);

            ResetMe();
            this.Close();
        }

        private void btnAdcDependente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text.Trim()))
            {
                MessageBox.Show("Por favor insira o Nome completo", "Dados Obrigatórios",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            CRUD.sql = "INSERT INTO DEPENDENTES(CadReferencia,Nome,GrauParentesco,DataNascimento,RG,CPF)" +
                "Values(@Cad_numero, @nomeDependente, @GrauParentesco, @DataNascimentoDependente, @RGDependente, @CPFDependente);";


            Executar(CRUD.sql, "Insert");

            MessageBox.Show("Dependente registrado.", "Cadastro Dependente",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //loadData("");
            ResetDependente();
        }

        private void ResetDependente()
        {
            txtNomeDependente.Text = "";
            txtDataNascimentoDependente.Text = "";
            cboxGrauParentesco.Text = "";
            txtRGDependente.Text = "";
            txtCPFDependente.Text = "";
        }

        private void btnListaDependente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCadNumero.Text.Trim()))
            {
                MessageBox.Show("Por favor salve o cadastro", "Dados Obrigatórios",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            FormDependentes formDependentes = new FormDependentes();
            formDependentes.txtCadReferencia.Text = txtCadNumero.Text;
            formDependentes.txtNomeReferencia.Text = txtNome.Text;
            formDependentes.Show();

        }

        private void cboxDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxDocumento.Text == "CPF")
            {
                txtCPF.Visible = true;
                txtRG.Visible = false;
                txtPassaporte.Visible = false;
                txtOrgEmissor.Visible = false;
            }
            else if (cboxDocumento.Text == "RG")
            {
                txtCPF.Visible = false;
                txtRG.Visible = true;
                txtPassaporte.Visible = false;
                txtOrgEmissor.Visible = true;
            }
            else if (cboxDocumento.Text == "PASSAPORTE")
            {
                txtCPF.Visible = false;
                txtRG.Visible = false;
                txtPassaporte.Visible = true;
                txtOrgEmissor.Visible = false;
            }

        }

        private void txtDataNascimento_Click(object sender, EventArgs e)
        {
            IniciarEsquerda();
        }

        private void IniciarEsquerda()
        {
            txtDataNascimento.SelectionStart = 0;
            txtRG.SelectionStart = 0;
            txtCPF.SelectionStart = 0;
            txtPassaporte.SelectionStart = 0;
            txtRGDependente.SelectionStart = 0;
            txtCPFDependente.SelectionStart = 0;
            txtDataNascimentoDependente.SelectionStart = 0;
            txtOrgEmissor.SelectionStart = 0;
            txtTelefone.SelectionStart = 0;
            txtDataCasamento.SelectionStart = 0;
            txtCEP.SelectionStart = 0;

            txtCertidaoNascimentoDependente.SelectionStart = 0;
            txtCPFDependente.SelectionStart = 0;
            txtDataNascimentoDependente.SelectionStart = 0;
            txtOrgEmissorDependente.SelectionStart = 0;
            txtRGDependente.SelectionStart = 0;
            txtPassaporteDependente.SelectionStart = 0;


        }

        private void cboxEmbarque_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxEmbarque.SelectedIndex == 1)
            {
                lblEmbarqueOnde.Visible = true;
                txtEmbarqueOnde.Visible = true;
            }
            else if (cboxEmbarque.SelectedIndex == 0)
            {
                lblEmbarqueOnde.Visible = false;
                txtEmbarqueOnde.Visible = false;
            }
        }

        private void txtCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnBuscarCEP_Click(sender, e);
        }

        private void cboxDocumentoDependente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxDocumentoDependente.Text == "CPF")
            {
                txtCPFDependente.Visible = true;
                txtRGDependente.Visible = false;
                txtPassaporteDependente.Visible = false;
                txtOrgEmissorDependente.Visible = false;
                txtCertidaoNascimentoDependente.Visible = false;
            }
            else if (cboxDocumentoDependente.Text == "RG")
            {
                txtCPFDependente.Visible = false;
                txtRGDependente.Visible = true;
                txtPassaporteDependente.Visible = false;
                txtOrgEmissorDependente.Visible = true;
                txtCertidaoNascimentoDependente.Visible = false;
            }
            else if (cboxDocumentoDependente.Text == "PASSAPORTE")
            {
                txtCPFDependente.Visible = false;
                txtRGDependente.Visible = false;
                txtPassaporteDependente.Visible = true;
                txtOrgEmissorDependente.Visible = false;
                txtCertidaoNascimentoDependente.Visible = false;
            }
            else if(cboxDocumentoDependente.Text== "CERT. NASC.")
            {
                txtCPFDependente.Visible = false;
                txtRGDependente.Visible = false;
                txtPassaporteDependente.Visible = false;
                txtOrgEmissorDependente.Visible = false;
                txtCertidaoNascimentoDependente.Visible = true;
            }
        }
    }
}
