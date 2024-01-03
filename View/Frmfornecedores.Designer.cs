namespace ControleDeVendasForm.View
{
    partial class Frmfornecedores
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabForcenecedores = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btncep = new System.Windows.Forms.Button();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.txtcelular = new System.Windows.Forms.MaskedTextBox();
            this.txttelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtcnpj = new System.Windows.Forms.MaskedTextBox();
            this.cbuf = new System.Windows.Forms.ComboBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.txtpesquisar = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tabelafornecedor = new System.Windows.Forms.DataGridView();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabForcenecedores.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelafornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 77);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cadastro de Fornecedores";
            // 
            // tabForcenecedores
            // 
            this.tabForcenecedores.Controls.Add(this.tabPage1);
            this.tabForcenecedores.Controls.Add(this.tabPage2);
            this.tabForcenecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabForcenecedores.Location = new System.Drawing.Point(0, 83);
            this.tabForcenecedores.Name = "tabForcenecedores";
            this.tabForcenecedores.SelectedIndex = 0;
            this.tabForcenecedores.Size = new System.Drawing.Size(980, 300);
            this.tabForcenecedores.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btncep);
            this.tabPage1.Controls.Add(this.txtnumero);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.txtcep);
            this.tabPage1.Controls.Add(this.txtcelular);
            this.tabPage1.Controls.Add(this.txttelefone);
            this.tabPage1.Controls.Add(this.txtcnpj);
            this.tabPage1.Controls.Add(this.cbuf);
            this.tabPage1.Controls.Add(this.txtcidade);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtendereco);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtbairro);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtnome);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtemail);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtcodigo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(972, 272);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Pessoais";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btncep
            // 
            this.btncep.BackColor = System.Drawing.SystemColors.Highlight;
            this.btncep.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncep.Location = new System.Drawing.Point(499, 61);
            this.btncep.Name = "btncep";
            this.btncep.Size = new System.Drawing.Size(91, 28);
            this.btncep.TabIndex = 40;
            this.btncep.Text = "Pesquisar";
            this.btncep.UseVisualStyleBackColor = false;
            this.btncep.Click += new System.EventHandler(this.btncep_Click);
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(656, 17);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(58, 21);
            this.txtnumero.TabIndex = 38;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(625, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 18);
            this.label18.TabIndex = 37;
            this.label18.Text = "N°";
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(377, 64);
            this.txtcep.Mask = "00000-000";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(116, 21);
            this.txtcep.TabIndex = 36;
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(377, 21);
            this.txtcelular.Mask = "(99) 00000-0000";
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(116, 21);
            this.txtcelular.TabIndex = 35;
            this.txtcelular.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtcelular_MaskInputRejected);
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(79, 179);
            this.txttelefone.Mask = "(99) 0000-0000";
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(116, 21);
            this.txttelefone.TabIndex = 34;
            // 
            // txtcnpj
            // 
            this.txtcnpj.Location = new System.Drawing.Point(79, 101);
            this.txtcnpj.Mask = "##,###,###/####-##";
            this.txtcnpj.Name = "txtcnpj";
            this.txtcnpj.Size = new System.Drawing.Size(116, 21);
            this.txtcnpj.TabIndex = 32;
            // 
            // cbuf
            // 
            this.cbuf.FormattingEnabled = true;
            this.cbuf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO",
            "DF"});
            this.cbuf.Location = new System.Drawing.Point(671, 56);
            this.cbuf.Name = "cbuf";
            this.cbuf.Size = new System.Drawing.Size(65, 23);
            this.cbuf.TabIndex = 30;
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(377, 179);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(155, 21);
            this.txtcidade.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(306, 182);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 18);
            this.label16.TabIndex = 28;
            this.label16.Text = "Cidade";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(631, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 18);
            this.label12.TabIndex = 20;
            this.label12.Text = "UF";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "Telefone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(306, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "Celular";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(306, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "CEP";
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(377, 101);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(155, 21);
            this.txtendereco.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(306, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Endereço";
            // 
            // txtbairro
            // 
            this.txtbairro.Location = new System.Drawing.Point(377, 140);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(155, 21);
            this.txtbairro.TabIndex = 11;
            this.txtbairro.TextChanged += new System.EventHandler(this.txtbairro_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(306, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Bairro";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(79, 63);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(184, 21);
            this.txtnome.TabIndex = 9;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "CNPJ";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(79, 140);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(184, 21);
            this.txtemail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(79, 21);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(64, 21);
            this.txtcodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnpesquisar);
            this.tabPage2.Controls.Add(this.txtpesquisar);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.tabelafornecedor);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(972, 272);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnpesquisar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisar.Location = new System.Drawing.Point(327, 11);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(101, 35);
            this.btnpesquisar.TabIndex = 7;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = false;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // txtpesquisar
            // 
            this.txtpesquisar.Location = new System.Drawing.Point(92, 17);
            this.txtpesquisar.Name = "txtpesquisar";
            this.txtpesquisar.Size = new System.Drawing.Size(192, 21);
            this.txtpesquisar.TabIndex = 2;
            this.txtpesquisar.TextChanged += new System.EventHandler(this.txtpesquisar_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(34, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 20);
            this.label17.TabIndex = 1;
            this.label17.Text = "Nome";
            // 
            // tabelafornecedor
            // 
            this.tabelafornecedor.AllowUserToAddRows = false;
            this.tabelafornecedor.AllowUserToDeleteRows = false;
            this.tabelafornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelafornecedor.Location = new System.Drawing.Point(7, 52);
            this.tabelafornecedor.Name = "tabelafornecedor";
            this.tabelafornecedor.ReadOnly = true;
            this.tabelafornecedor.Size = new System.Drawing.Size(959, 210);
            this.tabelafornecedor.TabIndex = 0;
            this.tabelafornecedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelafornecedor_CellContentClick_1);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btneditar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Location = new System.Drawing.Point(695, 389);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(130, 49);
            this.btneditar.TabIndex = 13;
            this.btneditar.Text = "EDITAR";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnexcluir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.Location = new System.Drawing.Point(510, 389);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(130, 49);
            this.btnexcluir.TabIndex = 12;
            this.btnexcluir.Text = "EXCLUIR";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnsalvar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.Location = new System.Drawing.Point(324, 389);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(130, 49);
            this.btnsalvar.TabIndex = 11;
            this.btnsalvar.Text = "SALVAR";
            this.btnsalvar.UseVisualStyleBackColor = false;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnnovo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovo.Location = new System.Drawing.Point(141, 389);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(130, 49);
            this.btnnovo.TabIndex = 10;
            this.btnnovo.Text = "NOVO";
            this.btnnovo.UseVisualStyleBackColor = false;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // Frmfornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 450);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.tabForcenecedores);
            this.Controls.Add(this.panel1);
            this.Name = "Frmfornecedores";
            this.Text = "Cadastro de Fornecedores";
            this.Load += new System.EventHandler(this.Frmfornecedores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabForcenecedores.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelafornecedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabForcenecedores;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btncep;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox txtcep;
        private System.Windows.Forms.MaskedTextBox txtcelular;
        private System.Windows.Forms.MaskedTextBox txttelefone;
        private System.Windows.Forms.MaskedTextBox txtcnpj;
        private System.Windows.Forms.ComboBox cbuf;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.TextBox txtpesquisar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView tabelafornecedor;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnnovo;
    }
}