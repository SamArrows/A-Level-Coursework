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
    public partial class Form1 : Form
    {
        double[] bounds = { 0, 0};
        User user;
        int score = 0;
        Polynomial quadratic = new Polynomial();
        string[] q1Answer = { "", "" };
        Polynomial[] TrueOrFalse = { new Polynomial(), new Polynomial() };
        Polynomial quadraticToAdd = new Polynomial();
        Polynomial discQuestionQuad = new Polynomial();
        int TrueOrFalseXValue;
        Polynomial cubic = new Polynomial();
        Polynomial quintic = new Polynomial();
        Binomial binomial = new Binomial();
        List<Label> questions = new List<Label>();
        List<TextBox> answerBoxes = new List<TextBox>();
        List<CheckBox> markScheme = new List<CheckBox>();
        List<Label> correctAnswers = new List<Label>();
        int difficultyLevel;
        public Form1(int difficulty, User player)
        {
            //difficulty --> 0 = easy, 1 = hard
            InitializeComponent();
            difficultyLevel = difficulty;
            user = player;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            quadratic.GenerateFactorisableQuadratic();
            q1Answer = quadratic.ShowFactorsOfQuadratic();
            questions = new List<Label>() { lblQ1, lblQ2, lblQ3, lblQ4, lblQ5, lblQ6, lblQ7, lblQ8, lblQ9, lblQ10 };
            answerBoxes = new List<TextBox>() { txtQ1, txtQ2, txtQ3, txtQ4, txtQ5, txtQ6, txtQ7, txtQ8, txtQ9, txtQ10 };
            markScheme = new List<CheckBox>() { cb1, cb2, cb3, cb4, cb5, cb6, cb7, cb8, cb9, cb10 };
            correctAnswers = new List<Label>() { lblCA1, lblCA2, lblCA3, lblCA4, lblCA5, lblCA6, lblCA7, lblCA8, lblCA9, lblCA10 };
            foreach (CheckBox cb in markScheme)
            {
                cb.Enabled = false;
                //users cannot unlawfully check the checkboxes and give themselves higher scores
            }
            Random rnd = new Random();
            switch (difficultyLevel)
            {
                case 0:
                    //easy difficulty
                    for (int i = 0; i < questions.Count; i++)
                    {
                        switch (i)
                        {
                            case 1 - 1:
                                //Factorise the quadratic
                                questions[i].Text = "Find the factors of the quadratic in the exact format of (ax + b)(cx + d) - don't omit 1s and 0s from your answer, e.g. (1x + 0)(2x + 3): " + quadratic.GenerateString();
                                break;
                            case 2 - 1:
                                //Find the quadratic's stationary point
                                questions[i].Text = "Find the x-coordinate of the quadratic's stationary point";
                                break;
                            case 3 - 1:
                                //Find the roots of the quadratic, square them and sum them    
                                questions[i].Text = "The roots of the quadratic are the opposite and adjacent sides of a triangle. What is the square of the hypotenuse?";
                                break;
                            case 4 - 1:
                                //Find the quadratic's derivative and find the highest power of x's coefficient
                                questions[i].Text = "Find the derivative of the quadratic and type its highest power of x's coefficient";
                                break;
                            case 5 - 1:
                                //Integrate the quadratic and find its x^3 coefficient --> a/3
                                questions[i].Text = "Integrate the quadratic and type the coefficient of x^3 in the box to a max of 3.d.p";
                                break;
                            case 6 - 1:
                                //Sum two quadratics
                                quadraticToAdd.GenerateRandomPolynomial(2, 1, 4);
                                questions[i].Text = "Add the following quadratics: " + quadraticToAdd.GenerateString() + " , " + quadratic.GenerateString() + "; What is the value of the coefficient of x?";
                                break;
                            case 7 - 1:
                                //find definite integral
                                bounds[0] = rnd.Next(0, 4);
                                bounds[1] = rnd.Next(5, 9);
                                questions[i].Text = "If y is acceleration and x is time, find the velocity of the graph y = " + quadratic.GenerateString() + " between " + bounds[0] + " and " + bounds[1] + " seconds to the nearest integer";
                                break;
                            case 8 - 1:
                                //find coordinates of the y-intercept --> x = 0
                                questions[i].Text = "What is the y-coordinate of the y-intercept of f'(x) if f(x) = " + quadratic.MultiplyPolynomial(4).GenerateString(); ;
                                break;
                            case 9 - 1:
                                //True or False
                                TrueOrFalse[0].GenerateRandomPolynomial(3, 0, 10);
                                TrueOrFalse[1].GenerateRandomPolynomial(4, 1, 5);
                                TrueOrFalseXValue = rnd.Next(2, 5);
                                questions[i].Text = "True (1) or False (0): " + TrueOrFalse[0].GenerateString() + " is larger than " + TrueOrFalse[1].GenerateString() + "when X is " + TrueOrFalseXValue;
                                break;
                            case 10 - 1:
                                //Discriminant True or False
                                discQuestionQuad.CreateQuadraticWithOneRoot();
                                discQuestionQuad.MultiplyPolynomialByInt(3);
                                discQuestionQuad = discQuestionQuad.SumPolynomial(quadraticToAdd);
                                questions[i].Text = "True (1) or False (0): the following quadratic only has one real root --> " + discQuestionQuad.GenerateString();
                                break;
                        }
                    }
                    break;
                case 1:
                    //hard difficulty
                    cubic.SetTerms(new List<int>() { rnd.Next(-20, 21), rnd.Next(-10, 11), rnd.Next(-5, 6), rnd.Next(1, 4) });
                    quintic.SetTerms(new List<int>() { rnd.Next(-20, 21), rnd.Next(-5, 5), rnd.Next(-6, 7), rnd.Next(-4, 4), rnd.Next(-3, 7), rnd.Next(1, 3) });
                    while (cubic.CheckIfStationaryPointsExist() != true)
                    {
                        cubic.SetTerms(new List<int>() { rnd.Next(-20, 21), rnd.Next(-10, 11), rnd.Next(-5, 6), rnd.Next(1, 4) });
                    }
                    while(quintic.CheckIfStationaryPointsExist() != true)
                    {
                        quintic.SetTerms(new List<int>() { rnd.Next(-20, 21), rnd.Next(-5, 5), rnd.Next(-6, 7), rnd.Next(-4, 4), rnd.Next(-3, 7), rnd.Next(1, 3) });
                    }
                    binomial.SetExponent(rnd.Next(5, 8));
                    binomial.SetTerms(new List<int>() { rnd.Next(2, 11), rnd.Next(1, 7) });
                    for (int i = 0; i < questions.Count; i++)
                    {
                        switch (i)
                        {
                            case 1 - 1:
                                //find a correct root
                                questions[i].Text = "Find a real root of the following polynomial (for all answers, find them upto 3.d.p if the answer is a decimal: " + cubic.GenerateString();
                                break;
                            case 2 - 1:
                                //find a stationary point
                                questions[i].Text = "For the above polynomial, find the x-coordinate of one of its stationary points";
                                break;
                            case 3 - 1:
                                //determine its status    
                                questions[i].Text = "Assuming you found a stationary point, determine whether it is maximum [-1], minimum [1] or not turning at all [0]";
                                break;
                            case 4 - 1:
                                //find a correct root
                                questions[i].Text = "Find a real root of the following polynomial upto a max of 3.d.p if the answer is a decimal: " + quintic.GenerateString();
                                break;
                            case 5 - 1:
                                //find a stationary point
                                questions[i].Text = "For the above polynomial, find the x-coordinate of one of its stationary points";
                                break;
                            case 6 - 1:
                                //determine its status
                                questions[i].Text = "Assuming you found a stationary point, determine whether it is maximum [-1], minimum [1] or not turning at all [0]";
                                break;
                            case 7 - 1:
                                //find definite integral
                                bounds[0] = rnd.Next(0, 4);
                                bounds[1] = rnd.Next(5, 9);
                                questions[i].Text = "If y is velocity and x is time, find the displacement of the graph y = " + quintic.GenerateString() + " between " 
                                    + bounds[0] +" and " + bounds[1] + " seconds, truncated to the nearest integer";
                                break;
                            case 8 - 1:
                                //determine the coefficient of a term in an expanded binomial
                                questions[i].Text = "Find the coefficient of x^2 in the expansion of the following binomial: " + binomial.ShowFactorisedBinomial();
                                break;
                            case 9 - 1:
                                //find gradient at specific point
                                questions[i].Text = "What is the gradient of f(x) at when x = 6 if f(x) = " + quintic.GenerateString();
                                break;
                            case 10 - 1:
                                //find the gradient of the quintic and the coefficient of its x^4
                                questions[i].Text = "What is the coefficient of x^4 in f'(x) if f(x) = " + quintic.GenerateString();
                                break;
                        }
                    }
                    break;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            score = 0;
            bool correctFormat = true;
            double test = 0;
            foreach(TextBox txt in answerBoxes)
            {
                //verify all inputs are valid --> can be converted to doubles and not just random characters that are only strings
                try
                {
                    if(test != 0)
                    {
                        test = Convert.ToDouble(txt.Text);
                    }
                }
                catch
                {
                    correctFormat = false;
                }
                test++;
            }
            if (correctFormat)
            {
                //all inputs are valid --> start checking answers
                double input = 0;
                double answer = 0;
                for (int i = 0; i < questions.Count; i++)
                {
                    if(i != (1-1))
                    {
                        input = Math.Round(Convert.ToDouble(answerBoxes[i].Text), 3);
                    }
                    if(i == (1 - 1))
                    {
                        if(difficultyLevel == 0)
                        {
                            //easy
                            //Factorise the quadratic --> (ax + b)(cx + d)
                            if (answerBoxes[i].Text == q1Answer[0] || answerBoxes[i].Text == q1Answer[1])
                            {
                                //correct
                                markScheme[i].Checked = true;
                                score++;
                            }
                            else
                            {
                                markScheme[i].Checked = false;
                                correctAnswers[i].Text = q1Answer[0];
                                correctAnswers[i].ForeColor = Color.IndianRed;
                            }
                        }
                        else
                        {
                            //hard
                            //find a correct root --> apply Newton's Method to their answer
                            //input = Convert.ToDouble(answerBoxes[i].Text);
                            input = cubic.SolvePolynomial(Convert.ToDouble(answerBoxes[i].Text));
                            if(-0.01 < input && input < 0.01)
                            {
                                //answer is correct
                                markScheme[i].Checked = true;
                                score++;
                            }
                            else
                            {
                                //answer is incorrect
                                markScheme[i].Checked = false;
                                answer = cubic.FindCorrectRoot();
                                correctAnswers[i].Text = Convert.ToString(answer);
                                correctAnswers[i].ForeColor = Color.IndianRed;
                            }
                            //answer = cubic.NewtonsMethod(input);
                            //if (Math.Round(answer, 3) == input)
                            //{
                            //    //answer is correct
                            //    markScheme[i].Checked = true;
                            //    score++;
                            //}
                            //else
                            //{
                                
                            //}
                        }
                    }
                    else
                    {
                        switch (i)
                        {
                            case (2 - 1):
                                //find a stationary point
                                //input = Convert.ToDouble(txtQ2.Text);
                                if(difficultyLevel == 0)
                                {
                                    //easy
                                    answer = quadratic.FindClosestStationaryPoint(input)[0];
                                }
                                else
                                {
                                    //hard
                                    answer = cubic.FindClosestStationaryPoint(input)[0];
                                }
                                break;
                            case (3 - 1):
                                //determine its status --> maximum [-1], minimum [1] or not turning at all [0]
                                //input = Convert.ToDouble(txtQ3.Text);
                                if (difficultyLevel == 0)
                                {
                                    //easy
                                    double[] nums = { 0, 0 };
                                    for (int j = 0; i < 2; i++)
                                    {
                                        nums[j] = Math.Pow(quadratic.SolveQuadratic()[j].ConvertToDouble(), 2);
                                    }
                                    answer = nums[0] + nums[1];
                                }
                                else
                                {
                                    //hard
                                    answer = cubic.CheckStatusOfPoint(cubic.FindClosestStationaryPoint(Convert.ToDouble(answerBoxes[i].Text)));
                                }
                                break;
                            case (4 - 1):
                                //input = Convert.ToDouble(txtQ4.Text);
                                switch (difficultyLevel)
                                {
                                    case 0:
                                        //easy
                                        //Find the coefficient of its derivative's highest power
                                        answer = quadratic.Differentiate().GetTerms()[1];
                                        break;
                                    case 1:
                                        //hard
                                        //find a correct root 
                                        answer = quintic.NewtonsMethod(input);
                                        if(answer == 9999)
                                        {
                                            answer = quintic.FindCorrectRoot();
                                        }
                                        break;
                                }
                                break;
                            case (5 - 1):
                                //input = Convert.ToDouble(txtQ5.Text);
                                switch (difficultyLevel)
                                {
                                    case 0:
                                        //easy
                                        //integrate quadratic and find coefficient of x^3 --> a/3 to 3.d.p
                                        answer = Convert.ToDouble(quadratic.GetTerms()[2]) / 3;
                                        break;
                                    case 1:
                                        //hard
                                        //find a stationary point
                                        answer = quintic.FindClosestStationaryPoint(input)[0];
                                        break;
                                }
                                break;
                            case (6 - 1):
                                //input = Convert.ToDouble(txtQ6.Text);
                                switch (difficultyLevel)
                                {
                                    case 0:
                                        //easy
                                        //sum two quadratics
                                        answer = quadratic.SumPolynomial(quadraticToAdd).GetTerms()[1];
                                        break;
                                    case 2:
                                        //hard
                                        //determine its status
                                        double userInput = Convert.ToDouble(txtQ5.Text);
                                        answer = quintic.CheckStatusOfPoint(quintic.FindClosestStationaryPoint(userInput));
                                        //for some reason, the above line kept on throwing decimal values so I added the code below to debug
                                        if((answer > 0 && userInput > 0 )|| (answer < 0 && userInput < 0) || (answer == 0 && userInput == 0))
                                        {
                                            answer = input;
                                        }
                                        break;
                                }
                                break;
                            case (7 - 1):
                                //find definite integral
                                if (difficultyLevel == 0)
                                {
                                    //apply the trapezium rule to a quadratic
                                    answer = Math.Floor(quadratic.FindDefiniteIntegral(bounds[0], bounds[1]));
                                }
                                else
                                {
                                    //apply the trapezium rule to a quintic
                                    answer = Math.Floor(quintic.FindDefiniteIntegral(bounds[0], bounds[1]));
                                }
                                break;
                            case (8 - 1):
                                //input = Convert.ToDouble(txtQ8.Text);
                                if(difficultyLevel == 0)
                                {
                                    //easy - find y coordinate of the y-intercept of a derivative --> x = 0
                                    // y = ax^2 + bx + c
                                    answer = quadratic.MultiplyPolynomial(4).Differentiate().SolvePolynomial(0);
                                }
                                else
                                {
                                    //hard - determine the coefficient of a term in an expanded binomial
                                    answer = binomial.DetermineCoefficientOfSpecificTerm(binomial.GetExponent() - 2);
                                }
                                break;
                            case 9 - 1:
                                if(difficultyLevel == 0)
                                {
                                    //easy --> is [0] > [1], True (1) or False (0)
                                    if (TrueOrFalse[0].SolvePolynomial(TrueOrFalseXValue) > TrueOrFalse[1].SolvePolynomial(TrueOrFalseXValue))
                                    {
                                        answer = 1;
                                    }
                                    else
                                    {
                                        answer = 0;
                                    }
                                }
                                else
                                {
                                    //hard --> find gradient at specific point
                                    answer = quintic.Differentiate().SolvePolynomial(6);
                                }
                                break;
                            case 10 - 1:
                                if(difficultyLevel == 0)
                                {
                                    //easy --> does the quadratic have only one root? 1 - true, 0 - false
                                    if(discQuestionQuad.GetDiscriminantFromQuadratic() == 0)
                                    {
                                        answer = 1;
                                    }
                                    else
                                    {
                                        answer = 0;
                                    }
                                }
                                else
                                {
                                    //hard --> find coefficient from derivative
                                    answer = quintic.Differentiate().GetTerms()[4];
                                }
                                break;
                        }
                        if (Math.Round(answer, 3) == input)
                        {
                            //answer is correct

                            markScheme[i].Checked = true;
                            score++;
                        }
                        else
                        {
                            //answer is incorrect
                            markScheme[i].Checked = false;
                            correctAnswers[i].Text = Convert.ToString(answer);
                            correctAnswers[i].ForeColor = Color.IndianRed;
                        }
                    }
                }
                //show user their score out of 10
                //save score and user to the database as well as quiz type
                score *= 10;
                MessageBox.Show("Great attempt! You got " + score + "%");
                //save score to database
                string quizType = "";
                if(difficultyLevel == 0)
                {
                    quizType = "ME";
                }
                else
                {
                    quizType = "MH";
                    
                }
                //saves score as a percentage -> score / 10 * 100 --> score x 10
                Quiz q = new Quiz(user.GetUserID(), quizType, score);
                user.SaveQuizScore(q);
                MessageBox.Show("Result stored! QuizID = " + q.GetQuizID());
            }
            else
            {
                //an input is a string --> alert user that they need to make sure all answers are numeric
                MessageBox.Show("An error was detected with one of your answers; please make sure they are all numbers!");
            }
            
        }
    }
}
