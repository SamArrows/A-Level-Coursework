namespace PolynomialQuiz
{
    partial class Form3
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
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddNodeToTree = new System.Windows.Forms.Button();
            this.txtNodesInOrderOfInsertion = new System.Windows.Forms.TextBox();
            this.txtNodesFromTraversal = new System.Windows.Forms.TextBox();
            this.btnClearTree = new System.Windows.Forms.Button();
            this.btnPreOrder = new System.Windows.Forms.Button();
            this.btnInOrder = new System.Windows.Forms.Button();
            this.btnPostOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEntry
            // 
            this.txtEntry.Location = new System.Drawing.Point(22, 88);
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.Size = new System.Drawing.Size(100, 20);
            this.txtEntry.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a number to insert into the tree";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(25, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddNodeToTree
            // 
            this.btnAddNodeToTree.Location = new System.Drawing.Point(140, 86);
            this.btnAddNodeToTree.Name = "btnAddNodeToTree";
            this.btnAddNodeToTree.Size = new System.Drawing.Size(127, 23);
            this.btnAddNodeToTree.TabIndex = 4;
            this.btnAddNodeToTree.Text = "Add Node to Tree";
            this.btnAddNodeToTree.UseVisualStyleBackColor = true;
            this.btnAddNodeToTree.Click += new System.EventHandler(this.btnAddNodeToTree_Click);
            // 
            // txtNodesInOrderOfInsertion
            // 
            this.txtNodesInOrderOfInsertion.Location = new System.Drawing.Point(24, 123);
            this.txtNodesInOrderOfInsertion.Multiline = true;
            this.txtNodesInOrderOfInsertion.Name = "txtNodesInOrderOfInsertion";
            this.txtNodesInOrderOfInsertion.Size = new System.Drawing.Size(175, 263);
            this.txtNodesInOrderOfInsertion.TabIndex = 5;
            // 
            // txtNodesFromTraversal
            // 
            this.txtNodesFromTraversal.Location = new System.Drawing.Point(396, 15);
            this.txtNodesFromTraversal.Multiline = true;
            this.txtNodesFromTraversal.Name = "txtNodesFromTraversal";
            this.txtNodesFromTraversal.Size = new System.Drawing.Size(179, 371);
            this.txtNodesFromTraversal.TabIndex = 6;
            // 
            // btnClearTree
            // 
            this.btnClearTree.Location = new System.Drawing.Point(279, 86);
            this.btnClearTree.Name = "btnClearTree";
            this.btnClearTree.Size = new System.Drawing.Size(99, 22);
            this.btnClearTree.TabIndex = 7;
            this.btnClearTree.Text = "Clear Tree";
            this.btnClearTree.UseVisualStyleBackColor = true;
            this.btnClearTree.Click += new System.EventHandler(this.btnClearTree_Click);
            // 
            // btnPreOrder
            // 
            this.btnPreOrder.Location = new System.Drawing.Point(233, 133);
            this.btnPreOrder.Name = "btnPreOrder";
            this.btnPreOrder.Size = new System.Drawing.Size(128, 50);
            this.btnPreOrder.TabIndex = 8;
            this.btnPreOrder.Text = "Pre-Order Traversal";
            this.btnPreOrder.UseVisualStyleBackColor = true;
            this.btnPreOrder.Click += new System.EventHandler(this.btnPreOrder_Click);
            // 
            // btnInOrder
            // 
            this.btnInOrder.Location = new System.Drawing.Point(233, 189);
            this.btnInOrder.Name = "btnInOrder";
            this.btnInOrder.Size = new System.Drawing.Size(128, 50);
            this.btnInOrder.TabIndex = 9;
            this.btnInOrder.Text = "In Order Traversal";
            this.btnInOrder.UseVisualStyleBackColor = true;
            this.btnInOrder.Click += new System.EventHandler(this.btnInOrder_Click);
            // 
            // btnPostOrder
            // 
            this.btnPostOrder.Location = new System.Drawing.Point(233, 245);
            this.btnPostOrder.Name = "btnPostOrder";
            this.btnPostOrder.Size = new System.Drawing.Size(128, 50);
            this.btnPostOrder.TabIndex = 10;
            this.btnPostOrder.Text = "Post-Order Traversal";
            this.btnPostOrder.UseVisualStyleBackColor = true;
            this.btnPostOrder.Click += new System.EventHandler(this.btnPostOrder_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPostOrder);
            this.Controls.Add(this.btnInOrder);
            this.Controls.Add(this.btnPreOrder);
            this.Controls.Add(this.btnClearTree);
            this.Controls.Add(this.txtNodesFromTraversal);
            this.Controls.Add(this.txtNodesInOrderOfInsertion);
            this.Controls.Add(this.btnAddNodeToTree);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEntry);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddNodeToTree;
        private System.Windows.Forms.TextBox txtNodesInOrderOfInsertion;
        private System.Windows.Forms.TextBox txtNodesFromTraversal;
        private System.Windows.Forms.Button btnClearTree;
        private System.Windows.Forms.Button btnPreOrder;
        private System.Windows.Forms.Button btnInOrder;
        private System.Windows.Forms.Button btnPostOrder;
    }
}