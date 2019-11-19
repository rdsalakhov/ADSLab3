namespace View
{
    partial class GanttChartView
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
            this.BackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GanttChart = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GanttChart)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(33, 24);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(181, 71);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back...";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gantt Chart";
            // 
            // GanttChart
            // 
            this.GanttChart.AllowUserToAddRows = false;
            this.GanttChart.AllowUserToDeleteRows = false;
            this.GanttChart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GanttChart.Location = new System.Drawing.Point(119, 270);
            this.GanttChart.Name = "GanttChart";
            this.GanttChart.ReadOnly = true;
            this.GanttChart.RowHeadersWidth = 82;
            this.GanttChart.RowTemplate.Height = 33;
            this.GanttChart.Size = new System.Drawing.Size(698, 628);
            this.GanttChart.TabIndex = 2;
            this.GanttChart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GanttChart_CellContentClick);
            // 
            // GanttChartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 1012);
            this.Controls.Add(this.GanttChart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButton);
            this.Name = "GanttChartView";
            this.Text = "GanttChartView";
            ((System.ComponentModel.ISupportInitialize)(this.GanttChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GanttChart;
    }
}