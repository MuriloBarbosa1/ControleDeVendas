namespace ControleDeVendasForm.View
{
    partial class Frmdetalhes
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
            this.txtobs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.dataInicio = new System.Windows.Forms.Label();
            this.tabelaDetalhes = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaDetalhes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 90);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(172, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "DETALHES DA VENDA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtobs);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txttotal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtdata);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtcliente);
            this.groupBox1.Controls.Add(this.dataInicio);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 190);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da venda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtobs
            // 
            this.txtobs.Location = new System.Drawing.Point(121, 125);
            this.txtobs.Multiline = true;
            this.txtobs.Name = "txtobs";
            this.txtobs.ReadOnly = true;
            this.txtobs.Size = new System.Drawing.Size(594, 47);
            this.txtobs.TabIndex = 9;
            this.txtobs.TextChanged += new System.EventHandler(this.txtobs_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Observações";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(511, 33);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(218, 20);
            this.txttotal.TabIndex = 7;
            this.txttotal.TextChanged += new System.EventHandler(this.txttotal_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label3.Location = new System.Drawing.Point(386, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total da venda";
            // 
            // txtdata
            // 
            this.txtdata.Location = new System.Drawing.Point(106, 76);
            this.txtdata.Name = "txtdata";
            this.txtdata.ReadOnly = true;
            this.txtdata.Size = new System.Drawing.Size(218, 20);
            this.txtdata.TabIndex = 5;
            this.txtdata.TextChanged += new System.EventHandler(this.txtdata_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label2.Location = new System.Drawing.Point(36, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data";
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(106, 29);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.ReadOnly = true;
            this.txtcliente.Size = new System.Drawing.Size(218, 20);
            this.txtcliente.TabIndex = 3;
            this.txtcliente.TextChanged += new System.EventHandler(this.txtcliente_TextChanged);
            // 
            // dataInicio
            // 
            this.dataInicio.AutoSize = true;
            this.dataInicio.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dataInicio.Location = new System.Drawing.Point(20, 29);
            this.dataInicio.Name = "dataInicio";
            this.dataInicio.Size = new System.Drawing.Size(61, 20);
            this.dataInicio.TabIndex = 1;
            this.dataInicio.Text = "Cliente";
            // 
            // tabelaDetalhes
            // 
            this.tabelaDetalhes.AllowUserToAddRows = false;
            this.tabelaDetalhes.AllowUserToDeleteRows = false;
            this.tabelaDetalhes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaDetalhes.Location = new System.Drawing.Point(12, 292);
            this.tabelaDetalhes.Name = "tabelaDetalhes";
            this.tabelaDetalhes.ReadOnly = true;
            this.tabelaDetalhes.Size = new System.Drawing.Size(738, 181);
            this.tabelaDetalhes.TabIndex = 7;
            this.tabelaDetalhes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaDetalhes_CellContentClick);
            // 
            // Frmdetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 485);
            this.Controls.Add(this.tabelaDetalhes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Frmdetalhes";
            this.Text = "DETALHES";
            this.Load += new System.EventHandler(this.Frmdetalhes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaDetalhes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dataInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tabelaDetalhes;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtcliente;
        public System.Windows.Forms.TextBox txtobs;
        public System.Windows.Forms.TextBox txttotal;
        public System.Windows.Forms.TextBox txtdata;
    }
}