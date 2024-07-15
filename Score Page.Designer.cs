
namespace COMP1551_SeaAnimal_Game
{
    partial class Score_Page
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.gobackbtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database4DataSet = new COMP1551_SeaAnimal_Game.Database4DataSet();
            this.gameTableAdapter = new COMP1551_SeaAnimal_Game.Database4DataSetTableAdapters.GameTableAdapter();
            this.chartScore_Hard = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gameBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chartLoad = new System.Windows.Forms.Button();
            this.playerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartScore_Hard_Bar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartScore_Hard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartScore_Hard_Bar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score (Hard Level Only)";
            // 
            // gobackbtn
            // 
            this.gobackbtn.Location = new System.Drawing.Point(13, 17);
            this.gobackbtn.Margin = new System.Windows.Forms.Padding(4);
            this.gobackbtn.Name = "gobackbtn";
            this.gobackbtn.Size = new System.Drawing.Size(100, 28);
            this.gobackbtn.TabIndex = 2;
            this.gobackbtn.Text = "&Level Page";
            this.gobackbtn.UseVisualStyleBackColor = true;
            this.gobackbtn.Click += new System.EventHandler(this.gobackbtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerNameDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.gameBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(46, 75);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(426, 213);
            this.dataGridView.TabIndex = 3;
            // 
            // gameBindingSource
            // 
            this.gameBindingSource.DataMember = "Game";
            this.gameBindingSource.DataSource = this.database4DataSet;
            // 
            // database4DataSet
            // 
            this.database4DataSet.DataSetName = "Database4DataSet";
            this.database4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gameTableAdapter
            // 
            this.gameTableAdapter.ClearBeforeFill = true;
            // 
            // chartScore_Hard
            // 
            chartArea1.Name = "ChartArea1";
            this.chartScore_Hard.ChartAreas.Add(chartArea1);
            this.chartScore_Hard.DataSource = this.gameBindingSource1;
            legend1.Name = "Legend1";
            this.chartScore_Hard.Legends.Add(legend1);
            this.chartScore_Hard.Location = new System.Drawing.Point(478, 75);
            this.chartScore_Hard.Name = "chartScore_Hard";
            this.chartScore_Hard.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Score";
            series1.XValueMember = "PlayerName";
            series1.YValueMembers = "Score";
            this.chartScore_Hard.Series.Add(series1);
            this.chartScore_Hard.Size = new System.Drawing.Size(522, 431);
            this.chartScore_Hard.TabIndex = 4;
            this.chartScore_Hard.Text = "chart1";
            // 
            // gameBindingSource1
            // 
            this.gameBindingSource1.DataMember = "Game";
            this.gameBindingSource1.DataSource = this.database4DataSet;
            // 
            // chartLoad
            // 
            this.chartLoad.Location = new System.Drawing.Point(653, 513);
            this.chartLoad.Margin = new System.Windows.Forms.Padding(4);
            this.chartLoad.Name = "chartLoad";
            this.chartLoad.Size = new System.Drawing.Size(144, 28);
            this.chartLoad.TabIndex = 5;
            this.chartLoad.Text = "Load";
            this.chartLoad.UseVisualStyleBackColor = true;
            this.chartLoad.Click += new System.EventHandler(this.chartLoad_Click);
            // 
            // playerNameDataGridViewTextBoxColumn
            // 
            this.playerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.playerNameDataGridViewTextBoxColumn.DataPropertyName = "PlayerName";
            this.playerNameDataGridViewTextBoxColumn.HeaderText = "PlayerName";
            this.playerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.playerNameDataGridViewTextBoxColumn.Name = "playerNameDataGridViewTextBoxColumn";
            this.playerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            this.scoreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chartScore_Hard_Bar
            // 
            chartArea2.Name = "ChartArea1";
            this.chartScore_Hard_Bar.ChartAreas.Add(chartArea2);
            this.chartScore_Hard_Bar.DataSource = this.gameBindingSource1;
            legend2.Name = "Legend1";
            this.chartScore_Hard_Bar.Legends.Add(legend2);
            this.chartScore_Hard_Bar.Location = new System.Drawing.Point(46, 294);
            this.chartScore_Hard_Bar.Name = "chartScore_Hard_Bar";
            this.chartScore_Hard_Bar.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Score";
            series2.XValueMember = "PlayerName";
            series2.YValueMembers = "Score";
            this.chartScore_Hard_Bar.Series.Add(series2);
            this.chartScore_Hard_Bar.Size = new System.Drawing.Size(426, 212);
            this.chartScore_Hard_Bar.TabIndex = 6;
            this.chartScore_Hard_Bar.Text = "chart1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(182, 513);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(144, 28);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Score_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::COMP1551_SeaAnimal_Game.Properties.Resources.coraloceanbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.chartScore_Hard_Bar);
            this.Controls.Add(this.chartLoad);
            this.Controls.Add(this.chartScore_Hard);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.gobackbtn);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Score_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Score_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartScore_Hard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartScore_Hard_Bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gobackbtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private Database4DataSet database4DataSet;
        private System.Windows.Forms.BindingSource gameBindingSource;
        private Database4DataSetTableAdapters.GameTableAdapter gameTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartScore_Hard;
        private System.Windows.Forms.BindingSource gameBindingSource1;
        private System.Windows.Forms.Button chartLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartScore_Hard_Bar;
        private System.Windows.Forms.Button btnRefresh;
    }
}