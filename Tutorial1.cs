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
    public partial class Tutorial1 : Form
    {
        Polynomial p;
        public Tutorial1()
        {
            InitializeComponent();
            p = new Polynomial();
            p.GenerateFactorisableQuadratic();
            lblText1.Text = "Polynomials are sequences with multiple terms of x in them. Quadratics are a very common type of polynomial, which contain a number of x^2, such as " + p.GenerateString() + Environment.NewLine + "Polynomials are used in various places in the real world, including modelling economic markets, particle motion, determining optimal proportions of materials to use to minimise cost and maximise efficiency in engineering, creating precise lighting in computer graphics and various aspects of chemistry." + Environment.NewLine + "Being able to create polynomials and manipulate them to achieve desired outcomes is very useful, for example, finding the exact point where a particle stops in relation to time, or dimensions for a drinks container to minimise costs." + Environment.NewLine + "To do these, you need to be able to solve polynomials, aka, find points where x is 0. With quadratics, this is easy as sometimes they can be factorised, like with " + p.GenerateString() + "where it has two brackets in a form like (ax + b) * (cx + d). Other quadratics require the quadratic formula to solve: x = { -b (+ or -) square root [b^2  - 4*a*c]  } / (2*a) " + Environment.NewLine + "Other polynomial types don't have simple formulas to use, such as cubics and quartics which do have formulas but tend to be long winded to find roots with." + Environment.NewLine + "A straight forward method of finding roots to polynomials where the highest power is greater than 2 is to use the Newton-Raphson Method." + Environment.NewLine + "The following link gives an in-depth explanation of how it works --> https://youtu.be/-RdOwhmqP5s?t=271" + Environment.NewLine + " but it can be effectively summarised as" + Environment.NewLine + "x(n+1) = x(n) - P(x) / P'(x) --> you start with a guess of what the root may be; from here you, put that into the polynomial; next, you have to find the derivative of the polynomial (the derivative means the rate of change; it is explained further on what a derivative is);" + Environment.NewLine + "you then plug in your guess for what x could be into the derivative like you did for the polynomial; next, you divide the polynomial by its derivative and then subtract this number from your guess for x; you keep iterating this process and eventually your approximation for the root is refined." + Environment.NewLine + "Calculating derivatives is important as they show the rate at which something changes, for example, a model for a meteor's velocity can be differentiated with respect to time to find its acceleration at a given time." + Environment.NewLine + "Derivatives can also be used to optimise modelling, for example, finding where the rate at which money is spent on materials for a car to be made is at its minimum by finding where the rate of change is 0 for a formula that describes the car's costs and relation to materials." + Environment.NewLine + "The formula for finding a polynomials derivative is to look at each term individually: the derivative for a term that is a * x^n  is a * n * x^(n-1). For example, in " + p.GenerateString() + ", the derivative would be " + p.Differentiate().GenerateString() + Environment.NewLine + "   Terms where x is to the power of 1, i.e. ax, are just a as n is 1 and a * 1 = a; for terms where x is to the power of 0 (so just a number like 12), the derivative is 0 as 12 * 0 = 0;";
        }

        private void btnExitTutorial_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
