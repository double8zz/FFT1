namespace test1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            SeeSharpTools.JY.GUI.EasyChartXSeries easyChartXSeries1 = new SeeSharpTools.JY.GUI.EasyChartXSeries();
            SeeSharpTools.JY.GUI.EasyChartXSeries easyChartXSeries2 = new SeeSharpTools.JY.GUI.EasyChartXSeries();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.textBox_fileName = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.easyChart_readData1 = new SeeSharpTools.JY.GUI.EasyChartX();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(526, 8);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "选择文件";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // textBox_fileName
            // 
            this.textBox_fileName.Location = new System.Drawing.Point(66, 9);
            this.textBox_fileName.Name = "textBox_fileName";
            this.textBox_fileName.Size = new System.Drawing.Size(454, 21);
            this.textBox_fileName.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(15, 13);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(41, 12);
            this.label.TabIndex = 2;
            this.label.Text = "文件名";
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxLog.Location = new System.Drawing.Point(8, 748);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(1026, 110);
            this.richTextBoxLog.TabIndex = 5;
            this.richTextBoxLog.Text = "";
            this.richTextBoxLog.TextChanged += new System.EventHandler(this.richTextBoxLog_TextChanged);
            // 
            // easyChart_readData1
            // 
            this.easyChart_readData1.AxisX.AutoScale = true;
            this.easyChart_readData1.AxisX.AutoZoomReset = false;
            this.easyChart_readData1.AxisX.Color = System.Drawing.Color.Black;
            this.easyChart_readData1.AxisX.InitWithScaleView = false;
            this.easyChart_readData1.AxisX.IsLogarithmic = false;
            this.easyChart_readData1.AxisX.LabelAngle = 0;
            this.easyChart_readData1.AxisX.LabelEnabled = true;
            this.easyChart_readData1.AxisX.LabelFormat = null;
            this.easyChart_readData1.AxisX.MajorGridColor = System.Drawing.Color.Black;
            this.easyChart_readData1.AxisX.MajorGridCount = -1;
            this.easyChart_readData1.AxisX.MajorGridEnabled = true;
            this.easyChart_readData1.AxisX.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChart_readData1.AxisX.Maximum = 1000D;
            this.easyChart_readData1.AxisX.Minimum = 0D;
            this.easyChart_readData1.AxisX.MinorGridColor = System.Drawing.Color.Black;
            this.easyChart_readData1.AxisX.MinorGridEnabled = false;
            this.easyChart_readData1.AxisX.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChart_readData1.AxisX.TickWidth = 1F;
            this.easyChart_readData1.AxisX.Title = "";
            this.easyChart_readData1.AxisX.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChart_readData1.AxisX.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChart_readData1.AxisX.ViewMaximum = 1000D;
            this.easyChart_readData1.AxisX.ViewMinimum = 0D;
            this.easyChart_readData1.AxisX2.AutoScale = true;
            this.easyChart_readData1.AxisX2.AutoZoomReset = false;
            this.easyChart_readData1.AxisX2.Color = System.Drawing.Color.Black;
            this.easyChart_readData1.AxisX2.InitWithScaleView = false;
            this.easyChart_readData1.AxisX2.IsLogarithmic = false;
            this.easyChart_readData1.AxisX2.LabelAngle = 0;
            this.easyChart_readData1.AxisX2.LabelEnabled = true;
            this.easyChart_readData1.AxisX2.LabelFormat = null;
            this.easyChart_readData1.AxisX2.MajorGridColor = System.Drawing.Color.Black;
            this.easyChart_readData1.AxisX2.MajorGridCount = -1;
            this.easyChart_readData1.AxisX2.MajorGridEnabled = true;
            this.easyChart_readData1.AxisX2.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChart_readData1.AxisX2.Maximum = 1000D;
            this.easyChart_readData1.AxisX2.Minimum = 0D;
            this.easyChart_readData1.AxisX2.MinorGridColor = System.Drawing.Color.Black;
            this.easyChart_readData1.AxisX2.MinorGridEnabled = false;
            this.easyChart_readData1.AxisX2.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChart_readData1.AxisX2.TickWidth = 1F;
            this.easyChart_readData1.AxisX2.Title = "";
            this.easyChart_readData1.AxisX2.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChart_readData1.AxisX2.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChart_readData1.AxisX2.ViewMaximum = 1000D;
            this.easyChart_readData1.AxisX2.ViewMinimum = 0D;
            this.easyChart_readData1.AxisY.AutoScale = true;
            this.easyChart_readData1.AxisY.AutoZoomReset = false;
            this.easyChart_readData1.AxisY.Color = System.Drawing.Color.Black;
            this.easyChart_readData1.AxisY.InitWithScaleView = false;
            this.easyChart_readData1.AxisY.IsLogarithmic = false;
            this.easyChart_readData1.AxisY.LabelAngle = 0;
            this.easyChart_readData1.AxisY.LabelEnabled = true;
            this.easyChart_readData1.AxisY.LabelFormat = null;
            this.easyChart_readData1.AxisY.MajorGridColor = System.Drawing.Color.Black;
            this.easyChart_readData1.AxisY.MajorGridCount = 6;
            this.easyChart_readData1.AxisY.MajorGridEnabled = true;
            this.easyChart_readData1.AxisY.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChart_readData1.AxisY.Maximum = 3.5D;
            this.easyChart_readData1.AxisY.Minimum = 0.5D;
            this.easyChart_readData1.AxisY.MinorGridColor = System.Drawing.Color.Black;
            this.easyChart_readData1.AxisY.MinorGridEnabled = false;
            this.easyChart_readData1.AxisY.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChart_readData1.AxisY.TickWidth = 1F;
            this.easyChart_readData1.AxisY.Title = "";
            this.easyChart_readData1.AxisY.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChart_readData1.AxisY.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChart_readData1.AxisY.ViewMaximum = 3.5D;
            this.easyChart_readData1.AxisY.ViewMinimum = 0.5D;
            this.easyChart_readData1.AxisY2.AutoScale = true;
            this.easyChart_readData1.AxisY2.AutoZoomReset = false;
            this.easyChart_readData1.AxisY2.Color = System.Drawing.Color.Black;
            this.easyChart_readData1.AxisY2.InitWithScaleView = false;
            this.easyChart_readData1.AxisY2.IsLogarithmic = false;
            this.easyChart_readData1.AxisY2.LabelAngle = 0;
            this.easyChart_readData1.AxisY2.LabelEnabled = true;
            this.easyChart_readData1.AxisY2.LabelFormat = null;
            this.easyChart_readData1.AxisY2.MajorGridColor = System.Drawing.Color.Black;
            this.easyChart_readData1.AxisY2.MajorGridCount = 6;
            this.easyChart_readData1.AxisY2.MajorGridEnabled = true;
            this.easyChart_readData1.AxisY2.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Dash;
            this.easyChart_readData1.AxisY2.Maximum = 3.5D;
            this.easyChart_readData1.AxisY2.Minimum = 0.5D;
            this.easyChart_readData1.AxisY2.MinorGridColor = System.Drawing.Color.Black;
            this.easyChart_readData1.AxisY2.MinorGridEnabled = false;
            this.easyChart_readData1.AxisY2.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.DashDot;
            this.easyChart_readData1.AxisY2.TickWidth = 1F;
            this.easyChart_readData1.AxisY2.Title = "";
            this.easyChart_readData1.AxisY2.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChart_readData1.AxisY2.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChart_readData1.AxisY2.ViewMaximum = 3.5D;
            this.easyChart_readData1.AxisY2.ViewMinimum = 0.5D;
            this.easyChart_readData1.BackColor = System.Drawing.Color.White;
            this.easyChart_readData1.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.easyChart_readData1.Cumulitive = false;
            this.easyChart_readData1.GradientStyle = SeeSharpTools.JY.GUI.EasyChartX.ChartGradientStyle.None;
            this.easyChart_readData1.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChart_readData1.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.easyChart_readData1.LegendForeColor = System.Drawing.Color.Black;
            this.easyChart_readData1.LegendVisible = false;
            easyChartXSeries1.Color = System.Drawing.Color.Red;
            easyChartXSeries1.Marker = SeeSharpTools.JY.GUI.EasyChartXSeries.MarkerType.None;
            easyChartXSeries1.Name = "Series1";
            easyChartXSeries1.Type = SeeSharpTools.JY.GUI.EasyChartXSeries.LineType.FastLine;
            easyChartXSeries1.Visible = true;
            easyChartXSeries1.Width = SeeSharpTools.JY.GUI.EasyChartXSeries.LineWidth.Thin;
            easyChartXSeries1.XPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries1.YPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries2.Color = System.Drawing.Color.Blue;
            easyChartXSeries2.Marker = SeeSharpTools.JY.GUI.EasyChartXSeries.MarkerType.None;
            easyChartXSeries2.Name = "Series2";
            easyChartXSeries2.Type = SeeSharpTools.JY.GUI.EasyChartXSeries.LineType.FastLine;
            easyChartXSeries2.Visible = false;
            easyChartXSeries2.Width = SeeSharpTools.JY.GUI.EasyChartXSeries.LineWidth.Thin;
            easyChartXSeries2.XPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries2.YPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            this.easyChart_readData1.LineSeries.Add(easyChartXSeries1);
            this.easyChart_readData1.LineSeries.Add(easyChartXSeries2);
            this.easyChart_readData1.Location = new System.Drawing.Point(8, 38);
            this.easyChart_readData1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.easyChart_readData1.Miscellaneous.CheckInfinity = false;
            this.easyChart_readData1.Miscellaneous.CheckNaN = false;
            this.easyChart_readData1.Miscellaneous.CheckNegtiveOrZero = false;
            this.easyChart_readData1.Miscellaneous.DirectionChartCount = 3;
            this.easyChart_readData1.Miscellaneous.Fitting = SeeSharpTools.JY.GUI.EasyChartX.FitType.Range;
            this.easyChart_readData1.Miscellaneous.MarkerSize = 7;
            this.easyChart_readData1.Miscellaneous.MaxSeriesCount = 32;
            this.easyChart_readData1.Miscellaneous.MaxSeriesPointCount = 4000;
            this.easyChart_readData1.Miscellaneous.ShowFunctionMenu = true;
            this.easyChart_readData1.Miscellaneous.SplitLayoutColumnInterval = 0F;
            this.easyChart_readData1.Miscellaneous.SplitLayoutDirection = SeeSharpTools.JY.GUI.EasyChartXUtility.LayoutDirection.LeftToRight;
            this.easyChart_readData1.Miscellaneous.SplitLayoutRowInterval = 0F;
            this.easyChart_readData1.Miscellaneous.SplitViewAutoLayout = true;
            this.easyChart_readData1.Name = "easyChart_readData1";
            this.easyChart_readData1.SeriesCount = 1;
            this.easyChart_readData1.Size = new System.Drawing.Size(652, 310);
            this.easyChart_readData1.SplitView = false;
            this.easyChart_readData1.TabIndex = 78;
            this.easyChart_readData1.XCursor.AutoInterval = true;
            this.easyChart_readData1.XCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.easyChart_readData1.XCursor.Interval = 0.001D;
            this.easyChart_readData1.XCursor.Mode = SeeSharpTools.JY.GUI.EasyChartXCursor.CursorMode.Zoom;
            this.easyChart_readData1.XCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.easyChart_readData1.XCursor.Value = double.NaN;
            this.easyChart_readData1.YCursor.AutoInterval = true;
            this.easyChart_readData1.YCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.easyChart_readData1.YCursor.Interval = 0.001D;
            this.easyChart_readData1.YCursor.Mode = SeeSharpTools.JY.GUI.EasyChartXCursor.CursorMode.Disabled;
            this.easyChart_readData1.YCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.easyChart_readData1.YCursor.Value = double.NaN;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 80;
            this.button1.Text = "计算参数";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(701, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 41);
            this.label2.TabIndex = 81;
            this.label2.Text = "ENOB：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(703, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 41);
            this.label3.TabIndex = 82;
            this.label3.Text = "SINAD：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(705, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 41);
            this.label4.TabIndex = 83;
            this.label4.Text = "SNR：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(705, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 41);
            this.label5.TabIndex = 84;
            this.label5.Text = "THD：";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.08425F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.91575F));
            this.tableLayoutPanel1.Controls.Add(this.formsPlot1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 368);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(652, 364);
            this.tableLayoutPanel1.TabIndex = 85;
            // 
            // formsPlot1
            // 
            this.formsPlot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlot1.Location = new System.Drawing.Point(4, 2);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(644, 360);
            this.formsPlot1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(730, 368);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 43);
            this.button2.TabIndex = 86;
            this.button2.Text = "绘制频谱图";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 864);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.easyChart_readData1);
            this.Controls.Add(this.richTextBoxLog);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBox_fileName);
            this.Controls.Add(this.buttonOpenFile);
            this.Name = "Form1";
            this.Text = "高速数据采集卡ADC性能测评";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.TextBox textBox_fileName;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private SeeSharpTools.JY.GUI.EasyChartX easyChart_readData1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.Button button2;
    }
}

