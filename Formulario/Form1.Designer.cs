﻿namespace Formulario
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.maskCPF = new System.Windows.Forms.MaskedTextBox();
            this.maskN = new System.Windows.Forms.MaskedTextBox();
            this.maskCEP = new System.Windows.Forms.MaskedTextBox();
            this.maskCelular = new System.Windows.Forms.MaskedTextBox();
            this.maskDATA = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cBoxEstado = new System.Windows.Forms.ComboBox();
            this.cBoxBairro = new System.Windows.Forms.ComboBox();
            this.CboxCidade = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtImagem = new System.Windows.Forms.Button();
            this.btExcluirFoto = new System.Windows.Forms.Button();
            this.Btexcluir = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.maskContrato = new System.Windows.Forms.MaskedTextBox();
            this.OpAndamendo = new System.Windows.Forms.RadioButton();
            this.OpConcluido = new System.Windows.Forms.RadioButton();
            this.OpCancelado = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.txtEndereco = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome completo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Endereço ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "CPF";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 241);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "CEP";
            this.label7.Click += new System.EventHandler(this.label5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 242);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "N°";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 301);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Bairro";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(249, 301);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cidade";
            this.label10.Click += new System.EventHandler(this.label4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 364);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Celular";
            this.label11.Click += new System.EventHandler(this.label4_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(146, 364);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Email";
            this.label12.Click += new System.EventHandler(this.label4_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(419, 301);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Estado";
            this.label13.Click += new System.EventHandler(this.label4_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 556);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "Situação ";
            this.label14.Click += new System.EventHandler(this.label4_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 430);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "Observações";
            this.label15.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(22, 453);
            this.txtObs.Margin = new System.Windows.Forms.Padding(4);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(591, 89);
            this.txtObs.TabIndex = 13;
            this.txtObs.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(214, 47);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(54, 26);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(280, 47);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(305, 26);
            this.txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(148, 387);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(361, 26);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // maskCPF
            // 
            this.maskCPF.Location = new System.Drawing.Point(214, 100);
            this.maskCPF.Margin = new System.Windows.Forms.Padding(4);
            this.maskCPF.Mask = "000,000,000-00";
            this.maskCPF.Name = "maskCPF";
            this.maskCPF.Size = new System.Drawing.Size(112, 26);
            this.maskCPF.TabIndex = 2;
            this.maskCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // maskN
            // 
            this.maskN.Location = new System.Drawing.Point(423, 265);
            this.maskN.Margin = new System.Windows.Forms.Padding(4);
            this.maskN.Name = "maskN";
            this.maskN.Size = new System.Drawing.Size(112, 26);
            this.maskN.TabIndex = 7;
            this.maskN.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // maskCEP
            // 
            this.maskCEP.Location = new System.Drawing.Point(22, 264);
            this.maskCEP.Margin = new System.Windows.Forms.Padding(4);
            this.maskCEP.Mask = "00000-000";
            this.maskCEP.Name = "maskCEP";
            this.maskCEP.Size = new System.Drawing.Size(112, 26);
            this.maskCEP.TabIndex = 5;
            this.maskCEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // maskCelular
            // 
            this.maskCelular.Location = new System.Drawing.Point(22, 387);
            this.maskCelular.Margin = new System.Windows.Forms.Padding(4);
            this.maskCelular.Mask = "(00) 0000-00000";
            this.maskCelular.Name = "maskCelular";
            this.maskCelular.Size = new System.Drawing.Size(112, 26);
            this.maskCelular.TabIndex = 11;
            this.maskCelular.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // maskDATA
            // 
            this.maskDATA.Location = new System.Drawing.Point(334, 100);
            this.maskDATA.Margin = new System.Windows.Forms.Padding(4);
            this.maskDATA.Mask = "00/00/0000";
            this.maskDATA.Name = "maskDATA";
            this.maskDATA.Size = new System.Drawing.Size(112, 26);
            this.maskDATA.TabIndex = 3;
            this.maskDATA.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Data de Contrato";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(257, 556);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 19);
            this.label16.TabIndex = 0;
            this.label16.Text = "Valor";
            this.label16.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(306, 553);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(112, 26);
            this.txtValor.TabIndex = 17;
            this.txtValor.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // cBoxEstado
            // 
            this.cBoxEstado.AutoCompleteCustomSource.AddRange(new string[] {
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cBoxEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxEstado.FormattingEnabled = true;
            this.cBoxEstado.Items.AddRange(new object[] {
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cBoxEstado.Location = new System.Drawing.Point(411, 324);
            this.cBoxEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxEstado.Name = "cBoxEstado";
            this.cBoxEstado.Size = new System.Drawing.Size(158, 27);
            this.cBoxEstado.TabIndex = 10;
            this.cBoxEstado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cBoxBairro
            // 
            this.cBoxBairro.AutoCompleteCustomSource.AddRange(new string[] {
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cBoxBairro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxBairro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxBairro.FormattingEnabled = true;
            this.cBoxBairro.Location = new System.Drawing.Point(22, 324);
            this.cBoxBairro.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxBairro.Name = "cBoxBairro";
            this.cBoxBairro.Size = new System.Drawing.Size(216, 27);
            this.cBoxBairro.TabIndex = 8;
            this.cBoxBairro.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // CboxCidade
            // 
            this.CboxCidade.AutoCompleteCustomSource.AddRange(new string[] {
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.CboxCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboxCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboxCidade.FormattingEnabled = true;
            this.CboxCidade.Location = new System.Drawing.Point(245, 324);
            this.CboxCidade.Margin = new System.Windows.Forms.Padding(4);
            this.CboxCidade.Name = "CboxCidade";
            this.CboxCidade.Size = new System.Drawing.Size(158, 27);
            this.CboxCidade.TabIndex = 9;
            this.CboxCidade.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // BtImagem
            // 
            this.BtImagem.BackColor = System.Drawing.Color.Cyan;
            this.BtImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtImagem.FlatAppearance.BorderSize = 0;
            this.BtImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtImagem.Image = global::Formulario.Properties.Resources.icons8_fotografia_16;
            this.BtImagem.Location = new System.Drawing.Point(22, 199);
            this.BtImagem.Margin = new System.Windows.Forms.Padding(4);
            this.BtImagem.Name = "BtImagem";
            this.BtImagem.Size = new System.Drawing.Size(120, 28);
            this.BtImagem.TabIndex = 0;
            this.BtImagem.TabStop = false;
            this.BtImagem.Text = "Imagem";
            this.BtImagem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtImagem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtImagem.UseVisualStyleBackColor = false;
            this.BtImagem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btExcluirFoto
            // 
            this.btExcluirFoto.BackColor = System.Drawing.Color.OrangeRed;
            this.btExcluirFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btExcluirFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExcluirFoto.FlatAppearance.BorderSize = 0;
            this.btExcluirFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluirFoto.Image = global::Formulario.Properties.Resources.icons8_x_16;
            this.btExcluirFoto.Location = new System.Drawing.Point(150, 199);
            this.btExcluirFoto.Margin = new System.Windows.Forms.Padding(4);
            this.btExcluirFoto.Name = "btExcluirFoto";
            this.btExcluirFoto.Size = new System.Drawing.Size(49, 28);
            this.btExcluirFoto.TabIndex = 0;
            this.btExcluirFoto.TabStop = false;
            this.btExcluirFoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExcluirFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btExcluirFoto.UseVisualStyleBackColor = false;
            this.btExcluirFoto.Click += new System.EventHandler(this.button5_Click);
            // 
            // Btexcluir
            // 
            this.Btexcluir.BackColor = System.Drawing.Color.OrangeRed;
            this.Btexcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btexcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btexcluir.FlatAppearance.BorderSize = 0;
            this.Btexcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btexcluir.Image = global::Formulario.Properties.Resources.icons8_x_16;
            this.Btexcluir.Location = new System.Drawing.Point(432, 594);
            this.Btexcluir.Margin = new System.Windows.Forms.Padding(4);
            this.Btexcluir.Name = "Btexcluir";
            this.Btexcluir.Size = new System.Drawing.Size(77, 29);
            this.Btexcluir.TabIndex = 0;
            this.Btexcluir.TabStop = false;
            this.Btexcluir.Text = "Excluir";
            this.Btexcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btexcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btexcluir.UseVisualStyleBackColor = false;
            this.Btexcluir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.Cyan;
            this.btSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalvar.FlatAppearance.BorderSize = 0;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Image = global::Formulario.Properties.Resources.icons8_caixa_de_seleção_marcada_16;
            this.btSalvar.Location = new System.Drawing.Point(528, 594);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(74, 29);
            this.btSalvar.TabIndex = 18;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "N°  Contrato";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // maskContrato
            // 
            this.maskContrato.Location = new System.Drawing.Point(214, 153);
            this.maskContrato.Margin = new System.Windows.Forms.Padding(4);
            this.maskContrato.Name = "maskContrato";
            this.maskContrato.Size = new System.Drawing.Size(134, 26);
            this.maskContrato.TabIndex = 4;
            this.maskContrato.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // OpAndamendo
            // 
            this.OpAndamendo.AutoSize = true;
            this.OpAndamendo.Location = new System.Drawing.Point(82, 554);
            this.OpAndamendo.Name = "OpAndamendo";
            this.OpAndamendo.Size = new System.Drawing.Size(117, 23);
            this.OpAndamendo.TabIndex = 19;
            this.OpAndamendo.TabStop = true;
            this.OpAndamendo.Text = "Em andamento";
            this.OpAndamendo.UseVisualStyleBackColor = true;
            // 
            // OpConcluido
            // 
            this.OpConcluido.AutoSize = true;
            this.OpConcluido.Location = new System.Drawing.Point(82, 577);
            this.OpConcluido.Name = "OpConcluido";
            this.OpConcluido.Size = new System.Drawing.Size(89, 23);
            this.OpConcluido.TabIndex = 19;
            this.OpConcluido.TabStop = true;
            this.OpConcluido.Text = "Concluido";
            this.OpConcluido.UseVisualStyleBackColor = true;
            // 
            // OpCancelado
            // 
            this.OpCancelado.AutoSize = true;
            this.OpCancelado.Location = new System.Drawing.Point(82, 600);
            this.OpCancelado.Name = "OpCancelado";
            this.OpCancelado.Size = new System.Drawing.Size(92, 23);
            this.OpCancelado.TabIndex = 19;
            this.OpCancelado.TabStop = true;
            this.OpCancelado.Text = "Cancelado";
            this.OpCancelado.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Formulario.Properties.Resources.icons8_x_16;
            this.button2.Location = new System.Drawing.Point(296, 594);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 29);
            this.button2.TabIndex = 0;
            this.button2.TabStop = false;
            this.button2.Text = "Excluir";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(142, 264);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(261, 26);
            this.txtEndereco.TabIndex = 4;
            this.txtEndereco.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Formulario.Properties.Resources.Screenshot_2024_06_17_21_12_58;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(615, 630);
            this.Controls.Add(this.OpCancelado);
            this.Controls.Add(this.OpConcluido);
            this.Controls.Add(this.OpAndamendo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CboxCidade);
            this.Controls.Add(this.cBoxBairro);
            this.Controls.Add(this.cBoxEstado);
            this.Controls.Add(this.maskCelular);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.maskContrato);
            this.Controls.Add(this.maskDATA);
            this.Controls.Add(this.maskCEP);
            this.Controls.Add(this.maskN);
            this.Controls.Add(this.maskCPF);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btexcluir);
            this.Controls.Add(this.btExcluirFoto);
            this.Controls.Add(this.BtImagem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox maskCPF;
        private System.Windows.Forms.MaskedTextBox maskN;
        private System.Windows.Forms.MaskedTextBox maskCEP;
        private System.Windows.Forms.MaskedTextBox maskCelular;
        private System.Windows.Forms.MaskedTextBox maskDATA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cBoxEstado;
        private System.Windows.Forms.ComboBox cBoxBairro;
        private System.Windows.Forms.ComboBox CboxCidade;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtImagem;
        private System.Windows.Forms.Button btExcluirFoto;
        private System.Windows.Forms.Button Btexcluir;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskContrato;
        private System.Windows.Forms.RadioButton OpAndamendo;
        private System.Windows.Forms.RadioButton OpConcluido;
        private System.Windows.Forms.RadioButton OpCancelado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox txtEndereco;
    }
}

