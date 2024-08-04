namespace PolynomialQuiz
{
    partial class PolynomialQuiz
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
            this.txtTermEntry = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblTerms = new System.Windows.Forms.Label();
            this.btnFindRoots = new System.Windows.Forms.Button();
            this.btnAddTerm = new System.Windows.Forms.Button();
            this.lbSolutions = new System.Windows.Forms.ListBox();
            this.btnTutorial = new System.Windows.Forms.Button();
            this.btnFindDerivative = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.txtBinomialA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBinomialB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBinomialC = new System.Windows.Forms.TextBox();
            this.btnIntegrate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTermEntry
            // 
            this.txtTermEntry.Location = new System.Drawing.Point(43, 54);
            this.txtTermEntry.Name = "txtTermEntry";
            this.txtTermEntry.Size = new System.Drawing.Size(100, 20);
            this.txtTermEntry.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(40, 24);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(323, 13);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Enter the coefficient of the next term in the polynomial as an integer";
            // 
            // lblTerms
            // 
            this.lblTerms.AutoSize = true;
            this.lblTerms.Location = new System.Drawing.Point(40, 87);
            this.lblTerms.Name = "lblTerms";
            this.lblTerms.Size = new System.Drawing.Size(10, 13);
            this.lblTerms.TabIndex = 2;
            this.lblTerms.Text = " ";
            // 
            // btnFindRoots
            // 
            this.btnFindRoots.Location = new System.Drawing.Point(43, 83);
            this.btnFindRoots.Name = "btnFindRoots";
            this.btnFindRoots.Size = new System.Drawing.Size(100, 23);
            this.btnFindRoots.TabIndex = 3;
            this.btnFindRoots.Text = "Find the roots";
            this.btnFindRoots.UseVisualStyleBackColor = true;
            this.btnFindRoots.Click += new System.EventHandler(this.btnFindRoots_Click);
            // 
            // btnAddTerm
            // 
            this.btnAddTerm.Location = new System.Drawing.Point(265, 51);
            this.btnAddTerm.Name = "btnAddTerm";
            this.btnAddTerm.Size = new System.Drawing.Size(188, 23);
            this.btnAddTerm.TabIndex = 4;
            this.btnAddTerm.Text = "Add Term to Polynomial";
            this.btnAddTerm.UseVisualStyleBackColor = true;
            this.btnAddTerm.Click += new System.EventHandler(this.btnAddTerm_Click);
            // 
            // lbSolutions
            // 
            this.lbSolutions.FormattingEnabled = true;
            this.lbSolutions.Location = new System.Drawing.Point(170, 235);
            this.lbSolutions.Name = "lbSolutions";
            this.lbSolutions.Size = new System.Drawing.Size(425, 199);
            this.lbSolutions.TabIndex = 5;
            // 
            // btnTutorial
            // 
            this.btnTutorial.Location = new System.Drawing.Point(265, 116);
            this.btnTutorial.Name = "btnTutorial";
            this.btnTutorial.Size = new System.Drawing.Size(188, 23);
            this.btnTutorial.TabIndex = 6;
            this.btnTutorial.Text = "How do I find roots to polynomials?";
            this.btnTutorial.UseVisualStyleBackColor = true;
            this.btnTutorial.Click += new System.EventHandler(this.btnTutorial_Click);
            // 
            // btnFindDerivative
            // 
            this.btnFindDerivative.Location = new System.Drawing.Point(265, 83);
            this.btnFindDerivative.Name = "btnFindDerivative";
            this.btnFindDerivative.Size = new System.Drawing.Size(188, 23);
            this.btnFindDerivative.TabIndex = 7;
            this.btnFindDerivative.Text = "Differentiate Polynomial";
            this.btnFindDerivative.UseVisualStyleBackColor = true;
            this.btnFindDerivative.Click += new System.EventHandler(this.btnFindDerivative_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.Location = new System.Drawing.Point(40, 329);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(100, 23);
            this.btnExpand.TabIndex = 8;
            this.btnExpand.Text = "Expand Binomial";
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // txtBinomialA
            // 
            this.txtBinomialA.Location = new System.Drawing.Point(59, 235);
            this.txtBinomialA.Name = "txtBinomialA";
            this.txtBinomialA.Size = new System.Drawing.Size(58, 20);
            this.txtBinomialA.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "Assign values to the binomial in the form (a + bx) ^ n\r\nor integrate a polynomial" +
    " using the trapezium rule in the bounds\r\na to b with n strips\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "b";
            // 
            // txtBinomialB
            // 
            this.txtBinomialB.Location = new System.Drawing.Point(59, 261);
            this.txtBinomialB.Name = "txtBinomialB";
            this.txtBinomialB.Size = new System.Drawing.Size(58, 20);
            this.txtBinomialB.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "c";
            // 
            // txtBinomialC
            // 
            this.txtBinomialC.Location = new System.Drawing.Point(59, 287);
            this.txtBinomialC.Name = "txtBinomialC";
            this.txtBinomialC.Size = new System.Drawing.Size(58, 20);
            this.txtBinomialC.TabIndex = 14;
            // 
            // btnIntegrate
            // 
            this.btnIntegrate.Location = new System.Drawing.Point(40, 359);
            this.btnIntegrate.Name = "btnIntegrate";
            this.btnIntegrate.Size = new System.Drawing.Size(100, 35);
            this.btnIntegrate.TabIndex = 16;
            this.btnIntegrate.Text = "Integrate using Trapezium Rule";
            this.btnIntegrate.UseVisualStyleBackColor = true;
            this.btnIntegrate.Click += new System.EventHandler(this.btnIntegrate_Click);
            // 
            // PolynomialQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIntegrate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBinomialC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBinomialB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBinomialA);
            this.Controls.Add(this.btnExpand);
            this.Controls.Add(this.btnFindDerivative);
            this.Controls.Add(this.btnTutorial);
            this.Controls.Add(this.lbSolutions);
            this.Controls.Add(this.btnAddTerm);
            this.Controls.Add(this.btnFindRoots);
            this.Controls.Add(this.lblTerms);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtTermEntry);
            this.Name = "PolynomialQuiz";
            this.Text = "Polynomial Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTermEntry;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblTerms;
        private System.Windows.Forms.Button btnFindRoots;
        private System.Windows.Forms.Button btnAddTerm;
        private System.Windows.Forms.ListBox lbSolutions;
        private System.Windows.Forms.Button btnTutorial;
        private System.Windows.Forms.Button btnFindDerivative;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.TextBox txtBinomialA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBinomialB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBinomialC;
        private System.Windows.Forms.Button btnIntegrate;
    }
}