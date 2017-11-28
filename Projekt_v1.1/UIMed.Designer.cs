namespace Projekt_v1._1
{
    partial class UIMed
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
            this.UIMed_buttonStartNulpunktsjustering = new System.Windows.Forms.Button();
            this.UIMed_buttonStartKalibrering = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UIMed_textBoxDatoKalibrering = new System.Windows.Forms.TextBox();
            this.UIMed_buttonLogud = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UIMed_buttonStartNulpunktsjustering
            // 
            this.UIMed_buttonStartNulpunktsjustering.Location = new System.Drawing.Point(202, 106);
            this.UIMed_buttonStartNulpunktsjustering.Name = "UIMed_buttonStartNulpunktsjustering";
            this.UIMed_buttonStartNulpunktsjustering.Size = new System.Drawing.Size(174, 78);
            this.UIMed_buttonStartNulpunktsjustering.TabIndex = 0;
            this.UIMed_buttonStartNulpunktsjustering.Text = "Start nulpunktsjustering";
            this.UIMed_buttonStartNulpunktsjustering.UseVisualStyleBackColor = true;
            this.UIMed_buttonStartNulpunktsjustering.Click += new System.EventHandler(this.UIMed_buttonStartNulpunktsjustering_Click);
            // 
            // UIMed_buttonStartKalibrering
            // 
            this.UIMed_buttonStartKalibrering.Location = new System.Drawing.Point(456, 106);
            this.UIMed_buttonStartKalibrering.Name = "UIMed_buttonStartKalibrering";
            this.UIMed_buttonStartKalibrering.Size = new System.Drawing.Size(174, 78);
            this.UIMed_buttonStartKalibrering.TabIndex = 1;
            this.UIMed_buttonStartKalibrering.Text = "Start kalibrering";
            this.UIMed_buttonStartKalibrering.UseVisualStyleBackColor = true;
            this.UIMed_buttonStartKalibrering.Click += new System.EventHandler(this.UIMed_buttonStartKalibrering_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dato for sidste kalibrering:";
            // 
            // UIMed_textBoxDatoKalibrering
            // 
            this.UIMed_textBoxDatoKalibrering.Location = new System.Drawing.Point(202, 231);
            this.UIMed_textBoxDatoKalibrering.Name = "UIMed_textBoxDatoKalibrering";
            this.UIMed_textBoxDatoKalibrering.Size = new System.Drawing.Size(202, 22);
            this.UIMed_textBoxDatoKalibrering.TabIndex = 3;
            // 
            // UIMed_buttonLogud
            // 
            this.UIMed_buttonLogud.Location = new System.Drawing.Point(202, 300);
            this.UIMed_buttonLogud.Name = "UIMed_buttonLogud";
            this.UIMed_buttonLogud.Size = new System.Drawing.Size(174, 78);
            this.UIMed_buttonLogud.TabIndex = 4;
            this.UIMed_buttonLogud.Text = "Logud";
            this.UIMed_buttonLogud.UseVisualStyleBackColor = true;
            this.UIMed_buttonLogud.Click += new System.EventHandler(this.UIMed_buttonLogud_Click);
            // 
            // UIMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 467);
            this.Controls.Add(this.UIMed_buttonLogud);
            this.Controls.Add(this.UIMed_textBoxDatoKalibrering);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UIMed_buttonStartKalibrering);
            this.Controls.Add(this.UIMed_buttonStartNulpunktsjustering);
            this.Name = "UIMed";
            this.Text = "UIMed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UIMed_buttonStartNulpunktsjustering;
        private System.Windows.Forms.Button UIMed_buttonStartKalibrering;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UIMed_textBoxDatoKalibrering;
        private System.Windows.Forms.Button UIMed_buttonLogud;
    }
}