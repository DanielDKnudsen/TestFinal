﻿namespace Projekt_v1._1
{
    partial class UILogind
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
            this.label1 = new System.Windows.Forms.Label();
            this.UILogind_textBoxBrugernavn = new System.Windows.Forms.TextBox();
            this.labelKodeord = new System.Windows.Forms.Label();
            this.UILogind_textBoxKodeord = new System.Windows.Forms.TextBox();
            this.UILogind_radioButtonSunhedspersonale = new System.Windows.Forms.RadioButton();
            this.UILogind_radioButtonMedicoTekniker = new System.Windows.Forms.RadioButton();
            this.UILogind_buttonLogind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brugernavn:";
            // 
            // UILogind_textBoxBrugernavn
            // 
            this.UILogind_textBoxBrugernavn.Location = new System.Drawing.Point(55, 55);
            this.UILogind_textBoxBrugernavn.Name = "UILogind_textBoxBrugernavn";
            this.UILogind_textBoxBrugernavn.Size = new System.Drawing.Size(258, 22);
            this.UILogind_textBoxBrugernavn.TabIndex = 1;
            // 
            // labelKodeord
            // 
            this.labelKodeord.AutoSize = true;
            this.labelKodeord.Location = new System.Drawing.Point(55, 109);
            this.labelKodeord.Name = "labelKodeord";
            this.labelKodeord.Size = new System.Drawing.Size(66, 17);
            this.labelKodeord.TabIndex = 2;
            this.labelKodeord.Text = "Kodeord:";
            // 
            // UILogind_textBoxKodeord
            // 
            this.UILogind_textBoxKodeord.Location = new System.Drawing.Point(55, 130);
            this.UILogind_textBoxKodeord.Name = "UILogind_textBoxKodeord";
            this.UILogind_textBoxKodeord.Size = new System.Drawing.Size(258, 22);
            this.UILogind_textBoxKodeord.TabIndex = 3;
            this.UILogind_textBoxKodeord.UseSystemPasswordChar = true;
            // 
            // UILogind_radioButtonSunhedspersonale
            // 
            this.UILogind_radioButtonSunhedspersonale.AutoSize = true;
            this.UILogind_radioButtonSunhedspersonale.Checked = true;
            this.UILogind_radioButtonSunhedspersonale.Location = new System.Drawing.Point(55, 191);
            this.UILogind_radioButtonSunhedspersonale.Name = "UILogind_radioButtonSunhedspersonale";
            this.UILogind_radioButtonSunhedspersonale.Size = new System.Drawing.Size(156, 21);
            this.UILogind_radioButtonSunhedspersonale.TabIndex = 4;
            this.UILogind_radioButtonSunhedspersonale.TabStop = true;
            this.UILogind_radioButtonSunhedspersonale.Text = "Sundhedspersonale";
            this.UILogind_radioButtonSunhedspersonale.UseVisualStyleBackColor = true;
            // 
            // UILogind_radioButtonMedicoTekniker
            // 
            this.UILogind_radioButtonMedicoTekniker.AutoSize = true;
            this.UILogind_radioButtonMedicoTekniker.Location = new System.Drawing.Point(234, 191);
            this.UILogind_radioButtonMedicoTekniker.Name = "UILogind_radioButtonMedicoTekniker";
            this.UILogind_radioButtonMedicoTekniker.Size = new System.Drawing.Size(136, 21);
            this.UILogind_radioButtonMedicoTekniker.TabIndex = 5;
            this.UILogind_radioButtonMedicoTekniker.Text = "Medico-teknikker";
            this.UILogind_radioButtonMedicoTekniker.UseVisualStyleBackColor = true;
            // 
            // UILogind_buttonLogind
            // 
            this.UILogind_buttonLogind.Location = new System.Drawing.Point(109, 232);
            this.UILogind_buttonLogind.Name = "UILogind_buttonLogind";
            this.UILogind_buttonLogind.Size = new System.Drawing.Size(174, 78);
            this.UILogind_buttonLogind.TabIndex = 6;
            this.UILogind_buttonLogind.Text = "Logind";
            this.UILogind_buttonLogind.UseVisualStyleBackColor = true;
            this.UILogind_buttonLogind.Click += new System.EventHandler(this.UILogind_buttonLogind_Click);
            // 
            // UILogind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 345);
            this.Controls.Add(this.UILogind_buttonLogind);
            this.Controls.Add(this.UILogind_radioButtonMedicoTekniker);
            this.Controls.Add(this.UILogind_radioButtonSunhedspersonale);
            this.Controls.Add(this.UILogind_textBoxKodeord);
            this.Controls.Add(this.labelKodeord);
            this.Controls.Add(this.UILogind_textBoxBrugernavn);
            this.Controls.Add(this.label1);
            this.Name = "UILogind";
            this.Text = "UILogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UILogind_textBoxBrugernavn;
        private System.Windows.Forms.Label labelKodeord;
        private System.Windows.Forms.TextBox UILogind_textBoxKodeord;
        private System.Windows.Forms.RadioButton UILogind_radioButtonSunhedspersonale;
        private System.Windows.Forms.RadioButton UILogind_radioButtonMedicoTekniker;
        private System.Windows.Forms.Button UILogind_buttonLogind;
    }
}