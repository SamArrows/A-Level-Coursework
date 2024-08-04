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
    public partial class Menu : Form
    {
        User user;
        public Menu(User player)
        {
            InitializeComponent();
            user = player;
        }

        private void btnCreateQuiz_Click(object sender, EventArgs e)
        {
            if(!rbDataStructures.Checked && !rbPureMaths.Checked)
            {
                MessageBox.Show("You haven't selected a quiz type to load!");
            }
            else
            {
                if (rbPureMaths.Checked)
                {
                    //maths quiz gets generated
                    new Form1(tbDifficulty.Value, user).Show();
                }
                else
                {
                    //computer science data structures quiz gets generated
                    new Form2(user).Show();
                }
            }
            
        }

        private void rbDataStructures_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDataStructures.Checked)
            {
                tbDifficulty.Enabled = false;
            }
            else
            {
                tbDifficulty.Enabled = true;
            }
        }

        private void btnPolynomialCalculator_Click(object sender, EventArgs e)
        {
            new PolynomialQuiz().Show();
        }

        private void btnBuildTrees_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void btnViewPersonalBests_Click(object sender, EventArgs e)
        {
            List<string> PBs = new List<string>() { };
            foreach(Quiz q in user.RankQuizzes())
            {
                PBs.Add(q.DisplayAsString(user));
            }
            lbLeaderboard.DataSource = PBs;
        }

        private void btnGetQuizById_Click(object sender, EventArgs e)
        {
            try
            {
                Quiz q = user.GetQuizByQuizID(Convert.ToInt32(txtQuizInfo.Text));
                if(q != null)
                {
                    if (user.GetUserID() != q.GetUserID())
                    {
                        lbLeaderboard.DataSource = new string[] { "The quiz specified isn't one you have performed so cannot be viewed!"};
                    }
                    else
                    {
                        lbLeaderboard.DataSource = new string[] { user.GetQuizByQuizID(Convert.ToInt32(txtQuizInfo.Text)).DisplayAsString(user) };
                    }
                }
            }
            catch
            {
                lbLeaderboard.DataSource = new string[] { "You have to enter a valid numerical quiz ID!" };
            }
        }

        private void btnGetQuizByType_Click(object sender, EventArgs e)
        {
            lbLeaderboard.Text = "";
            List<string> quizzes = new List<string>(){ };
            foreach(Quiz q in user.GetQuizzesByType(txtQuizInfo.Text)) 
            {
                quizzes.Add(q.DisplayAsString(user));
            }
            lbLeaderboard.DataSource = quizzes;
        }
    }
}
