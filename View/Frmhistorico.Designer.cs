namespace ControleDeVendasForm.View
{
    partial class Frmhistorico
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.dataFinal = new System.Windows.Forms.Label();
            this.dataInicio = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.tabelaHistorico = new System.Windows.Forms.DataGridView();
            this.colCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(172, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "HISTORICO DE VENDA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 90);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnpesquisar);
            this.groupBox1.Controls.Add(this.dtFim);
            this.groupBox1.Controls.Add(this.dataFinal);
            this.groupBox1.Controls.Add(this.dataInicio);
            this.groupBox1.Controls.Add(this.dtInicio);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 118);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnpesquisar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisar.Location = new System.Drawing.Point(574, 33);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(109, 31);
            this.btnpesquisar.TabIndex = 49;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = false;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // dtFim
            // 
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(408, 40);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(106, 20);
            this.dtFim.TabIndex = 3;
            // 
            // dataFinal
            // 
            this.dataFinal.AutoSize = true;
            this.dataFinal.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dataFinal.Location = new System.Drawing.Point(308, 39);
            this.dataFinal.Name = "dataFinal";
            this.dataFinal.Size = new System.Drawing.Size(85, 20);
            this.dataFinal.TabIndex = 2;
            this.dataFinal.Text = "Data Final:";
            // 
            // dataInicio
            // 
            this.dataInicio.AutoSize = true;
            this.dataInicio.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dataInicio.Location = new System.Drawing.Point(6, 40);
            this.dataInicio.Name = "dataInicio";
            this.dataInicio.Size = new System.Drawing.Size(93, 20);
            this.dataInicio.TabIndex = 1;
            this.dataInicio.Text = "Data Inicio:";
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(105, 39);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(106, 20);
            this.dtInicio.TabIndex = 0;
            // 
            // tabelaHistorico
            // 
            this.tabelaHistorico.AllowUserToAddRows = false;
            this.tabelaHistorico.AllowUserToDeleteRows = false;
            this.tabelaHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCod,
            this.ColData,
            this.colCliente,
            this.colTotal,
            this.colObs});
            this.tabelaHistorico.Location = new System.Drawing.Point(12, 220);
            this.tabelaHistorico.Name = "tabelaHistorico";
            this.tabelaHistorico.ReadOnly = true;
            this.tabelaHistorico.Size = new System.Drawing.Size(738, 218);
            this.tabelaHistorico.TabIndex = 6;
            this.tabelaHistorico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaHistorico_CellClick);
            // 
            // colCod
            // 
            this.colCod.HeaderText = "Código";
            this.colCod.Name = "colCod";
            this.colCod.ReadOnly = true;
            // 
            // ColData
            // 
            this.ColData.HeaderText = "Data da venda";
            this.ColData.Name = "ColData";
            this.ColData.ReadOnly = true;
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colObs
            // 
            this.colObs.HeaderText = "Obs";
            this.colObs.Name = "colObs";
            this.colObs.ReadOnly = true;
            // 
            // Frmhistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 450);
            this.Controls.Add(this.tabelaHistorico);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Frmhistorico";
            this.Text = "Historico de venda";
            this.Load += new System.EventHandler(this.Frmhistorico_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaHistorico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label dataInicio;
        private System.Windows.Forms.Label dataFinal;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.DataGridView tabelaHistorico;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObs;
    }
}