namespace Projekt_v1._1
{
    partial class UIPrint
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
            this.label1 = new System.Windows.Forms.Label();
            this.UIPrint_KnapFiltrering = new System.Windows.Forms.Button();
            this.BlodtrykPRINTChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.UIPrint_comboBox = new System.Windows.Forms.ComboBox();
            this.UIPatient_KnapPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BlodtrykPRINTChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tidspunkt:";
            // 
            // UIPrint_KnapFiltrering
            // 
            this.UIPrint_KnapFiltrering.Location = new System.Drawing.Point(342, 116);
            this.UIPrint_KnapFiltrering.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.UIPrint_KnapFiltrering.Name = "UIPrint_KnapFiltrering";
            this.UIPrint_KnapFiltrering.Size = new System.Drawing.Size(226, 74);
            this.UIPrint_KnapFiltrering.TabIndex = 2;
            this.UIPrint_KnapFiltrering.Text = "Digital Filtrering";
            this.UIPrint_KnapFiltrering.UseVisualStyleBackColor = true;
            // 
            // BlodtrykPRINTChart
            // 
            chartArea1.Name = "ChartArea1";
            this.BlodtrykPRINTChart.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.BlodtrykPRINTChart.Legends.Add(legend1);
            this.BlodtrykPRINTChart.Location = new System.Drawing.Point(49, 215);
            this.BlodtrykPRINTChart.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BlodtrykPRINTChart.Name = "BlodtrykPRINTChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Blodtryk";
            this.BlodtrykPRINTChart.Series.Add(series1);
            this.BlodtrykPRINTChart.Size = new System.Drawing.Size(1631, 676);
            this.BlodtrykPRINTChart.TabIndex = 3;
            this.BlodtrykPRINTChart.Text = "UIPrint_ChartBT";
            // 
            // UIPrint_comboBox
            // 
            this.UIPrint_comboBox.FormattingEnabled = true;
            this.UIPrint_comboBox.Location = new System.Drawing.Point(49, 149);
            this.UIPrint_comboBox.Name = "UIPrint_comboBox";
            this.UIPrint_comboBox.Size = new System.Drawing.Size(208, 37);
            this.UIPrint_comboBox.TabIndex = 4;
            // 
            // UIPatient_KnapPrint
            // 
            this.UIPatient_KnapPrint.Location = new System.Drawing.Point(597, 116);
            this.UIPatient_KnapPrint.Margin = new System.Windows.Forms.Padding(5);
            this.UIPatient_KnapPrint.Name = "UIPatient_KnapPrint";
            this.UIPatient_KnapPrint.Size = new System.Drawing.Size(226, 74);
            this.UIPatient_KnapPrint.TabIndex = 5;
            this.UIPatient_KnapPrint.Text = "Print";
            this.UIPatient_KnapPrint.UseVisualStyleBackColor = true;
            // 
            // UIPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2107, 941);
            this.Controls.Add(this.UIPatient_KnapPrint);
            this.Controls.Add(this.UIPrint_comboBox);
            this.Controls.Add(this.BlodtrykPRINTChart);
            this.Controls.Add(this.UIPrint_KnapFiltrering);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "UIPrint";
            this.Text = "UIPrint";
            ((System.ComponentModel.ISupportInitialize)(this.BlodtrykPRINTChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UIPrint_KnapFiltrering;
        private System.Windows.Forms.DataVisualization.Charting.Chart BlodtrykPRINTChart;
        private System.Windows.Forms.ComboBox UIPrint_comboBox;
        private System.Windows.Forms.Button UIPatient_KnapPrint;
    }
}