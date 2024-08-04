using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolynomialQuiz
{
    public partial class Form3 : Form
    {
        Tree tree = new Tree();
        Node root = new Node();
        public Form3()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddNodeToTree_Click(object sender, EventArgs e)
        {
            int numToAdd;
            try
            {
                numToAdd = Convert.ToInt32(txtEntry.Text);
            }
            catch
            {
                numToAdd = -999999999;
            }
            if(numToAdd != -999999999)
            {
                if(root.GetData() == -9999999)
                {
                    root.SetData(numToAdd);
                }
                else
                {
                    root = tree.InsertNode(root, numToAdd);
                }
                txtNodesInOrderOfInsertion.Text += numToAdd + Environment.NewLine;
                txtEntry.Text = "";
            }
        }

        private void btnClearTree_Click(object sender, EventArgs e)
        {
            root = new Node();
            txtNodesInOrderOfInsertion.Text = "";
            txtNodesFromTraversal.Text = "";
        }

        private void btnPreOrder_Click(object sender, EventArgs e)
        {
            if(root.GetData() != -9999999)
            {
                txtNodesFromTraversal.Text = "";
                tree.PreOrderTraversal(root, txtNodesFromTraversal);
            }
        }

        private void btnInOrder_Click(object sender, EventArgs e)
        {
            if (root.GetData() != -9999999)
            {
                txtNodesFromTraversal.Text = "";
                tree.InOrderTraversal(root, txtNodesFromTraversal);
            }
        }

        private void btnPostOrder_Click(object sender, EventArgs e)
        {
            if (root.GetData() != -9999999)
            {
                txtNodesFromTraversal.Text = "";
                tree.PostOrderTraversal(root, txtNodesFromTraversal);
            }
        }
    }
}
