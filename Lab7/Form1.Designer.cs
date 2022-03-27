namespace Lab7
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartPopulation = new System.Windows.Forms.NumericUpDown();
            this.StartBudget = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberOfIncidents = new System.Windows.Forms.Label();
            this.AmoutOfFines = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NumberOfArrests = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NumberOfStuff = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AmountBudget = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AmountPopulation = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.NextMonth = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-1, 140);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1129, 496);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Начальный бюджет:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Начальная популяция:";
            // 
            // StartPopulation
            // 
            this.StartPopulation.Location = new System.Drawing.Point(139, 61);
            this.StartPopulation.Name = "StartPopulation";
            this.StartPopulation.Size = new System.Drawing.Size(120, 20);
            this.StartPopulation.TabIndex = 3;
            // 
            // StartBudget
            // 
            this.StartBudget.Location = new System.Drawing.Point(139, 25);
            this.StartBudget.Name = "StartBudget";
            this.StartBudget.Size = new System.Drawing.Size(120, 20);
            this.StartBudget.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Инцидентов";
            // 
            // NumberOfIncidents
            // 
            this.NumberOfIncidents.AutoSize = true;
            this.NumberOfIncidents.Location = new System.Drawing.Point(362, 48);
            this.NumberOfIncidents.Name = "NumberOfIncidents";
            this.NumberOfIncidents.Size = new System.Drawing.Size(13, 13);
            this.NumberOfIncidents.TabIndex = 6;
            this.NumberOfIncidents.Text = "0";
            // 
            // AmoutOfFines
            // 
            this.AmoutOfFines.AutoSize = true;
            this.AmoutOfFines.Location = new System.Drawing.Point(472, 48);
            this.AmoutOfFines.Name = "AmoutOfFines";
            this.AmoutOfFines.Size = new System.Drawing.Size(13, 13);
            this.AmoutOfFines.TabIndex = 8;
            this.AmoutOfFines.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Сумма штрафов";
            // 
            // NumberOfArrests
            // 
            this.NumberOfArrests.AutoSize = true;
            this.NumberOfArrests.Location = new System.Drawing.Point(570, 48);
            this.NumberOfArrests.Name = "NumberOfArrests";
            this.NumberOfArrests.Size = new System.Drawing.Size(13, 13);
            this.NumberOfArrests.TabIndex = 10;
            this.NumberOfArrests.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Арестов";
            // 
            // NumberOfStuff
            // 
            this.NumberOfStuff.AutoSize = true;
            this.NumberOfStuff.Location = new System.Drawing.Point(362, 102);
            this.NumberOfStuff.Name = "NumberOfStuff";
            this.NumberOfStuff.Size = new System.Drawing.Size(13, 13);
            this.NumberOfStuff.TabIndex = 12;
            this.NumberOfStuff.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Штат сотрудников";
            // 
            // AmountBudget
            // 
            this.AmountBudget.AutoSize = true;
            this.AmountBudget.Location = new System.Drawing.Point(472, 102);
            this.AmountBudget.Name = "AmountBudget";
            this.AmountBudget.Size = new System.Drawing.Size(13, 13);
            this.AmountBudget.TabIndex = 14;
            this.AmountBudget.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(456, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Бюджет";
            // 
            // AmountPopulation
            // 
            this.AmountPopulation.AutoSize = true;
            this.AmountPopulation.Location = new System.Drawing.Point(570, 102);
            this.AmountPopulation.Name = "AmountPopulation";
            this.AmountPopulation.Size = new System.Drawing.Size(13, 13);
            this.AmountPopulation.TabIndex = 16;
            this.AmountPopulation.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(540, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Популяция";
            // 
            // NextMonth
            // 
            this.NextMonth.Location = new System.Drawing.Point(678, 26);
            this.NextMonth.Name = "NextMonth";
            this.NextMonth.Size = new System.Drawing.Size(145, 72);
            this.NextMonth.TabIndex = 17;
            this.NextMonth.Text = "Start";
            this.NextMonth.UseVisualStyleBackColor = true;
            this.NextMonth.Click += new System.EventHandler(this.NextMonth_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 634);
            this.Controls.Add(this.NextMonth);
            this.Controls.Add(this.AmountPopulation);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.AmountBudget);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NumberOfStuff);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NumberOfArrests);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AmoutOfFines);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NumberOfIncidents);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StartBudget);
            this.Controls.Add(this.StartPopulation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartBudget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown StartPopulation;
        private System.Windows.Forms.NumericUpDown StartBudget;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NumberOfIncidents;
        private System.Windows.Forms.Label AmoutOfFines;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NumberOfArrests;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label NumberOfStuff;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label AmountBudget;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label AmountPopulation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button NextMonth;
    }
}

