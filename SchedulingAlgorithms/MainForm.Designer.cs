namespace SchedulingAlgorithms
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.nudArrival = new System.Windows.Forms.NumericUpDown();
            this.ProcessListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Options = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudFBQ = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudRRQ = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArrival)).BeginInit();
            this.Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFBQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRRQ)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(762, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 48);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(738, 434);
            this.chart.TabIndex = 25;
            this.chart.Text = "chart";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLabel);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Controls.Add(this.nudDuration);
            this.groupBox1.Controls.Add(this.nudArrival);
            this.groupBox1.Controls.Add(this.ProcessListView);
            this.groupBox1.Location = new System.Drawing.Point(12, 577);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 264);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process Editor";
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRemove.Location = new System.Drawing.Point(638, 46);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 23);
            this.btnRemove.TabIndex = 22;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Location = new System.Drawing.Point(532, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Duration Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Arrival Time:";
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(6, 47);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(100, 22);
            this.txtLabel.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(3, 27);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(97, 17);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "Process label:";
            // 
            // nudDuration
            // 
            this.nudDuration.Location = new System.Drawing.Point(274, 47);
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(100, 22);
            this.nudDuration.TabIndex = 3;
            // 
            // nudArrival
            // 
            this.nudArrival.Location = new System.Drawing.Point(140, 47);
            this.nudArrival.Name = "nudArrival";
            this.nudArrival.Size = new System.Drawing.Size(100, 22);
            this.nudArrival.TabIndex = 2;
            // 
            // ProcessListView
            // 
            this.ProcessListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ProcessListView.FullRowSelect = true;
            this.ProcessListView.GridLines = true;
            this.ProcessListView.HideSelection = false;
            this.ProcessListView.Location = new System.Drawing.Point(6, 75);
            this.ProcessListView.Name = "ProcessListView";
            this.ProcessListView.Size = new System.Drawing.Size(726, 183);
            this.ProcessListView.TabIndex = 15;
            this.ProcessListView.UseCompatibleStateImageBehavior = false;
            this.ProcessListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Label";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Arrival Time";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Duration Time";
            this.columnHeader3.Width = 100;
            // 
            // Options
            // 
            this.Options.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Options.Controls.Add(this.label6);
            this.Options.Controls.Add(this.nudFBQ);
            this.Options.Controls.Add(this.label5);
            this.Options.Controls.Add(this.nudRRQ);
            this.Options.Location = new System.Drawing.Point(12, 488);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(738, 83);
            this.Options.TabIndex = 3;
            this.Options.TabStop = false;
            this.Options.Text = "Options";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "FB Quantum:";
            // 
            // nudFBQ
            // 
            this.nudFBQ.Location = new System.Drawing.Point(140, 50);
            this.nudFBQ.Name = "nudFBQ";
            this.nudFBQ.Size = new System.Drawing.Size(100, 22);
            this.nudFBQ.TabIndex = 27;
            this.nudFBQ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFBQ.ValueChanged += new System.EventHandler(this.nudFBQ_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "RR Quantum:";
            // 
            // nudRRQ
            // 
            this.nudRRQ.Location = new System.Drawing.Point(6, 50);
            this.nudRRQ.Name = "nudRRQ";
            this.nudRRQ.Size = new System.Drawing.Size(100, 22);
            this.nudRRQ.TabIndex = 26;
            this.nudRRQ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRRQ.ValueChanged += new System.EventHandler(this.nudRRQ_ValueChanged);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 853);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(780, 900);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU Scheduling Algorithms [Sajad Afaghiy]";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArrival)).EndInit();
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFBQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRRQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView ProcessListView;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.NumericUpDown nudArrival;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox Options;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudFBQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudRRQ;
    }
}

