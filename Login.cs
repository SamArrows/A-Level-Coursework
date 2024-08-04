using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PolynomialQuiz
{
    public partial class Login : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Project.mdb");
        public Login()
        {
            InitializeComponent();
        }
        private void btnCreateNewUser_Click(object sender, EventArgs e){
            if (txtPassword.Text.Length >= 8 && txtUsername.Text != "")
            {
                //check that the chosen username doesn't already exist
                User newUser = new User(txtUsername.Text, txtPassword.Text);
                string sql = "Select * from tblUser where Username = @Username";
                OleDbConnection conn = newUser.GetConn();
                conn.Open();
                OleDbCommand checkIfUserExists = new OleDbCommand(sql, conn);
                checkIfUserExists.Parameters.AddWithValue("@Username", newUser.GetUsername());
                OleDbDataReader qryReader = checkIfUserExists.ExecuteReader();
                bool canUseThisName = true;
                while (qryReader.Read())
                {
                    try
                    {
                        qryReader.GetInt32(0);
                        canUseThisName = false;
                        //tries to get the first user name value with the given value
                        //if it can get it, it exists so a user can't be created with this username
                    }
                    catch
                    {
                        canUseThisName = true;
                        //username not found in the database - it can be used
                    }
                }
                conn.Close();
                if (canUseThisName == true)
                {
                    //check that the password is at least 8 characters long
                    if (newUser.GetPassword().Length >= 8)
                    {
                        //password is valid
                        conn.Open();
                        sql = "Select MAX (UserID) from tblUser";
                        int uid = Convert.ToInt32(new OleDbCommand(sql, conn).ExecuteScalar()) + 1;
                        sql = "INSERT INTO tblUser VALUES (@UserID, @Username, @Password)";
                        OleDbCommand createUser = new OleDbCommand(sql, conn);
                        createUser.Parameters.AddWithValue("@UserID", uid);
                        createUser.Parameters.AddWithValue("@Username", newUser.GetUsername());
                        createUser.Parameters.AddWithValue("@Password", newUser.GetPassword());
                        createUser.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("New user successfully created!");
                        LogIn();
                    }
                    else
                    {
                        lblStatus.Text = "Passwords for new users must have at least 8 characters.";
                    }
                }
                else
                {
                   lblStatus.Text = "That username already exists! Pick another to create a new account.";
                }
            } }
        private void LogIn()
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                User u = new User();
                u.LoadUser(txtUsername.Text);
                if (u.ComparePassword(txtPassword.Text))
                {
                    //login successful
                    new Menu(u).Show();
                }
                else
                {
                    //login unsuccessful
                    lblStatus.Text = "Incorrect credentials!";
                }
                conn.Close();
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            LogIn();
        }
    }
    public class Quiz
    {
        private int QuizID;
        private int UserID;
        private string QuizType = "";
        private int Score;
        public string DisplayAsString(User user)
        {
            string quiztype = "";
            switch (QuizType)
            {
                case "C":
                    quiztype = "Computing";
                    break;
                case "ME":
                    quiztype = "Maths (easy)";
                    break;
                case "MH":
                    quiztype = "Maths (hard)";
                    break;
            }
            return "Quiz ID : " + QuizID + " | User : " + user.GetUsername() + " | " + "Quiz Type : "
                + quiztype + " | Score as percentage : " + Score;
        }
        public Quiz(){}
        public Quiz(int uid, string qt, int s)
        { 
            UserID = uid;
            QuizType = qt;
            Score = s;
        }
        public Quiz(int qid, int uid, string qt, int s)
        {
            SetData(qid, uid, qt, s);
        }
        public int GetUserID()
        {
            return UserID;
        }
        public int GetQuizID()
        {
            return QuizID;
        }
        public int GetScore()
        {
            return Score;
        }
        public string GetType()
        {
            if (QuizType == "C" || QuizType == "ME" || QuizType == "MH")
            {
                //computing quiz = C
                //easy maths quiz = ME
                //hard maths quiz = MH
                return QuizType;
            }
            else
            {
                return "";
            }
        }
        public void SetData(int qID, int uID, string qT, int sc)
        {
            QuizID = qID;
            UserID = uID;
            QuizType = qT;
            Score = sc;
        }

    }
    public class User
    {
        private int UserID;
        private string Username;
        private string Password;
        private Dictionary<int, Quiz> QuizScores = new Dictionary<int, Quiz>();
        bool UserLoaded = false;
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Project.mdb");
        public User()
        {
        }
        public User(string name, string pass)
        {
            Username = name;
            Password = pass;
        }
        public OleDbConnection GetConn()
        {
            return conn;
        }
        public string GetPassword()
        {
            return Password;
        }
        public void SaveQuizScore(Quiz quiz)
        {
            conn.Open();
            string sql = "Select MAX (QuizID) from tblQuiz";
            int qid = Convert.ToInt32(new OleDbCommand(sql, conn).ExecuteScalar()) + 1;
            sql = "INSERT INTO tblQuiz VALUES (@QuizID, @UserID, @QuizType, @Score)";
            OleDbCommand storeQuiz = new OleDbCommand(sql, conn);
            storeQuiz.Parameters.AddWithValue("@QuizID", qid);
            storeQuiz.Parameters.AddWithValue("@UserID", quiz.GetUserID());
            storeQuiz.Parameters.AddWithValue("@QuizType", quiz.GetType());
            storeQuiz.Parameters.AddWithValue("@Score", quiz.GetScore());
            storeQuiz.ExecuteNonQuery();
            conn.Close();
        }
        public int GetUserID()
        {
            return UserID;
        }
        public string GetUsername()
        {
            return Username;
        }
        public bool ComparePassword(string attempt)
        {
            if (attempt == Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SetData(int UID, string name, string Pass)
        {
            //Dictionary<int, Quiz> quizzes
            UserID = UID;
            Username = name;
            Password = Pass;
            //QuizScores = quizzes;
        }
        public List<Quiz> GetQuizzesByType(string type)
        {
            List<Quiz> QuizzesByType = new List<Quiz>(){ };
            LoadQuizzes();
            if(type == "C" || type == "ME" || type == "MH")
            {
                foreach(KeyValuePair<int, Quiz> kvp in QuizScores)
                {
                    if(kvp.Value.GetType() == type)
                    {
                        QuizzesByType.Add(kvp.Value);
                    }
                }
            }
            return QuizzesByType;
        }
        public Quiz GetQuizByQuizID(int ID)
        {
            LoadQuizzes();
            try
            {
                return QuizScores[ID];
            }
            catch
            {
                return null;
            }
        }
        public List<Quiz> RankQuizzes()
        {
            List<Quiz> quizzes = new List<Quiz>() { };
            conn.Open();
            string sql = "Select * from tblQuiz where UserID = @UserID order by Score";
            OleDbCommand loadQuizzes = new OleDbCommand(sql, conn);
            loadQuizzes.Parameters.AddWithValue("@UserID", UserID);
            OleDbDataReader qryReader = loadQuizzes.ExecuteReader();
            while (qryReader.Read())
            {
                Quiz quiz = new Quiz();
                quiz.SetData(qryReader.GetInt32(0), qryReader.GetInt32(1), qryReader.GetString(2), qryReader.GetInt32(3));
                quizzes.Add(quiz);
            }
            conn.Close();
            return quizzes;
        }
        public void LoadQuizzes()
        {
            if (UserLoaded == true)
            {
                conn.Open();
                QuizScores.Clear();
                string sql = "Select * from tblQuiz where UserID = @UserID";
                OleDbCommand loadQuizzes = new OleDbCommand(sql, conn);
                loadQuizzes.Parameters.AddWithValue("@UserID", UserID);
                OleDbDataReader qryReader = loadQuizzes.ExecuteReader();
                while (qryReader.Read())
                {
                    Quiz quiz = new Quiz();
                    quiz.SetData(qryReader.GetInt32(0), qryReader.GetInt32(1), qryReader.GetString(2), qryReader.GetInt32(3));
                    QuizScores.Add(quiz.GetQuizID(), quiz);
                    //MessageBox.Show(quiz.DisplayAsString(this));
                }
                conn.Close();
            }
        }
        public void LoadUser(string user)
        {
            conn.Open();
            string sql = "Select * from tblUser";
            OleDbCommand loadUser = new OleDbCommand(sql + " where Username = @Username", conn);
            loadUser.Parameters.AddWithValue("@Username", user);
            OleDbDataReader qryReader = loadUser.ExecuteReader();
            while (qryReader.Read())
            {
                SetData(qryReader.GetInt32(0), qryReader.GetString(1), qryReader.GetString(2));
            }
            UserLoaded = true;
            conn.Close();
        }
    }
}