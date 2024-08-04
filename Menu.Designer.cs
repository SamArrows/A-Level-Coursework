namespace PolynomialQuiz
{
    partial class Menu
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
            this.rbPureMaths = new System.Windows.Forms.RadioButton();
            this.rbDataStructures = new System.Windows.Forms.RadioButton();
            this.tbDifficulty = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateQuiz = new System.Windows.Forms.Button();
            this.btnPolynomialCalculator = new System.Windows.Forms.Button();
            this.btnBuildTrees = new System.Windows.Forms.Button();
            this.btnViewPersonalBests = new System.Windows.Forms.Button();
            this.lbLeaderboard = new System.Windows.Forms.ListBox();
            this.btnGetQuizById = new System.Windows.Forms.Button();
            this.txtQuizInfo = new System.Windows.Forms.TextBox();
            this.btnGetQuizByType = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbDifficulty)).BeginInit();
            this.SuspendLayout();
            // 
            // rbPureMaths
            // 
            this.rbPureMaths.AutoSize = true;
            this.rbPureMaths.Location = new System.Drawing.Point(24, 31);
            this.rbPureMaths.Name = "rbPureMaths";
            this.rbPureMaths.Size = new System.Drawing.Size(79, 17);
            this.rbPureMaths.TabIndex = 0;
            this.rbPureMaths.TabStop = true;
            this.rbPureMaths.Text = "Pure Maths";
            this.rbPureMaths.UseVisualStyleBackColor = true;
            // 
            // rbDataStructures
            // 
            this.rbDataStructures.AutoSize = true;
            this.rbDataStructures.Location = new System.Drawing.Point(24, 55);
            this.rbDataStructures.Name = "rbDataStructures";
            this.rbDataStructures.Size = new System.Drawing.Size(142, 17);
            this.rbDataStructures.TabIndex = 1;
            this.rbDataStructures.TabStop = true;
            this.rbDataStructures.Text = "Complex Data Structures";
            this.rbDataStructures.UseVisualStyleBackColor = true;
            this.rbDataStructures.CheckedChanged += new System.EventHandler(this.rbDataStructures_CheckedChanged);
            // 
            // tbDifficulty
            // 
            this.tbDifficulty.Location = new System.Drawing.Point(39, 78);
            this.tbDifficulty.Maximum = 1;
            this.tbDifficulty.Name = "tbDifficulty";
            this.tbDifficulty.Size = new System.Drawing.Size(104, 45);
            this.tbDifficulty.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Easy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hard";
            // 
            // btnCreateQuiz
            // 
            this.btnCreateQuiz.Location = new System.Drawing.Point(49, 153);
            this.btnCreateQuiz.Name = "btnCreateQuiz";
            this.btnCreateQuiz.Size = new System.Drawing.Size(75, 23);
            this.btnCreateQuiz.TabIndex = 6;
            this.btnCreateQuiz.Text = "Create Quiz";
            this.btnCreateQuiz.UseVisualStyleBackColor = true;
            this.btnCreateQuiz.Click += new System.EventHandler(this.btnCreateQuiz_Click);
            // 
            // btnPolynomialCalculator
            // 
            this.btnPolynomialCalculator.Location = new System.Drawing.Point(49, 215);
            this.btnPolynomialCalculator.Name = "btnPolynomialCalculator";
            this.btnPolynomialCalculator.Size = new System.Drawing.Size(75, 35);
            this.btnPolynomialCalculator.TabIndex = 7;
            this.btnPolynomialCalculator.Text = "Polynomial Calculator";
            this.btnPolynomialCalculator.UseVisualStyleBackColor = true;
            this.btnPolynomialCalculator.Click += new System.EventHandler(this.btnPolynomialCalculator_Click);
            // 
            // btnBuildTrees
            // 
            this.btnBuildTrees.Location = new System.Drawing.Point(49, 256);
            this.btnBuildTrees.Name = "btnBuildTrees";
            this.btnBuildTrees.Size = new System.Drawing.Size(75, 34);
            this.btnBuildTrees.TabIndex = 8;
            this.btnBuildTrees.Text = "Binary Tree Builder";
            this.btnBuildTrees.UseVisualStyleBackColor = true;
            this.btnBuildTrees.Click += new System.EventHandler(this.btnBuildTrees_Click);
            // 
            // btnViewPersonalBests
            // 
            this.btnViewPersonalBests.Location = new System.Drawing.Point(232, 66);
            this.btnViewPersonalBests.Name = "btnViewPersonalBests";
            this.btnViewPersonalBests.Size = new System.Drawing.Size(132, 57);
            this.btnViewPersonalBests.TabIndex = 9;
            this.btnViewPersonalBests.Text = "View Personal Bests";
            this.btnViewPersonalBests.UseVisualStyleBackColor = true;
            this.btnViewPersonalBests.Click += new System.EventHandler(this.btnViewPersonalBests_Click);
            // 
            // lbLeaderboard
            // 
            this.lbLeaderboard.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lbLeaderboard.FormattingEnabled = true;
            this.lbLeaderboard.Location = new System.Drawing.Point(370, 38);
            this.lbLeaderboard.Name = "lbLeaderboard";
            this.lbLeaderboard.Size = new System.Drawing.Size(418, 342);
            this.lbLeaderboard.TabIndex = 10;
            // 
            // btnGetQuizById
            // 
            this.btnGetQuizById.Location = new System.Drawing.Point(232, 176);
            this.btnGetQuizById.Name = "btnGetQuizById";
            this.btnGetQuizById.Size = new System.Drawing.Size(132, 52);
            this.btnGetQuizById.TabIndex = 11;
            this.btnGetQuizById.Text = "Get Quiz by Quiz ID\r\nv";
            this.btnGetQuizById.UseVisualStyleBackColor = true;
            this.btnGetQuizById.Click += new System.EventHandler(this.btnGetQuizById_Click);
            // 
            // txtQuizInfo
            // 
            this.txtQuizInfo.Location = new System.Drawing.Point(232, 234);
            this.txtQuizInfo.Name = "txtQuizInfo";
            this.txtQuizInfo.Size = new System.Drawing.Size(132, 20);
            this.txtQuizInfo.TabIndex = 12;
            this.txtQuizInfo.Text = "Enter Quiz ID or Quiz Type";
            // 
            // btnGetQuizByType
            // 
            this.btnGetQuizByType.Location = new System.Drawing.Point(232, 261);
            this.btnGetQuizByType.Name = "btnGetQuizByType";
            this.btnGetQuizByType.Size = new System.Drawing.Size(132, 71);
            this.btnGetQuizByType.TabIndex = 13;
            this.btnGetQuizByType.Text = "^\r\nGet Quiz by Quiz Type (C, MH, ME)";
            this.btnGetQuizByType.UseVisualStyleBackColor = true;
            this.btnGetQuizByType.Click += new System.EventHandler(this.btnGetQuizByType_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetQuizByType);
            this.Controls.Add(this.txtQuizInfo);
            this.Controls.Add(this.btnGetQuizById);
            this.Controls.Add(this.lbLeaderboard);
            this.Controls.Add(this.btnViewPersonalBests);
            this.Controls.Add(this.btnBuildTrees);
            this.Controls.Add(this.btnPolynomialCalculator);
            this.Controls.Add(this.btnCreateQuiz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDifficulty);
            this.Controls.Add(this.rbDataStructures);
            this.Controls.Add(this.rbPureMaths);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.tbDifficulty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbPureMaths;
        private System.Windows.Forms.RadioButton rbDataStructures;
        private System.Windows.Forms.TrackBar tbDifficulty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateQuiz;
        private System.Windows.Forms.Button btnPolynomialCalculator;
        private System.Windows.Forms.Button btnBuildTrees;
        private System.Windows.Forms.Button btnViewPersonalBests;
        private System.Windows.Forms.ListBox lbLeaderboard;
        private System.Windows.Forms.Button btnGetQuizById;
        private System.Windows.Forms.TextBox txtQuizInfo;
        private System.Windows.Forms.Button btnGetQuizByType;
    }
}