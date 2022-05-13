
namespace Лабораторная_8
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btStart1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.btStart2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ed1 = new System.Windows.Forms.NumericUpDown();
            this.ed2 = new System.Windows.Forms.NumericUpDown();
            this.ed3 = new System.Windows.Forms.NumericUpDown();
            this.ed4 = new System.Windows.Forms.NumericUpDown();
            this.ed5 = new System.Windows.Forms.NumericUpDown();
            this.edAmount = new System.Windows.Forms.NumericUpDown();
            this.btStart3 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ed1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btStart1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 184);
            this.panel1.TabIndex = 0;
            // 
            // btStart1
            // 
            this.btStart1.Location = new System.Drawing.Point(99, 66);
            this.btStart1.Name = "btStart1";
            this.btStart1.Size = new System.Drawing.Size(84, 45);
            this.btStart1.TabIndex = 1;
            this.btStart1.Text = "Узнать ";
            this.btStart1.UseVisualStyleBackColor = true;
            this.btStart1.Click += new System.EventHandler(this.btStart1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вопрос";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.btStart2);
            this.panel2.Controls.Add(this.lb2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(4, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 200);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chart1);
            this.panel3.Controls.Add(this.btStart3);
            this.panel3.Controls.Add(this.edAmount);
            this.panel3.Controls.Add(this.ed5);
            this.panel3.Controls.Add(this.ed4);
            this.panel3.Controls.Add(this.ed3);
            this.panel3.Controls.Add(this.ed2);
            this.panel3.Controls.Add(this.ed1);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(484, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(952, 406);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ответ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 22);
            this.textBox1.TabIndex = 3;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(133, 134);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(0, 17);
            this.lb1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Вопрос";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ответ";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(163, 151);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(0, 17);
            this.lb2.TabIndex = 2;
            // 
            // btStart2
            // 
            this.btStart2.Location = new System.Drawing.Point(103, 83);
            this.btStart2.Name = "btStart2";
            this.btStart2.Size = new System.Drawing.Size(84, 45);
            this.btStart2.TabIndex = 3;
            this.btStart2.Text = "Узнать";
            this.btStart2.UseVisualStyleBackColor = true;
            this.btStart2.Click += new System.EventHandler(this.btStart2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(247, 22);
            this.textBox2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Вероятность 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Вероятность 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Вероятность 3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Вероятность 4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(104, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Вероятность 5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(75, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Количество испытаний";
            // 
            // ed1
            // 
            this.ed1.DecimalPlaces = 2;
            this.ed1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ed1.Location = new System.Drawing.Point(270, 35);
            this.ed1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ed1.Name = "ed1";
            this.ed1.Size = new System.Drawing.Size(120, 22);
            this.ed1.TabIndex = 6;
            // 
            // ed2
            // 
            this.ed2.DecimalPlaces = 2;
            this.ed2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ed2.Location = new System.Drawing.Point(270, 75);
            this.ed2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ed2.Name = "ed2";
            this.ed2.Size = new System.Drawing.Size(120, 22);
            this.ed2.TabIndex = 7;
            // 
            // ed3
            // 
            this.ed3.DecimalPlaces = 2;
            this.ed3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ed3.Location = new System.Drawing.Point(270, 114);
            this.ed3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ed3.Name = "ed3";
            this.ed3.Size = new System.Drawing.Size(120, 22);
            this.ed3.TabIndex = 8;
            // 
            // ed4
            // 
            this.ed4.DecimalPlaces = 2;
            this.ed4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ed4.Location = new System.Drawing.Point(270, 152);
            this.ed4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ed4.Name = "ed4";
            this.ed4.Size = new System.Drawing.Size(120, 22);
            this.ed4.TabIndex = 9;
            // 
            // ed5
            // 
            this.ed5.DecimalPlaces = 2;
            this.ed5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ed5.Location = new System.Drawing.Point(270, 191);
            this.ed5.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ed5.Name = "ed5";
            this.ed5.Size = new System.Drawing.Size(120, 22);
            this.ed5.TabIndex = 10;
            this.ed5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // edAmount
            // 
            this.edAmount.Location = new System.Drawing.Point(270, 269);
            this.edAmount.Name = "edAmount";
            this.edAmount.Size = new System.Drawing.Size(120, 22);
            this.edAmount.TabIndex = 11;
            this.edAmount.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // btStart3
            // 
            this.btStart3.Location = new System.Drawing.Point(157, 324);
            this.btStart3.Name = "btStart3";
            this.btStart3.Size = new System.Drawing.Size(155, 50);
            this.btStart3.TabIndex = 12;
            this.btStart3.Text = "Узнать";
            this.btStart3.UseVisualStyleBackColor = true;
            this.btStart3.Click += new System.EventHandler(this.btStart3_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(457, 35);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(466, 338);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 417);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ed1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btStart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btStart2;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown edAmount;
        private System.Windows.Forms.NumericUpDown ed5;
        private System.Windows.Forms.NumericUpDown ed4;
        private System.Windows.Forms.NumericUpDown ed3;
        private System.Windows.Forms.NumericUpDown ed2;
        private System.Windows.Forms.NumericUpDown ed1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btStart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

