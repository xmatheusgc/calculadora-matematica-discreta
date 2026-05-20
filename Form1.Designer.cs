namespace projeto_md
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabConversion = new System.Windows.Forms.TabPage();
            this.lblResultConv = new System.Windows.Forms.Label();
            this.rtbStepsConv = new System.Windows.Forms.RichTextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.cbToBase = new System.Windows.Forms.ComboBox();
            this.cbFromBase = new System.Windows.Forms.ComboBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.tabEuclid = new System.Windows.Forms.TabPage();
            this.lblResultEuclid = new System.Windows.Forms.Label();
            this.rtbStepsEuclid = new System.Windows.Forms.RichTextBox();
            this.btnEuclid = new System.Windows.Forms.Button();
            this.txtB_Euclid = new System.Windows.Forms.TextBox();
            this.txtA_Euclid = new System.Windows.Forms.TextBox();
            this.tabSieve = new System.Windows.Forms.TabPage();
            this.lblPrimes = new System.Windows.Forms.Label();
            this.rtbStepsSieve = new System.Windows.Forms.RichTextBox();
            this.btnSieve = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.tabOperations = new System.Windows.Forms.TabPage();
            this.lblResultOps = new System.Windows.Forms.Label();
            this.rtbStepsOps = new System.Windows.Forms.RichTextBox();
            this.btnCalculateOps = new System.Windows.Forms.Button();
            this.cbOperation = new System.Windows.Forms.ComboBox();
            this.cbBaseOps = new System.Windows.Forms.ComboBox();
            this.txtB_Ops = new System.Windows.Forms.TextBox();
            this.txtA_Ops = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabConversion.SuspendLayout();
            this.tabEuclid.SuspendLayout();
            this.tabSieve.SuspendLayout();
            this.tabOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabConversion);
            this.tabControl1.Controls.Add(this.tabOperations);
            this.tabControl1.Controls.Add(this.tabEuclid);
            this.tabControl1.Controls.Add(this.tabSieve);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabConversion
            // 
            this.tabConversion.Controls.Add(this.lblResultConv);
            this.tabConversion.Controls.Add(this.rtbStepsConv);
            this.tabConversion.Controls.Add(this.btnConvert);
            this.tabConversion.Controls.Add(this.cbToBase);
            this.tabConversion.Controls.Add(this.cbFromBase);
            this.tabConversion.Controls.Add(this.txtValue);
            this.tabConversion.Location = new System.Drawing.Point(4, 22);
            this.tabConversion.Name = "tabConversion";
            this.tabConversion.Padding = new System.Windows.Forms.Padding(3);
            this.tabConversion.Size = new System.Drawing.Size(792, 424);
            this.tabConversion.TabIndex = 0;
            this.tabConversion.Text = "Conversão";
            this.tabConversion.UseVisualStyleBackColor = true;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(16, 16);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(240, 20);
            this.txtValue.TabIndex = 0;
            // 
            // cbFromBase
            // 
            this.cbFromBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFromBase.Items.AddRange(new object[] {
            "Decimal",
            "Binário",
            "Hexadecimal"});
            this.cbFromBase.Location = new System.Drawing.Point(272, 14);
            this.cbFromBase.Name = "cbFromBase";
            this.cbFromBase.Size = new System.Drawing.Size(120, 21);
            this.cbFromBase.TabIndex = 1;
            // 
            // cbToBase
            // 
            this.cbToBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbToBase.Items.AddRange(new object[] {
            "Decimal",
            "Binário",
            "Hexadecimal"});
            this.cbToBase.Location = new System.Drawing.Point(400, 14);
            this.cbToBase.Name = "cbToBase";
            this.cbToBase.Size = new System.Drawing.Size(120, 21);
            this.cbToBase.TabIndex = 2;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(528, 12);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Converter";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // rtbStepsConv
            // 
            this.rtbStepsConv.Location = new System.Drawing.Point(16, 48);
            this.rtbStepsConv.Name = "rtbStepsConv";
            this.rtbStepsConv.Size = new System.Drawing.Size(760, 320);
            this.rtbStepsConv.TabIndex = 4;
            this.rtbStepsConv.Text = "";
            // 
            // lblResultConv
            // 
            this.lblResultConv.AutoSize = true;
            this.lblResultConv.Location = new System.Drawing.Point(16, 376);
            this.lblResultConv.Name = "lblResultConv";
            this.lblResultConv.Size = new System.Drawing.Size(55, 13);
            this.lblResultConv.TabIndex = 5;
            this.lblResultConv.Text = "Resultado:";
            // 
            // tabOperations
            // 
            this.tabOperations.Controls.Add(this.lblResultOps);
            this.tabOperations.Controls.Add(this.rtbStepsOps);
            this.tabOperations.Controls.Add(this.btnCalculateOps);
            this.tabOperations.Controls.Add(this.cbOperation);
            this.tabOperations.Controls.Add(this.cbBaseOps);
            this.tabOperations.Controls.Add(this.txtB_Ops);
            this.tabOperations.Controls.Add(this.txtA_Ops);
            this.tabOperations.Location = new System.Drawing.Point(4, 22);
            this.tabOperations.Name = "tabOperations";
            this.tabOperations.Padding = new System.Windows.Forms.Padding(3);
            this.tabOperations.Size = new System.Drawing.Size(792, 424);
            this.tabOperations.TabIndex = 1;
            this.tabOperations.Text = "Operações";
            this.tabOperations.UseVisualStyleBackColor = true;
            // 
            // txtA_Ops
            // 
            this.txtA_Ops.Location = new System.Drawing.Point(16, 16);
            this.txtA_Ops.Name = "txtA_Ops";
            this.txtA_Ops.Size = new System.Drawing.Size(180, 20);
            this.txtA_Ops.TabIndex = 0;
            // 
            // txtB_Ops
            // 
            this.txtB_Ops.Location = new System.Drawing.Point(200, 16);
            this.txtB_Ops.Name = "txtB_Ops";
            this.txtB_Ops.Size = new System.Drawing.Size(180, 20);
            this.txtB_Ops.TabIndex = 1;
            // 
            // cbBaseOps
            // 
            this.cbBaseOps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaseOps.Items.AddRange(new object[] {
            "Decimal",
            "Binário",
            "Hexadecimal"});
            this.cbBaseOps.Location = new System.Drawing.Point(388, 14);
            this.cbBaseOps.Name = "cbBaseOps";
            this.cbBaseOps.Size = new System.Drawing.Size(120, 21);
            this.cbBaseOps.TabIndex = 2;
            // 
            // cbOperation
            // 
            this.cbOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperation.Items.AddRange(new object[] {
            "Soma",
            "Subtração",
            "Multiplicação"});
            this.cbOperation.Location = new System.Drawing.Point(516, 14);
            this.cbOperation.Name = "cbOperation";
            this.cbOperation.Size = new System.Drawing.Size(120, 21);
            this.cbOperation.TabIndex = 3;
            // 
            // btnCalculateOps
            // 
            this.btnCalculateOps.Location = new System.Drawing.Point(644, 12);
            this.btnCalculateOps.Name = "btnCalculateOps";
            this.btnCalculateOps.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateOps.TabIndex = 4;
            this.btnCalculateOps.Text = "Calcular";
            this.btnCalculateOps.UseVisualStyleBackColor = true;
            this.btnCalculateOps.Click += new System.EventHandler(this.btnCalculateOps_Click);
            // 
            // rtbStepsOps
            // 
            this.rtbStepsOps.Location = new System.Drawing.Point(16, 48);
            this.rtbStepsOps.Name = "rtbStepsOps";
            this.rtbStepsOps.Size = new System.Drawing.Size(760, 320);
            this.rtbStepsOps.TabIndex = 5;
            this.rtbStepsOps.Text = "";
            // 
            // lblResultOps
            // 
            this.lblResultOps.AutoSize = true;
            this.lblResultOps.Location = new System.Drawing.Point(16, 376);
            this.lblResultOps.Name = "lblResultOps";
            this.lblResultOps.Size = new System.Drawing.Size(55, 13);
            this.lblResultOps.TabIndex = 6;
            this.lblResultOps.Text = "Resultado:";
            // 
            // tabEuclid
            // 
            this.tabEuclid.Controls.Add(this.lblResultEuclid);
            this.tabEuclid.Controls.Add(this.rtbStepsEuclid);
            this.tabEuclid.Controls.Add(this.btnEuclid);
            this.tabEuclid.Controls.Add(this.txtB_Euclid);
            this.tabEuclid.Controls.Add(this.txtA_Euclid);
            this.tabEuclid.Location = new System.Drawing.Point(4, 22);
            this.tabEuclid.Name = "tabEuclid";
            this.tabEuclid.Padding = new System.Windows.Forms.Padding(3);
            this.tabEuclid.Size = new System.Drawing.Size(792, 424);
            this.tabEuclid.TabIndex = 2;
            this.tabEuclid.Text = "Euclides";
            this.tabEuclid.UseVisualStyleBackColor = true;
            // 
            // txtA_Euclid
            // 
            this.txtA_Euclid.Location = new System.Drawing.Point(16, 16);
            this.txtA_Euclid.Name = "txtA_Euclid";
            this.txtA_Euclid.Size = new System.Drawing.Size(180, 20);
            this.txtA_Euclid.TabIndex = 0;
            // 
            // txtB_Euclid
            // 
            this.txtB_Euclid.Location = new System.Drawing.Point(200, 16);
            this.txtB_Euclid.Name = "txtB_Euclid";
            this.txtB_Euclid.Size = new System.Drawing.Size(180, 20);
            this.txtB_Euclid.TabIndex = 1;
            // 
            // btnEuclid
            // 
            this.btnEuclid.Location = new System.Drawing.Point(388, 14);
            this.btnEuclid.Name = "btnEuclid";
            this.btnEuclid.Size = new System.Drawing.Size(75, 23);
            this.btnEuclid.TabIndex = 2;
            this.btnEuclid.Text = "Calcular";
            this.btnEuclid.UseVisualStyleBackColor = true;
            this.btnEuclid.Click += new System.EventHandler(this.btnEuclid_Click);
            // 
            // rtbStepsEuclid
            // 
            this.rtbStepsEuclid.Location = new System.Drawing.Point(16, 48);
            this.rtbStepsEuclid.Name = "rtbStepsEuclid";
            this.rtbStepsEuclid.Size = new System.Drawing.Size(760, 320);
            this.rtbStepsEuclid.TabIndex = 3;
            this.rtbStepsEuclid.Text = "";
            // 
            // lblResultEuclid
            // 
            this.lblResultEuclid.AutoSize = true;
            this.lblResultEuclid.Location = new System.Drawing.Point(16, 376);
            this.lblResultEuclid.Name = "lblResultEuclid";
            this.lblResultEuclid.Size = new System.Drawing.Size(55, 13);
            this.lblResultEuclid.TabIndex = 4;
            this.lblResultEuclid.Text = "Resultado:";
            // 
            // tabSieve
            // 
            this.tabSieve.Controls.Add(this.lblPrimes);
            this.tabSieve.Controls.Add(this.rtbStepsSieve);
            this.tabSieve.Controls.Add(this.btnSieve);
            this.tabSieve.Controls.Add(this.txtN);
            this.tabSieve.Location = new System.Drawing.Point(4, 22);
            this.tabSieve.Name = "tabSieve";
            this.tabSieve.Padding = new System.Windows.Forms.Padding(3);
            this.tabSieve.Size = new System.Drawing.Size(792, 424);
            this.tabSieve.TabIndex = 3;
            this.tabSieve.Text = "Crivo";
            this.tabSieve.UseVisualStyleBackColor = true;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(16, 16);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(180, 20);
            this.txtN.TabIndex = 0;
            // 
            // btnSieve
            // 
            this.btnSieve.Location = new System.Drawing.Point(200, 14);
            this.btnSieve.Name = "btnSieve";
            this.btnSieve.Size = new System.Drawing.Size(75, 23);
            this.btnSieve.TabIndex = 1;
            this.btnSieve.Text = "Executar";
            this.btnSieve.UseVisualStyleBackColor = true;
            this.btnSieve.Click += new System.EventHandler(this.btnSieve_Click);
            // 
            // rtbStepsSieve
            // 
            this.rtbStepsSieve.Location = new System.Drawing.Point(16, 48);
            this.rtbStepsSieve.Name = "rtbStepsSieve";
            this.rtbStepsSieve.Size = new System.Drawing.Size(760, 320);
            this.rtbStepsSieve.TabIndex = 2;
            this.rtbStepsSieve.Text = "";
            // 
            // lblPrimes
            // 
            this.lblPrimes.AutoSize = true;
            this.lblPrimes.Location = new System.Drawing.Point(16, 376);
            this.lblPrimes.Name = "lblPrimes";
            this.lblPrimes.Size = new System.Drawing.Size(37, 13);
            this.lblPrimes.TabIndex = 3;
            this.lblPrimes.Text = "Primos:";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Projeto de Matemática Discreta";
            this.tabControl1.ResumeLayout(false);
            this.tabConversion.ResumeLayout(false);
            this.tabConversion.PerformLayout();
            this.tabOperations.ResumeLayout(false);
            this.tabOperations.PerformLayout();
            this.tabEuclid.ResumeLayout(false);
            this.tabEuclid.PerformLayout();
            this.tabSieve.ResumeLayout(false);
            this.tabSieve.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabConversion;
        private System.Windows.Forms.TabPage tabOperations;
        private System.Windows.Forms.TabPage tabEuclid;
        private System.Windows.Forms.TabPage tabSieve;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.ComboBox cbFromBase;
        private System.Windows.Forms.ComboBox cbToBase;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.RichTextBox rtbStepsConv;
        private System.Windows.Forms.Label lblResultConv;
        private System.Windows.Forms.TextBox txtA_Ops;
        private System.Windows.Forms.TextBox txtB_Ops;
        private System.Windows.Forms.ComboBox cbBaseOps;
        private System.Windows.Forms.ComboBox cbOperation;
        private System.Windows.Forms.Button btnCalculateOps;
        private System.Windows.Forms.RichTextBox rtbStepsOps;
        private System.Windows.Forms.Label lblResultOps;
        private System.Windows.Forms.TextBox txtA_Euclid;
        private System.Windows.Forms.TextBox txtB_Euclid;
        private System.Windows.Forms.Button btnEuclid;
        private System.Windows.Forms.RichTextBox rtbStepsEuclid;
        private System.Windows.Forms.Label lblResultEuclid;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnSieve;
        private System.Windows.Forms.RichTextBox rtbStepsSieve;
        private System.Windows.Forms.Label lblPrimes;

        #endregion
    }
}

