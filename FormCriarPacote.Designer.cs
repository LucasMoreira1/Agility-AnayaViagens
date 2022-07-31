namespace ANAYA_VIAGENS
{
    partial class FormCriarPacote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.imgPacote = new System.Windows.Forms.PictureBox();
            this.txtRoteiro = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCodPacote = new System.Windows.Forms.TextBox();
            this.txtDataViagem = new System.Windows.Forms.MaskedTextBox();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnImportarImagem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgPacote)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Destino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data";
            // 
            // txtDestino
            // 
            this.txtDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.Location = new System.Drawing.Point(131, 41);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(263, 22);
            this.txtDestino.TabIndex = 2;
            // 
            // imgPacote
            // 
            this.imgPacote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPacote.Location = new System.Drawing.Point(536, 97);
            this.imgPacote.Name = "imgPacote";
            this.imgPacote.Size = new System.Drawing.Size(318, 293);
            this.imgPacote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPacote.TabIndex = 3;
            this.imgPacote.TabStop = false;
            // 
            // txtRoteiro
            // 
            this.txtRoteiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoteiro.Location = new System.Drawing.Point(131, 97);
            this.txtRoteiro.Name = "txtRoteiro";
            this.txtRoteiro.Size = new System.Drawing.Size(348, 561);
            this.txtRoteiro.TabIndex = 4;
            this.txtRoteiro.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Roteiro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(678, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Foto";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(31, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "Pacote Nº";
            // 
            // txtCodPacote
            // 
            this.txtCodPacote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPacote.Location = new System.Drawing.Point(131, 12);
            this.txtCodPacote.Name = "txtCodPacote";
            this.txtCodPacote.Size = new System.Drawing.Size(100, 22);
            this.txtCodPacote.TabIndex = 2;
            // 
            // txtDataViagem
            // 
            this.txtDataViagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataViagem.Location = new System.Drawing.Point(131, 69);
            this.txtDataViagem.Mask = "00/00/0000";
            this.txtDataViagem.Name = "txtDataViagem";
            this.txtDataViagem.Size = new System.Drawing.Size(100, 22);
            this.txtDataViagem.TabIndex = 6;
            // 
            // btnCriar
            // 
            this.btnCriar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.Location = new System.Drawing.Point(536, 428);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(113, 50);
            this.btnCriar.TabIndex = 7;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnImportarImagem
            // 
            this.btnImportarImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportarImagem.Location = new System.Drawing.Point(741, 428);
            this.btnImportarImagem.Name = "btnImportarImagem";
            this.btnImportarImagem.Size = new System.Drawing.Size(113, 50);
            this.btnImportarImagem.TabIndex = 8;
            this.btnImportarImagem.Text = "Importar Imagem";
            this.btnImportarImagem.UseVisualStyleBackColor = true;
            this.btnImportarImagem.Click += new System.EventHandler(this.btnImportarImagem_Click);
            // 
            // FormCriarPacote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(927, 733);
            this.Controls.Add(this.btnImportarImagem);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.txtDataViagem);
            this.Controls.Add(this.txtRoteiro);
            this.Controls.Add(this.imgPacote);
            this.Controls.Add(this.txtCodPacote);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FormCriarPacote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Pacote de Viagem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.imgPacote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.PictureBox imgPacote;
        private System.Windows.Forms.RichTextBox txtRoteiro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox txtDataViagem;
        private System.Windows.Forms.Button btnCriar;
        public System.Windows.Forms.TextBox txtCodPacote;
        private System.Windows.Forms.Button btnImportarImagem;
    }
}