namespace PolynomialQuiz
{
    partial class Tutorial1
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
            this.lblText1 = new System.Windows.Forms.Label();
            this.btnExitTutorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Location = new System.Drawing.Point(12, 32);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(0, 13);
            this.lblText1.TabIndex = 0;
            // 
            // btnExitTutorial
            // 
            this.btnExitTutorial.Location = new System.Drawing.Point(12, 6);
            this.btnExitTutorial.Name = "btnExitTutorial";
            this.btnExitTutorial.Size = new System.Drawing.Size(75, 23);
            this.btnExitTutorial.TabIndex = 0;
            this.btnExitTutorial.Text = "Exit Tutorial";
            this.btnExitTutorial.Click += new System.EventHandler(this.btnExitTutorial_Click);
            // 
            // Tutorial1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 450);
            this.Controls.Add(this.btnExitTutorial);
            this.Controls.Add(this.lblText1);
            this.Name = "Tutorial1";
            this.Text = "Tutorial1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Button btnExitTutorial;
    }
}