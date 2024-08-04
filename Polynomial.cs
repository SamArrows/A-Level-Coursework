using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PolynomialQuiz
{
    //class Term : MathsMethods
    //{
    //    public Term(Object o, string operation, bool hasChild)
    //    {
    //        if(Convert.ToString(o) == "x" && operation == "" && hasChild == false)
    //        {
    //            isJustX = true;
    //            num = "x";
    //            code = "";
    //            hasChildTerm = false;
    //        }
    //        else
    //        {
    //            num = o;
    //            code = operation;
    //            if (!ValidateOperation())
    //            {
    //                code = "";
    //            }
    //            else
    //            {
    //                hasChildTerm = hasChild;
    //            }
    //        }
    //    }
    //    public bool isJustX;
    //    Object num;
    //    string code;
    //    Term child;
    //    public bool hasChildTerm;
    //    public static string[] operations = { "log", "ln", "sin", "cos", "tan", "sec", "csc", "cot", "e" };
    //    public string GetCode()
    //    {
    //        return code;
    //    }
    //    public Object GetNum()
    //    {
    //        return num;
    //    }
    //    public Term GetChild()
    //    {
    //        return child;
    //    }
    //    public bool ValidateOperation()
    //    {
    //        bool valid = false;
    //        byte b = 0;
    //        while (b < operations.Length && valid == false)
    //        {
    //            if (operations[b] == code)
    //            {
    //                valid = true;
    //            }
    //            b++;
    //        }
    //        return valid;
    //    }
    //    public void AddChild(Term t)
    //    {
    //        if(hasChildTerm == true)
    //        {
    //            if (ValidateOperation())
    //            {
    //                child = t;
    //            }
    //        }
    //    }
    //    public double GenerateNumWithXSubstituted(double x)
    //    {
    //        Term t = this;
    //        t.isJustX = false;
    //        t.num = x;
    //        return t.GenerateNum();
    //    }
    //    public double GenerateNum()
    //    {
    //        if (isJustX)
    //        {
    //            return 0;
    //        }
    //        else
    //        {
    //            double number;
    //            try
    //            {
    //                number = Convert.ToDouble(num);
    //            }
    //            catch
    //            {
    //                number = 1;
    //            }
    //            if (ValidateOperation() && hasChildTerm)
    //            {
    //                switch (code)
    //                {
    //                    case "sin":
    //                        try
    //                        {
    //                            number *= Math.Sin(child.GenerateNum());
    //                        }
    //                        catch
    //                        {

    //                        }
    //                        break;
    //                    case "cos":
    //                        try
    //                        {
    //                            number *= Math.Cos(child.GenerateNum());
    //                        }
    //                        catch
    //                        {

    //                        }
    //                        break;
    //                    case "tan":
    //                        try
    //                        {
    //                            number *= Math.Tan(child.GenerateNum());
    //                        }
    //                        catch
    //                        {

    //                        }
    //                        break;
    //                    case "sec":
    //                        try
    //                        {
    //                            number *= Sec(child.GenerateNum());
    //                        }
    //                        catch
    //                        {

    //                        }
    //                        break;
    //                    case "csc":
    //                        try
    //                        {
    //                            number *= Csc(child.GenerateNum());
    //                        }
    //                        catch
    //                        {

    //                        }
    //                        break;
    //                    case "cot":
    //                        try
    //                        {
    //                            number *= Cot(child.GenerateNum());
    //                        }
    //                        catch
    //                        {

    //                        }
    //                        break;
    //                    case "e":
    //                        number *= Math.E;
    //                        break;
    //                    case "log":
    //                        number = Math.Log10(number);
    //                        break;
    //                    case "ln":
    //                        number = Math.Log(number);
    //                        break;
    //                }
    //            }
    //            try
    //            {
    //                return Convert.ToDouble(num);
    //            }
    //            catch
    //            {
    //                return 1;
    //            }
    //        }
    //    }
    //    public string GenerateText()
    //    {
    //        if (isJustX)
    //        {
    //            return "x";
    //        }
    //        if (hasChildTerm == false)
    //        {
    //            return Convert.ToString(num);
    //        }
    //        else
    //        {
    //            if (ValidateOperation())
    //            {
    //                return Convert.ToString(num) + code + "(" + child.GenerateText() + ")";
    //            }
    //            else
    //            {
    //                return Convert.ToString(num);
    //            }
    //        }
    //    }
    //}
    //class Model
    //{
    //    //questions to be asked may involve differentiating the given model/expression
    //    List<Term> terms = new List<Term>();
    //    byte type = 0;
    //    Polynomial p;
    //    public void Clear()
    //    {
    //        terms.Clear();
    //        type = 0;
    //    }
    //    public string GenerateText()
    //    {
    //        string text = "";
    //        if (type == 1)
    //        {
    //            // y = a + b * ( c ^ [k*x] )
    //            text = terms[0].GenerateNum() + "+" + terms[1].GenerateNum() + "*e^(" + terms[3].GenerateNum() + "*x)";
    //        }
    //        else
    //        {
    //            if(type == 2)
    //            {
    //                // y = [ax^3 + bx^2 + cx + d] + e^(kx)
    //                text = "e^" + terms[1].GenerateText() + "x + " + p.GenerateString();
    //            }
    //            else
    //            {
    //                //type == 3
    //                // y = [ax^3 + bx^2 + cx + d] + ke^(kx)
    //                //terms[0] = e, terms[1] = k
    //                text = terms[1].GenerateText() + "e^(" + terms[1].GenerateText() + "x) + " + p.GenerateString();
    //            }
    //        }
    //        return text;
    //    }
    //    public double SolveModel(double x)
    //    {
    //        if(type == 1)
    //        {
    //            // y = a + b * ( c ^ [k*x] )
    //            //terms 0 = a, terms 1 = b, terms 2 = e, terms 3 = k
    //            return terms[0].GenerateNum() + terms[1].GenerateNum() * Math.Pow(2.718, terms[3].GenerateNum() * x);
    //        }
    //        else if(type == 2)
    //        {
    //            // y = [ax^3 + bx^2 + cx + d] + e^(kx)
    //            //terms[0] = e, terms[1] = k
    //            return p.SolvePolynomial(x) + Math.Pow(2.718, terms[1].GenerateNum() * x);
    //        }
    //        else if(type == 3)
    //        {
    //            // y = [ax^3 + bx^2 + cx + d] + ke^(kx)
    //            //terms[0] = e, terms[1] = k
    //            return p.SolvePolynomial(x) + Math.Pow(2.718 * terms[1].GenerateNum(), terms[1].GenerateNum() * x);
    //        }
    //        else
    //        {
    //            return 0;
    //        }
    //    }
    //    public void CreateModelWithCubicAndE()
    //    {
    //        Clear();
    //        Random rnd = new Random();
    //        p = new Polynomial();
    //        p.SetTerms(new List<int>() { 1, rnd.Next(1, 4), rnd.Next(5, 13), rnd.Next(4, 9) });
    //        // y = [ax^3 + bx^2 + cx + d] + e^(kx)
    //        //terms.Add(new Term(p, "", false));
    //        //term below = k
    //        terms.Add(new Term(Math.E, "", false));
    //        terms.Add(new Term(rnd.Next(1, 4), "", false));
    //        type = 2;
    //    }
    //    public void CreateModelWithE(int[] bounds)
    //    {
    //        // y = a + b * ( c ^ [k*x] )
    //        //has a size of 4 --> a, b, c and k; x is a variable to be solved.
    //        Clear();
    //        Random rnd = new Random();
    //        terms.Add(new Term(rnd.Next(bounds[0], bounds[1]), "", false));
    //        terms.Add(new Term(rnd.Next(bounds[0], bounds[1]), "", false));
    //        terms.Add(new Term(Math.E, "", false));
    //        terms.Add(new Term(rnd.Next(2, 4), "", false));
    //        type = 1;
    //    }
    //    public Model Differentiate()
    //    {
    //        Model m = new Model();
    //        if(type == 1)
    //        {
    //            m.type = 1;
    //            //y = 0 + [b*k]*e ^ [kx]
    //            m.terms.Add(new Term(0, "", false));
    //            m.terms.Add(new Term(terms[1].GenerateNum() * terms[3].GenerateNum(), "", false));
    //            m.terms.Add(new Term(Math.E, "", false));
    //            m.terms.Add(new Term(terms[3].GenerateNum(), "", false));
    //        }
    //        else if(type == 2)
    //        {
    //            // y = [ax^3 + bx^2 + cx + d] + e^(kx)
    //            // y = 0x^3 + ax^2 + bx + ke^kx
    //            m.type = 3;
    //            m.p = p.Differentiate();
    //            Term t = new Term(terms[0], "e", true);
    //            t.AddChild(new Term(1, "", false));
    //            m.terms.Clear();
    //            m.terms.Add(t);
    //            m.terms.Add(new Term(terms[0], "", false));
    //        }
    //        return m;
    //    }
    //    //public string Differentiate()
    //    //{
    //    //    string text = "";
    //    //    if(type == 1)
    //    //    {
    //    //        text = Convert.ToString(terms[1].GenerateNum() * terms[2].GenerateNum());
    //    //        if (terms[2].GenerateNum() == Math.E)
    //    //        {
    //    //            text += "e";
    //    //        }
    //    //        else
    //    //        {
    //    //            text += "Ln(" + terms[2] + ") * " + terms[2];
    //    //        }
    //    //        text += "^(" + terms[3] + "x)";
    //    //    }
    //    //    else if(type == 2)
    //    //    {
    //    //        text = terms[1].GenerateNum() * terms[2].GenerateNum() + "e^" + terms[2].GenerateText() + "x + " + p.Differentiate().GenerateString();
    //    //    }
    //    //    return text;
    //    //}
    //    public KeyValuePair<double, string> Differentiate(double x)
    //    {
    //        string val = "";
    //        double key;
    //        if (type == 1)
    //        {
    //            // y = a + b*c ^ [k*x] )
    //            val = Convert.ToString(terms[1].GenerateNum() * terms[2].GenerateNum());
    //            if (terms[2].GenerateNum() == Math.E) 
    //            {
    //                val += "e";
    //            }
    //            else 
    //            { 
    //                val += "Ln(" + terms[2] + ") * " + terms[2]; 
    //            }
    //            val += "^(" + terms[3] + "x)";
    //            //string to be returned
    //        }
    //        if (x == 999)
    //        {
                
    //            //don't need to return a number for the solved equation
    //            //assign 999 to the key to show it has no x value given and thus cannot be differentiated definitely
    //            key = 999;
    //        }
    //        else
    //        {
    //            //x has been given - find derivative AND solve it
    //            key = Convert.ToDouble(terms[1].GenerateNum() * terms[2].GenerateNum()) * Math.Pow(Math.Log(Convert.ToDouble(terms[2].GenerateNum())), x * Convert.ToDouble(terms[3].GenerateNum()));
    //        }
    //        return new KeyValuePair<double, string>(key, val);
    //    }
    //}
    class Binomial : Polynomial
    {
        int exponent = 1;
        public int GetExponent()
        {
            return exponent;
        }
        public int DetermineCoefficientOfSpecificTerm(int powerOfX)
        {
            if (terms.Count != 2) 
            {
                return 0;
            }
            else 
            { 
                return NCR(exponent, powerOfX) * Convert.ToInt32(Math.Pow(terms[1], exponent - powerOfX) * Math.Pow(terms[0], powerOfX)); 
            }
        }
        public string ShowFactorisedBinomial()
        {
            return "(" + terms[1] + "x + " + terms[0] + ") ^ " + exponent;
        }
        public override void SetTerms(List<int> values)
        {
            if(values.Count == 2)
            {
                terms = values;
            }
        }
        public override void AddTerm(int x)
        {
            if (terms.Count < 2)
            {
                terms.Add(x);
            }
        }
        public void SetExponent(int exp)
        {
            exponent = exp;
        }
        public Polynomial ReturnExpansionAsPolynomial()
        {
            Polynomial expansion = new Polynomial();
            Stack<int> stack = new Stack<int>();
            //the use of the stack allows me to keep the same algorithm for generating the coefficients and then just pop from the stack to get them in the right order for the list of a polynomial
            //the algorithm finds coefficients of terms with descending powers of x however adding these straight to the list for polynomials won't work based on how my polynomial class is parsed
            //the LIFO structure for stacks means the order of coefficients can be added to the list reversed which is perfect
            int a = terms[1];
            int b = terms[0];
            for (int i = 0; i < exponent + 1; i++)
            {
                stack.Push(NCR(exponent, i) * Convert.ToInt32(Math.Pow(a, exponent - i) * Math.Pow(b, i)));
            }
            foreach(int j in stack)
            {
                expansion.AddTerm(stack.Pop());
            }
            return expansion;
        }
        public List<string> ReturnExpansionAsStringList()
        {
            List<string> expansion = new List<string>();
            int a = terms[1];
            int b = terms[0];
            for (int i = 0; i < exponent + 1; i++)
            {
                string xTerm;

                if (i == exponent - 1)
                {
                    xTerm = "x";
                }
                else
                {
                    if (i == exponent)
                    {
                        xTerm = "";
                    }
                    else
                    {
                        xTerm = "x^" + Convert.ToString(exponent - i);
                    }
                }
                expansion.Add(Convert.ToString(NCR(exponent, i) * Math.Pow(a, exponent - i) * Math.Pow(b, i)) + xTerm);
            }
            return expansion;
        }
        public string ReturnExpansionAsString()
        {
            string text = "";
            int a = terms[1];
            int b = terms[0];
            for (int i = 0; i < exponent + 1; i++)
            {
                string xTerm;

                if (i == exponent - 1)
                {
                    xTerm = "x";
                }
                else
                {
                    if (i == exponent)
                    {
                        xTerm = "";
                    }
                    else
                    {
                        xTerm = "x^" + Convert.ToString(exponent - i);
                    }
                }
                text += Convert.ToString(NCR(exponent, i) * Math.Pow(a, exponent - i) * Math.Pow(b, i)) + xTerm + "\n";
            }
            return text;
        }
    }
    class Polynomial : MathsMethods
    {
        bool factorisedQuadratic = false;
        string[] factorsOfQuadratic = { "", "" };
        bool logApplied = false;
        //bool hiddenPolynomial = false;
        //Term hide;
        //public void HidePolynomial(Term operationToX)
        //{
        //    factorisedQuadratic = false;
        //    bool? validOperator = null;
        //    Term t = operationToX;
        //    while (validOperator == null)
        //    {
        //        if (t.isJustX == true)
        //        {
        //            validOperator = true;
        //        }
        //        else
        //        {
        //            try
        //            {
        //                t = t.GetChild();
        //            }
        //            catch
        //            {
        //                //t has no child nor are any of its parents equal to x
        //                validOperator = false;
        //            }

        //        }
        //    }
        //    if (validOperator == true)
        //    {
        //        hide = operationToX;
        //    }
        //}
        public double FindDefiniteIntegral(double lower, double upper)
        {
            return TrapeziumRule(lower, upper, 1000000);
        }
        public double TrapeziumRule(double lowerBound, double upperBound, int strips)
        {
            double height = (upperBound - lowerBound) / strips;
            double integral = 0;
            for(double i = lowerBound + height; i < upperBound; i = Sum(i, height))
            {
                integral += SolvePolynomial(i);
            }
            integral *= 2;
            integral += (SolvePolynomial(lowerBound) + SolvePolynomial(upperBound));
            integral *= (height / 2);
            return integral;
        }
        protected List<int> terms = new List<int>();
        public void ApplyLog()
        {
            logApplied = true;
        }
        public void RemoveLog()
        {
            logApplied = false;
        }
        public virtual void SetTerms(List<int> values)
        {
            factorisedQuadratic = false;
            terms = values;
        }
        public virtual void AddTerm(int x)
        {
            factorisedQuadratic = false;
            terms.Add(x);
        }
        public List<int> GetTerms()
        {
            return terms;
        }
        public void MultiplyPolynomialByInt(int j)
        {
            factorisedQuadratic = false;
            for (int i = 0; i < terms.Count; i++)
            {
                terms[i] *= j;
            }
        }
        public Polynomial MultiplyPolynomial(int j)
        {
            Polynomial p = new Polynomial();
            p.SetTerms(terms);
            factorisedQuadratic = false;
            for (int i = 0; i < terms.Count; i++)
            {
                terms[i] *= j;
            }
            return p;
        }
        public Polynomial SumPolynomial(Polynomial p)
        {
            Polynomial returnP = new Polynomial();
            int loop = p.GetTerms().Count;
            if (loop > terms.Count)
            {
                loop = terms.Count;
            }
            for(int i = 0; i < loop; i++)
            {
                returnP.AddTerm(p.GetTerms()[i] + terms[i]);
            }
            return returnP;
        }
        public int GetDiscriminantFromQuadratic()
        {
            if (terms.Count == 3 && terms[terms.Count-1] != 0)
            {
                return terms[1] * terms[1] - (4 * terms[2] * terms[0]);
            }
            else
            {
                return 99999999;
            }
        }
        public void CreateQuadraticWithOneRoot()
        {
            factorisedQuadratic = false;
            //discriminant = 0
            //b^2  -  4ac  = 0
            //b^2 = 4ac
            Random rnd = new Random();
            int b = 2 * rnd.Next(1, 5);
            int a = 0;
            int c = 0;
            while(b*b != 4 * a * c)
            {
                a = rnd.Next(2, 10);
                c = rnd.Next(2, 10);
            }
            SetTerms(new List<int>() { c, b, a });
        }
        public double FindCorrectRoot()
        {
            double root = 9999;
            double counter = -10;
            while(root == 9999)
            {
                root = NewtonsMethod(counter);
                counter += 0.1;
            }
            return root;
        }
        public void GenerateFactorisableQuadratic()
        {
            //finds a quadratic that can be factorised as (ax + b)(cx + d)
            //expanded quadratic should be (ac)x^2 + (bc + ad)x + (bd)
            Random rnd = new Random();
            int a = rnd.Next(1, 3);
            int b = rnd.Next(0, 10);
            int c = rnd.Next(1, 3);
            int d = rnd.Next(0, 10);
            SetTerms(new List<int>() { b * d, b * c + a * d, a * c });
            factorsOfQuadratic[0] = "(" + a + "x + " + b + ")(" + c + "x + " + d + ")";
            factorsOfQuadratic[1] = "(" + c + "x + " + d + ")(" + a + "x + " + b + ")";
            factorisedQuadratic = true;
        }
        public string[] ShowFactorsOfQuadratic()
        {
            if(factorisedQuadratic == true)
            {
                return factorsOfQuadratic;
            }
            else
            {
                return new string[] { "", "" };
            }
        }
        public void GenerateRandomPolynomial(int highestPower, int lowerBound, int higherBound)
        {
            factorisedQuadratic = false;
            Random rnd = new Random();
            terms.Clear();
            for(int i = 0; i < highestPower+1; i++)
            {
                terms.Add(rnd.Next(lowerBound, higherBound));
            }
        }
        public string GenerateString()
        {
            string x = "x";
            if(logApplied == true)
            {
                x = "[log(x)]";
            }
            string text = "";
            for (int i = terms.Count - 1; i > -1; i--)
            {
                if (terms[i] != 0)
                {
                    if (i != terms.Count - 1)
                    {
                        if (terms[i] > 0)
                        {
                            text += "+";
                        }
                    }
                    text += terms[i];
                    if (i < 2)
                    {
                        if (i == 1)
                        {
                            text += x;
                        }
                    }
                    else
                    {
                        text += x + "^" + i;
                    }
                }

            }
            return text;
        }
        public double[] FindClosestStationaryPoint(double xApproximation)
        {
            if (CheckIfStationaryPointsExist())
            {
                //stationary pooints exist for the polynomial
                double[] point = new double[] { 0, 0 };
                point[0] = Differentiate().NewtonsMethod(xApproximation);
                if (point[0] == 9999)
                {
                    point[0] = Differentiate().FindCorrectRoot();
                }
                point[1] = SolvePolynomial(point[0]);
                return point;
            }
            else
            {
                return new double[] { 9999, 9999 };
            }
        }
        public int CheckStatusOfPoint(double[] stationaryPoint)
        {
            double x;
            x = Differentiate().Differentiate().SolvePolynomial(stationaryPoint[0]);
            if (x == 0)
            {
                return 0;
                //not a turning point --> gradient = 0
            }
            else
            {
                if (x > 0)
                {
                    return 1;
                    //is a minimum turning point --> gradient > 0 --> code returns 1
                }
                else
                {
                    return -1;
                    //is a maximum turning point --> gradient < 0 --> code returns -1
                }
            }

        }
        public bool CheckIfStationaryPointsExist()
        {
            int termsOfDerivative = Differentiate().GetTerms().Count;
            if (termsOfDerivative % 2 == 1)
            {
                //polynomial's derivative's highest power is even -> if this has no real roots then there are no stationary points
                if(termsOfDerivative == 3)
                {
                    //quadratic - check if at least one of its roots has only real components
                    if(Differentiate().SolveQuadratic()[0].imaginary == 0 || Differentiate().SolveQuadratic()[1].imaginary == 0)
                    {
                        //quadratic has a real solution -> polynomial has a stationary point
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    //the derivative is a quartic or similar -> apply Newton's Method to try and find a root
                    if(Differentiate().FindCorrectRoot() != 9999)
                    {
                        //correct root has been found -> stationary points exist
                        return true;
                    }
                    else
                    {
                        //no correct root could be identified so no stationary points can be found
                        return false;
                    }
                }
            }
            else
            {
                //derivative of the polynomial must cross the x axis due to having an odd power for its highest power, meaning the polynomial has a stationary point
                return true;
            }
        }
        public double SolvePolynomial(double x)
        {
            //finds the solution to the polynomial when x is a particular value
            double solution = 0;
            for (int i = 0; i < terms.Count; i++)
            {
                solution += terms[i] * Math.Pow(x, i);
            }
            return solution;
        }
        public int newtonCounter = 0;
        public double NewtonsMethod(double x)
        {
            newtonCounter++;
            if (Math.Round(SolvePolynomial(x), 4) == 0)
            {
                newtonCounter = 0;
                return x;
            }
            else
            {
                if(newtonCounter < 30)
                {
                    return NewtonsMethod(x - SolvePolynomial(x) / Differentiate().SolvePolynomial(x));
                }
                else
                {
                    newtonCounter = 0;
                    return 9999;
                }
            }
        }
        public Polynomial Differentiate()
        {
            Polynomial derivative = new Polynomial();
            for (int i = 0; i < terms.Count; i++)
            {
                if (i == 0)
                {

                }
                else
                {
                    if (terms[i] != 0)
                    {
                        derivative.AddTerm(i * terms[i]);
                    }
                    else
                    {
                        derivative.AddTerm(0);
                    }
                }
            }
            return derivative;
        }
        public List<string> FindRootsOfPolynomialAsStrings()
        {
            List<string> strings = new List<string>();
            List<Complex> roots = FindRootsOfPolynomial();
            foreach(Complex root in roots)
            {
                strings.Add(root.GenerateString());
            }
            return strings;
        }
        public List<Complex> FindRootsOfPolynomial()
        {
            List<Complex> solutions = new List<Complex>();
            if (terms.Count == 3 && terms[2] != 0)
            {
                Complex[] quadRoots = new Complex[] { new Complex(0,0), new Complex(0,0) };
                quadRoots = SolveQuadratic();
                foreach(Complex root in quadRoots)
                {
                    solutions.Add(root);
                }
            }
            else
            {
                if(terms.Count > 3)
                {
                    //randomise approximation start-points for Newton's Method
                    //Run the algorithm a few times to try and find several roots
                    for (int i = 0; i < 10; i++)
                    {
                        double approximation = i - 5;
                        Complex x = new Complex(NewtonsMethod(approximation), 0);
                        bool alreadyFound = false;
                        foreach (Complex solution in solutions)
                        {
                            x.real = Math.Round(x.real, 5);
                            solution.real = Math.Round(solution.real, 5);
                            if (x.real == solution.real)
                            {
                                alreadyFound = true;
                            }
                        }
                        if (!alreadyFound)
                        {
                            solutions.Add(x);
                        }
                    }
                }   
            }
            return solutions;
        }
        public Complex[] SolveQuadratic()
        {
            Complex[] solutions = new Complex[] { new Complex(0, 0), new Complex(0, 0) };
            if(terms.Count == 3 && terms[2] != 0)
            {
                double a = terms[2];
                double b = terms[1];
                double c = terms[0];
                double root;
                if (!((b * b) - (4 * a * c) < 0))
                {
                    root = Math.Sqrt((b * b) - (4 * a * c));
                    solutions[0].real = (-b + root) / (2 * a);
                    solutions[1].real = (-b - root) / (2 * a);
                }
                else
                {
                    root = Math.Sqrt(Math.Abs((b * b) - (4 * a * c)));
                    solutions[0].real = (-b) / 2;
                    solutions[0].imaginary = root / 2;
                    solutions[1].real = (-b) / 2;
                    solutions[1].imaginary = (-root) / 2;
                }
            }
            return solutions;
        }
    }
    public class Complex
    {
        public Complex(double rComponent, double iComponent) { real = rComponent;  imaginary = iComponent; }
        public double real; public double imaginary;
        public double ConvertToDouble()
        {
            if(imaginary == 0){ return real; }
            else return 9999999999999999;
        }
        public void Add(Complex num) { real += num.real; imaginary += num.imaginary; }
        public void Sub(Complex num) { real -= num.real; imaginary -= num.imaginary; }
        public void MultiplyByComplex(Complex complex) { real = (real * complex.real) + (imaginary * complex.imaginary); 
            imaginary = (real * complex.imaginary) + (imaginary * complex.real); 
        }
        public void DivideByComplex(Complex complex) {  real = (real / complex.real) + (imaginary / complex.imaginary);  
            imaginary = (real / complex.imaginary) + (imaginary / complex.real); 
        }
        public void MultiplyByReal(double multiplicand)
        {
            real *= multiplicand;
            imaginary *= multiplicand;
        }
        public void DivideByReal(double divisor)
        {
            real /= divisor;
            imaginary /= divisor;
        }
        public string GenerateString()
        {
            if(imaginary > 0)
            {
                //2 + 3i or 2 + 0i
                return real + " + " + imaginary + "i";
            }
            else if(imaginary == 0)
            {
                return Convert.ToString(real);
            }
            else return real + " - " + Math.Abs(imaginary) + "i";
        }
    }
}