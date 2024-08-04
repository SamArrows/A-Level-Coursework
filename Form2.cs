using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace PolynomialQuiz
{ 
    
    public partial class Form2 : Form
    {
        User user;
        DictionaryTree tree = new DictionaryTree();
        Tree numericTree = new Tree();
        //PersonNode root;
        TrueFalse Q1 = new TrueFalse();
        TrueFalse Q6 = new TrueFalse();
        TextBoxQuestion Q2 = new TextBoxQuestion();
        TextBoxQuestion Q3 = new TextBoxQuestion();
        TextBoxQuestion Q4 = new TextBoxQuestion();
        TextBoxQuestion Q5 = new TextBoxQuestion();
        TextBoxQuestion Q7 = new TextBoxQuestion();
        List<CompQuestion> questions = new List<CompQuestion>();
        List<KeyValuePair<string, Date>> people = new List<KeyValuePair<string, Date>>();
        List<KeyValuePair<string, Date>> traversal = new List<KeyValuePair<string, Date>>();
        List<int> numTreeNodes;
        List<CheckBox> markScheme;
        List<string> answers = new List<string>() { "", "", "", "", "", "", "" };
        public Form2(User player)
        {
            //the data structures quiz has no difficulty variation
            InitializeComponent();
            markScheme = new List<CheckBox>(){ cb1, cb2, cb3, cb4, cb5, cb6, cb7 };
            user = player;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            questions = new List<CompQuestion>() { Q1, Q2, Q3, Q4, Q5, Q6, Q7 };
            Random rnd = new Random();
            tree.SetTreeType(1);
            //tree is instantiated based on age
            tree.GenerateQuizReadyTree();
            foreach (KeyValuePair<string, Date> kvp in tree.GetNodesInOrderOfInsertionIntoTree())
            {
                txtNodes.Text += kvp.Key + " " + kvp.Value.GetUKdate() + Environment.NewLine;
                //people.Add(p);
                //shows the nodes in the randomly generated tree in order of insertion
                people.Add(kvp);
            }
            Node node = new Node();
            numTreeNodes = numericTree.GenerateRandomTree(node, 10, 1, 30);

            //q1 = name of the first person returned from a pre-order traversal
            answers[0] = people[rnd.Next(0, people.Count - 1)].Key;
            Q1.SetUpQuestion(new Control[] { rbQ1True, rbQ1False }, cb1, lblQ1, "True or false: the name of the first person returned from a pre-order traversal is " + answers[0]);
            answers[0] = "true";

            //q2 = name of the last person returned from a post-order traversal
            Q2.SetUpQuestion(new TextBox[] {txtQ2}, cb2, lblQ2, "Type the birthday of the last person to be returned from a post-order traversal in the format dd/mm/yyyy unless the day or month only has one digit in which case d/mm/yyyy | dd/m/yyyy | d/m/yyyy");
            tree.PostOrderTraversal(tree.root, traversal);
            answers[1] = traversal[traversal.Count - 1].Value.GetUKdate();

            //q3 = name of the second oldest person
            Q3.SetUpQuestion(new TextBox[] { txtQ3 }, cb3, lblQ3, "Who is the second person returned from an inorder traversal?");
            tree.InOrderTraversal(tree.root, traversal);
            answers[2] = traversal[1].Key;

            //q4 = name of the youngest person
            Q4.SetUpQuestion(new TextBox[] { txtQ4 }, cb4, lblQ4, "What's the name of the last person returned from an inorder traversal?");
            answers[3] = tree.GetStackFromTraversal(1, tree.root).Pop().Key;

            //q5 = find dot product of two randomly generated vectors
            Vector U = new Vector(0, 0).GenerateRandomVector(2, 10);
            Vector V = new Vector(0, 0).GenerateRandomVector(1, 5);
            Q5.SetUpQuestion(new TextBox[] { txtQ5 }, cb5, lblQ5, "What is the dot product of " + U.GenerateString() + " and " + V.GenerateString() + " ?");
            answers[4] = U.DotProduct(V.GetXY()).ToString();

            //q6 = true or false about a numeric binary tree
            Node root = new Node();
            numTreeNodes = numericTree.GenerateRandomTree(root, 10, -20, 20);
            List<int> nodes = new List<int>();
            numericTree.PreOrderTraversal(root, nodes);
            lblQ6.Text = numericTree.ShowNodes(nodes);
            Q6.SetUpQuestion(new RadioButton[] { rbQ6True, rbQ6False }, cb6, lblQ6, lblQ6.Text + " True or false: in the tree with the nodes shown to the left inserted into it, " + numTreeNodes[4] + " will be the third number returned from a pre-order traversal.");
            if(nodes[2] == numTreeNodes[4])
            {
                answers[5] = "true";
            }
            else
            {
                answers[5] = "false";
            }

            //q7 - angle of vectors to the nearest degree
            U.GenerateRandomVector(3, 8);
            V.GenerateRandomVector(1, 6);
            Q7.SetUpQuestion(new TextBox[] { txtQ7 }, cb7, lblQ7, "What is the angle formed between the following vectors? " + U.GenerateString() + " and " + V.GenerateString());
            answers[6] = Math.Round(U.CalcVecAng(V.GetXY())).ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //validate that all questions have been answered
            //interface is used to check if each question has been answered through the method QuestionAnswered() which varies depending on the question type
            bool canBeMarked = true;
            foreach(CompQuestion q in questions)
            {
                if (!q.QuestionAnswered())
                {
                    canBeMarked = false;
                }
            }
            if(canBeMarked == true)
            {
                int score = 0;
                for (int i = 0; i < questions.Count; i++)
                {
                    if (questions[i].MarkQuestion(answers[i]))
                    {
                        //correct
                        questions[i].GetCheckBox().Checked = true;
                        score++;
                    }
                    else
                    {
                        //incorrect
                        questions[i].GetCheckBox().Checked = false;
                    }
                }
                score *= (100 / 7);
                MessageBox.Show("Well done! You got " + Convert.ToString(score) + "%");
                user.SaveQuizScore(new Quiz(user.GetUserID(), "C", score));
            }
            else
            {
                MessageBox.Show("You haven't answered all the questions!");
            }
        }

        private void rbQ6False_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    public class CompQuestion
    {
        public bool MarkQuestion(string answer)
        {
            if(answer == Convert.ToString(GetAnswer()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        Label lblQuestion;
        CheckBox cb;
        public void SetUpQuestion(Control[] inputs, CheckBox cb, Label lbl, string textForLabel)
        {
            SetLabel(lbl);
            SetTextOfLabel(textForLabel);
            SetCheckBox(cb);
            AssignInputs(inputs);
        }
        public virtual void AssignInputs(Control[] inputs)
        {

        }
        public void SetLabel(Label lbl) => lblQuestion = lbl;
        public void SetCheckBox(CheckBox checkbox) => cb = checkbox;
        public CheckBox GetCheckBox() => cb;
        public void SetTextOfLabel(string text) => lblQuestion.Text = text;
        public virtual Object GetAnswer()
        {
            return "";
        }
        public virtual bool QuestionAnswered()
        {
            if (GetAnswer() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    public class Vector{
        public Vector(double x, double y) {
            XY.Clear();
            XY.Add(x);
            XY.Add(y);  }
        Random rnd = new Random();
        List<double> XY = new List<double>() { };
        public void SetXY(double x, double y) {
            XY.Clear();
            XY.Add(x);
            XY.Add(y);  }
        public string GenerateString(){ return "{ " + XY[0] + ", " + XY[1] + " }";
        }
        public Vector GenerateRandomVector(){
            SetXY(rnd.NextDouble(), rnd.NextDouble());
            return this;  }
        public Vector GenerateRandomVector(int lowerBound, int upperBound) {
            SetXY(rnd.Next(lowerBound, upperBound), rnd.Next(lowerBound, upperBound));
            return this; }
        public List<double> GetXY()   { return XY;  }
        public double GetX()  {
            try {    return XY[0]; }
            catch {  return 0;  } }
        public double GetY()  {
            try
            { return XY[1]; }
            catch
            { return 0; }  }
        public double CalcVecAng(List<double> vectorV)
        {
            //Multiply the vectors
            double UxV = DotProduct(vectorV);
            double magU = Math.Sqrt(DotProduct(XY));
            double magV = Math.Sqrt(DotProduct(vectorV));
            double angle = Math.Acos(UxV / (magU * magV) * (Math.PI / 180));
            return angle;
        }
        public double DotProduct(List<double> vectorV)  {
            double dotProduct = 0;
            for (int i = 0; i < XY.Count; i++)
            {
                dotProduct += XY[i] * vectorV[i];
            }
            return dotProduct;  } }
    public class TextBoxQuestion : CompQuestion, IQuestionAnswered
    {
        TextBox txt;
        public override void AssignInputs(Control[] inputs)
        {
            if(inputs.Length == 1)
            {
                if(inputs[0] is TextBox)
                {
                    SetTextBox((TextBox)inputs[0]);
                }
            }
        }
        public void SetTextBox(TextBox textbox)
        {
            txt = textbox;
        }
        public string GetText()
        {
            return txt.Text;
        }
        public override Object GetAnswer()
        {
            if(GetText() == "")
            {
                return "";
            }
            return GetText();
        }
    }
    public static class TextBoxExtension
    {
        //allows textboxes to have an extended method
        public static bool QuestionAnswered(this TextBox txt)
        {
            if (txt.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class TrueFalse : CompQuestion, IQuestionAnswered
    {
        RadioButton rbTrue;
        RadioButton rbFalse;
        public override void AssignInputs(Control[] inputs)
        {
            if (inputs.Length == 2)
            {
                if (inputs[0] is RadioButton && inputs[1] is RadioButton)
                {
                    SetButtons((RadioButton)inputs[0], (RadioButton)inputs[1]);
                }
            }
        }
        public void SetButtons(RadioButton rb1, RadioButton rb2)
        {
            rbTrue = rb1;
            rbFalse = rb2;
        }
        public override Object GetAnswer() 
        {
            if (QuestionAnswered())
            {
                if (rbTrue.Checked)
                {
                    return "true";
                }
                else
                {
                    return "false";
                }
            }
            else
            {
                return "";
            }
        }
        public override bool QuestionAnswered()
        {
            if(!rbTrue.Checked && !rbFalse.Checked)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    ////class Matrix
    //{
    //    //not completed
    //    private List<List<double>> table = new List<List<double>>();
    //    //each list represents a new row
    //    //the size of a single list represents the number of columns
    //    private int[] type = { 0, 0 };
    //    //type[0] is the number of rows of the matrix and type[1] is the number of columns
    //    public List<List<double>> GetTable()
    //    {
    //        return table;
    //    }
    //    public int[] GetType()
    //    {
    //        return type;
    //    }
    //    public Matrix MultiplyByMatrix(Matrix m)
    //    {
    //        //this function assumes the matrix being called is the first multiplicand and that the parameter of the function is the second,
    //        //e.g. if this was 2x3 and the parameter was 3x2, the result would be a 2x3 x 3x2 --> returns a 2x2 matrix
    //        //in matrix multiplication, the number of rows of the first matrix must equal the number of columns of the second matrix
    //        if (type[0] == m.GetType()[1])
    //        {
    //            //matrix multiplication can occur due to the rule mentioned above
    //            Matrix result = new Matrix();
    //            //result will have the same number of rows as the first matrix and the same number of columns as the second matrix
    //            result.DefineBounds(type[0], m.GetType()[1]);
    //            //now we need to multiply the matrices

    //            for (int i = 0; i < type[0]; i++)
    //            {
    //                List<double> row = new List<double>();
    //                for (int j = 0; j < m.GetType()[1]; j++)
    //                {
    //                    row.Add(table[i][j] * m.GetTable()[i][j]);
    //                }
    //                result.InsertRow(row);
    //            }
    //            return result;
    //        }
    //        else
    //        {
    //            //rows of first matrix != columns of second matrix --> multiplication can't occur
    //            return null;
    //        }
    //    }
    //    public void ScalarOperation(int scalar, char operation)
    //    {
    //        char[] validOperators = { '+', '-', '*', '/', '%' };
    //        bool validInput = false;
    //        foreach (char op in validOperators)
    //        {
    //            if (operation == op)
    //            {
    //                validInput = true;
    //            }
    //        }
    //        if (validInput == true)
    //        {
    //            foreach (List<double> row in table)
    //            {
    //                for (int i = 0; i < row.Count; i++)
    //                {
    //                    switch (operation)
    //                    {
    //                        case '+':
    //                            row[i] += scalar;
    //                            break;
    //                        case '-':
    //                            row[i] -= scalar;
    //                            break;
    //                        case '*':
    //                            row[i] *= scalar;
    //                            break;
    //                        case '/':
    //                            row[i] /= scalar;
    //                            break;
    //                        case '%':
    //                            row[i] %= scalar;
    //                            break;
    //                    }
    //                }
    //            }
    //        }
    //    }
    //    public void Debug()
    //    {
    //        Console.WriteLine(type[0] + "x" + type[1] + "|" + table.Count);
    //    }
    //    public void DefineBounds(int rows, int columns)
    //    {
    //        table.Clear();
    //        type[0] = rows;
    //        type[1] = columns;
    //    }
    //    public void InsertRow(List<double> row)
    //    {
    //        if (table.Count < type[0])
    //        {
    //            if (row.Count == type[1])
    //            {
    //                table.Add(row);
    //            }
    //        }
    //    }
    //    public string PrintMatrix()
    //    {
    //        string text = "";
    //        foreach (List<double> row in table)
    //        {
    //            foreach (int num in row)
    //            {
    //                text += num.ToString() + ", ";
    //            }
    //            text += "\n";
    //        }
    //        return text;
    //    }
    //}
}
