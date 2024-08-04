using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Windows.Forms;

namespace PolynomialQuiz
{
    class BinaryTree
    {
    }
    class Node
    {
        public Node()
        {

        }
        public Node(int val)
        {
            data = val;
        }
        private int data = -9999999;
        private Node left;
        private Node right;
        //each node has data as well as two child nodes: the one directly to its left and the one directly to its right.
        //the node class contains methods for getting and setting these attributes, which are utilised by the tree class.
        public int GetData()
        {
            return data;
        }
        public Node GetLeftNode()
        {
            return left;
        }
        public Node GetRightNode()
        {
            return right;
        }
        public void SetRightNode(Node node)
        {
            right = node;
        }
        public void SetLeftNode(Node node)
        {
            left = node;
        }
        public void SetData(int val)
        {
            data = val;
        }
    }
    class Tree
    {
        public string ShowNodes(List<int> nodes)
        {
            string text = "{ ";
            foreach(int i in nodes) 
            {
                text += i + ", ";
            }
            text += "}";
            return text;
        }
        public List<int> GenerateRandomTree(Node root, int numberOfNodesToInsert, int lowerBound, int upperBound)
        {
            List<int> nodes = new List<int>();
            Random rnd = new Random();
            if(numberOfNodesToInsert > 0)
            {
                for (int i = 0; i < numberOfNodesToInsert; i++)
                {
                    int num = rnd.Next(lowerBound, upperBound);
                    if(root.GetData() == -9999999)
                    {
                        root.SetData(num);
                    }
                    else
                    {
                        root = InsertNode(root, num);
                    }
                    
                    nodes.Add(num);
                }
            }
            return nodes;
        }
        public void PreOrderTraversal(Node root, List<int> nums)
        {
            nums.Add(root.GetData());
            if (root.GetLeftNode() != null)
            {
                PreOrderTraversal(root.GetLeftNode(), nums);
            }
            if (root.GetRightNode() != null)
            {
                PreOrderTraversal(root.GetRightNode(), nums);
            }
        }
        public void InOrderTraversal(Node root, List<int> nums)
        {
            
            if (root.GetLeftNode() != null)
            {
                PreOrderTraversal(root.GetLeftNode(), nums);
            }
            nums.Add(root.GetData());
            if (root.GetRightNode() != null)
            {
                PreOrderTraversal(root.GetRightNode(), nums);
            }
        }
        public void PostOrderTraversal(Node root, List<int> nums)
        {

            if (root.GetLeftNode() != null)
            {
                PreOrderTraversal(root.GetLeftNode(), nums);
            }
            
            if (root.GetRightNode() != null)
            {
                PreOrderTraversal(root.GetRightNode(), nums);
            }
            nums.Add(root.GetData());
        }
        public void PreOrderTraversal(Node root, Control areaToWrite)
        {
            areaToWrite.Text += Convert.ToString(root.GetData()) + Environment.NewLine;
            if (root.GetLeftNode() != null)
            {
                PreOrderTraversal(root.GetLeftNode(), areaToWrite);
            }
            if (root.GetRightNode() != null)
            {
                PreOrderTraversal(root.GetRightNode(), areaToWrite);
            }
        }
        public void InOrderTraversal(Node root, Control areaToWrite)
        {
            if (root.GetLeftNode() != null)
            {
                InOrderTraversal(root.GetLeftNode(), areaToWrite);
            }
            areaToWrite.Text += Convert.ToString(root.GetData()) + Environment.NewLine;
            if (root.GetRightNode() != null)
            {
                InOrderTraversal(root.GetRightNode(), areaToWrite);
            }
        }
        public void PostOrderTraversal(Node root, Control areaToWrite)
        {
            if (root.GetLeftNode() != null)
            {
                PostOrderTraversal(root.GetLeftNode(), areaToWrite);
            }
            if (root.GetRightNode() != null)
            {
                PostOrderTraversal(root.GetRightNode(), areaToWrite);
            }
            areaToWrite.Text += Convert.ToString(root.GetData()) + Environment.NewLine;
        }
        public Node InsertNode(Node root, int v)
        {
            /*
            * The InsertNode algorithm is recursive and keeps cycling through nodes in the tree until it finds one with the left or right child of it empty.
             * At this point, the node is assigned to be the located node's child, using setters and getters to access node attributes and modify them.
             */
            if (root == null)
            {
                /*
                 * The constructor for node doesn't need any parameters as these are assigned when new nodes are made and added to the tree.
                 * The left and right attributes need to be left null in order for the algorithm to easily locate available positions in the tree.
                */
                root = new Node();
                root.SetData(v);
            }
            else if (v < root.GetData())
            {
                root.SetLeftNode(InsertNode(root.GetLeftNode(), v));
            }
            else
            {
                root.SetRightNode(InsertNode(root.GetRightNode(), v));
            }
            return root;
        }
    }
    class Date
    {
        private int year;
        private int month;
        private int day;
        private string USdate;
        private string UKdate;
        private bool leapYear;
        private bool validDateComplete = false;
        public Date()
        {

        }
        public Date(int day, int month, int year)
        {
            SetDate(day, month, year);
        }
        public bool GetValidity()
        {
            return validDateComplete;
        }
        public int GetYear()
        {
            return year;
        }
        public int GetMonth()
        {
            return month;
        }
        public int GetDay()
        {
            return day;
        }
        public string GetUSdate()
        {
            return USdate;
        }
        public string GetUKdate()
        {
            return UKdate;
        }
        public Date GenerateRandomDate()
        {
            //generates a random date to be used to create questions
            Random rnd = new Random();
            Date date = new Date();
            while (!date.GetValidity())
            {
                date.SetDate(rnd.Next(1, 32), rnd.Next(1, 13), rnd.Next(1900, 2021));
            }
            return date;
        }
        public Date SetDate(int inputDay, int inputMonth, int inputYear)
        {
            int dayLimit = 0;
            /*
             * Calculate if the year is a leap year based on the following rules:
             * Every year that is exactly divisible by four is a leap year, 
             * except for years that are exactly divisible by 100, but these centurial years are leap years if they are exactly divisible by 400. 
             * For example, the years 1700, 1800, and 1900 are not leap years, but the years 1600 and 2000 are.
            */
            if((inputYear % 400 == 0) || (inputYear % 100 != 0 && inputYear % 4 == 0))
            {
                leapYear = true;
            }
            else
            {
                leapYear = false;
            }
            //Figure out whether the days entered is a valid date based on the month and whether it is a leap year or not
            if (inputMonth < 13 && inputMonth > 0)
            {
                switch (inputMonth)
                {
                    case 1:
                        dayLimit = 31;
                        break;
                    case 2:
                        if (leapYear)
                        {
                            dayLimit = 29;
                        }
                        else
                        {
                            dayLimit = 28;
                        }
                        break;
                    case 3:
                        dayLimit = 31;
                        break;
                    case 4:
                        dayLimit = 30;
                        break;
                    case 5:
                        dayLimit = 31;
                        break;
                    case 6:
                        dayLimit = 30;
                        break;
                    case 7:
                        dayLimit = 31;
                        break;
                    case 8:
                        dayLimit = 31;
                        break;
                    case 9:
                        dayLimit = 30;
                        break;
                    case 10:
                        dayLimit = 31;
                        break;
                    case 11:
                        dayLimit = 30;
                        break;
                    case 12:
                        dayLimit = 31;
                        break;
                }
                //Check that the day entered is valid for the month
                if (inputDay > 0 && inputDay <= dayLimit)
                {
                    day = inputDay;
                    month = inputMonth;
                    year = inputYear;
                    USdate = Convert.ToString(month) + "/" + Convert.ToString(day) + "/" + Convert.ToString(year);
                    UKdate = Convert.ToString(day) + "/" + Convert.ToString(month) + "/" + Convert.ToString(year);
                    validDateComplete = true;
                }
                else
                {
                    validDateComplete = false;
                }
            }
            else
            {
                validDateComplete = false;
            }
            if (validDateComplete)
            {
                return this;
            }
            else
            {
                return null;
            }
        }
        public bool CompareDates(Date d2) 
        {
            //determine if a date is earlier than another date
            bool earlier = false;
            if (GetYear() < d2.GetYear())
            {
                earlier = true;
            }
            else
            {
                if (GetYear() == d2.GetYear())
                {
                    if (GetMonth() < d2.GetMonth())
                    {
                        earlier = true;
                    }
                    else
                    {
                        //find out if the month is equal and if not, go down to the day
                        if (GetMonth() == d2.GetMonth())
                        {
                            if (GetDay() < d2.GetDay())
                            {
                                earlier = true;
                            }
                        }
                    }
                }
            }
            return earlier;
        }
    }
    class PersonNode
    {
        public PersonNode()   {  }
        public PersonNode(string name, Date date) => person = new KeyValuePair<string, Date>(name, date);
        private KeyValuePair<string, Date> person = new KeyValuePair<string, Date>("", new Date().SetDate(1, 1, 1));
        //key is person's name, value is their date of birth
        private PersonNode left;
        private PersonNode right;
        //each node has data as well as two child nodes: the one directly to its left and the one directly to its right.
        //the node class contains methods for getting and setting these attributes, which are utilised by the tree class.
        public KeyValuePair<string, Date> GetData() => person;
        public KeyValuePair<string, Date> GetKVP() => person;
        public string GetName() => person.Key;
        public string GetDate() => person.Value.GetUKdate();
        public string GenerateString() => GetName() + ": " + GetDate();
        public PersonNode GetLeftNode() => left;
        public PersonNode GetRightNode() => right;
        public void SetRightNode(PersonNode node) => right = node;
        public void SetLeftNode(PersonNode node) => left = node;
        public void SetData(string name, Date birth) => new PersonNode(name, birth);
    }
    class DictionaryTree
    {
        public PersonNode root = new PersonNode();
        Dictionary<string, Date> nodes = new Dictionary<string, Date>();
        public Dictionary<string, Date> GetNodesInOrderOfInsertionIntoTree()
        {
            return nodes;
        }
        public void GenerateQuizReadyTree()
        {
            if (treeTypeSet == false)
            {

            }
            else
            {
                //GenerateQuizReadyTree(int traversalType)
                HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.verywellfamily.com/top-1000-baby-boy-names-2757618"); //website with boys' names rated
                string name = "";
                Random rndName = new Random();
                for (int i = 0; i < 6; i++)
                {
                    foreach (var item in doc.DocumentNode.SelectNodes("/html/body/main/article/div[2]/ol/li[" + rndName.Next(1, 1001) + "]"))
                    {
                        //webscraping is used to get 10 names from a list of 1000 names in a site to assign to people to insert into the tree
                        name = item.InnerText + " ";
                    }
                    Date date = new Date().GenerateRandomDate();
                    MessageBox.Show("Person " + Convert.ToString(i+1) + " added to the binary tree is " + name + ", born on " + date.GetUKdate());
                    nodes.Add(name, date);
                    if (root.GetDate() == new Date(1,1,1).GetUKdate())
                    {
                        root.SetData(name, date);
                    }
                    else
                    {
                        root = InsertNode(root, name, date);
                    }
                }
            }
        }
        private int alphabeticalOrAge;
        private bool treeTypeSet = false;
        //alphabeticalOrAge basically determines whether nodes should be added to the tree based on a person's name or their age
        //Once the method that will be used for inserting nodes is determined, it cannot be changed, due to the boolean treeTypeSet
        public void SetTreeType(int val)
        {
            if (!treeTypeSet)
            {
                alphabeticalOrAge = val;
                treeTypeSet = true;
            }
            //if treeTypeSet isn't true then the type of tree to build can be set
            //if val is 0, the tree is built based on name; if it is 1, it is built based on age
        }
        public Stack<KeyValuePair<string, Date>> GetStackFromTraversal(byte b, PersonNode root)
        {
            List<KeyValuePair<string, Date>> people = new List<KeyValuePair<string, Date>>();
            if (b == 0)
            {
                //pre order
                PreOrderTraversal(root, people);
            }
            else
            {
                if (b == 1)
                {
                    //in order
                    InOrderTraversal(root, people);
                }
                else
                {
                    //post order
                    PostOrderTraversal(root, people);
                }
            }
            Stack<KeyValuePair<string, Date>> stack = new Stack<KeyValuePair<string, Date>>();
            foreach (KeyValuePair<string, Date> kvp in people)
            {
                stack.Push(kvp);
            }
            return stack;
        }
        public Queue<KeyValuePair<string, Date>> GetQueueFromTraversal(byte b, PersonNode root)
        {
            List<KeyValuePair<string, Date>> people = new List<KeyValuePair<string, Date>>();
            if (b == 0)
            {
                //pre order
                PreOrderTraversal(root, people);
            }
            else
            {
                if (b == 1)
                {
                    //in order
                    InOrderTraversal(root, people);
                }
                else
                {
                    //post order
                    PostOrderTraversal(root, people);
                }
            }
            Queue<KeyValuePair<string, Date>> q = new Queue<KeyValuePair<string, Date>>();
            foreach(var item in people)
            {
                q.Enqueue(item);
            }
            return q;
        }
        public void PreOrderTraversal(PersonNode root, List<KeyValuePair<string, Date>> people)
        {
            //format the dictionary
            //foreach (KeyValuePair<string, Date> kvp in root.GetData())
            //{
            //    output = kvp.Key + " { " + kvp.Value.GetUKdate() + " } ";
            //}
            people.Add(root.GetKVP());
            if (root.GetLeftNode() != null)
            {
                PostOrderTraversal(root.GetLeftNode(), people);
            }
            
            if (root.GetRightNode() != null)
            {
                PostOrderTraversal(root.GetRightNode(), people);
            }
        }
        //public List<PersonNode> PreOrderTraversal(PersonNode root)
        //{
        //    List<PersonNode> output = new List<PersonNode>();
        //    //format the dictionary
        //    //foreach (KeyValuePair<string, Date> kvp in root.GetData())
        //    //{
        //    //    output = kvp.Key + " { " + kvp.Value.GetUKdate() + " } ";
        //    //}
        //    //Console.WriteLine(output);
        //    output.Add(root);
        //    if (root.GetLeftNode() != null)
        //    {
        //        PreOrderTraversal(root.GetLeftNode());
        //    }
        //    if (root.GetRightNode() != null)
        //    {
        //        PreOrderTraversal(root.GetRightNode());
        //    }
        //    return output;
        //}
        //public List<PersonNode> InOrderTraversal(PersonNode root)
        //{
        //    List<PersonNode> output = new List<PersonNode>();
        //    //format the dictionary
        //    //foreach (KeyValuePair<string, Date> kvp in root.GetData())
        //    //{
        //    //    output = kvp.Key + " { " + kvp.Value.GetUKdate() + " } ";
        //    //}
        //    if (root.GetLeftNode() != null)
        //    {
        //        InOrderTraversal(root.GetLeftNode());
        //    }
        //    output.Add(root);
        //    if (root.GetRightNode() != null)
        //    {
        //        InOrderTraversal(root.GetRightNode());
        //    }
        //    return output;
        //}
        public void InOrderTraversal(PersonNode root, List<KeyValuePair<string, Date>> people)
        {
            //format the dictionary
            //foreach (KeyValuePair<string, Date> kvp in root.GetData())
            //{
            //    output = kvp.Key + " { " + kvp.Value.GetUKdate() + " } ";
            //}
            if (root.GetLeftNode() != null)
            {
                PostOrderTraversal(root.GetLeftNode(), people);
            }
            people.Add(root.GetKVP());
            if (root.GetRightNode() != null)
            {
                PostOrderTraversal(root.GetRightNode(), people);
            }
        }
        public void PostOrderTraversal(PersonNode root, List<KeyValuePair<string, Date>> people)
        {
            //format the dictionary
            //foreach (KeyValuePair<string, Date> kvp in root.GetData())
            //{
            //    output = kvp.Key + " { " + kvp.Value.GetUKdate() + " } ";
            //}
            if (root.GetLeftNode() != null)
            {
                PostOrderTraversal(root.GetLeftNode(), people);
            }
            if (root.GetRightNode() != null)
            {
                PostOrderTraversal(root.GetRightNode(), people);
            }
            people.Add(root.GetKVP());
        }
        public PersonNode InsertNode(PersonNode leaf, string name, Date date)
        {
            /*
            * The InsertNode algorithm is recursive and keeps cycling through nodes in the tree until it finds one with the left or right child of it empty.
             * At this point, the node is assigned to be the located node's child, using setters and getters to access node attributes and modify them.
             */
            if (treeTypeSet)
            {
                if (leaf == null)
                {
                    /*
                     * The constructor for node doesn't need any parameters as these are assigned when new nodes are made and added to the tree.
                     * The left and right attributes need to be left null in order for the algorithm to easily locate available positions in the tree.
                    */
                    leaf = new PersonNode(name, date);
                    //string output = "";
                    //foreach (KeyValuePair<string, Date> kvp in root.GetData())
                    //{
                    //    output = kvp.Key + " { " + kvp.Value.GetUKdate() + " } ";
                    //}
                }
                else
                {
                    //leaf.SetData(name, date);
                    if (alphabeticalOrAge == 0)
                    {
                        #region alphabetical
                        //build tree based on name --> not done, probably won't use
                        string nameOfPerson = leaf.GetName();
                        byte[] asciiOfInsertionNode = Encoding.ASCII.GetBytes(name);
                        byte[] asciiOfCurrentNode = Encoding.ASCII.GetBytes(nameOfPerson);
                        if (asciiOfCurrentNode.Length > asciiOfInsertionNode.Length)
                        {
                            //do a for loop which is capped at the shorter name's length
                            foreach (char character in asciiOfInsertionNode)
                            {
                                //if(character >)
                            }
                        }
                        else
                        {

                        }
                        #endregion
                    }
                    else
                    {
                        #region numeric
                        //build tree based on age
                        //get the date in the dictionary
                        Date dateOfRoot = new Date();
                        dateOfRoot = leaf.GetData().Value;
                        if (date.CompareDates(dateOfRoot))
                        {
                            //the person to be inserted is older, so moves left
                            leaf.SetLeftNode(InsertNode(leaf.GetLeftNode(), name, date));
                        }
                        else
                        {
                            //the person to be inserted is younger, so moves right
                            leaf.SetRightNode(InsertNode(leaf.GetRightNode(), name, date));
                        }
                        #endregion
                    }

                }
                return leaf;
            }
            else
            {
                return null;
            }
        }
    }
}
