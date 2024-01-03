namespace ControleDeVendasForm.View
{
    partial class Frmpagamento
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
            this.txtdinheiro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcartao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttroco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnfinalizarvenda = new System.Windows.Forms.Button();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 90);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(139, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "TELA DE PAGAMENTO";
            // 
            // txtdinheiro
            // 
            this.txtdinheiro.Location = new System.Drawing.Point(180, 122);
            this.txtdinheiro.Name = "txtdinheiro";
            this.txtdinheiro.Size = new System.Drawing.Size(150, 20);
            this.txtdinheiro.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "DINHEIRO";
            // 
            // txtcartao
            // 
            this.txtcartao.Location = new System.Drawing.Point(180, 181);
            this.txtcartao.Name = "txtcartao";
            this.txtcartao.Size = new System.Drawing.Size(150, 20);
            this.txtcartao.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "CARTÃO";
            // 
            // txttroco
            // 
            this.txttroco.Location = new System.Drawing.Point(180, 233);
            this.txttroco.Name = "txttroco";
            this.txttroco.ReadOnly = true;
            this.txttroco.Size = new System.Drawing.Size(150, 20);
            this.txttroco.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "TROCO";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(180, 324);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(145, 20);
            this.txttotal.TabIndex = 11;
            this.txttotal.TextChanged += new System.EventHandler(this.txttotal_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(113, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "TOTAL";
            // 
            // btnfinalizarvenda
            // 
            this.btnfinalizarvenda.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnfinalizarvenda.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinalizarvenda.Location = new System.Drawing.Point(89, 397);
            this.btnfinalizarvenda.Name = "btnfinalizarvenda";
            this.btnfinalizarvenda.Size = new System.Drawing.Size(360, 41);
            this.btnfinalizarvenda.TabIndex = 48;
            this.btnfinalizarvenda.Text = "FINALIZAR VENDA";
            this.btnfinalizarvenda.UseVisualStyleBackColor = false;
            this.btnfinalizarvenda.Click += new System.EventHandler(this.btnfinalizarvenda_Click);
            // 
            // txtobs
            // 
            this.txtobs.Location = new System.Drawing.Point(547, 233);
            this.txtobs.Multiline = true;
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(183, 171);
            this.txtobs.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(423, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 18);
            this.label6.TabIndex = 49;
            this.label6.Text = "OBSERVAÇÕES";
            // 
            // Frmpagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.txtobs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnfinalizarvenda);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttroco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcartao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdinheiro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Frmpagamento";
            this.Text = "Tela de Pagamento";
            this.Load += new System.EventHandler(this.Frmpagamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdinheiro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcartao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttroco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnfinalizarvenda;
        public System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtobs;
        private System.Windows.Forms.Label label6;
    }
}