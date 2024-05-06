namespace Simulation_Lab_9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btStart = new System.Windows.Forms.Button();
            this.edN = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.ed2 = new System.Windows.Forms.NumericUpDown();
            this.ed4 = new System.Windows.Forms.NumericUpDown();
            this.ed3 = new System.Windows.Forms.NumericUpDown();
            this.ed1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbAv = new System.Windows.Forms.TextBox();
            this.tbVar = new System.Windows.Forms.TextBox();
            this.tbEAr = new System.Windows.Forms.TextBox();
            this.tbEVar = new System.Windows.Forms.TextBox();
            this.tbChi = new System.Windows.Forms.TextBox();
            this.tbTrue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.edN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btStart.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStart.Location = new System.Drawing.Point(68, 402);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(231, 49);
            this.btStart.TabIndex = 38;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // edN
            // 
            this.edN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edN.Location = new System.Drawing.Point(230, 335);
            this.edN.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.edN.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.edN.Name = "edN";
            this.edN.Size = new System.Drawing.Size(93, 30);
            this.edN.TabIndex = 37;
            this.edN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edN.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(49, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 22);
            this.label9.TabIndex = 36;
            this.label9.Text = "Number of trials";
            // 
            // tb5
            // 
            this.tb5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb5.Location = new System.Drawing.Point(229, 280);
            this.tb5.Multiline = true;
            this.tb5.Name = "tb5";
            this.tb5.ReadOnly = true;
            this.tb5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb5.Size = new System.Drawing.Size(93, 29);
            this.tb5.TabIndex = 35;
            this.tb5.Text = "auto";
            this.tb5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ed2
            // 
            this.ed2.DecimalPlaces = 2;
            this.ed2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ed2.Location = new System.Drawing.Point(229, 107);
            this.ed2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ed2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ed2.Name = "ed2";
            this.ed2.Size = new System.Drawing.Size(93, 30);
            this.ed2.TabIndex = 34;
            this.ed2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ed2.Value = new decimal(new int[] {
            42,
            0,
            0,
            131072});
            // 
            // ed4
            // 
            this.ed4.DecimalPlaces = 2;
            this.ed4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ed4.Location = new System.Drawing.Point(229, 224);
            this.ed4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ed4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ed4.Name = "ed4";
            this.ed4.Size = new System.Drawing.Size(93, 30);
            this.ed4.TabIndex = 33;
            this.ed4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ed4.Value = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            // 
            // ed3
            // 
            this.ed3.DecimalPlaces = 2;
            this.ed3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ed3.Location = new System.Drawing.Point(229, 163);
            this.ed3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ed3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ed3.Name = "ed3";
            this.ed3.Size = new System.Drawing.Size(93, 30);
            this.ed3.TabIndex = 32;
            this.ed3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ed3.Value = new decimal(new int[] {
            20,
            0,
            0,
            131072});
            // 
            // ed1
            // 
            this.ed1.DecimalPlaces = 2;
            this.ed1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ed1.Location = new System.Drawing.Point(229, 50);
            this.ed1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ed1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ed1.Name = "ed1";
            this.ed1.Size = new System.Drawing.Size(93, 30);
            this.ed1.TabIndex = 31;
            this.ed1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ed1.Value = new decimal(new int[] {
            13,
            0,
            0,
            131072});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(49, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 22);
            this.label8.TabIndex = 30;
            this.label8.Text = "Prob 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(49, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 22);
            this.label7.TabIndex = 29;
            this.label7.Text = "Prob 5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(49, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 22);
            this.label6.TabIndex = 28;
            this.label6.Text = "Prob 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(49, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "Prob 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(49, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Prob 1";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(388, 50);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(655, 401);
            this.chart1.TabIndex = 40;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(384, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 41;
            this.label1.Text = "Average:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(704, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 42;
            this.label2.Text = "Error  = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(384, 607);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 22);
            this.label3.TabIndex = 43;
            this.label3.Text = "Chi-squared:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(704, 548);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 22);
            this.label10.TabIndex = 44;
            this.label10.Text = "Error  = ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(384, 548);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 22);
            this.label11.TabIndex = 45;
            this.label11.Text = "Varience:";
            // 
            // tbAv
            // 
            this.tbAv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAv.Location = new System.Drawing.Point(484, 484);
            this.tbAv.Multiline = true;
            this.tbAv.Name = "tbAv";
            this.tbAv.ReadOnly = true;
            this.tbAv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbAv.Size = new System.Drawing.Size(184, 29);
            this.tbAv.TabIndex = 46;
            // 
            // tbVar
            // 
            this.tbVar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbVar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbVar.Location = new System.Drawing.Point(484, 546);
            this.tbVar.Multiline = true;
            this.tbVar.Name = "tbVar";
            this.tbVar.ReadOnly = true;
            this.tbVar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbVar.Size = new System.Drawing.Size(184, 29);
            this.tbVar.TabIndex = 47;
            // 
            // tbEAr
            // 
            this.tbEAr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEAr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEAr.Location = new System.Drawing.Point(777, 484);
            this.tbEAr.Multiline = true;
            this.tbEAr.Name = "tbEAr";
            this.tbEAr.ReadOnly = true;
            this.tbEAr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbEAr.Size = new System.Drawing.Size(87, 29);
            this.tbEAr.TabIndex = 48;
            this.tbEAr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEVar
            // 
            this.tbEVar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEVar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEVar.Location = new System.Drawing.Point(777, 546);
            this.tbEVar.Multiline = true;
            this.tbEVar.Name = "tbEVar";
            this.tbEVar.ReadOnly = true;
            this.tbEVar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbEVar.Size = new System.Drawing.Size(87, 29);
            this.tbEVar.TabIndex = 49;
            this.tbEVar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbChi
            // 
            this.tbChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbChi.Location = new System.Drawing.Point(509, 609);
            this.tbChi.Multiline = true;
            this.tbChi.Name = "tbChi";
            this.tbChi.ReadOnly = true;
            this.tbChi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbChi.Size = new System.Drawing.Size(77, 29);
            this.tbChi.TabIndex = 50;
            this.tbChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbChi.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // tbTrue
            // 
            this.tbTrue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTrue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTrue.Location = new System.Drawing.Point(592, 609);
            this.tbTrue.Multiline = true;
            this.tbTrue.Name = "tbTrue";
            this.tbTrue.ReadOnly = true;
            this.tbTrue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbTrue.Size = new System.Drawing.Size(258, 29);
            this.tbTrue.TabIndex = 51;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 680);
            this.Controls.Add(this.tbTrue);
            this.Controls.Add(this.tbChi);
            this.Controls.Add(this.tbEVar);
            this.Controls.Add(this.tbEAr);
            this.Controls.Add(this.tbVar);
            this.Controls.Add(this.tbAv);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.edN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb5);
            this.Controls.Add(this.ed2);
            this.Controls.Add(this.ed4);
            this.Controls.Add(this.ed3);
            this.Controls.Add(this.ed1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.edN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.NumericUpDown edN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.NumericUpDown ed2;
        private System.Windows.Forms.NumericUpDown ed4;
        private System.Windows.Forms.NumericUpDown ed3;
        private System.Windows.Forms.NumericUpDown ed1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbAv;
        private System.Windows.Forms.TextBox tbVar;
        private System.Windows.Forms.TextBox tbEAr;
        private System.Windows.Forms.TextBox tbEVar;
        private System.Windows.Forms.TextBox tbChi;
        private System.Windows.Forms.TextBox tbTrue;
    }
}

