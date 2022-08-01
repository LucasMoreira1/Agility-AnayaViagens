using System;

namespace ANAYA_VIAGENS
{
    partial class formPaginaInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPaginaInicial));
            this.panelEsquerdo = new System.Windows.Forms.Panel();
            this.btnAjuda = new FontAwesome.Sharp.IconButton();
            this.panelDocumentos = new System.Windows.Forms.Panel();
            this.btnCheques = new FontAwesome.Sharp.IconButton();
            this.btnCarteirinha = new FontAwesome.Sharp.IconButton();
            this.btnDocumentos = new FontAwesome.Sharp.IconButton();
            this.btnRelatorios = new FontAwesome.Sharp.IconButton();
            this.panelPesquisas = new System.Windows.Forms.Panel();
            this.btnPesquisarEmpresa = new FontAwesome.Sharp.IconButton();
            this.btnPesquisarCliente = new FontAwesome.Sharp.IconButton();
            this.btnPesquisar = new FontAwesome.Sharp.IconButton();
            this.panelCadastros = new System.Windows.Forms.Panel();
            this.btnCriarPacotes = new FontAwesome.Sharp.IconButton();
            this.btnCadastroCliente = new FontAwesome.Sharp.IconButton();
            this.btnCadastros = new FontAwesome.Sharp.IconButton();
            this.btnTelaVendas = new FontAwesome.Sharp.IconButton();
            this.btnPaginaInicial = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelFormTitulo = new System.Windows.Forms.Panel();
            this.panelFormCentral = new System.Windows.Forms.Panel();
            this.txtConsultaCPF = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisarCPF = new System.Windows.Forms.Button();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panelEsquerdo.SuspendLayout();
            this.panelDocumentos.SuspendLayout();
            this.panelPesquisas.SuspendLayout();
            this.panelCadastros.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelFormCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEsquerdo
            // 
            this.panelEsquerdo.AutoScroll = true;
            this.panelEsquerdo.BackColor = System.Drawing.Color.White;
            this.panelEsquerdo.Controls.Add(this.btnAjuda);
            this.panelEsquerdo.Controls.Add(this.panelDocumentos);
            this.panelEsquerdo.Controls.Add(this.btnDocumentos);
            this.panelEsquerdo.Controls.Add(this.btnRelatorios);
            this.panelEsquerdo.Controls.Add(this.panelPesquisas);
            this.panelEsquerdo.Controls.Add(this.btnPesquisar);
            this.panelEsquerdo.Controls.Add(this.panelCadastros);
            this.panelEsquerdo.Controls.Add(this.btnCadastros);
            this.panelEsquerdo.Controls.Add(this.btnTelaVendas);
            this.panelEsquerdo.Controls.Add(this.btnPaginaInicial);
            this.panelEsquerdo.Controls.Add(this.panelLogo);
            this.panelEsquerdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEsquerdo.Location = new System.Drawing.Point(0, 0);
            this.panelEsquerdo.Name = "panelEsquerdo";
            this.panelEsquerdo.Size = new System.Drawing.Size(315, 681);
            this.panelEsquerdo.TabIndex = 0;
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackColor = System.Drawing.Color.White;
            this.btnAjuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAjuda.FlatAppearance.BorderSize = 0;
            this.btnAjuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(126)))), ((int)(((byte)(209)))));
            this.btnAjuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.btnAjuda.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.btnAjuda.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(166)))), ((int)(((byte)(209)))));
            this.btnAjuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAjuda.IconSize = 35;
            this.btnAjuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjuda.Location = new System.Drawing.Point(0, 702);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAjuda.Size = new System.Drawing.Size(298, 45);
            this.btnAjuda.TabIndex = 9;
            this.btnAjuda.Text = "Ajuda";
            this.btnAjuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjuda.UseVisualStyleBackColor = false;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // panelDocumentos
            // 
            this.panelDocumentos.BackColor = System.Drawing.Color.LightGray;
            this.panelDocumentos.Controls.Add(this.btnCheques);
            this.panelDocumentos.Controls.Add(this.btnCarteirinha);
            this.panelDocumentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDocumentos.Location = new System.Drawing.Point(0, 608);
            this.panelDocumentos.Name = "panelDocumentos";
            this.panelDocumentos.Size = new System.Drawing.Size(298, 94);
            this.panelDocumentos.TabIndex = 8;
            // 
            // btnCheques
            // 
            this.btnCheques.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCheques.FlatAppearance.BorderSize = 0;
            this.btnCheques.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(126)))), ((int)(((byte)(209)))));
            this.btnCheques.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btnCheques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheques.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheques.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.btnCheques.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.btnCheques.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(166)))), ((int)(((byte)(209)))));
            this.btnCheques.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheques.IconSize = 35;
            this.btnCheques.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheques.Location = new System.Drawing.Point(0, 45);
            this.btnCheques.Name = "btnCheques";
            this.btnCheques.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCheques.Size = new System.Drawing.Size(315, 45);
            this.btnCheques.TabIndex = 3;
            this.btnCheques.Text = "Transporte";
            this.btnCheques.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheques.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheques.UseVisualStyleBackColor = false;
            this.btnCheques.Click += new System.EventHandler(this.btnCheques_Click);
            // 
            // btnCarteirinha
            // 
            this.btnCarteirinha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCarteirinha.FlatAppearance.BorderSize = 0;
            this.btnCarteirinha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(126)))), ((int)(((byte)(209)))));
            this.btnCarteirinha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btnCarteirinha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarteirinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarteirinha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.btnCarteirinha.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            this.btnCarteirinha.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(166)))), ((int)(((byte)(209)))));
            this.btnCarteirinha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCarteirinha.IconSize = 35;
            this.btnCarteirinha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarteirinha.Location = new System.Drawing.Point(0, 0);
            this.btnCarteirinha.Name = "btnCarteirinha";
            this.btnCarteirinha.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCarteirinha.Size = new System.Drawing.Size(315, 45);
            this.btnCarteirinha.TabIndex = 2;
            this.btnCarteirinha.Text = "Controle Interno";
            this.btnCarteirinha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarteirinha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCarteirinha.UseVisualStyleBackColor = false;
            this.btnCarteirinha.Click += new System.EventHandler(this.btnCarteirinha_Click);
            // 
            // btnDocumentos
            // 
            this.btnDocumentos.BackColor = System.Drawing.Color.White;
            this.btnDocumentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocumentos.FlatAppearance.BorderSize = 0;
            this.btnDocumentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(126)))), ((int)(((byte)(209)))));
            this.btnDocumentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btnDocumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocumentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.btnDocumentos.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnDocumentos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(166)))), ((int)(((byte)(209)))));
            this.btnDocumentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDocumentos.IconSize = 35;
            this.btnDocumentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocumentos.Location = new System.Drawing.Point(0, 563);
            this.btnDocumentos.Name = "btnDocumentos";
            this.btnDocumentos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDocumentos.Size = new System.Drawing.Size(298, 45);
            this.btnDocumentos.TabIndex = 7;
            this.btnDocumentos.Text = "Documentos";
            this.btnDocumentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocumentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDocumentos.UseVisualStyleBackColor = false;
            this.btnDocumentos.Click += new System.EventHandler(this.btnDocumentos_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BackColor = System.Drawing.Color.White;
            this.btnRelatorios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelatorios.FlatAppearance.BorderSize = 0;
            this.btnRelatorios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(126)))), ((int)(((byte)(209)))));
            this.btnRelatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.btnRelatorios.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.btnRelatorios.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(166)))), ((int)(((byte)(209)))));
            this.btnRelatorios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRelatorios.IconSize = 35;
            this.btnRelatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.Location = new System.Drawing.Point(0, 518);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRelatorios.Size = new System.Drawing.Size(298, 45);
            this.btnRelatorios.TabIndex = 5;
            this.btnRelatorios.Text = "Relatorios";
            this.btnRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // panelPesquisas
            // 
            this.panelPesquisas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelPesquisas.Controls.Add(this.btnPesquisarEmpresa);
            this.panelPesquisas.Controls.Add(this.btnPesquisarCliente);
            this.panelPesquisas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPesquisas.Location = new System.Drawing.Point(0, 424);
            this.panelPesquisas.Name = "panelPesquisas";
            this.panelPesquisas.Size = new System.Drawing.Size(298, 94);
            this.panelPesquisas.TabIndex = 4;
            // 
            // btnPesquisarEmpresa
            // 
            this.btnPesquisarEmpresa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisarEmpresa.FlatAppearance.BorderSize = 0;
            this.btnPesquisarEmpresa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(126)))), ((int)(((byte)(209)))));
            this.btnPesquisarEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btnPesquisarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.btnPesquisarEmpresa.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
            this.btnPesquisarEmpresa.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(166)))), ((int)(((byte)(209)))));
            this.btnPesquisarEmpresa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPesquisarEmpresa.IconSize = 35;
            this.btnPesquisarEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarEmpresa.Location = new System.Drawing.Point(0, 45);
            this.btnPesquisarEmpresa.Name = "btnPesquisarEmpresa";
            this.btnPesquisarEmpresa.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPesquisarEmpresa.Size = new System.Drawing.Size(315, 45);
            this.btnPesquisarEmpresa.TabIndex = 3;
            this.btnPesquisarEmpresa.Text = "Pesquisar Pacotes";
            this.btnPesquisarEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisarEmpresa.UseVisualStyleBackColor = false;
            this.btnPesquisarEmpresa.Click += new System.EventHandler(this.btnPesquisarEmpresa_Click);
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisarCliente.FlatAppearance.BorderSize = 0;
            this.btnPesquisarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(126)))), ((int)(((byte)(209)))));
            this.btnPesquisarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btnPesquisarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.btnPesquisarCliente.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnPesquisarCliente.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(166)))), ((int)(((byte)(209)))));
            this.btnPesquisarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPesquisarCliente.IconSize = 35;
            this.btnPesquisarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarCliente.Location = new System.Drawing.Point(0, 0);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPesquisarCliente.Size = new System.Drawing.Size(315, 45);
            this.btnPesquisarCliente.TabIndex = 2;
            this.btnPesquisarCliente.Text = "Pesquisar Clientes";
            this.btnPesquisarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisarCliente.UseVisualStyleBackColor = false;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisarCliente_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.White;
            this.btnPesquisar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(126)))), ((int)(((byte)(209)))));
            this.btnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.btnPesquisar.IconChar = FontAwesome.Sharp.IconChar.SearchPlus;
            this.btnPesquisar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(166)))), ((int)(((byte)(209)))));
            this.btnPesquisar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPesquisar.IconSize = 35;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(0, 379);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPesquisar.Size = new System.Drawing.Size(298, 45);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // panelCadastros
            // 
            this.panelCadastros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelCadastros.Controls.Add(this.btnCriarPacotes);
            this.panelCadastros.Controls.Add(this.btnCadastroCliente);
            this.panelCadastros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCadastros.Location = new System.Drawing.Point(0, 285);
            this.panelCadastros.Name = "panelCadastros";
            this.panelCadastros.Size = new System.Drawing.Size(298, 94);
            this.panelCadastros.TabIndex = 2;
            // 
            // btnCriarPacotes
            // 
            this.btnCriarPacotes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCriarPacotes.FlatAppearance.BorderSize = 0;
            this.btnCriarPacotes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(126)))), ((int)(((byte)(209)))));
            this.btnCriarPacotes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btnCriarPacotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarPacotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPacotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.btnCriarPacotes.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnCriarPacotes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(166)))), ((int)(((byte)(209)))));
            this.btnCriarPacotes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCriarPacotes.IconSize = 35;
            this.btnCriarPacotes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCriarPacotes.Location = new System.Drawing.Point(0, 45);
            this.btnCriarPacotes.Name = "btnCriarPacotes";
            this.btnCriarPacotes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCriarPacotes.Size = new System.Drawing.Size(315, 45);
            this.btnCriarPacotes.TabIndex = 3;
            this.btnCriarPacotes.Text = "Cadastrar Pacotes";
            this.btnCriarPacotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCriarPacotes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCriarPacotes.UseVisualStyleBackColor = false;
            this.btnCriarPacotes.Click += new System.EventHandler(this.btnCriarPacotes_Click);
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastroCliente.FlatAppearance.BorderSize = 0;
            this.btnCadastroCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(126)))), ((int)(((byte)(209)))));
            this.btnCadastroCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btnCadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.btnCadastroCliente.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnCadastroCliente.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(166)))), ((int)(((byte)(209)))));
            this.btnCadastroCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastroCliente.IconSize = 35;
            this.btnCadastroCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroCliente.Location = new System.Drawing.Point(0, 0);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCadastroCliente.Size = new System.Drawing.Size(315, 45);
            this.btnCadastroCliente.TabIndex = 2;
            this.btnCadastroCliente.Text = "Cadastrar Clientes";
            this.btnCadastroCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastroCliente.UseVisualStyleBackColor = false;
            this.btnCadastroCliente.Click += new System.EventHandler(this.btnCadastroCliente_Click);
            // 
            // btnCadastros
            // 
            this.btnCadastros.BackColor = System.Drawing.Color.White;
            this.btnCadastros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastros.FlatAppearance.BorderSize = 0;
            this.btnCadastros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(126)))), ((int)(((byte)(209)))));
            this.btnCadastros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.btnCadastros.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnCadastros.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(166)))), ((int)(((byte)(209)))));
            this.btnCadastros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastros.IconSize = 35;
            this.btnCadastros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastros.Location = new System.Drawing.Point(0, 240);
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCadastros.Size = new System.Drawing.Size(298, 45);
            this.btnCadastros.TabIndex = 1;
            this.btnCadastros.Text = "Cadastros";
            this.btnCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastros.UseVisualStyleBackColor = false;
            this.btnCadastros.Click += new System.EventHandler(this.btnCadastros_Click);
            // 
            // btnTelaVendas
            // 
            this.btnTelaVendas.BackColor = System.Drawing.Color.White;
            this.btnTelaVendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTelaVendas.FlatAppearance.BorderSize = 0;
            this.btnTelaVendas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(126)))), ((int)(((byte)(209)))));
            this.btnTelaVendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btnTelaVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelaVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaVendas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.btnTelaVendas.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnTelaVendas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(166)))), ((int)(((byte)(209)))));
            this.btnTelaVendas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTelaVendas.IconSize = 35;
            this.btnTelaVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTelaVendas.Location = new System.Drawing.Point(0, 195);
            this.btnTelaVendas.Name = "btnTelaVendas";
            this.btnTelaVendas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTelaVendas.Size = new System.Drawing.Size(298, 45);
            this.btnTelaVendas.TabIndex = 10;
            this.btnTelaVendas.Text = "Tela de vendas";
            this.btnTelaVendas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTelaVendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTelaVendas.UseVisualStyleBackColor = false;
            this.btnTelaVendas.Click += new System.EventHandler(this.btnTelaVendas_Click);
            // 
            // btnPaginaInicial
            // 
            this.btnPaginaInicial.BackColor = System.Drawing.Color.White;
            this.btnPaginaInicial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaginaInicial.FlatAppearance.BorderSize = 0;
            this.btnPaginaInicial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(126)))), ((int)(((byte)(209)))));
            this.btnPaginaInicial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btnPaginaInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaginaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaginaInicial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.btnPaginaInicial.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnPaginaInicial.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(166)))), ((int)(((byte)(209)))));
            this.btnPaginaInicial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPaginaInicial.IconSize = 35;
            this.btnPaginaInicial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaginaInicial.Location = new System.Drawing.Point(0, 150);
            this.btnPaginaInicial.Name = "btnPaginaInicial";
            this.btnPaginaInicial.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPaginaInicial.Size = new System.Drawing.Size(298, 45);
            this.btnPaginaInicial.TabIndex = 8;
            this.btnPaginaInicial.Text = "Pagina Inicial";
            this.btnPaginaInicial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaginaInicial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaginaInicial.UseVisualStyleBackColor = false;
            this.btnPaginaInicial.Click += new System.EventHandler(this.btnPaginaInicial_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Silver;
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(298, 150);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ANAYA_VIAGENS.Properties.Resources.logo_fundo_azul1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelFormTitulo
            // 
            this.panelFormTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            this.panelFormTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormTitulo.Location = new System.Drawing.Point(315, 0);
            this.panelFormTitulo.Name = "panelFormTitulo";
            this.panelFormTitulo.Size = new System.Drawing.Size(949, 30);
            this.panelFormTitulo.TabIndex = 1;
            // 
            // panelFormCentral
            // 
            this.panelFormCentral.BackColor = System.Drawing.Color.White;
            this.panelFormCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelFormCentral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormCentral.Controls.Add(this.txtConsultaCPF);
            this.panelFormCentral.Controls.Add(this.dataGridView1);
            this.panelFormCentral.Controls.Add(this.label1);
            this.panelFormCentral.Controls.Add(this.btnPesquisarCPF);
            this.panelFormCentral.Controls.Add(this.webView21);
            this.panelFormCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormCentral.Location = new System.Drawing.Point(315, 30);
            this.panelFormCentral.Name = "panelFormCentral";
            this.panelFormCentral.Size = new System.Drawing.Size(949, 651);
            this.panelFormCentral.TabIndex = 2;
            // 
            // txtConsultaCPF
            // 
            this.txtConsultaCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsultaCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultaCPF.Location = new System.Drawing.Point(724, 10);
            this.txtConsultaCPF.Mask = "000,000,000-00";
            this.txtConsultaCPF.Name = "txtConsultaCPF";
            this.txtConsultaCPF.Size = new System.Drawing.Size(123, 22);
            this.txtConsultaCPF.TabIndex = 5;
            this.txtConsultaCPF.Click += new System.EventHandler(this.txtConsultaCPF_Click);
            this.txtConsultaCPF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PesquisaCPF);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(140, 33);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(630, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consulta CPF";
            // 
            // btnPesquisarCPF
            // 
            this.btnPesquisarCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarCPF.Location = new System.Drawing.Point(853, 5);
            this.btnPesquisarCPF.Name = "btnPesquisarCPF";
            this.btnPesquisarCPF.Size = new System.Drawing.Size(83, 33);
            this.btnPesquisarCPF.TabIndex = 2;
            this.btnPesquisarCPF.Text = "Pesquisar";
            this.btnPesquisarCPF.UseVisualStyleBackColor = true;
            this.btnPesquisarCPF.Click += new System.EventHandler(this.btnPesquisarCPF_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(0, 44);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(947, 605);
            this.webView21.Source = new System.Uri("https://www.anayaviagens.com.br/", System.UriKind.Absolute);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // formPaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelFormCentral);
            this.Controls.Add(this.panelFormTitulo);
            this.Controls.Add(this.panelEsquerdo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "formPaginaInicial";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anaya Viagens";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formPaginaInicial_FormClosing);
            this.panelEsquerdo.ResumeLayout(false);
            this.panelDocumentos.ResumeLayout(false);
            this.panelPesquisas.ResumeLayout(false);
            this.panelCadastros.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelFormCentral.ResumeLayout(false);
            this.panelFormCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion
        private System.Windows.Forms.Panel panelEsquerdo;
        private System.Windows.Forms.Panel panelDocumentos;
        private FontAwesome.Sharp.IconButton btnCheques;
        private FontAwesome.Sharp.IconButton btnCarteirinha;
        private System.Windows.Forms.Panel panelPesquisas;
        private FontAwesome.Sharp.IconButton btnPesquisarEmpresa;
        private FontAwesome.Sharp.IconButton btnPesquisarCliente;
        private System.Windows.Forms.Panel panelCadastros;
        private FontAwesome.Sharp.IconButton btnCriarPacotes;
        private FontAwesome.Sharp.IconButton btnCadastroCliente;
        private System.Windows.Forms.Panel panelFormTitulo;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel panelFormCentral;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisarCPF;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox txtConsultaCPF;
        public FontAwesome.Sharp.IconButton btnPaginaInicial;
        public FontAwesome.Sharp.IconButton btnAjuda;
        public FontAwesome.Sharp.IconButton btnDocumentos;
        public FontAwesome.Sharp.IconButton btnRelatorios;
        public FontAwesome.Sharp.IconButton btnPesquisar;
        public FontAwesome.Sharp.IconButton btnCadastros;
        public FontAwesome.Sharp.IconButton btnTelaVendas;
    }
}

