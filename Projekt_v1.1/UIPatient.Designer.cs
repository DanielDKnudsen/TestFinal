namespace Projekt_v1._1
{
    partial class UIPatient
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
            this.UIPatient_KnapNul = new System.Windows.Forms.Button();
            this.UIPatient_KnapDigital = new System.Windows.Forms.Button();
            this.UIPatient_KnapStopAlarm = new System.Windows.Forms.Button();
            this.BTChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UIPatient_LabelPULS = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UIPatient_LabelMID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.UIPatient_LabelSysDia = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.UIPatient_LabelPatientNavn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UIPatient_LabelDato = new System.Windows.Forms.Label();
            this.UIPatient_KnapStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BTChart)).BeginInit();
            this.SuspendLayout();
            // 
            // UIPatient_KnapNul
            // 
            this.UIPatient_KnapNul.BackColor = System.Drawing.Color.Black;
            this.UIPatient_KnapNul.ForeColor = System.Drawing.Color.White;
            this.UIPatient_KnapNul.Location = new System.Drawing.Point(387, 839);
            this.UIPatient_KnapNul.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UIPatient_KnapNul.Name = "UIPatient_KnapNul";
            this.UIPatient_KnapNul.Size = new System.Drawing.Size(304, 141);
            this.UIPatient_KnapNul.TabIndex = 0;
            this.UIPatient_KnapNul.Text = "Start Nulpunktsjustering";
            this.UIPatient_KnapNul.UseVisualStyleBackColor = false;
            this.UIPatient_KnapNul.Click += new System.EventHandler(this.UIPatient_KnapNul_Click);
            // 
            // UIPatient_KnapDigital
            // 
            this.UIPatient_KnapDigital.BackColor = System.Drawing.Color.Black;
            this.UIPatient_KnapDigital.ForeColor = System.Drawing.Color.White;
            this.UIPatient_KnapDigital.Location = new System.Drawing.Point(35, 839);
            this.UIPatient_KnapDigital.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UIPatient_KnapDigital.Name = "UIPatient_KnapDigital";
            this.UIPatient_KnapDigital.Size = new System.Drawing.Size(304, 141);
            this.UIPatient_KnapDigital.TabIndex = 1;
            this.UIPatient_KnapDigital.Text = " Digital filtrering";
            this.UIPatient_KnapDigital.UseVisualStyleBackColor = false;
            this.UIPatient_KnapDigital.Click += new System.EventHandler(this.UIPatient_KnapDigital_Click);
            // 
            // UIPatient_KnapStopAlarm
            // 
            this.UIPatient_KnapStopAlarm.BackColor = System.Drawing.Color.Red;
            this.UIPatient_KnapStopAlarm.Enabled = false;
            this.UIPatient_KnapStopAlarm.Location = new System.Drawing.Point(2056, 857);
            this.UIPatient_KnapStopAlarm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UIPatient_KnapStopAlarm.Name = "UIPatient_KnapStopAlarm";
            this.UIPatient_KnapStopAlarm.Size = new System.Drawing.Size(303, 141);
            this.UIPatient_KnapStopAlarm.TabIndex = 2;
            this.UIPatient_KnapStopAlarm.Text = "Stop Alarm";
            this.UIPatient_KnapStopAlarm.UseVisualStyleBackColor = false;
            this.UIPatient_KnapStopAlarm.Click += new System.EventHandler(this.UIPatient_KnapStopAlarm_Click);
            // 
            // BTChart
            // 
            this.BTChart.BackColor = System.Drawing.Color.Black;
            this.BTChart.BorderlineColor = System.Drawing.Color.Black;
            this.BTChart.BorderSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(98)))), ((int)(((byte)(113)))));
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BorderColor = System.Drawing.Color.Blue;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 82.57609F;
            chartArea1.Position.Width = 94F;
            chartArea1.Position.Y = 3F;
            this.BTChart.ChartAreas.Add(chartArea1);
            legend1.AutoFitMinFontSize = 20;
            legend1.BackColor = System.Drawing.Color.Black;
            legend1.BorderColor = System.Drawing.Color.Black;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            legend1.ForeColor = System.Drawing.Color.Red;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 8.423913F;
            legend1.Position.Width = 13.56185F;
            legend1.Position.X = 3F;
            legend1.Position.Y = 88.57609F;
            this.BTChart.Legends.Add(legend1);
            this.BTChart.Location = new System.Drawing.Point(28, 42);
            this.BTChart.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BTChart.Name = "BTChart";
            series1.BorderColor = System.Drawing.Color.Navy;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.IsXValueIndexed = true;
            series1.LabelBackColor = System.Drawing.Color.Black;
            series1.LabelForeColor = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.Name = "BT";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.BTChart.Series.Add(series1);
            this.BTChart.Size = new System.Drawing.Size(1958, 732);
            this.BTChart.TabIndex = 3;
            this.BTChart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(2062, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "PULS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(2063, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "BPM";
            // 
            // UIPatient_LabelPULS
            // 
            this.UIPatient_LabelPULS.AutoSize = true;
            this.UIPatient_LabelPULS.BackColor = System.Drawing.Color.Black;
            this.UIPatient_LabelPULS.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UIPatient_LabelPULS.ForeColor = System.Drawing.Color.Lime;
            this.UIPatient_LabelPULS.Location = new System.Drawing.Point(2230, 76);
            this.UIPatient_LabelPULS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UIPatient_LabelPULS.Name = "UIPatient_LabelPULS";
            this.UIPatient_LabelPULS.Size = new System.Drawing.Size(93, 102);
            this.UIPatient_LabelPULS.TabIndex = 6;
            this.UIPatient_LabelPULS.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(1164, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 29);
            this.label4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(2063, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "MiddelBT";
            // 
            // UIPatient_LabelMID
            // 
            this.UIPatient_LabelMID.AutoSize = true;
            this.UIPatient_LabelMID.BackColor = System.Drawing.Color.Black;
            this.UIPatient_LabelMID.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UIPatient_LabelMID.ForeColor = System.Drawing.Color.Red;
            this.UIPatient_LabelMID.Location = new System.Drawing.Point(2231, 190);
            this.UIPatient_LabelMID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UIPatient_LabelMID.Name = "UIPatient_LabelMID";
            this.UIPatient_LabelMID.Size = new System.Drawing.Size(79, 85);
            this.UIPatient_LabelMID.TabIndex = 9;
            this.UIPatient_LabelMID.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(2063, 237);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "mmHg";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(2068, 317);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "Sys/Dia";
            // 
            // UIPatient_LabelSysDia
            // 
            this.UIPatient_LabelSysDia.AutoSize = true;
            this.UIPatient_LabelSysDia.BackColor = System.Drawing.Color.Black;
            this.UIPatient_LabelSysDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UIPatient_LabelSysDia.ForeColor = System.Drawing.Color.Yellow;
            this.UIPatient_LabelSysDia.Location = new System.Drawing.Point(2226, 297);
            this.UIPatient_LabelSysDia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UIPatient_LabelSysDia.Name = "UIPatient_LabelSysDia";
            this.UIPatient_LabelSysDia.Size = new System.Drawing.Size(96, 52);
            this.UIPatient_LabelSysDia.TabIndex = 12;
            this.UIPatient_LabelSysDia.Text = "--/--";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.AliceBlue;
            this.label10.Location = new System.Drawing.Point(2058, 426);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 52);
            this.label10.TabIndex = 13;
            this.label10.Text = "Patient:";
            // 
            // UIPatient_LabelPatientNavn
            // 
            this.UIPatient_LabelPatientNavn.AutoSize = true;
            this.UIPatient_LabelPatientNavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UIPatient_LabelPatientNavn.ForeColor = System.Drawing.Color.AliceBlue;
            this.UIPatient_LabelPatientNavn.Location = new System.Drawing.Point(2060, 493);
            this.UIPatient_LabelPatientNavn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UIPatient_LabelPatientNavn.Name = "UIPatient_LabelPatientNavn";
            this.UIPatient_LabelPatientNavn.Size = new System.Drawing.Size(209, 40);
            this.UIPatient_LabelPatientNavn.TabIndex = 14;
            this.UIPatient_LabelPatientNavn.Text = "XXXXXXXX";
            this.UIPatient_LabelPatientNavn.Click += new System.EventHandler(this.UIPatient_LabelPatientNavn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2060, 556);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 40);
            this.label3.TabIndex = 15;
            this.label3.Text = "Indlæggelsesdato:";
            // 
            // UIPatient_LabelDato
            // 
            this.UIPatient_LabelDato.AutoSize = true;
            this.UIPatient_LabelDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UIPatient_LabelDato.ForeColor = System.Drawing.Color.White;
            this.UIPatient_LabelDato.Location = new System.Drawing.Point(2060, 611);
            this.UIPatient_LabelDato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UIPatient_LabelDato.Name = "UIPatient_LabelDato";
            this.UIPatient_LabelDato.Size = new System.Drawing.Size(93, 40);
            this.UIPatient_LabelDato.TabIndex = 16;
            this.UIPatient_LabelDato.Text = "Dato";
            this.UIPatient_LabelDato.Click += new System.EventHandler(this.UIPatient_LabelDato_Click);
            // 
            // UIPatient_KnapStart
            // 
            this.UIPatient_KnapStart.BackColor = System.Drawing.Color.Black;
            this.UIPatient_KnapStart.ForeColor = System.Drawing.Color.White;
            this.UIPatient_KnapStart.Location = new System.Drawing.Point(738, 839);
            this.UIPatient_KnapStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UIPatient_KnapStart.Name = "UIPatient_KnapStart";
            this.UIPatient_KnapStart.Size = new System.Drawing.Size(304, 141);
            this.UIPatient_KnapStart.TabIndex = 17;
            this.UIPatient_KnapStart.Text = "Start Måling";
            this.UIPatient_KnapStart.UseVisualStyleBackColor = false;
            this.UIPatient_KnapStart.Click += new System.EventHandler(this.UIPatient_KnapStart_Click);
            // 
            // UIPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(2459, 1046);
            this.Controls.Add(this.UIPatient_KnapStart);
            this.Controls.Add(this.UIPatient_LabelDato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UIPatient_LabelPatientNavn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.UIPatient_LabelSysDia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UIPatient_LabelMID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UIPatient_LabelPULS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTChart);
            this.Controls.Add(this.UIPatient_KnapStopAlarm);
            this.Controls.Add(this.UIPatient_KnapDigital);
            this.Controls.Add(this.UIPatient_KnapNul);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UIPatient";
            this.Text = "UIPatient";
            this.Load += new System.EventHandler(this.UIPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BTChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UIPatient_KnapNul;
        private System.Windows.Forms.Button UIPatient_KnapDigital;
        private System.Windows.Forms.Button UIPatient_KnapStopAlarm;
        private System.Windows.Forms.DataVisualization.Charting.Chart BTChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label UIPatient_LabelPULS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label UIPatient_LabelMID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label UIPatient_LabelSysDia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label UIPatient_LabelPatientNavn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label UIPatient_LabelDato;
        private System.Windows.Forms.Button UIPatient_KnapStart;
    }
}