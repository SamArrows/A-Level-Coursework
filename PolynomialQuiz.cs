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
    public partial class PolynomialQuiz : Form
    {
        Polynomial p;
        Binomial b;
        TextBox[] binomialInformation;
        public PolynomialQuiz()
        {
            InitializeComponent();
            p = new Polynomial();
            binomialInformation = new TextBox[] { txtBinomialA, txtBinomialB, txtBinomialC };
            lblTerms.Location = new Point(40, 157);
        }
        private void btnFindRoots_Click(object sender, EventArgs e)
        {
            lbSolutions.DataSource = p.FindRootsOfPolynomialAsStrings();
            lblTerms.Text = "";
            p = new Polynomial();
        }
        private void btnAddTerm_Click(object sender, EventArgs e)
        {
            int coefficient;
            try
            {
                coefficient = Convert.ToInt32(txtTermEntry.Text);
            }
            catch
            {
                coefficient = 999999991;
            }
            if(coefficient != 999999991)
            {
                p.AddTerm(coefficient);
                lblTerms.Text = p.GenerateString();
                txtTermEntry.Text = "";
            }
        }
        private void btnTutorial_Click(object sender, EventArgs e)
        {
            new Tutorial1().Show();
        }
        private void btnFindDerivative_Click(object sender, EventArgs e)
        {
            lbSolutions.DataSource = new List<string>() { p.Differentiate().GenerateString() };
            lblTerms.Text = "";
            p = new Polynomial();
        }
        private List<int> GetABN()
        {
            List<int> abn = new List<int>();
            bool expansionPossible = true;
            foreach (TextBox t in binomialInformation)
            {
                if (t.Text != "")
                {
                    try
                    {
                        int i = Convert.ToInt32(t.Text);
                        if (i > 0)
                        {
                            abn.Add(i);
                        }
                        else
                        {
                            expansionPossible = false;
                        }
                    }
                    catch
                    {
                        expansionPossible = false;
                    }
                }
                else
                {
                    expansionPossible = false;
                }
            }
            if(expansionPossible == false)
            {
                return new List<int>(){ };
            }
            else
            {
                return abn;
            }
        }
        private void btnExpand_Click(object sender, EventArgs e)
        {
            if (GetABN().Count != 0)
            {
                b = new Binomial();
                b.SetTerms(new List<int>() { GetABN()[0], GetABN()[1] });
                b.SetExponent(GetABN()[2]);
                //lbSolutions.DataSource = new List<string>() { b.ReturnExpansionAsString() };
                lbSolutions.DataSource = b.ReturnExpansionAsStringList();
                b = new Binomial();
            }
        }

        private void btnIntegrate_Click(object sender, EventArgs e)
        {
            if(GetABN().Count != 0)
            {
                lbSolutions.DataSource = new List<string>() { Convert.ToString(p.TrapeziumRule(GetABN()[0], GetABN()[1], GetABN()[2])) };
            }
        }
    }
}
