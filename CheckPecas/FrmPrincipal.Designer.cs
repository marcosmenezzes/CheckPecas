namespace CheckPecas
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.mtxtData = new System.Windows.Forms.MaskedTextBox();
            this.cbPecas = new System.Windows.Forms.ComboBox();
            this.txtProduzidas = new System.Windows.Forms.TextBox();
            this.txtPrejuizo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxtHrFinal = new System.Windows.Forms.MaskedTextBox();
            this.mtxtHrInicial = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnSalvas = new System.Windows.Forms.Button();
            this.numericAprovadas = new System.Windows.Forms.NumericUpDown();
            this.numericReprovadas = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAprovadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericReprovadas)).BeginInit();
            this.SuspendLayout();
            // 
            // mtxtData
            // 
            this.mtxtData.Location = new System.Drawing.Point(248, 96);
            this.mtxtData.Mask = "00/00/0000";
            this.mtxtData.Name = "mtxtData";
            this.mtxtData.Size = new System.Drawing.Size(69, 20);
            this.mtxtData.TabIndex = 0;
            this.mtxtData.ValidatingType = typeof(System.DateTime);
            this.mtxtData.Leave += new System.EventHandler(this.mtxtData_Leave);
            // 
            // cbPecas
            // 
            this.cbPecas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPecas.FormattingEnabled = true;
            this.cbPecas.Location = new System.Drawing.Point(257, 122);
            this.cbPecas.Name = "cbPecas";
            this.cbPecas.Size = new System.Drawing.Size(140, 21);
            this.cbPecas.TabIndex = 1;
            this.cbPecas.TextChanged += new System.EventHandler(this.cbPecas_TextChanged);
            // 
            // txtProduzidas
            // 
            this.txtProduzidas.Enabled = false;
            this.txtProduzidas.Location = new System.Drawing.Point(285, 201);
            this.txtProduzidas.Name = "txtProduzidas";
            this.txtProduzidas.Size = new System.Drawing.Size(64, 20);
            this.txtProduzidas.TabIndex = 4;
            this.txtProduzidas.TextChanged += new System.EventHandler(this.txtProduzidas_TextChanged);
            // 
            // txtPrejuizo
            // 
            this.txtPrejuizo.Enabled = false;
            this.txtPrejuizo.Location = new System.Drawing.Point(320, 227);
            this.txtPrejuizo.Name = "txtPrejuizo";
            this.txtPrejuizo.Size = new System.Drawing.Size(92, 20);
            this.txtPrejuizo.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(257, 253);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(205, 20);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.mtxtHrFinal);
            this.groupBox1.Controls.Add(this.mtxtHrInicial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(403, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 99);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tempo de Produção";
            // 
            // mtxtHrFinal
            // 
            this.mtxtHrFinal.Location = new System.Drawing.Point(101, 55);
            this.mtxtHrFinal.Mask = "00:00";
            this.mtxtHrFinal.Name = "mtxtHrFinal";
            this.mtxtHrFinal.Size = new System.Drawing.Size(38, 22);
            this.mtxtHrFinal.TabIndex = 3;
            this.mtxtHrFinal.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtHrInicial
            // 
            this.mtxtHrInicial.Location = new System.Drawing.Point(101, 25);
            this.mtxtHrInicial.Mask = "00:00";
            this.mtxtHrInicial.Name = "mtxtHrInicial";
            this.mtxtHrInicial.Size = new System.Drawing.Size(38, 22);
            this.mtxtHrInicial.TabIndex = 2;
            this.mtxtHrInicial.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hr. Final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hr. Inicial:";
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.Black;
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnRelatorio.Location = new System.Drawing.Point(218, 305);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(115, 26);
            this.btnRelatorio.TabIndex = 8;
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnSalvas
            // 
            this.btnSalvas.BackColor = System.Drawing.Color.Black;
            this.btnSalvas.FlatAppearance.BorderSize = 0;
            this.btnSalvas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvas.ForeColor = System.Drawing.Color.White;
            this.btnSalvas.Location = new System.Drawing.Point(368, 305);
            this.btnSalvas.Name = "btnSalvas";
            this.btnSalvas.Size = new System.Drawing.Size(115, 26);
            this.btnSalvas.TabIndex = 9;
            this.btnSalvas.Text = "Salvar";
            this.btnSalvas.UseVisualStyleBackColor = false;
            this.btnSalvas.Click += new System.EventHandler(this.btnSalvas_Click);
            // 
            // numericAprovadas
            // 
            this.numericAprovadas.Enabled = false;
            this.numericAprovadas.Location = new System.Drawing.Point(285, 149);
            this.numericAprovadas.Name = "numericAprovadas";
            this.numericAprovadas.Size = new System.Drawing.Size(64, 20);
            this.numericAprovadas.TabIndex = 10;
            this.numericAprovadas.ValueChanged += new System.EventHandler(this.numericAprovadas_ValueChanged);
            // 
            // numericReprovadas
            // 
            this.numericReprovadas.Enabled = false;
            this.numericReprovadas.Location = new System.Drawing.Point(285, 177);
            this.numericReprovadas.Name = "numericReprovadas";
            this.numericReprovadas.Size = new System.Drawing.Size(64, 20);
            this.numericReprovadas.TabIndex = 11;
            this.numericReprovadas.ValueChanged += new System.EventHandler(this.numericReprovadas_ValueChanged);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CheckPecas.Properties.Resources.Check_Peças__1_;
            this.ClientSize = new System.Drawing.Size(614, 442);
            this.Controls.Add(this.numericReprovadas);
            this.Controls.Add(this.numericAprovadas);
            this.Controls.Add(this.btnSalvas);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPrejuizo);
            this.Controls.Add(this.txtProduzidas);
            this.Controls.Add(this.cbPecas);
            this.Controls.Add(this.mtxtData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAprovadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericReprovadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtData;
        private System.Windows.Forms.ComboBox cbPecas;
        private System.Windows.Forms.TextBox txtProduzidas;
        private System.Windows.Forms.TextBox txtPrejuizo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtxtHrFinal;
        private System.Windows.Forms.MaskedTextBox mtxtHrInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnSalvas;
        private System.Windows.Forms.NumericUpDown numericAprovadas;
        private System.Windows.Forms.NumericUpDown numericReprovadas;
    }
}