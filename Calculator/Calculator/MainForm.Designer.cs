using System.Collections.Generic;

namespace Calculator
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxYMax = new System.Windows.Forms.TextBox();
            this.textBoxYMin = new System.Windows.Forms.TextBox();
            this.textBoxXMax = new System.Windows.Forms.TextBox();
            this.textBoxXMin = new System.Windows.Forms.TextBox();
            this.btnScale = new System.Windows.Forms.Button();
            this.btnBuildGraph = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panelX5 = new System.Windows.Forms.Panel();
            this.panelFx5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxfX5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxX5 = new System.Windows.Forms.TextBox();
            this.panelX4 = new System.Windows.Forms.Panel();
            this.panelFx4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxfX4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxX4 = new System.Windows.Forms.TextBox();
            this.panelX3 = new System.Windows.Forms.Panel();
            this.panelFx3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxfX3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxX3 = new System.Windows.Forms.TextBox();
            this.panelX2 = new System.Windows.Forms.Panel();
            this.panelFx2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxfX2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.panelX1 = new System.Windows.Forms.Panel();
            this.panelFx1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxfX1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnSolveNum = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnCheckResult = new System.Windows.Forms.Button();
            this.btnFindRoots = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxFx = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.labelFx = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelEqual0 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_a0 = new System.Windows.Forms.TextBox();
            this.labelCoeff1 = new System.Windows.Forms.Label();
            this.textBox_a1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelCoeff2 = new System.Windows.Forms.Label();
            this.textBox_a2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_a3 = new System.Windows.Forms.TextBox();
            this.labelCoeff3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox_a4 = new System.Windows.Forms.TextBox();
            this.labelCoeff4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox_a5 = new System.Windows.Forms.TextBox();
            this.labelCoeff5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelTrackBar = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.degreeBox = new System.Windows.Forms.ComboBox();
            this.labelCoeff0 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelX5.SuspendLayout();
            this.panelFx5.SuspendLayout();
            this.panelX4.SuspendLayout();
            this.panelFx4.SuspendLayout();
            this.panelX3.SuspendLayout();
            this.panelFx3.SuspendLayout();
            this.panelX2.SuspendLayout();
            this.panelFx2.SuspendLayout();
            this.panelX1.SuspendLayout();
            this.panelFx1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxFx.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.textBoxYMax);
            this.groupBox2.Controls.Add(this.textBoxYMin);
            this.groupBox2.Controls.Add(this.textBoxXMax);
            this.groupBox2.Controls.Add(this.textBoxXMin);
            this.groupBox2.Controls.Add(this.btnScale);
            this.groupBox2.Controls.Add(this.btnBuildGraph);
            this.groupBox2.Controls.Add(this.chart);
            this.groupBox2.Controls.Add(this.panel8);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(0, 202);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(593, 339);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // textBoxYMax
            // 
            this.textBoxYMax.Location = new System.Drawing.Point(288, 19);
            this.textBoxYMax.MaxLength = 5;
            this.textBoxYMax.Name = "textBoxYMax";
            this.textBoxYMax.Size = new System.Drawing.Size(33, 20);
            this.textBoxYMax.TabIndex = 7;
            this.textBoxYMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxYMax.Click += new System.EventHandler(this.textBoxScale_Click);
            this.textBoxYMax.TextChanged += new System.EventHandler(this.textBoxScale_TextChanged);
            this.textBoxYMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxYMin
            // 
            this.textBoxYMin.Location = new System.Drawing.Point(288, 281);
            this.textBoxYMin.MaxLength = 5;
            this.textBoxYMin.Name = "textBoxYMin";
            this.textBoxYMin.Size = new System.Drawing.Size(33, 20);
            this.textBoxYMin.TabIndex = 6;
            this.textBoxYMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxYMin.Click += new System.EventHandler(this.textBoxScale_Click);
            this.textBoxYMin.TextChanged += new System.EventHandler(this.textBoxScale_TextChanged);
            this.textBoxYMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxXMax
            // 
            this.textBoxXMax.Location = new System.Drawing.Point(250, 306);
            this.textBoxXMax.MaxLength = 5;
            this.textBoxXMax.Name = "textBoxXMax";
            this.textBoxXMax.Size = new System.Drawing.Size(33, 20);
            this.textBoxXMax.TabIndex = 5;
            this.textBoxXMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxXMax.Click += new System.EventHandler(this.textBoxScale_Click);
            this.textBoxXMax.TextChanged += new System.EventHandler(this.textBoxScale_TextChanged);
            this.textBoxXMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxXMin
            // 
            this.textBoxXMin.Location = new System.Drawing.Point(5, 306);
            this.textBoxXMin.MaxLength = 5;
            this.textBoxXMin.Name = "textBoxXMin";
            this.textBoxXMin.Size = new System.Drawing.Size(33, 20);
            this.textBoxXMin.TabIndex = 4;
            this.textBoxXMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxXMin.Click += new System.EventHandler(this.textBoxScale_Click);
            this.textBoxXMin.TextChanged += new System.EventHandler(this.textBoxScale_TextChanged);
            this.textBoxXMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // btnScale
            // 
            this.btnScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScale.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnScale.Location = new System.Drawing.Point(366, 294);
            this.btnScale.Name = "btnScale";
            this.btnScale.Size = new System.Drawing.Size(186, 25);
            this.btnScale.TabIndex = 3;
            this.btnScale.Text = "Масштаб по умолчанию";
            this.btnScale.UseVisualStyleBackColor = false;
            this.btnScale.Click += new System.EventHandler(this.btnScale_Click);
            // 
            // btnBuildGraph
            // 
            this.btnBuildGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuildGraph.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnBuildGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBuildGraph.Location = new System.Drawing.Point(366, 263);
            this.btnBuildGraph.Name = "btnBuildGraph";
            this.btnBuildGraph.Size = new System.Drawing.Size(186, 25);
            this.btnBuildGraph.TabIndex = 2;
            this.btnBuildGraph.Text = "Построить график";
            this.btnBuildGraph.UseVisualStyleBackColor = false;
            this.btnBuildGraph.Click += new System.EventHandler(this.btnBuildGraph_Click);
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.SystemColors.HighlightText;
            chartArea2.AxisX.Crossing = 0D;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.LineWidth = 2;
            chartArea2.AxisY.Crossing = 0D;
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.LineWidth = 2;
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            this.chart.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(5, 18);
            this.chart.Name = "chart";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Func";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(278, 282);
            this.chart.TabIndex = 0;
            this.chart.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            this.chart.MouseEnter += new System.EventHandler(this.chart_MouseEnter);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.panel7);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Location = new System.Drawing.Point(329, 19);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(259, 241);
            this.panel8.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panelX5);
            this.panel7.Controls.Add(this.panelX4);
            this.panel7.Controls.Add(this.panelX3);
            this.panel7.Controls.Add(this.panelX2);
            this.panel7.Controls.Add(this.panelX1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 63);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(259, 176);
            this.panel7.TabIndex = 16;
            this.panel7.Visible = false;
            // 
            // panelX5
            // 
            this.panelX5.AutoSize = true;
            this.panelX5.Controls.Add(this.panelFx5);
            this.panelX5.Controls.Add(this.label1);
            this.panelX5.Controls.Add(this.textBoxX5);
            this.panelX5.Location = new System.Drawing.Point(0, 140);
            this.panelX5.Name = "panelX5";
            this.panelX5.Size = new System.Drawing.Size(263, 36);
            this.panelX5.TabIndex = 12;
            this.panelX5.Visible = false;
            // 
            // panelFx5
            // 
            this.panelFx5.Controls.Add(this.label11);
            this.panelFx5.Controls.Add(this.textBoxfX5);
            this.panelFx5.Location = new System.Drawing.Point(175, 2);
            this.panelFx5.Margin = new System.Windows.Forms.Padding(2);
            this.panelFx5.Name = "panelFx5";
            this.panelFx5.Size = new System.Drawing.Size(81, 28);
            this.panelFx5.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(0, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 18);
            this.label11.TabIndex = 13;
            this.label11.Text = "f(x₅) =";
            // 
            // textBoxfX5
            // 
            this.textBoxfX5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxfX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxfX5.Location = new System.Drawing.Point(51, 4);
            this.textBoxfX5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textBoxfX5.Name = "textBoxfX5";
            this.textBoxfX5.ReadOnly = true;
            this.textBoxfX5.Size = new System.Drawing.Size(27, 23);
            this.textBoxfX5.TabIndex = 12;
            this.textBoxfX5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "x₅ =";
            // 
            // textBoxX5
            // 
            this.textBoxX5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxX5.Location = new System.Drawing.Point(47, 7);
            this.textBoxX5.Name = "textBoxX5";
            this.textBoxX5.ReadOnly = true;
            this.textBoxX5.Size = new System.Drawing.Size(123, 23);
            this.textBoxX5.TabIndex = 8;
            this.textBoxX5.TabStop = false;
            // 
            // panelX4
            // 
            this.panelX4.AutoSize = true;
            this.panelX4.Controls.Add(this.panelFx4);
            this.panelX4.Controls.Add(this.label8);
            this.panelX4.Controls.Add(this.textBoxX4);
            this.panelX4.Location = new System.Drawing.Point(0, 105);
            this.panelX4.Name = "panelX4";
            this.panelX4.Size = new System.Drawing.Size(262, 42);
            this.panelX4.TabIndex = 11;
            this.panelX4.Visible = false;
            // 
            // panelFx4
            // 
            this.panelFx4.Controls.Add(this.label9);
            this.panelFx4.Controls.Add(this.textBoxfX4);
            this.panelFx4.Location = new System.Drawing.Point(175, 2);
            this.panelFx4.Margin = new System.Windows.Forms.Padding(2);
            this.panelFx4.Name = "panelFx4";
            this.panelFx4.Size = new System.Drawing.Size(81, 28);
            this.panelFx4.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(0, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "f(x₄) =";
            // 
            // textBoxfX4
            // 
            this.textBoxfX4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxfX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxfX4.Location = new System.Drawing.Point(51, 4);
            this.textBoxfX4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textBoxfX4.Name = "textBoxfX4";
            this.textBoxfX4.ReadOnly = true;
            this.textBoxfX4.Size = new System.Drawing.Size(27, 23);
            this.textBoxfX4.TabIndex = 12;
            this.textBoxfX4.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(10, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "x₄ =";
            // 
            // textBoxX4
            // 
            this.textBoxX4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxX4.Location = new System.Drawing.Point(47, 7);
            this.textBoxX4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textBoxX4.Name = "textBoxX4";
            this.textBoxX4.ReadOnly = true;
            this.textBoxX4.Size = new System.Drawing.Size(123, 23);
            this.textBoxX4.TabIndex = 8;
            this.textBoxX4.TabStop = false;
            // 
            // panelX3
            // 
            this.panelX3.AutoSize = true;
            this.panelX3.Controls.Add(this.panelFx3);
            this.panelX3.Controls.Add(this.label7);
            this.panelX3.Controls.Add(this.textBoxX3);
            this.panelX3.Location = new System.Drawing.Point(0, 70);
            this.panelX3.Name = "panelX3";
            this.panelX3.Size = new System.Drawing.Size(263, 42);
            this.panelX3.TabIndex = 10;
            this.panelX3.Visible = false;
            // 
            // panelFx3
            // 
            this.panelFx3.Controls.Add(this.label4);
            this.panelFx3.Controls.Add(this.textBoxfX3);
            this.panelFx3.Location = new System.Drawing.Point(175, 2);
            this.panelFx3.Margin = new System.Windows.Forms.Padding(2);
            this.panelFx3.Name = "panelFx3";
            this.panelFx3.Size = new System.Drawing.Size(81, 28);
            this.panelFx3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "f(x₃) =";
            // 
            // textBoxfX3
            // 
            this.textBoxfX3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxfX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxfX3.Location = new System.Drawing.Point(51, 4);
            this.textBoxfX3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textBoxfX3.Name = "textBoxfX3";
            this.textBoxfX3.ReadOnly = true;
            this.textBoxfX3.Size = new System.Drawing.Size(27, 23);
            this.textBoxfX3.TabIndex = 10;
            this.textBoxfX3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(10, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "x₃ =";
            // 
            // textBoxX3
            // 
            this.textBoxX3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxX3.Location = new System.Drawing.Point(47, 7);
            this.textBoxX3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.ReadOnly = true;
            this.textBoxX3.Size = new System.Drawing.Size(123, 23);
            this.textBoxX3.TabIndex = 6;
            this.textBoxX3.TabStop = false;
            // 
            // panelX2
            // 
            this.panelX2.AutoSize = true;
            this.panelX2.Controls.Add(this.panelFx2);
            this.panelX2.Controls.Add(this.label6);
            this.panelX2.Controls.Add(this.textBoxX2);
            this.panelX2.Location = new System.Drawing.Point(0, 35);
            this.panelX2.Name = "panelX2";
            this.panelX2.Size = new System.Drawing.Size(261, 42);
            this.panelX2.TabIndex = 9;
            this.panelX2.Visible = false;
            // 
            // panelFx2
            // 
            this.panelFx2.Controls.Add(this.label3);
            this.panelFx2.Controls.Add(this.textBoxfX2);
            this.panelFx2.Location = new System.Drawing.Point(175, 2);
            this.panelFx2.Margin = new System.Windows.Forms.Padding(2);
            this.panelFx2.Name = "panelFx2";
            this.panelFx2.Size = new System.Drawing.Size(81, 28);
            this.panelFx2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "f(x₂) =";
            // 
            // textBoxfX2
            // 
            this.textBoxfX2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxfX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxfX2.Location = new System.Drawing.Point(51, 4);
            this.textBoxfX2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textBoxfX2.Name = "textBoxfX2";
            this.textBoxfX2.ReadOnly = true;
            this.textBoxfX2.Size = new System.Drawing.Size(27, 23);
            this.textBoxfX2.TabIndex = 8;
            this.textBoxfX2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(10, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "x₂ =";
            // 
            // textBoxX2
            // 
            this.textBoxX2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxX2.Location = new System.Drawing.Point(47, 7);
            this.textBoxX2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.ReadOnly = true;
            this.textBoxX2.Size = new System.Drawing.Size(123, 23);
            this.textBoxX2.TabIndex = 4;
            this.textBoxX2.TabStop = false;
            // 
            // panelX1
            // 
            this.panelX1.AutoSize = true;
            this.panelX1.Controls.Add(this.panelFx1);
            this.panelX1.Controls.Add(this.label5);
            this.panelX1.Controls.Add(this.textBoxX1);
            this.panelX1.Location = new System.Drawing.Point(0, 0);
            this.panelX1.Name = "panelX1";
            this.panelX1.Size = new System.Drawing.Size(260, 43);
            this.panelX1.TabIndex = 8;
            this.panelX1.Visible = false;
            // 
            // panelFx1
            // 
            this.panelFx1.Controls.Add(this.label2);
            this.panelFx1.Controls.Add(this.textBoxfX1);
            this.panelFx1.Location = new System.Drawing.Point(175, 2);
            this.panelFx1.Margin = new System.Windows.Forms.Padding(2);
            this.panelFx1.Name = "panelFx1";
            this.panelFx1.Size = new System.Drawing.Size(81, 28);
            this.panelFx1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "f(x₁) =";
            // 
            // textBoxfX1
            // 
            this.textBoxfX1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxfX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxfX1.Location = new System.Drawing.Point(52, 4);
            this.textBoxfX1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textBoxfX1.Name = "textBoxfX1";
            this.textBoxfX1.ReadOnly = true;
            this.textBoxfX1.Size = new System.Drawing.Size(27, 23);
            this.textBoxfX1.TabIndex = 6;
            this.textBoxfX1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "x₁ =";
            // 
            // textBoxX1
            // 
            this.textBoxX1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxX1.Location = new System.Drawing.Point(47, 7);
            this.textBoxX1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.ReadOnly = true;
            this.textBoxX1.Size = new System.Drawing.Size(123, 23);
            this.textBoxX1.TabIndex = 2;
            this.textBoxX1.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.AutoSize = true;
            this.panel9.Controls.Add(this.btnSolveNum);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 31);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(259, 32);
            this.panel9.TabIndex = 2;
            // 
            // btnSolveNum
            // 
            this.btnSolveNum.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSolveNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSolveNum.Location = new System.Drawing.Point(29, 4);
            this.btnSolveNum.Name = "btnSolveNum";
            this.btnSolveNum.Size = new System.Drawing.Size(207, 25);
            this.btnSolveNum.TabIndex = 23;
            this.btnSolveNum.Text = "Решить числено";
            this.btnSolveNum.UseVisualStyleBackColor = false;
            this.btnSolveNum.Visible = false;
            this.btnSolveNum.Click += new System.EventHandler(this.btnSolveNum_Click);
            // 
            // panel10
            // 
            this.panel10.AutoSize = true;
            this.panel10.Controls.Add(this.btnCheckResult);
            this.panel10.Controls.Add(this.btnFindRoots);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(259, 31);
            this.panel10.TabIndex = 1;
            // 
            // btnCheckResult
            // 
            this.btnCheckResult.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCheckResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheckResult.Location = new System.Drawing.Point(136, 3);
            this.btnCheckResult.Name = "btnCheckResult";
            this.btnCheckResult.Size = new System.Drawing.Size(100, 25);
            this.btnCheckResult.TabIndex = 2;
            this.btnCheckResult.Text = "Проверить";
            this.btnCheckResult.UseVisualStyleBackColor = false;
            this.btnCheckResult.Click += new System.EventHandler(this.btnCheckResult_Click);
            // 
            // btnFindRoots
            // 
            this.btnFindRoots.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnFindRoots.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFindRoots.Location = new System.Drawing.Point(29, 3);
            this.btnFindRoots.Name = "btnFindRoots";
            this.btnFindRoots.Size = new System.Drawing.Size(100, 25);
            this.btnFindRoots.TabIndex = 1;
            this.btnFindRoots.Text = "Найти корни";
            this.btnFindRoots.UseVisualStyleBackColor = false;
            this.btnFindRoots.Click += new System.EventHandler(this.btnFindRoots_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.groupBoxFx);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.degreeBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 202);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBoxFx
            // 
            this.groupBoxFx.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxFx.Controls.Add(this.label12);
            this.groupBoxFx.Controls.Add(this.labelFx);
            this.groupBoxFx.Controls.Add(this.panel6);
            this.groupBoxFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxFx.Location = new System.Drawing.Point(29, 99);
            this.groupBoxFx.Name = "groupBoxFx";
            this.groupBoxFx.Size = new System.Drawing.Size(524, 66);
            this.groupBoxFx.TabIndex = 1;
            this.groupBoxFx.TabStop = false;
            this.groupBoxFx.Text = "Решим уравнение вида:";
            this.groupBoxFx.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Help;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(509, 10);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "?";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label12.MouseHover += new System.EventHandler(this.label12_MouseHover);
            // 
            // labelFx
            // 
            this.labelFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFx.Location = new System.Drawing.Point(6, 34);
            this.labelFx.Name = "labelFx";
            this.labelFx.Size = new System.Drawing.Size(40, 17);
            this.labelFx.TabIndex = 30;
            this.labelFx.Text = "f(x) =";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.labelEqual0);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Location = new System.Drawing.Point(52, 32);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(469, 26);
            this.panel6.TabIndex = 1;
            // 
            // labelEqual0
            // 
            this.labelEqual0.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelEqual0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEqual0.Location = new System.Drawing.Point(439, 0);
            this.labelEqual0.Name = "labelEqual0";
            this.labelEqual0.Size = new System.Drawing.Size(28, 26);
            this.labelEqual0.TabIndex = 26;
            this.labelEqual0.Text = "= 0";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.textBox_a0);
            this.panel1.Controls.Add(this.labelCoeff1);
            this.panel1.Controls.Add(this.textBox_a1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(320, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 26);
            this.panel1.TabIndex = 5;
            // 
            // textBox_a0
            // 
            this.textBox_a0.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_a0.ForeColor = System.Drawing.Color.Gray;
            this.textBox_a0.Location = new System.Drawing.Point(76, 0);
            this.textBox_a0.MaxLength = 5;
            this.textBox_a0.Name = "textBox_a0";
            this.textBox_a0.Size = new System.Drawing.Size(40, 23);
            this.textBox_a0.TabIndex = 2;
            this.textBox_a0.Text = "a₀";
            this.textBox_a0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_a0.Visible = false;
            this.textBox_a0.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox_a0.VisibleChanged += new System.EventHandler(this.textBox_VisibleChanged);
            this.textBox_a0.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBox_a0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.textBox_a0.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // labelCoeff1
            // 
            this.labelCoeff1.AutoSize = true;
            this.labelCoeff1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoeff1.Location = new System.Drawing.Point(46, 0);
            this.labelCoeff1.Name = "labelCoeff1";
            this.labelCoeff1.Size = new System.Drawing.Size(30, 17);
            this.labelCoeff1.TabIndex = 16;
            this.labelCoeff1.Text = "x  +";
            this.labelCoeff1.Visible = false;
            // 
            // textBox_a1
            // 
            this.textBox_a1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_a1.ForeColor = System.Drawing.Color.Gray;
            this.textBox_a1.Location = new System.Drawing.Point(0, 0);
            this.textBox_a1.MaxLength = 5;
            this.textBox_a1.Name = "textBox_a1";
            this.textBox_a1.Size = new System.Drawing.Size(40, 23);
            this.textBox_a1.TabIndex = 1;
            this.textBox_a1.Text = "a₁";
            this.textBox_a1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_a1.Visible = false;
            this.textBox_a1.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox_a1.VisibleChanged += new System.EventHandler(this.textBox_VisibleChanged);
            this.textBox_a1.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBox_a1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.textBox_a1.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.labelCoeff2);
            this.panel2.Controls.Add(this.textBox_a2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(240, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 26);
            this.panel2.TabIndex = 4;
            // 
            // labelCoeff2
            // 
            this.labelCoeff2.AutoSize = true;
            this.labelCoeff2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoeff2.Location = new System.Drawing.Point(42, 1);
            this.labelCoeff2.Name = "labelCoeff2";
            this.labelCoeff2.Size = new System.Drawing.Size(35, 17);
            this.labelCoeff2.TabIndex = 12;
            this.labelCoeff2.Text = "x²  +";
            this.labelCoeff2.Visible = false;
            // 
            // textBox_a2
            // 
            this.textBox_a2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_a2.ForeColor = System.Drawing.Color.Gray;
            this.textBox_a2.Location = new System.Drawing.Point(0, -1);
            this.textBox_a2.MaxLength = 5;
            this.textBox_a2.Name = "textBox_a2";
            this.textBox_a2.Size = new System.Drawing.Size(40, 23);
            this.textBox_a2.TabIndex = 1;
            this.textBox_a2.Text = "a₂";
            this.textBox_a2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_a2.Visible = false;
            this.textBox_a2.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox_a2.VisibleChanged += new System.EventHandler(this.textBox_VisibleChanged);
            this.textBox_a2.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBox_a2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.textBox_a2.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.textBox_a3);
            this.panel3.Controls.Add(this.labelCoeff3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(159, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(81, 26);
            this.panel3.TabIndex = 3;
            // 
            // textBox_a3
            // 
            this.textBox_a3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_a3.ForeColor = System.Drawing.Color.Gray;
            this.textBox_a3.Location = new System.Drawing.Point(0, 0);
            this.textBox_a3.MaxLength = 5;
            this.textBox_a3.Name = "textBox_a3";
            this.textBox_a3.Size = new System.Drawing.Size(40, 23);
            this.textBox_a3.TabIndex = 1;
            this.textBox_a3.Text = "a₃";
            this.textBox_a3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_a3.Visible = false;
            this.textBox_a3.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox_a3.VisibleChanged += new System.EventHandler(this.textBox_VisibleChanged);
            this.textBox_a3.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBox_a3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.textBox_a3.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // labelCoeff3
            // 
            this.labelCoeff3.AutoSize = true;
            this.labelCoeff3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoeff3.Location = new System.Drawing.Point(43, 0);
            this.labelCoeff3.Name = "labelCoeff3";
            this.labelCoeff3.Size = new System.Drawing.Size(35, 17);
            this.labelCoeff3.TabIndex = 9;
            this.labelCoeff3.Text = "x³  +";
            this.labelCoeff3.Visible = false;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.textBox_a4);
            this.panel4.Controls.Add(this.labelCoeff4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(80, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(79, 26);
            this.panel4.TabIndex = 2;
            // 
            // textBox_a4
            // 
            this.textBox_a4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_a4.ForeColor = System.Drawing.Color.Gray;
            this.textBox_a4.Location = new System.Drawing.Point(0, 0);
            this.textBox_a4.MaxLength = 5;
            this.textBox_a4.Name = "textBox_a4";
            this.textBox_a4.Size = new System.Drawing.Size(40, 23);
            this.textBox_a4.TabIndex = 1;
            this.textBox_a4.Text = "a₄";
            this.textBox_a4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_a4.Visible = false;
            this.textBox_a4.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox_a4.VisibleChanged += new System.EventHandler(this.textBox_VisibleChanged);
            this.textBox_a4.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBox_a4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.textBox_a4.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // labelCoeff4
            // 
            this.labelCoeff4.AutoSize = true;
            this.labelCoeff4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoeff4.Location = new System.Drawing.Point(41, 0);
            this.labelCoeff4.Name = "labelCoeff4";
            this.labelCoeff4.Size = new System.Drawing.Size(35, 17);
            this.labelCoeff4.TabIndex = 8;
            this.labelCoeff4.Text = "x⁴  +";
            this.labelCoeff4.Visible = false;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.textBox_a5);
            this.panel5.Controls.Add(this.labelCoeff5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(80, 26);
            this.panel5.TabIndex = 1;
            // 
            // textBox_a5
            // 
            this.textBox_a5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_a5.ForeColor = System.Drawing.Color.Gray;
            this.textBox_a5.Location = new System.Drawing.Point(0, 0);
            this.textBox_a5.MaxLength = 5;
            this.textBox_a5.Name = "textBox_a5";
            this.textBox_a5.Size = new System.Drawing.Size(40, 23);
            this.textBox_a5.TabIndex = 1;
            this.textBox_a5.Text = "a₅";
            this.textBox_a5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_a5.Visible = false;
            this.textBox_a5.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox_a5.VisibleChanged += new System.EventHandler(this.textBox_VisibleChanged);
            this.textBox_a5.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBox_a5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.textBox_a5.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // labelCoeff5
            // 
            this.labelCoeff5.AutoSize = true;
            this.labelCoeff5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoeff5.Location = new System.Drawing.Point(42, 1);
            this.labelCoeff5.Name = "labelCoeff5";
            this.labelCoeff5.Size = new System.Drawing.Size(35, 17);
            this.labelCoeff5.TabIndex = 7;
            this.labelCoeff5.Text = "x⁵  +";
            this.labelCoeff5.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox3.Controls.Add(this.labelTrackBar);
            this.groupBox3.Controls.Add(this.trackBar);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(334, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 74);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Знаков после запятой";
            // 
            // labelTrackBar
            // 
            this.labelTrackBar.AutoSize = true;
            this.labelTrackBar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.labelTrackBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTrackBar.Location = new System.Drawing.Point(153, 33);
            this.labelTrackBar.Name = "labelTrackBar";
            this.labelTrackBar.Size = new System.Drawing.Size(18, 20);
            this.labelTrackBar.TabIndex = 32;
            this.labelTrackBar.Text = "4";
            // 
            // trackBar
            // 
            this.trackBar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.trackBar.LargeChange = 1;
            this.trackBar.Location = new System.Drawing.Point(11, 20);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(140, 45);
            this.trackBar.TabIndex = 0;
            this.trackBar.TabStop = false;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar.Value = 4;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfirm.Location = new System.Drawing.Point(223, 167);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConfirm.Size = new System.Drawing.Size(118, 25);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Подтвердить";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(223, 167);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 25);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(26, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Порядок уравнения";
            // 
            // degreeBox
            // 
            this.degreeBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.degreeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.degreeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.degreeBox.FormattingEnabled = true;
            this.degreeBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.degreeBox.Location = new System.Drawing.Point(171, 49);
            this.degreeBox.Name = "degreeBox";
            this.degreeBox.Size = new System.Drawing.Size(40, 24);
            this.degreeBox.TabIndex = 0;
            this.degreeBox.SelectedIndexChanged += new System.EventHandler(this.degreeBox_SelectedIndexChanged);
            // 
            // labelCoeff0
            // 
            this.labelCoeff0.AutoSize = true;
            this.labelCoeff0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoeff0.Location = new System.Drawing.Point(588, 12);
            this.labelCoeff0.Name = "labelCoeff0";
            this.labelCoeff0.Size = new System.Drawing.Size(0, 17);
            this.labelCoeff0.TabIndex = 17;
            this.labelCoeff0.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(593, 541);
            this.Controls.Add(this.labelCoeff0);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(609, 580);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Решение алгебраических уравнений";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panelX5.ResumeLayout(false);
            this.panelX5.PerformLayout();
            this.panelFx5.ResumeLayout(false);
            this.panelFx5.PerformLayout();
            this.panelX4.ResumeLayout(false);
            this.panelX4.PerformLayout();
            this.panelFx4.ResumeLayout(false);
            this.panelFx4.PerformLayout();
            this.panelX3.ResumeLayout(false);
            this.panelX3.PerformLayout();
            this.panelFx3.ResumeLayout(false);
            this.panelFx3.PerformLayout();
            this.panelX2.ResumeLayout(false);
            this.panelX2.PerformLayout();
            this.panelFx2.ResumeLayout(false);
            this.panelFx2.PerformLayout();
            this.panelX1.ResumeLayout(false);
            this.panelX1.PerformLayout();
            this.panelFx1.ResumeLayout(false);
            this.panelFx1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxFx.ResumeLayout(false);
            this.groupBoxFx.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox degreeBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label labelCoeff0;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelTrackBar;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.GroupBox groupBoxFx;
        private System.Windows.Forms.Label labelFx;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labelEqual0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_a0;
        private System.Windows.Forms.Label labelCoeff1;
        private System.Windows.Forms.TextBox textBox_a1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelCoeff2;
        private System.Windows.Forms.TextBox textBox_a2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_a3;
        private System.Windows.Forms.Label labelCoeff3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox_a4;
        private System.Windows.Forms.Label labelCoeff4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox_a5;
        private System.Windows.Forms.Label labelCoeff5;
        private System.Windows.Forms.Button btnBuildGraph;
        private System.Windows.Forms.Button btnScale;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBoxYMax;
        private System.Windows.Forms.TextBox textBoxYMin;
        private System.Windows.Forms.TextBox textBoxXMax;
        private System.Windows.Forms.TextBox textBoxXMin;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnSolveNum;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panelX5;
        private System.Windows.Forms.Panel panelFx5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxfX5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxX5;
        private System.Windows.Forms.Panel panelX4;
        private System.Windows.Forms.Panel panelFx4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxfX4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxX4;
        private System.Windows.Forms.Panel panelX3;
        private System.Windows.Forms.Panel panelFx3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxfX3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxX3;
        private System.Windows.Forms.Panel panelX2;
        private System.Windows.Forms.Panel panelFx2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxfX2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.Panel panelX1;
        private System.Windows.Forms.Panel panelFx1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxfX1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnCheckResult;
        private System.Windows.Forms.Button btnFindRoots;
    }
}

