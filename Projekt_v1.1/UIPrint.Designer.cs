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
            this.UIPrint_textBoxTidspunkt = new System.Windows.Forms.TextBox();
            this.UIPrint_buttonFiltrering = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tidspunkt:";
            // 
            // UIPrint_textBoxTidspunkt
            // 
            this.UIPrint_textBoxTidspunkt.Location = new System.Drawing.Point(28, 84);
            this.UIPrint_textBoxTidspunkt.Name = "UIPrint_textBoxTidspunkt";
            this.UIPrint_textBoxTidspunkt.Size = new System.Drawing.Size(100, 22);
            this.UIPrint_textBoxTidspunkt.TabIndex = 1;
            // 
            // UIPrint_buttonFiltrering
            // 
            this.UIPrint_buttonFiltrering.Location = new System.Drawing.Point(491, 64);
            this.UIPrint_buttonFiltrering.Name = "UIPrint_buttonFiltrering";
            this.UIPrint_buttonFiltrering.Size = new System.Drawing.Size(129, 41);
            this.UIPrint_buttonFiltrering.TabIndex = 2;
            this.UIPrint_buttonFiltrering.Text = "Digital Filtrering";
            this.UIPrint_buttonFiltrering.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(28, 134);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1112, 373);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "UIPrint_ChartBT";
            // 
            // UIPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 519);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.UIPrint_buttonFiltrering);
            this.Controls.Add(this.UIPrint_textBoxTidspunkt);
            this.Controls.Add(this.label1);
            this.Name = "UIPrint";
            this.Text = "UIPrint";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UIPrint_textBoxTidspunkt;
        private System.Windows.Forms.Button UIPrint_buttonFiltrering;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}