namespace Projekt_v1._1
{
    partial class UIKontor1
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
            this.UIKontor_StartKnap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UIKontor_StartKnap
            // 
            this.UIKontor_StartKnap.Location = new System.Drawing.Point(89, 61);
            this.UIKontor_StartKnap.Name = "UIKontor_StartKnap";
            this.UIKontor_StartKnap.Size = new System.Drawing.Size(75, 23);
            this.UIKontor_StartKnap.TabIndex = 0;
            this.UIKontor_StartKnap.Text = "Start";
            this.UIKontor_StartKnap.UseVisualStyleBackColor = true;
            this.UIKontor_StartKnap.Click += new System.EventHandler(this.UIKontor_StartKnap_Click);
            // 
            // UIKontor1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 397);
            this.Controls.Add(this.UIKontor_StartKnap);
            this.Name = "UIKontor1";
            this.Text = "UIKontor1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UIKontor_StartKnap;
    }
}