namespace ControleDeVendasForm.View
{
    partial class Frmvendas
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.btnremover = new System.Windows.Forms.Button();
            this.txtqtd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabelaProdutos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnpagamento = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtsenhaExcluir = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProdutos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 90);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(356, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "TELA DE VENDAS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdata);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtcpf);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(9, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 136);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtdata
            // 
            this.txtdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdata.Location = new System.Drawing.Point(422, 19);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(104, 21);
            this.txtdata.TabIndex = 15;
            this.txtdata.TextChanged += new System.EventHandler(this.txtdata_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(367, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Data:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(64, 74);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(217, 20);
            this.txtnome.TabIndex = 13;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nome:";
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(64, 33);
            this.txtcpf.Mask = "###,###,###-##";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(154, 20);
            this.txtcpf.TabIndex = 11;
            this.txtcpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtcpf_MaskInputRejected);
            this.txtcpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcpf_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "CPF:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnadicionar);
            this.groupBox2.Controls.Add(this.btnremover);
            this.groupBox2.Controls.Add(this.txtqtd);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtpreco);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtdescricao);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtcodigo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.groupBox2.Location = new System.Drawing.Point(9, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 169);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnadicionar
            // 
            this.btnadicionar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnadicionar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadicionar.Location = new System.Drawing.Point(221, 130);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(92, 26);
            this.btnadicionar.TabIndex = 46;
            this.btnadicionar.Text = "ADICIONAR";
            this.btnadicionar.UseVisualStyleBackColor = false;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // btnremover
            // 
            this.btnremover.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnremover.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremover.Location = new System.Drawing.Point(454, 130);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(92, 26);
            this.btnremover.TabIndex = 45;
            this.btnremover.Text = "REMOVER";
            this.btnremover.UseVisualStyleBackColor = false;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // txtqtd
            // 
            this.txtqtd.Location = new System.Drawing.Point(117, 117);
            this.txtqtd.Name = "txtqtd";
            this.txtqtd.Size = new System.Drawing.Size(81, 26);
            this.txtqtd.TabIndex = 43;
            this.txtqtd.TextChanged += new System.EventHandler(this.txtqtdestoque_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label13.Location = new System.Drawing.Point(13, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 20);
            this.label13.TabIndex = 42;
            this.label13.Text = "Quantidade:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(117, 80);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(73, 26);
            this.txtpreco.TabIndex = 40;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label18.Location = new System.Drawing.Point(47, 80);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 20);
            this.label18.TabIndex = 39;
            this.label18.Text = "Preço :";
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(117, 48);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(437, 26);
            this.txtdescricao.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label4.Location = new System.Drawing.Point(27, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Descrição:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(117, 22);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(64, 26);
            this.txtcodigo.TabIndex = 3;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label2.Location = new System.Drawing.Point(47, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tabelaProdutos
            // 
            this.tabelaProdutos.AllowUserToAddRows = false;
            this.tabelaProdutos.AllowUserToDeleteRows = false;
            this.tabelaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaProdutos.Location = new System.Drawing.Point(589, 96);
            this.tabelaProdutos.Name = "tabelaProdutos";
            this.tabelaProdutos.ReadOnly = true;
            this.tabelaProdutos.Size = new System.Drawing.Size(553, 226);
            this.tabelaProdutos.TabIndex = 5;
            this.tabelaProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txttotal);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(643, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 76);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(98, 40);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(80, 20);
            this.txttotal.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total(R$)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btncancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(1050, 448);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(92, 41);
            this.btncancelar.TabIndex = 47;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            // 
            // btnpagamento
            // 
            this.btnpagamento.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnpagamento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpagamento.Location = new System.Drawing.Point(741, 410);
            this.btnpagamento.Name = "btnpagamento";
            this.btnpagamento.Size = new System.Drawing.Size(92, 41);
            this.btnpagamento.TabIndex = 48;
            this.btnpagamento.Text = "Pagamento";
            this.btnpagamento.UseVisualStyleBackColor = false;
            this.btnpagamento.Click += new System.EventHandler(this.btnpagamento_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtsenhaExcluir);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(9, 423);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(563, 78);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            // 
            // txtsenhaExcluir
            // 
            this.txtsenhaExcluir.Location = new System.Drawing.Point(115, 36);
            this.txtsenhaExcluir.Name = "txtsenhaExcluir";
            this.txtsenhaExcluir.PasswordChar = '*';
            this.txtsenhaExcluir.Size = new System.Drawing.Size(124, 20);
            this.txtsenhaExcluir.TabIndex = 17;
            this.txtsenhaExcluir.TextChanged += new System.EventHandler(this.txtsenhaExcluir_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Responsavel:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Frmvendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 501);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnpagamento);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabelaProdutos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Frmvendas";
            this.Text = "Tela de Vendas";
            this.Load += new System.EventHandler(this.Frmvendas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProdutos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtqtd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.DataGridView tabelaProdutos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnpagamento;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtsenhaExcluir;
        private System.Windows.Forms.Label label8;
    }
}