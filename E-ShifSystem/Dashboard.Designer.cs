namespace E_ShifSystem
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.orderStatusChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chartTotalRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTransUni = new System.Windows.Forms.Button();
            this.lblAvailableTransUnit = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnJobOnService = new System.Windows.Forms.Button();
            this.lblJobOnService = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPendingJobs = new System.Windows.Forms.Button();
            this.lblPendingJob = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderStatusChart)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalRevenue)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::E_ShifSystem.Properties.Resources.Asset_7widget;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.orderStatusChart);
            this.panel5.Location = new System.Drawing.Point(775, 224);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(415, 470);
            this.panel5.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Squada One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(135, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "(Today)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Squada One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 26);
            this.label8.TabIndex = 4;
            this.label8.Text = "Order Status";
            // 
            // orderStatusChart
            // 
            this.orderStatusChart.BackColor = System.Drawing.Color.Transparent;
            chartArea11.BackColor = System.Drawing.Color.Transparent;
            chartArea11.Name = "ChartArea1";
            this.orderStatusChart.ChartAreas.Add(chartArea11);
            legend11.BackColor = System.Drawing.Color.Transparent;
            legend11.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend11.Font = new System.Drawing.Font("Squada One", 8F);
            legend11.ForeColor = System.Drawing.Color.White;
            legend11.HeaderSeparatorColor = System.Drawing.Color.Transparent;
            legend11.InterlacedRows = true;
            legend11.IsTextAutoFit = false;
            legend11.ItemColumnSpacing = 10;
            legend11.Name = "Legend1";
            legend11.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
            this.orderStatusChart.Legends.Add(legend11);
            this.orderStatusChart.Location = new System.Drawing.Point(25, 49);
            this.orderStatusChart.Margin = new System.Windows.Forms.Padding(2);
            this.orderStatusChart.Name = "orderStatusChart";
            this.orderStatusChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(27)))), ((int)(((byte)(86))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(70)))), ((int)(((byte)(129)))))};
            this.orderStatusChart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series11.BackSecondaryColor = System.Drawing.Color.Transparent;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series11.Legend = "Legend1";
            series11.Name = "Orders";
            this.orderStatusChart.Series.Add(series11);
            this.orderStatusChart.Size = new System.Drawing.Size(369, 406);
            this.orderStatusChart.TabIndex = 0;
            this.orderStatusChart.Text = "orderStatusChart";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::E_ShifSystem.Properties.Resources.ChartWidgetBG;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.chartTotalRevenue);
            this.panel4.Location = new System.Drawing.Point(26, 338);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(726, 357);
            this.panel4.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Squada One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(167, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "(Montly)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Squada One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(39, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 26);
            this.label7.TabIndex = 4;
            this.label7.Text = "Total Revenue";
            // 
            // chartTotalRevenue
            // 
            this.chartTotalRevenue.AllowDrop = true;
            this.chartTotalRevenue.BackColor = System.Drawing.Color.Transparent;
            chartArea12.AxisX.IsLabelAutoFit = false;
            chartArea12.AxisX.IsMarginVisible = false;
            chartArea12.AxisX.LabelStyle.Font = new System.Drawing.Font("Squada One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea12.AxisX.LabelStyle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea12.AxisX.LineColor = System.Drawing.Color.White;
            chartArea12.AxisX.LineWidth = 0;
            chartArea12.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea12.AxisX.MajorGrid.LineWidth = 0;
            chartArea12.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea12.AxisY.IsLabelAutoFit = false;
            chartArea12.AxisY.LabelStyle.Font = new System.Drawing.Font("Squada One", 9F);
            chartArea12.AxisY.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea12.AxisY.LabelStyle.Format = "Rs.{0}";
            chartArea12.AxisY.LineColor = System.Drawing.Color.White;
            chartArea12.AxisY.LineWidth = 0;
            chartArea12.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea12.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea12.BackColor = System.Drawing.Color.Transparent;
            chartArea12.Name = "ChartArea1";
            this.chartTotalRevenue.ChartAreas.Add(chartArea12);
            legend12.BackColor = System.Drawing.Color.Transparent;
            legend12.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend12.Enabled = false;
            legend12.ForeColor = System.Drawing.Color.White;
            legend12.Name = "Legend1";
            this.chartTotalRevenue.Legends.Add(legend12);
            this.chartTotalRevenue.Location = new System.Drawing.Point(0, 58);
            this.chartTotalRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.chartTotalRevenue.Name = "chartTotalRevenue";
            series12.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series12.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(54)))));
            series12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(54)))));
            series12.BorderWidth = 5;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series12.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(31)))));
            series12.Legend = "Legend1";
            series12.MarkerBorderColor = System.Drawing.Color.Transparent;
            series12.MarkerSize = 10;
            series12.Name = "Revenue";
            series12.YValuesPerPoint = 2;
            this.chartTotalRevenue.Series.Add(series12);
            this.chartTotalRevenue.Size = new System.Drawing.Size(701, 297);
            this.chartTotalRevenue.TabIndex = 0;
            this.chartTotalRevenue.Text = "chart1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::E_ShifSystem.Properties.Resources.Asset_10widgetTransportUni;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.btnTransUni);
            this.panel3.Controls.Add(this.lblAvailableTransUnit);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(841, 35);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 187);
            this.panel3.TabIndex = 5;
            // 
            // btnTransUni
            // 
            this.btnTransUni.Font = new System.Drawing.Font("Squada One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransUni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(143)))));
            this.btnTransUni.Location = new System.Drawing.Point(244, 128);
            this.btnTransUni.Margin = new System.Windows.Forms.Padding(2);
            this.btnTransUni.Name = "btnTransUni";
            this.btnTransUni.Size = new System.Drawing.Size(74, 28);
            this.btnTransUni.TabIndex = 7;
            this.btnTransUni.Text = "View More";
            this.btnTransUni.UseVisualStyleBackColor = true;
            this.btnTransUni.Click += new System.EventHandler(this.btnTransUni_Click);
            // 
            // lblAvailableTransUnit
            // 
            this.lblAvailableTransUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAvailableTransUnit.AutoSize = true;
            this.lblAvailableTransUnit.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailableTransUnit.Font = new System.Drawing.Font("Squada One", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableTransUnit.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAvailableTransUnit.Location = new System.Drawing.Point(142, 65);
            this.lblAvailableTransUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailableTransUnit.Name = "lblAvailableTransUnit";
            this.lblAvailableTransUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAvailableTransUnit.Size = new System.Drawing.Size(75, 68);
            this.lblAvailableTransUnit.TabIndex = 2;
            this.lblAvailableTransUnit.Text = "10";
            this.lblAvailableTransUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Squada One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(97)))), ((int)(((byte)(166)))));
            this.label6.Location = new System.Drawing.Point(67, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "Available Transport Unit";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::E_ShifSystem.Properties.Resources.Asset_9widgetJobsDone;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnJobOnService);
            this.panel2.Controls.Add(this.lblJobOnService);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(404, 35);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 180);
            this.panel2.TabIndex = 4;
            // 
            // btnJobOnService
            // 
            this.btnJobOnService.Font = new System.Drawing.Font("Squada One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobOnService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(143)))));
            this.btnJobOnService.Location = new System.Drawing.Point(306, 128);
            this.btnJobOnService.Margin = new System.Windows.Forms.Padding(2);
            this.btnJobOnService.Name = "btnJobOnService";
            this.btnJobOnService.Size = new System.Drawing.Size(74, 28);
            this.btnJobOnService.TabIndex = 6;
            this.btnJobOnService.Text = "View More";
            this.btnJobOnService.UseVisualStyleBackColor = true;
            this.btnJobOnService.Click += new System.EventHandler(this.btnJobOnService_Click);
            // 
            // lblJobOnService
            // 
            this.lblJobOnService.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJobOnService.AutoSize = true;
            this.lblJobOnService.BackColor = System.Drawing.Color.Transparent;
            this.lblJobOnService.Font = new System.Drawing.Font("Squada One", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobOnService.ForeColor = System.Drawing.SystemColors.Control;
            this.lblJobOnService.Location = new System.Drawing.Point(169, 65);
            this.lblJobOnService.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJobOnService.Name = "lblJobOnService";
            this.lblJobOnService.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblJobOnService.Size = new System.Drawing.Size(75, 68);
            this.lblJobOnService.TabIndex = 2;
            this.lblJobOnService.Text = "10";
            this.lblJobOnService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Squada One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(97)))), ((int)(((byte)(166)))));
            this.label4.Location = new System.Drawing.Point(127, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Jobs on Service";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::E_ShifSystem.Properties.Resources.LoadWidget;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnPendingJobs);
            this.panel1.Controls.Add(this.lblPendingJob);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 180);
            this.panel1.TabIndex = 0;
            // 
            // btnPendingJobs
            // 
            this.btnPendingJobs.Font = new System.Drawing.Font("Squada One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendingJobs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(143)))));
            this.btnPendingJobs.Location = new System.Drawing.Point(236, 128);
            this.btnPendingJobs.Margin = new System.Windows.Forms.Padding(2);
            this.btnPendingJobs.Name = "btnPendingJobs";
            this.btnPendingJobs.Size = new System.Drawing.Size(74, 28);
            this.btnPendingJobs.TabIndex = 5;
            this.btnPendingJobs.Text = "View More";
            this.btnPendingJobs.UseVisualStyleBackColor = true;
            this.btnPendingJobs.Click += new System.EventHandler(this.btnPendingJobs_Click);
            // 
            // lblPendingJob
            // 
            this.lblPendingJob.AutoSize = true;
            this.lblPendingJob.BackColor = System.Drawing.Color.Transparent;
            this.lblPendingJob.Font = new System.Drawing.Font("Squada One", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingJob.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPendingJob.Location = new System.Drawing.Point(140, 65);
            this.lblPendingJob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPendingJob.Name = "lblPendingJob";
            this.lblPendingJob.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPendingJob.Size = new System.Drawing.Size(75, 68);
            this.lblPendingJob.TabIndex = 2;
            this.lblPendingJob.Text = "10";
            this.lblPendingJob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Squada One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(97)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(87, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "No of Pending Jobs";
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::E_ShifSystem.Properties.Resources.ChartWidgetBG;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(26, 223);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(255, 97);
            this.panel6.TabIndex = 8;
            this.panel6.Click += new System.EventHandler(this.panel6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Squada One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(59, 24);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 52);
            this.label9.TabIndex = 6;
            this.label9.Text = "Create New Job\r\n(New Customer)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::E_ShifSystem.Properties.Resources.ChartWidgetBG;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Controls.Add(this.label11);
            this.panel8.Location = new System.Drawing.Point(296, 275);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(292, 46);
            this.panel8.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Squada One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(7, 10);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(281, 26);
            this.label11.TabIndex = 6;
            this.label11.Text = "Check Available Transport Unit";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = global::E_ShifSystem.Properties.Resources.ChartWidgetBG;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Controls.Add(this.label12);
            this.panel9.Location = new System.Drawing.Point(296, 223);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(292, 46);
            this.panel9.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Squada One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(79, 11);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 26);
            this.label12.TabIndex = 6;
            this.label12.Text = "Make Payment";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = global::E_ShifSystem.Properties.Resources.ChartWidgetBG;
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel10.Controls.Add(this.label13);
            this.panel10.Location = new System.Drawing.Point(600, 224);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(158, 97);
            this.panel10.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Squada One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(24, 23);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 52);
            this.label13.TabIndex = 6;
            this.label13.Text = "Update \r\nJob Status\r\n";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1227, 718);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Opacity = 0.5D;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderStatusChart)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalRevenue)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPendingJob;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblJobOnService;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAvailableTransUnit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalRevenue;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart orderStatusChart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnJobOnService;
        private System.Windows.Forms.Button btnPendingJobs;
        private System.Windows.Forms.Button btnTransUni;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}