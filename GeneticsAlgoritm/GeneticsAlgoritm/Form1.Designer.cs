namespace GeneticsAlgoritm
{
    partial class FormGeneticAlgorithm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.gBParameters = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nPP = new System.Windows.Forms.NumericUpDown();
            this.nS = new System.Windows.Forms.NumericUpDown();
            this.nMO = new System.Windows.Forms.NumericUpDown();
            this.nCo = new System.Windows.Forms.NumericUpDown();
            this.nPB = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lPP = new System.Windows.Forms.Label();
            this.lS = new System.Windows.Forms.Label();
            this.lMO = new System.Windows.Forms.Label();
            this.lCO = new System.Windows.Forms.Label();
            this.lPB = new System.Windows.Forms.Label();
            this.gBOutput = new System.Windows.Forms.GroupBox();
            this.bCalc = new System.Windows.Forms.Button();
            this.nJS = new System.Windows.Forms.NumericUpDown();
            this.lJS = new System.Windows.Forms.Label();
            this.cData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gBParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPB)).BeginInit();
            this.gBOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nJS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cData)).BeginInit();
            this.SuspendLayout();
            // 
            // gBParameters
            // 
            this.gBParameters.Controls.Add(this.comboBox1);
            this.gBParameters.Controls.Add(this.nPP);
            this.gBParameters.Controls.Add(this.nS);
            this.gBParameters.Controls.Add(this.nMO);
            this.gBParameters.Controls.Add(this.nCo);
            this.gBParameters.Controls.Add(this.nPB);
            this.gBParameters.Controls.Add(this.label1);
            this.gBParameters.Controls.Add(this.lPP);
            this.gBParameters.Controls.Add(this.lS);
            this.gBParameters.Controls.Add(this.lMO);
            this.gBParameters.Controls.Add(this.lCO);
            this.gBParameters.Controls.Add(this.lPB);
            this.gBParameters.Location = new System.Drawing.Point(12, 12);
            this.gBParameters.Name = "gBParameters";
            this.gBParameters.Size = new System.Drawing.Size(251, 196);
            this.gBParameters.TabIndex = 0;
            this.gBParameters.TabStop = false;
            this.gBParameters.Text = "Parametreler";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Herhangi biri",
            "Rulet",
            "Rastgele",
            "Turnuva"});
            this.comboBox1.Location = new System.Drawing.Point(125, 145);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Lütfen Seçiniz...";
            // 
            // nPP
            // 
            this.nPP.Location = new System.Drawing.Point(125, 119);
            this.nPP.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nPP.Name = "nPP";
            this.nPP.Size = new System.Drawing.Size(120, 20);
            this.nPP.TabIndex = 3;
            this.nPP.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nS
            // 
            this.nS.Location = new System.Drawing.Point(125, 93);
            this.nS.Name = "nS";
            this.nS.Size = new System.Drawing.Size(120, 20);
            this.nS.TabIndex = 3;
            this.nS.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nMO
            // 
            this.nMO.DecimalPlaces = 4;
            this.nMO.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.nMO.Location = new System.Drawing.Point(125, 67);
            this.nMO.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nMO.Name = "nMO";
            this.nMO.Size = new System.Drawing.Size(120, 20);
            this.nMO.TabIndex = 3;
            this.nMO.Value = new decimal(new int[] {
            10,
            0,
            0,
            262144});
            // 
            // nCo
            // 
            this.nCo.DecimalPlaces = 2;
            this.nCo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nCo.Location = new System.Drawing.Point(125, 41);
            this.nCo.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nCo.Name = "nCo";
            this.nCo.Size = new System.Drawing.Size(120, 20);
            this.nCo.TabIndex = 3;
            this.nCo.Value = new decimal(new int[] {
            70,
            0,
            0,
            131072});
            // 
            // nPB
            // 
            this.nPB.Location = new System.Drawing.Point(125, 15);
            this.nPB.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nPB.Name = "nPB";
            this.nPB.Size = new System.Drawing.Size(120, 20);
            this.nPB.TabIndex = 3;
            this.nPB.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eşletirme Tipi : ";
            // 
            // lPP
            // 
            this.lPP.AutoSize = true;
            this.lPP.Location = new System.Drawing.Point(12, 121);
            this.lPP.Name = "lPP";
            this.lPP.Size = new System.Drawing.Size(107, 13);
            this.lPP.TabIndex = 2;
            this.lPP.Text = "Penalty Parameters : ";
            // 
            // lS
            // 
            this.lS.AutoSize = true;
            this.lS.Location = new System.Drawing.Point(60, 95);
            this.lS.Name = "lS";
            this.lS.Size = new System.Drawing.Size(59, 13);
            this.lS.TabIndex = 2;
            this.lS.Text = "Seçkinlik : ";
            // 
            // lMO
            // 
            this.lMO.AutoSize = true;
            this.lMO.Location = new System.Drawing.Point(29, 69);
            this.lMO.Name = "lMO";
            this.lMO.Size = new System.Drawing.Size(90, 13);
            this.lMO.TabIndex = 2;
            this.lMO.Text = "Mutasyon Oranı : ";
            // 
            // lCO
            // 
            this.lCO.AutoSize = true;
            this.lCO.Location = new System.Drawing.Point(20, 43);
            this.lCO.Name = "lCO";
            this.lCO.Size = new System.Drawing.Size(99, 13);
            this.lCO.TabIndex = 1;
            this.lCO.Text = "Çaprazlama Oranı : ";
            // 
            // lPB
            // 
            this.lPB.AutoSize = true;
            this.lPB.Location = new System.Drawing.Point(12, 17);
            this.lPB.Name = "lPB";
            this.lPB.Size = new System.Drawing.Size(107, 13);
            this.lPB.TabIndex = 0;
            this.lPB.Text = "Popülasyon Boyutu : ";
            // 
            // gBOutput
            // 
            this.gBOutput.Controls.Add(this.bCalc);
            this.gBOutput.Controls.Add(this.nJS);
            this.gBOutput.Controls.Add(this.lJS);
            this.gBOutput.Location = new System.Drawing.Point(12, 214);
            this.gBOutput.Name = "gBOutput";
            this.gBOutput.Size = new System.Drawing.Size(251, 135);
            this.gBOutput.TabIndex = 0;
            this.gBOutput.TabStop = false;
            this.gBOutput.Text = "Çıkış";
            // 
            // bCalc
            // 
            this.bCalc.Location = new System.Drawing.Point(6, 55);
            this.bCalc.Name = "bCalc";
            this.bCalc.Size = new System.Drawing.Size(239, 52);
            this.bCalc.TabIndex = 4;
            this.bCalc.Text = "Hesapla";
            this.bCalc.UseVisualStyleBackColor = true;
            this.bCalc.Click += new System.EventHandler(this.bCalc_Click);
            // 
            // nJS
            // 
            this.nJS.Location = new System.Drawing.Point(125, 29);
            this.nJS.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nJS.Name = "nJS";
            this.nJS.Size = new System.Drawing.Size(120, 20);
            this.nJS.TabIndex = 3;
            this.nJS.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lJS
            // 
            this.lJS.AutoSize = true;
            this.lJS.Location = new System.Drawing.Point(19, 31);
            this.lJS.Name = "lJS";
            this.lJS.Size = new System.Drawing.Size(100, 13);
            this.lJS.TabIndex = 2;
            this.lJS.Text = "Jenerasyon Sayısı : ";
            // 
            // cData
            // 
            chartArea3.Name = "ChartArea1";
            this.cData.ChartAreas.Add(chartArea3);
            this.cData.Location = new System.Drawing.Point(269, 12);
            this.cData.Name = "cData";
            this.cData.Size = new System.Drawing.Size(519, 296);
            this.cData.TabIndex = 1;
            this.cData.Text = "cData";
            // 
            // FormGeneticAlgorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 361);
            this.Controls.Add(this.cData);
            this.Controls.Add(this.gBOutput);
            this.Controls.Add(this.gBParameters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGeneticAlgorithm";
            this.Text = "Genetik Algoritma";
            this.gBParameters.ResumeLayout(false);
            this.gBParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPB)).EndInit();
            this.gBOutput.ResumeLayout(false);
            this.gBOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nJS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBParameters;
        private System.Windows.Forms.GroupBox gBOutput;
        private System.Windows.Forms.DataVisualization.Charting.Chart cData;
        private System.Windows.Forms.NumericUpDown nPP;
        private System.Windows.Forms.NumericUpDown nS;
        private System.Windows.Forms.NumericUpDown nMO;
        private System.Windows.Forms.NumericUpDown nCo;
        private System.Windows.Forms.NumericUpDown nPB;
        private System.Windows.Forms.Label lPP;
        private System.Windows.Forms.Label lS;
        private System.Windows.Forms.Label lMO;
        private System.Windows.Forms.Label lCO;
        private System.Windows.Forms.Label lPB;
        private System.Windows.Forms.Button bCalc;
        private System.Windows.Forms.NumericUpDown nJS;
        private System.Windows.Forms.Label lJS;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

